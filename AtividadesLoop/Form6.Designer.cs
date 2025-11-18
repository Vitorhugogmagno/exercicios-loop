namespace AtividadesLoop
{
    partial class frmdw2
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
            this.btnlimp = new System.Windows.Forms.Button();
            this.btnvolt = new System.Windows.Forms.Button();
            this.btncalc = new System.Windows.Forms.Button();
            this.txtf = new System.Windows.Forms.TextBox();
            this.lblf = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnlimp
            // 
            this.btnlimp.Location = new System.Drawing.Point(711, 522);
            this.btnlimp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnlimp.Name = "btnlimp";
            this.btnlimp.Size = new System.Drawing.Size(168, 54);
            this.btnlimp.TabIndex = 13;
            this.btnlimp.Text = "Limpar";
            this.btnlimp.UseVisualStyleBackColor = true;
            this.btnlimp.Click += new System.EventHandler(this.btnlimp_Click);
            // 
            // btnvolt
            // 
            this.btnvolt.Location = new System.Drawing.Point(499, 522);
            this.btnvolt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnvolt.Name = "btnvolt";
            this.btnvolt.Size = new System.Drawing.Size(168, 54);
            this.btnvolt.TabIndex = 12;
            this.btnvolt.Text = "Voltar";
            this.btnvolt.UseVisualStyleBackColor = true;
            this.btnvolt.Click += new System.EventHandler(this.btnvolt_Click);
            // 
            // btncalc
            // 
            this.btncalc.Location = new System.Drawing.Point(248, 522);
            this.btncalc.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btncalc.Name = "btncalc";
            this.btncalc.Size = new System.Drawing.Size(168, 54);
            this.btncalc.TabIndex = 11;
            this.btncalc.Text = "Calcular";
            this.btncalc.UseVisualStyleBackColor = true;
            this.btncalc.Click += new System.EventHandler(this.btncalc_Click);
            // 
            // txtf
            // 
            this.txtf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtf.Location = new System.Drawing.Point(481, 202);
            this.txtf.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtf.Multiline = true;
            this.txtf.Name = "txtf";
            this.txtf.Size = new System.Drawing.Size(412, 26);
            this.txtf.TabIndex = 10;
            // 
            // lblf
            // 
            this.lblf.AutoSize = true;
            this.lblf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblf.Location = new System.Drawing.Point(120, 208);
            this.lblf.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblf.Name = "lblf";
            this.lblf.Size = new System.Drawing.Size(205, 20);
            this.lblf.TabIndex = 8;
            this.lblf.Text = "A temperatura convertida é:";
            // 
            // frmdw2
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
            this.Name = "frmdw2";
            this.Text = "Do while 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnlimp;
        private System.Windows.Forms.Button btnvolt;
        private System.Windows.Forms.Button btncalc;
        private System.Windows.Forms.TextBox txtf;
        private System.Windows.Forms.Label lblf;
    }
}