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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userid = textBox1.Text;
            string password = textBox2.Text;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-7U0PGQS;Initial Catalog=Library;" +
               "User Id=" + textBox1.Text + "; Password=" + textBox2.Text + ";";

            try
            {
                con.Open();
                MessageBox.Show("Login successful. You`re welcome!");
                Form form = new FormMain();
                form.Show();
                this.Hide();
                con.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Wrong credentials.\n" + exp.StackTrace);
            }
        }
    }
}
