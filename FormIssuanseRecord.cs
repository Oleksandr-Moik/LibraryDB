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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDataSet.Student". При необходимости она может быть перемещена или удалена.
            this.studentTableAdapter.Fill(this.libraryDataSet.Student);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDataSet.IssuanseRecord". При необходимости она может быть перемещена или удалена.
            this.issuanseRecordTableAdapter.Fill(this.libraryDataSet.IssuanseRecord);

        }

        private void fillWithInnerJoinToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.issuanseRecordTableAdapter.FillWithInnerJoin(this.libraryDataSet.IssuanseRecord);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
