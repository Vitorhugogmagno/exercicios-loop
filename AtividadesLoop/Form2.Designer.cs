namespace AtividadesLoop
{
    partial class frmw1
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
            this.lbldig = new System.Windows.Forms.Label();
            this.lbltab = new System.Windows.Forms.Label();
            this.txtdig = new System.Windows.Forms.TextBox();
            this.txttab = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbldig
            // 
            this.lbldig.AutoSize = true;
            this.lbldig.Location = new System.Drawing.Point(15, 107);
            this.lbldig.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbldig.Name = "lbldig";
            this.lbldig.Size = new System.Drawing.Size(340, 24);
            this.lbldig.TabIndex = 0;
            this.lbldig.Text = "Digite um número para ver sua tabuada";
            // 
            // lbltab
            // 
            this.lbltab.AutoSize = true;
            this.lbltab.Location = new System.Drawing.Point(24, 181);
            this.lbltab.Name = "lbltab";
            this.lbltab.Size = new System.Drawing.Size(121, 24);
            this.lbltab.TabIndex = 1;
            this.lbltab.Text = "A tabuada é :";
            // 
            // txtdig
            // 
            this.txtdig.Location = new System.Drawing.Point(364, 104);
            this.txtdig.Name = "txtdig";
            this.txtdig.Size = new System.Drawing.Size(143, 29);
            this.txtdig.TabIndex = 2;
            // 
            // txttab
            // 
            this.txttab.Enabled = false;
            this.txttab.Location = new System.Drawing.Point(235, 181);
            this.txttab.Name = "txttab";
            this.txttab.Size = new System.Drawing.Size(450, 29);
            this.txttab.TabIndex = 8;
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(333, 462);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(127, 33);
            this.btncalcular.TabIndex = 9;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(675, 462);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(127, 33);
            this.btnlimpar.TabIndex = 13;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(512, 462);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(127, 33);
            this.btnvoltar.TabIndex = 14;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // frmw1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 749);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txttab);
            this.Controls.Add(this.txtdig);
            this.Controls.Add(this.lbltab);
            this.Controls.Add(this.lbldig);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmw1";
            this.Text = "While 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldig;
        private System.Windows.Forms.Label lbltab;
        private System.Windows.Forms.TextBox txtdig;
        private System.Windows.Forms.TextBox txttab;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnvoltar;
    }
}