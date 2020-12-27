using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Exel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;

namespace LibraryDB
{
    public partial class FormReposrts : Form
    {
        public FormReposrts()
        {
            InitializeComponent();
            connection = new SqlConnection(FormMain.ConnectionString);
        }

        SqlConnection connection;

        private System.Data.DataTable BookDataTable()
        {
            SqlCommand selectAll = new SqlCommand("SELECT * FROM Book ", connection);
            SqlDataAdapter da = new SqlDataAdapter(selectAll);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        private System.Data.DataTable StudentDataTable()
        {
            SqlCommand selectAll = new SqlCommand("SELECT * FROM Student ", connection);
            SqlDataAdapter da = new SqlDataAdapter(selectAll);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        private System.Data.DataTable RecordDataTable()
        {
            SqlCommand selectAll = new SqlCommand("SELECT * FROM IssuanseRecord, Book, Student", connection);
            SqlDataAdapter da = new SqlDataAdapter(selectAll);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //book
            ReportDocument reportDocument = new ReportDocument();
            reportDocument.Load("BooksReport.rpt");
            reportDocument.SetDataSource(BookDataTable());
            crystalReportViewer1.ReportSource = reportDocument;
            crystalReportViewer1.Visible = true;
            ExcelExport();
        }

        private void WordExport()
        {
            connection.Open();

            var wa = new Word.Application();
            Word.Document wd;
            Word.Paragraph wHeader;
            wa.Visible = false;
            wd = wa.Documents.Add();

            wHeader = wd.Content.Paragraphs.Add();
            wHeader.Range.Text += "Report - Issuense record";
            wHeader.Range.Font.Size = 16;
            wHeader.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            wHeader.Range.InsertParagraphAfter();

            Word.Paragraph wMainPar = wd.Content.Paragraphs.Add();
            wMainPar.Range.Font.Size = 14;

            SqlCommand command1 = new SqlCommand(
                "SELECT rec.DateOfIssue, rec.DateOfReturn, book.Name, st.FirstName, st.SurName " +
                "FROM Book book, Student st, IssuanseRecord rec " +
                "WHERE book.BookId = rec.BookId AND st.StudentID = rec.StudentId", connection);
            SqlDataReader dataReader1 = command1.ExecuteReader();

            int i = 1;
            while (dataReader1.Read())
            {
                wMainPar.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                wMainPar.Range.Text +=
                    i.ToString() + ". Issue date - " + dataReader1["DateOfIssue"].ToString().Trim() +
                    "| Student - " + dataReader1["SurName"].ToString().Trim() + " " + dataReader1["FirstName"].ToString().Trim() +
                    "| Book - " + dataReader1["Name"].ToString().Trim() +
                    "| Return date - " + dataReader1["DateOfReturn"].ToString().Trim();
                wMainPar.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                i++;
            }

            dataReader1.Close();
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Word Document File (*.docx)|*.docx|All files (*.*)|*.*";
            saveFileDialog1.ShowDialog();

            wMainPar.Format.SpaceAfter = 24;
            wMainPar.Range.InsertParagraphAfter();
            wd.SaveAs(saveFileDialog1.FileName);
            connection.Close();
        }
        private void ExcelExport()
        {
            connection.Open();

            SqlDataAdapter da = new SqlDataAdapter("select * from Book", connection);
            System.Data.DataTable dtMainSQLData = new System.Data.DataTable();
            da.Fill(dtMainSQLData);
            DataColumnCollection dcCollection = dtMainSQLData.Columns;
            // Export Data into EXCEL Sheet
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            ExcelApp.Application.Workbooks.Add(Type.Missing);
            for (int i = 1; i < dtMainSQLData.Rows.Count + 1; i++)
            {
                for (int j = 1; j < dtMainSQLData.Columns.Count + 1; j++)
                {
                    if (i == 1)
                        ExcelApp.Cells[i, j] = dcCollection[j - 1].ToString();
                    else
                        ExcelApp.Cells[i, j] = dtMainSQLData.Rows[i - 1][j - 1].ToString();
                }
            }
            ExcelApp.ActiveWorkbook.Saved = true;
            ExcelApp.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //student
            ReportDocument reportDocument = new ReportDocument();
            //reportDocument.Load("StudentReport.rpt");
            reportDocument.SetDataSource(StudentDataTable());
            //crystalReportViewer1.ReportSource = reportDocument;
            crystalReportViewer1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //record
            ReportDocument reportDocument = new ReportDocument();
            reportDocument.Load("RecordReport.rpt");
            reportDocument.SetDataSource(RecordDataTable());
            crystalReportViewer1.ReportSource = reportDocument;
            crystalReportViewer1.Visible = true;
            WordExport();
        }

        private void FormReposrts_Load(object sender, EventArgs e)
        {

        }
    }
}
