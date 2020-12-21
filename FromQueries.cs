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
    public partial class FromQueries : Form
    {
        const string NONE = "None";
        const string WHERE = "WHERE";
        const string ORDER_BY = "ORDER BY";
        const string ALL = "ALL";
        
        private string QueryCommandText="";
        
        public FromQueries()
        {
            InitializeComponent();
        }

        private void FromQueries_Load(object sender, EventArgs e)
        {
            List<string> tables = new List<string>() { "Book", "Student", "IssuanseRecord" };
            for (int i = 0; i < tables.Count; i++) combobox_from.Items.Add(tables[i]);
            combobox_from.SelectedIndex = 0;

            List<string> actions = new List<string>() { NONE, WHERE, ORDER_BY };
            for (int i = 0; i < actions.Count; i++) comboBox_actions.Items.Add(actions[i]);
            comboBox_actions.SelectedIndex = 0;

            comboBox_whereCondition.SelectedIndex = 0;
        }

        private void select_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_doQuery_Click(object sender, EventArgs e)
        {
            GenareteQuery();
            new FormQResult(QueryCommandText).Show();
        }

        private void button_queryText_Click(object sender, EventArgs e)
        {
            GenareteQuery();
            richTextBox1.Text = QueryCommandText;
            richTextBox1.ReadOnly = true;
        }

        private void GenareteQuery()
        {
            string selectColumn, st2 = "";

            if (comboBox_selectColumn.SelectedItem.ToString() == ALL)
                selectColumn = "*";
            else
                selectColumn = comboBox_selectColumn.SelectedItem.ToString();

            QueryCommandText = $"SELECT {selectColumn} FROM {combobox_from.SelectedItem.ToString()} ";

            switch (comboBox_actions.SelectedItem.ToString())
            {
                case WHERE:
                    st2 = $" WHERE {comboBox_whereColumn.SelectedItem.ToString()} {comboBox_whereCondition.SelectedItem.ToString()} '{textBox_whereValue.Text}'";
                    break;
                case ORDER_BY:
                    st2 = $" ORDER BY {comboBox_orderColumn.SelectedItem.ToString()} ";
                    st2 +=
                        (comboBox_orderType.SelectedItem.ToString() == "by ascending") ?
                        " ASC" :
                        " DESC";
                    break;
                default:
                    st2 = "";
                    break;
            }
            QueryCommandText = QueryCommandText + st2;
        }

        private void comboBox_actions_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox_actions.SelectedItem.ToString())
            {
                case WHERE:
                    groupBox1.Enabled = false;
                    groupBox2.Enabled = true;
                    break;
                case ORDER_BY:
                    groupBox1.Enabled = true;
                    groupBox2.Enabled = false;
                    break;
                default:
                    groupBox1.Enabled = false;
                    groupBox2.Enabled = false;
                    break;
            }
        }

        private void combobox_from_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_selectColumn.Items.Clear();
            comboBox_whereColumn.Items.Clear();
            comboBox_orderColumn.Items.Clear();

            List<string> list;

            switch (combobox_from.SelectedItem.ToString())
            {
                case "Book":
                    list = new List<string>() {ALL, "BookId", "Name", "Author", "PublishOffice", "PublishCity", "Pages", "Price", "Year" };
                    break;
                case "Student":
                    list = new List<string>() { ALL, "studentId", "FirstName", "SurName", "ByFather", "Group", "BirthDate", "PhoneNumber" };
                    break;
                case "IssuanseRecord":
                    list = new List<string>() { ALL, "RecordId", "DataOfIssue", "DataOfReturn", "StudentId", "BookId" };
                    break;
                default:
                    list = new List<string> { ALL };
                    return;
            }
            for (int i = 0; i < list.Count; i++)
            {
                comboBox_selectColumn.Items.Add(list[i]);
                comboBox_whereColumn.Items.Add(list[i]);
                comboBox_orderColumn.Items.Add(list[i]);
            }
            comboBox_selectColumn.SelectedIndex = 0;
            comboBox_whereColumn.SelectedIndex = 0;
        }
    }
}
