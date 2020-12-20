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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new FormBook().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new FormStudent().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new FormIssuanseRecord().ShowDialog();
        }
    }
}
