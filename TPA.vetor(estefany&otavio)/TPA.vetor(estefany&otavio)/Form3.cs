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
    public partial class frmex2 : Form
    {
        public frmex2()
        {

            InitializeComponent();
            i = 0;
        }

        Double[] A = new Double[10];
        Double[] B = new Double[10];
        Int32 i;
        double x;

        private void btnadicionar_Click(object sender, EventArgs e)
        {
            btnlimpar.Visible = false;

            if (txtvetorA.Text == "")
            {
                MessageBox.Show("Digite um valor!");
                txtvetorA.Focus();
                return;
            }

            x = Convert.ToDouble(txtvetorA.Text);

            if (x <= 0)
            {
                MessageBox.Show("Digite apenas valores positivos!");
                txtvetorA.Clear();
                txtvetorA.Focus();
                return;
            }

            A[i] = x;

            txtvetorA.Clear();
            txtvetorA.Focus();
            i++;

           
            if (i > 9)
            {
                btnadicionar.Visible = false;
                txtvetorA.Enabled = false;
                btnconverter.Visible = true;
                i = 0;  
            }
        }

        private void btnconverter_Click(object sender, EventArgs e)
        {
            lstresult.Items.Clear();

            for (i = 0; i <= 9; i++)
            {
                B[i] = A[i] * (-1); 

                lstresult.Items.Add(A[i] + "  =  " + B[i]);
            }

            btnlimpar.Visible = true;
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            Hide();
            frmmenu menu = new frmmenu();
            menu.Show();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            lstresult.Items.Clear();
            txtvetorA.Enabled = true;
            txtvetorA.Focus();
            txtvetorA.Clear();

            i = 0;

            btnconverter.Visible = false;
            btnadicionar.Visible = true;
        }
    }
}
