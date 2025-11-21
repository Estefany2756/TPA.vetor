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
    public partial class frmex1 : Form
    {
        public frmex1()
        {
            InitializeComponent();
            i = 0;
        }
        Int32[] A = new Int32[2];
        Int32[] B = new Int32[2];
        Int32 i, x;

        private void btncalcular_Click(object sender, EventArgs e)
        {
            for (i = 0; i <= 1; i++)
            {
                B[i] = A[i] * A[i];

                lstresult.Items.Add( A[i] + "=" + B[i]);
                btnlimpar.Visible = true;
            }
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            Hide();
            frmmenu menu = new frmmenu();
            menu.Show();
        }

        private void lblresult_Click(object sender, EventArgs e)
        {

        }

        private void frmex1_Load(object sender, EventArgs e)
        {

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            
            lstresult.Items.Clear();
            txtvetorA.Enabled = true;
            txtvetorA.Focus();
            i = 0;
            btncalcular.Visible = false;
            txtadicionar.Visible = true;

        }

        private void txtadicionar_Click(object sender, EventArgs e)
        {
            if (i <= 1)
            {
                x = Convert.ToInt32(txtvetorA.Text);
                A[i] = x;
                txtvetorA.Clear();
                txtvetorA.Focus();
                btncalcular.Visible= false;
                btnlimpar.Visible = false;
                i++;
               

            }
            if (i > 1)
            {
                txtadicionar.Visible = false;
                txtvetorA.Enabled = false;
                btncalcular.Visible = true;
            
                i = 0;

            }
        }
    }
}
