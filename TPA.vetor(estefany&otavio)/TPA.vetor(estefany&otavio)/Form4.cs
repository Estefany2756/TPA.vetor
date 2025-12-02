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
    public partial class frmex4 : Form
    {
        public frmex4()
        {
            InitializeComponent();
        }
        double[] A = new double[30];
        double[] B = new double[30];
        int i = 0;
        double x;

        private void btnadicionar_Click(object sender, EventArgs e)
        {

            if (txtvetorA.Text == "")
            {
                MessageBox.Show("Digite um valor!");
                txtvetorA.Focus();
                return;
            }

            x = Convert.ToDouble(txtvetorA.Text);

            if (i <= 29)
            {
                A[i] = x;
                B[i] = Math.Pow(A[i], 3.0);
                txtvetorA.Clear();
                txtvetorA.Focus();
                i++;
            }
            if (i > 29)
            {
                txtvetorA.Visible = false;
                btnadicionar.Visible = false;
                lblbuscar.Visible = true;
                btnbuscar.Visible = true;
                txtbuscar.Visible = true;
                txtbuscaB.Visible = true;
                btnlimpar.Visible = true;
                txtbuscaA.Visible = true;
                lblB.Visible = true;
                lblA.Visible = true;
              
            }

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {

          


        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            Int32 numBusca;
            numBusca = Convert.ToInt32(txtbuscar.Text);
            btnlimpar.Visible = true;
            if (numBusca < 0 || numBusca > 29)
            {
                MessageBox.Show("Número não encontrado! Tente Novamente");
            }
            else
            {
                txtbuscaA.Text = A[numBusca].ToString();
                txtbuscaB.Text = B[numBusca].ToString();

            }


          
        }

        

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtbuscar.Clear();
            txtbuscaB.Clear();
            txtbuscar.Focus();
            txtbuscaA.Clear();

        }

        private void btnresetar_Click(object sender, EventArgs e)
        {
            i = 0;
            lblbuscar.Visible=false;
            btnadicionar.Visible = true;
            txtvetorA.Visible=true;
            btnbuscar.Visible = false;
            btnlimpar.Visible = false;
            txtbuscar.Visible= false;
            txtbuscaB.Visible=false;
            txtvetorA.Focus();
            txtbuscaA.Visible=false;
            lblA.Visible=false;
            lblB.Visible=false;
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            Hide();
            frmmenu menu = new frmmenu();
            menu.Show();
        }
    }
}
