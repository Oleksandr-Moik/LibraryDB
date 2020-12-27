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
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "delRecord";
            command.Parameters.Add("@id", SqlDbType.Int).Value =  Int32.Parse(textBox1.Text);
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Succesfuly deleted!");
                textBox1.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to remove \n\n" + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
