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
    public partial class FormDeleteRecord : Form
    {
        SqlConnection connection = new SqlConnection(FormMain.ConnectionString);

        public FormDeleteRecord()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmdGet = new SqlCommand();
            cmdGet.Connection = connection;
            cmdGet.CommandType = CommandType.StoredProcedure;
            cmdGet.CommandText = "del";
            cmdGet.Parameters.Add("@ids", SqlDbType.Int).Value = textBox1.Text;
            try
            {
                cmdGet.ExecuteNonQuery();
                MessageBox.Show("Succes deleted!");
            }
            catch
            { }
            connection.Close();
        }
    }
}
