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
    public partial class FormAddStudent : Form
    {

        private SqlConnection connection;
        public FormAddStudent()
        {
            InitializeComponent();
            connection = new SqlConnection(FormMain.ConnectionString);
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "createStudent";
            command.Parameters.Add("@firstName", SqlDbType.VarChar, 30).Value = firstNameTextBox.Text;
            command.Parameters.Add("@surName", SqlDbType.VarChar, 30).Value = surNameTextBox.Text;
            command.Parameters.Add("@byFather", SqlDbType.VarChar, 30).Value = byFatherTextBox.Text;
            command.Parameters.Add("@group", SqlDbType.VarChar, 6).Value = groupTextBox.Text;
            command.Parameters.Add("@birthDate", SqlDbType.Date).Value = birthDateDateTimePicker.Value;
            command.Parameters.Add("@tel", SqlDbType.VarChar, 10).Value = phoneNumberTextBox.Text; 

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Succesfuly added!");
                new FormAddStudent().Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to add \n\n" + ex.Message);
            }
            finally
            {
                connection.Close();
                this.Close();
            }

        }

        private void FormAddStudent_Load(object sender, EventArgs e)
        {

        }
    }
}
