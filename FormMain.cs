using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryDB
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
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
    }
}
