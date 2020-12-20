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
    public partial class FormBook : Form
    {
        public FormBook()
        {
            InitializeComponent();
        }

        private void bookBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bookBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libraryDataSet);
        }

        private void FormBook_Load(object sender, EventArgs e)
        {
            this.bookTableAdapter.Fill(this.libraryDataSet.Book);
            ComboBox_fill();
        }

        private void ComboBox_fill()
        {
            List<string> sort = new List<string>() { 
                "BookId", "Name", "Author", "PublishOffice", 
                "PublishCity", "Pages", "Price", "Year"};
            SetComboList(sort, comboBox1);
            
            List<string> method = new List<string>() { "ASC", "DESC" };
            SetComboList(method, comboBox2);


            List<string> filter = new List<string>() { 
                "Name", "Author", "PublishOffice","PublishCity" };
            SetComboList(filter, comboBox3);

            List<string> find = new List<string>() { 
                "BookId", "Name", "Price", "Autor", "Year" };
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
            for (int i = 0; i < bookDataGridView.RowCount; i++) bookDataGridView.Rows[i].DefaultCellStyle.BackColor = Color.White;
            string name = comboBox4.SelectedItem.ToString();
            string val = textBox2.Text;
            int index = this.bookBindingSource.Find(name, val);
            if (index >= 0)
            {
                bookDataGridView.Rows[index].DefaultCellStyle.BackColor = Color.Yellow;
                listBox1.SelectedIndex = index;
            }
            else label2.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // reset all
            bookBindingSource.Filter = "";
            for (int i = 0; i < bookBindingSource.Count; i++)
            {
                bookDataGridView.Rows[i].DefaultCellStyle.BackColor = Color.White;
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
                this.bookBindingSource.Sort = st + " " + comboBox2.SelectedItem.ToString();
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
                this.bookBindingSource.Filter = f;

                if (bookDataGridView.RowCount == 1)
                {
                    label1.Visible = true;
                    bookBindingSource.Filter = "";
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
    }
}
