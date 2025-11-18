using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadesLoop
{
    public partial class frmw2 : Form
    {
        public frmw2()
        {
            InitializeComponent();
        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            int i = 1, c=0;
            double f;
            while (i <= 10)
            {
                c = c + 10;
                f = (c * 1.8) + 32;
                txtf.Text = String.Format(txtf.Text + "\n "+ f.ToString());
                i++;
            }
        }

        private void btnvolt_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmmenu frmmenu = new frmmenu();
            frmmenu.Show();
        }

        private void btnlimp_Click(object sender, EventArgs e)
        {
            txtf.Clear();
        }

        private void txtf_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttemp_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblf_Click(object sender, EventArgs e)
        {

        }

        private void lbltemp_Click(object sender, EventArgs e)
        {

        }
    }
}
