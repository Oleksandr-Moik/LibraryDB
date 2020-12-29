using System.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibraryDB
{
    public partial class FormStudent : Form
    {
        SqlConnection connection;

        public FormStudent()
        {
            InitializeComponent();
            connection = new SqlConnection(FormMain.ConnectionString);
        }

        private void studentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libraryDataSet);
        }

        private void FormStudent_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDataSet.Student". При необходимости она может быть перемещена или удалена.
            this.studentTableAdapter.Fill(this.libraryDataSet.Student);
            ComboBox_fill();
        }

        private void ComboBox_fill()
        {
            List<string> sort = new List<string>() {
                "studentId", "FirstName", "SurName", "ByFather",
                "Group", "BirthDate", "PhoneNumber"};
            SetComboList(sort, comboBox1);

            List<string> method = new List<string>() { "ASC", "DESC" };
            SetComboList(method, comboBox2);


            List<string> filter = new List<string>() {
                "FirstName", "SurName", "BirthDate",
                "PhoneNumber", "Group"};
            SetComboList(filter, comboBox3);

            List<string> find = new List<string>() {
                "studentId", "FirstName", "PhoneNumber"};
            SetComboList(find, comboBox4);
        }

        private void SetComboList(List<String> list, ComboBox comboBox)
        {
            comboBox.Items.Clear();
            for (int i = 0; i < list.Count; i++) comboBox.Items.Add(list[i]);
            comboBox.SelectedIndex = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // search
            label2.Visible = false;
            for (int i = 0; i < studentDataGridView.RowCount; i++) studentDataGridView.Rows[i].DefaultCellStyle.BackColor = Color.White;
            string name = comboBox4.SelectedItem.ToString();
            string val = textBox2.Text;
            int index = this.studentBindingSource.Find(name, val);
            if (index >= 0)
            {
                studentDataGridView.Rows[index].DefaultCellStyle.BackColor = Color.Yellow;
                listBox1.SelectedIndex = index;
            }
            else label2.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // reset all
            studentBindingSource.Filter = "";
            for (int i = 0; i < studentBindingSource.Count; i++)
            {
                studentDataGridView.Rows[i].DefaultCellStyle.BackColor = Color.White;
                textBox1.Text = "";
                textBox2.Text = "";
                label1.Visible = false;
                label2.Visible = false;
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0 && comboBox2.SelectedIndex >= 0)
            {
                string st = comboBox1.SelectedItem.ToString();
                this.studentBindingSource.Sort = st + " " + comboBox2.SelectedItem.ToString();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1_SelectedIndexChanged(sender, e);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Visible = false;
            string name = comboBox3.SelectedItem.ToString();
            if (name.Trim() != "")
            {
                string f = name + " like '%" + textBox1.Text + "%'";
                this.studentBindingSource.Filter = f;

                if (studentDataGridView.RowCount == 1)
                {
                    label1.Visible = true;
                    studentBindingSource.Filter = "";
                }
                else
                {
                    label1.Visible = false;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void btn_Add_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("INSERT INTO Student VALUES " +
                $"('{firstNameTextBox.Text}','{surNameTextBox.Text}','{byFatherTextBox.Text}'," +
                $"'{groupTextBox.Text}'," +
                $"'{birthDateDateTimePicker.Value.Year}-{birthDateDateTimePicker.Value.Month}-{birthDateDateTimePicker.Value.Day}'," +
                $"'{phoneNumberTextBox.Text}')", connection);
            sqlCommand.ExecuteNonQuery();
            this.studentTableAdapter.Fill(this.libraryDataSet.Student);
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
            connection.Close();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand($"UPDATE Student SET " +
                $"FirstName = '{firstNameTextBox.Text}', SurName = '{surNameTextBox.Text}'," +
                $"ByFather = '{byFatherTextBox.Text}', [Group] = '{groupTextBox.Text}', " +
                $"BirthDate = '{birthDateDateTimePicker.Value.Year}-{birthDateDateTimePicker.Value.Month}-{birthDateDateTimePicker.Value.Day}', PhoneNumber = '{phoneNumberTextBox.Text}'" +
                $"WHERE StudentId = {studentIdLabel1.Text}", connection);
            sqlCommand.ExecuteNonQuery();
            this.studentTableAdapter.Fill(this.libraryDataSet.Student);
            connection.Close();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand($"DELETE Student WHERE StudentId = {studentIdLabel1.Text}", connection);
            command.ExecuteNonQuery();
            this.studentTableAdapter.Fill(this.libraryDataSet.Student);
            connection.Close();
        }
    }
}
