namespace TPA.vetor_estefany_otavio_
{
    partial class frmex1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtvetorA = new System.Windows.Forms.TextBox();
            this.txtadicionar = new System.Windows.Forms.Button();
            this.btncalcular = new System.Windows.Forms.Button();
            this.lstresult = new System.Windows.Forms.ListBox();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.lblresult = new System.Windows.Forms.Label();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtvetorA
            // 
            this.txtvetorA.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvetorA.Location = new System.Drawing.Point(80, 108);
            this.txtvetorA.Name = "txtvetorA";
            this.txtvetorA.Size = new System.Drawing.Size(108, 30);
            this.txtvetorA.TabIndex = 0;
            // 
            // txtadicionar
            // 
            this.txtadicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtadicionar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtadicionar.Location = new System.Drawing.Point(69, 227);
            this.txtadicionar.Name = "txtadicionar";
            this.txtadicionar.Size = new System.Drawing.Size(176, 44);
            this.txtadicionar.TabIndex = 1;
            this.txtadicionar.Text = "Adicionar Número";
            this.txtadicionar.UseVisualStyleBackColor = false;
            this.txtadicionar.Click += new System.EventHandler(this.txtadicionar_Click);
            // 
            // btncalcular
            // 
            this.btncalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btncalcular.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular.Location = new System.Drawing.Point(69, 227);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(176, 44);
            this.btncalcular.TabIndex = 2;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = false;
            this.btncalcular.Visible = false;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // lstresult
            // 
            this.lstresult.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstresult.FormattingEnabled = true;
            this.lstresult.ItemHeight = 23;
            this.lstresult.Location = new System.Drawing.Point(404, 108);
            this.lstresult.Name = "lstresult";
            this.lstresult.ScrollAlwaysVisible = true;
            this.lstresult.Size = new System.Drawing.Size(120, 142);
            this.lstresult.TabIndex = 3;
            // 
            // btnvoltar
            // 
            this.btnvoltar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnvoltar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoltar.Location = new System.Drawing.Point(465, 374);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(118, 45);
            this.btnvoltar.TabIndex = 4;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = false;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresult.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblresult.Location = new System.Drawing.Point(391, 82);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(70, 23);
            this.lblresult.TabIndex = 5;
            this.lblresult.Text = "  A = B";
            this.lblresult.Click += new System.EventHandler(this.lblresult_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnlimpar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpar.Location = new System.Drawing.Point(465, 326);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(118, 42);
            this.btnlimpar.TabIndex = 6;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = false;
            this.btnlimpar.Visible = false;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // frmex1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 450);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.lstresult);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtadicionar);
            this.Controls.Add(this.txtvetorA);
            this.Name = "frmex1";
            this.Text = "Quadrado do Vetor A (15 números)";
            this.Load += new System.EventHandler(this.frmex1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtvetorA;
        private System.Windows.Forms.Button txtadicionar;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.ListBox lstresult;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.Button btnlimpar;
    }
}