using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryDB
{
    public partial class FormMain : Form
    {
        public static string ConnectionString = Properties.Settings.Default.LibraryConnectionString;
        private SqlConnection connection;
        public FormMain()
        {
            InitializeComponent();
            connection = new SqlConnection(FormMain.ConnectionString);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new FormBook().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new FormStudent().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                new FormIssuanseRecord().Show();
            } catch (Exception exp)
            {
                MessageBox.Show(exp.StackTrace);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // queries
            new FromQueries().ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string query = "";
            if (checkBox1.Checked)
            {
                query = "SELECT st.FirstName, st.SurName, st.[Group], book.Name, book.Price " +
                    "FROM Book book, Student st, IssuanseRecord rec " +
                    "WHERE book.BookId = rec.BookId AND st.StudentID = rec.StudentId";
                new FormQResult(query, checkBox1.Text).Show();
            }
            if (checkBox2.Checked)
            {
                query = "SELECT st.FirstName, st.SurName, st.[Group], COUNT(rec.RecordId) as Count, SUM(book.Price) as Suma " +
                    "FROM Book book, Student st, IssuanseRecord rec " +
                    "WHERE book.BookId = rec.BookId AND st.StudentID = rec.StudentId " +
                    "Group By st.FirstName, st.SurName, st.[Group]";
                new FormQResult(query, checkBox2.Text).Show();
            }
            if (checkBox3.Checked)
            {
                query = "SELECT CAST(CAST(rec.DateOfIssue AS date) as DATETIME) Date, COUNT(rec.BookId) Count,SUM(book.Price) Suma " +
                    "FROM Book book, IssuanseRecord rec " +
                    "WHERE book.BookId=rec.BookId " +
                    "Group By CAST(CAST(rec.DateOfIssue AS date) as DATETIME)";
                
                new FormQResult(query, checkBox3.Text).Show();
            }

            if (query == "")
            {
                MessageBox.Show("Select at least one query!!!");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new FormReposrts().Show();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            new FormAddStudent().Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new FormDeleteRecord().Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int result;
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT dbo.book_count()", connection);
            result = (int)command.ExecuteScalar();
            MessageBox.Show($"In library {result} books");
            connection.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            float result;
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT dbo.total_price()", connection);
            result = (float)command.ExecuteScalar();
            MessageBox.Show($"Price of all books in library {result} UAH");
            connection.Close();
        }
    }
}
