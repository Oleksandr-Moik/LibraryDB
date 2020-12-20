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
    public partial class FormIssuanseRecord : Form
    {
        public FormIssuanseRecord()
        {
            InitializeComponent();
        }

        private void issuanseRecordBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.issuanseRecordBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libraryDataSet);
        }

        private void FormIssuanseRecord_Load(object sender, EventArgs e)
        {
            this.bookTableAdapter.Fill(this.libraryDataSet.Book);
            this.studentTableAdapter.Fill(this.libraryDataSet.Student);
            this.issuanseRecordTableAdapter.Fill(this.libraryDataSet.IssuanseRecord);
            ComboBox_fill();
        }

        private void ComboBox_fill()
        {
            List<string> method = new List<string>() { "ASC", "DESC" };
            SetComboList(method, comboBox2);

            List<string> sort = new List<string>() { "RecordId", "DataOfIssue", "DataOfReturn", "StudentId", "BookId"};
            SetComboList(sort, comboBox1);
            SetComboList(sort, comboBox3);
            SetComboList(sort, comboBox4);
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
            for (int i = 0; i < issuanseRecordDataGridView.RowCount; i++) issuanseRecordDataGridView.Rows[i].DefaultCellStyle.BackColor = Color.White;
            string name = comboBox4.SelectedItem.ToString();
            string val = textBox2.Text;
            int index = this.issuanseRecordBindingSource.Find(name, val);
            if (index >= 0)
            {
                issuanseRecordDataGridView.Rows[index].DefaultCellStyle.BackColor = Color.Yellow;
                //listBox1.SelectedIndex = index;
            }
            else label2.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // reset all
            issuanseRecordBindingSource.Filter = "";
            for (int i = 0; i < issuanseRecordBindingSource.Count; i++)
            {
                issuanseRecordDataGridView.Rows[i].DefaultCellStyle.BackColor = Color.White;
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
                this.issuanseRecordBindingSource.Sort = st + " " + comboBox2.SelectedItem.ToString();
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
                this.issuanseRecordBindingSource.Filter = f;

                if (issuanseRecordDataGridView.RowCount == 1)
                {
                    label1.Visible = true;
                    issuanseRecordBindingSource.Filter = "";
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
