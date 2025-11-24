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
        Double[] A = new Double[15];
        Double[] B = new Double[15];
        Int32 i;
        double x;

        private void btncalcular_Click(object sender, EventArgs e)
        {
            for (i = 0; i <= 14; i++)
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
            btnadicionar.Visible = true;

        }

        private void btnadicionar_Click(object sender, EventArgs e)
        {
            if (txtvetorA.Text == "")
            {
                MessageBox.Show("Digite um valor!");
                txtvetorA.Focus();
                return;

            }

            if (i <= 14)
            {
                x = Convert.ToDouble(txtvetorA.Text);
                A[i] = x;
                txtvetorA.Clear();
                txtvetorA.Focus();
                btncalcular.Visible = false;
                btnlimpar.Visible = false;
                i++;


            }
            if (i > 14)
            {
                btnadicionar.Visible = false;
                txtvetorA.Enabled = false;
                btncalcular.Visible = true;

                i = 0;

            }
        }

        private void txtadicionar_Click(object sender, EventArgs e)
        {
           
        }
    }
}
