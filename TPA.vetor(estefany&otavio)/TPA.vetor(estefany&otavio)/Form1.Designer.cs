namespace TPA.vetor_estefany_otavio_
{
    partial class frmmenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiprogramas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmisair = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiex1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiex2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiex3 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsmidevs = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiprogramas,
            this.tsmisair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiprogramas
            // 
            this.tsmiprogramas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiex1,
            this.tsmiex2,
            this.tsmiex3});
            this.tsmiprogramas.Name = "tsmiprogramas";
            this.tsmiprogramas.Size = new System.Drawing.Size(94, 24);
            this.tsmiprogramas.Text = "Programas";
            // 
            // tsmisair
            // 
            this.tsmisair.Name = "tsmisair";
            this.tsmisair.Size = new System.Drawing.Size(46, 24);
            this.tsmisair.Text = "sair";
            this.tsmisair.Click += new System.EventHandler(this.tsmisair_Click);
            // 
            // tsmiex1
            // 
            this.tsmiex1.Name = "tsmiex1";
            this.tsmiex1.Size = new System.Drawing.Size(224, 26);
            this.tsmiex1.Text = "Exercicio 1";
            this.tsmiex1.Click += new System.EventHandler(this.tsmiex1_Click);
            // 
            // tsmiex2
            // 
            this.tsmiex2.Name = "tsmiex2";
            this.tsmiex2.Size = new System.Drawing.Size(224, 26);
            this.tsmiex2.Text = "Exercício 2";
            // 
            // tsmiex3
            // 
            this.tsmiex3.Name = "tsmiex3";
            this.tsmiex3.Size = new System.Drawing.Size(224, 26);
            this.tsmiex3.Text = "Exercício3";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmidevs});
            this.statusStrip1.Location = new System.Drawing.Point(0, 424);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsmidevs
            // 
            this.tsmidevs.Name = "tsmidevs";
            this.tsmidevs.Size = new System.Drawing.Size(404, 20);
            this.tsmidevs.Text = "Programa Desenvolvido por Maria Estéfany e Otávio Aguiar";
            // 
            // frmmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmmenu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiprogramas;
        private System.Windows.Forms.ToolStripMenuItem tsmiex1;
        private System.Windows.Forms.ToolStripMenuItem tsmiex2;
        private System.Windows.Forms.ToolStripMenuItem tsmiex3;
        private System.Windows.Forms.ToolStripMenuItem tsmisair;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsmidevs;
    }
}

