using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPA.vetor_estefany_otavio_
{
    public partial class frmmenu : Form
    {
        public frmmenu()
        {
            InitializeComponent();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void tsmihora_Click(object sender, EventArgs e)
        {

        }

        private void tsmiex1_Click(object sender, EventArgs e)
        {
            Hide();
            frmex1 ex1 = new frmex1();
            ex1.Show();
        }

        private void tsmisair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsmiex2_Click(object sender, EventArgs e)
        {
            Hide();
            frmex2 ex2 = new frmex2();
            ex2.Show();
        }
    }
}
