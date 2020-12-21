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
    public partial class FormQResult : Form
    {
        private string ConnectionString = "Data Source=DESKTOP-7U0PGQS;Initial Catalog=Library;Integrated Security=True";
        private string Query;
        public FormQResult(string query)
        {
            InitializeComponent();
            Query = query;
        }

        private void FormQResult_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter(Query, connection);
            DataTable ds = new DataTable();
            da.Fill(ds);
            dataGridView1.DataSource = ds;
            connection.Close();
            richTextBox1.Text = "Query text\n"; 
            richTextBox1.Text += Query;
        }
    }
}
