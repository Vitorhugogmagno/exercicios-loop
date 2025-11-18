namespace AtividadesLoop
{
    partial class frmex3
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
            this.lbllarg = new System.Windows.Forms.Label();
            this.lblcomp = new System.Windows.Forms.Label();
            this.lblareatot = new System.Windows.Forms.Label();
            this.txtlarg = new System.Windows.Forms.TextBox();
            this.txtareat = new System.Windows.Forms.TextBox();
            this.txtcomp = new System.Windows.Forms.TextBox();
            this.btnlimp = new System.Windows.Forms.Button();
            this.btnvolt = new System.Windows.Forms.Button();
            this.btncalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbllarg
            // 
            this.lbllarg.AutoSize = true;
            this.lbllarg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllarg.Location = new System.Drawing.Point(59, 129);
            this.lbllarg.Name = "lbllarg";
            this.lbllarg.Size = new System.Drawing.Size(199, 20);
            this.lbllarg.TabIndex = 1;
            this.lbllarg.Text = "Digite a largura do cômodo";
            // 
            // lblcomp
            // 
            this.lblcomp.AutoSize = true;
            this.lblcomp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcomp.Location = new System.Drawing.Point(59, 184);
            this.lblcomp.Name = "lblcomp";
            this.lblcomp.Size = new System.Drawing.Size(242, 20);
            this.lblcomp.TabIndex = 2;
            this.lblcomp.Text = "Digite o comprimento do cômodo";
            // 
            // lblareatot
            // 
            this.lblareatot.AutoSize = true;
            this.lblareatot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblareatot.Location = new System.Drawing.Point(64, 237);
            this.lblareatot.Name = "lblareatot";
            this.lblareatot.Size = new System.Drawing.Size(210, 20);
            this.lblareatot.TabIndex = 3;
            this.lblareatot.Text = "A area total da residência é: ";
            // 
            // txtlarg
            // 
            this.txtlarg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlarg.Location = new System.Drawing.Point(289, 122);
            this.txtlarg.Name = "txtlarg";
            this.txtlarg.Size = new System.Drawing.Size(112, 26);
            this.txtlarg.TabIndex = 5;
            // 
            // txtareat
            // 
            this.txtareat.Enabled = false;
            this.txtareat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtareat.Location = new System.Drawing.Point(289, 234);
            this.txtareat.Name = "txtareat";
            this.txtareat.Size = new System.Drawing.Size(112, 26);
            this.txtareat.TabIndex = 6;
            // 
            // txtcomp
            // 
            this.txtcomp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcomp.Location = new System.Drawing.Point(320, 184);
            this.txtcomp.Name = "txtcomp";
            this.txtcomp.Size = new System.Drawing.Size(112, 26);
            this.txtcomp.TabIndex = 7;
            // 
            // btnlimp
            // 
            this.btnlimp.Location = new System.Drawing.Point(367, 321);
            this.btnlimp.Name = "btnlimp";
            this.btnlimp.Size = new System.Drawing.Size(112, 35);
            this.btnlimp.TabIndex = 10;
            this.btnlimp.Text = "Limpar";
            this.btnlimp.UseVisualStyleBackColor = true;
            this.btnlimp.Click += new System.EventHandler(this.btnlimp_Click);
            // 
            // btnvolt
            // 
            this.btnvolt.Location = new System.Drawing.Point(208, 321);
            this.btnvolt.Name = "btnvolt";
            this.btnvolt.Size = new System.Drawing.Size(112, 35);
            this.btnvolt.TabIndex = 9;
            this.btnvolt.Text = "Voltar";
            this.btnvolt.UseVisualStyleBackColor = true;
            this.btnvolt.Click += new System.EventHandler(this.btnvolt_Click);
            // 
            // btncalc
            // 
            this.btncalc.Location = new System.Drawing.Point(60, 321);
            this.btncalc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btncalc.Name = "btncalc";
            this.btncalc.Size = new System.Drawing.Size(112, 35);
            this.btncalc.TabIndex = 8;
            this.btncalc.Text = "Calcular";
            this.btncalc.UseVisualStyleBackColor = true;
            this.btncalc.Click += new System.EventHandler(this.btncalc_Click);
            // 
            // frmex3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnlimp);
            this.Controls.Add(this.btnvolt);
            this.Controls.Add(this.btncalc);
            this.Controls.Add(this.txtcomp);
            this.Controls.Add(this.txtareat);
            this.Controls.Add(this.txtlarg);
            this.Controls.Add(this.lblareatot);
            this.Controls.Add(this.lblcomp);
            this.Controls.Add(this.lbllarg);
            this.Name = "frmex3";
            this.Text = "ex3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbllarg;
        private System.Windows.Forms.Label lblcomp;
        private System.Windows.Forms.Label lblareatot;
        private System.Windows.Forms.TextBox txtlarg;
        private System.Windows.Forms.TextBox txtareat;
        private System.Windows.Forms.TextBox txtcomp;
        private System.Windows.Forms.Button btnlimp;
        private System.Windows.Forms.Button btnvolt;
        private System.Windows.Forms.Button btncalc;
    }
}