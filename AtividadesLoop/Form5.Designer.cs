namespace AtividadesLoop
{
    partial class frmw2
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
            this.lblf = new System.Windows.Forms.Label();
            this.txtf = new System.Windows.Forms.TextBox();
            this.btncalc = new System.Windows.Forms.Button();
            this.btnvolt = new System.Windows.Forms.Button();
            this.btnlimp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblf
            // 
            this.lblf.AutoSize = true;
            this.lblf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblf.Location = new System.Drawing.Point(42, 183);
            this.lblf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblf.Name = "lblf";
            this.lblf.Size = new System.Drawing.Size(205, 20);
            this.lblf.TabIndex = 1;
            this.lblf.Text = "A temperatura convertida é:";
            this.lblf.Click += new System.EventHandler(this.lblf_Click);
            // 
            // txtf
            // 
            this.txtf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtf.Location = new System.Drawing.Point(391, 177);
            this.txtf.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtf.Name = "txtf";
            this.txtf.Size = new System.Drawing.Size(369, 26);
            this.txtf.TabIndex = 3;
            this.txtf.TextChanged += new System.EventHandler(this.txtf_TextChanged);
            // 
            // btncalc
            // 
            this.btncalc.Location = new System.Drawing.Point(46, 441);
            this.btncalc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btncalc.Name = "btncalc";
            this.btncalc.Size = new System.Drawing.Size(112, 35);
            this.btncalc.TabIndex = 4;
            this.btncalc.Text = "Calcular";
            this.btncalc.UseVisualStyleBackColor = true;
            this.btncalc.Click += new System.EventHandler(this.btncalc_Click);
            // 
            // btnvolt
            // 
            this.btnvolt.Location = new System.Drawing.Point(194, 441);
            this.btnvolt.Name = "btnvolt";
            this.btnvolt.Size = new System.Drawing.Size(112, 35);
            this.btnvolt.TabIndex = 5;
            this.btnvolt.Text = "Voltar";
            this.btnvolt.UseVisualStyleBackColor = true;
            this.btnvolt.Click += new System.EventHandler(this.btnvolt_Click);
            // 
            // btnlimp
            // 
            this.btnlimp.Location = new System.Drawing.Point(353, 441);
            this.btnlimp.Name = "btnlimp";
            this.btnlimp.Size = new System.Drawing.Size(112, 35);
            this.btnlimp.TabIndex = 6;
            this.btnlimp.Text = "Limpar";
            this.btnlimp.UseVisualStyleBackColor = true;
            this.btnlimp.Click += new System.EventHandler(this.btnlimp_Click);
            // 
            // frmw2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btnlimp);
            this.Controls.Add(this.btnvolt);
            this.Controls.Add(this.btncalc);
            this.Controls.Add(this.txtf);
            this.Controls.Add(this.lblf);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmw2";
            this.Text = "while 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblf;
        private System.Windows.Forms.TextBox txtf;
        private System.Windows.Forms.Button btncalc;
        private System.Windows.Forms.Button btnvolt;
        private System.Windows.Forms.Button btnlimp;
    }
}