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
    public partial class frmw1 : Form
    {
        public frmw1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {

            int  num, tab,

                i = 1;
            num = Convert.ToInt32(txtdig.Text);
            while (i <= 9)
            {
                tab = num * i;
                txttab.Text = String.Format(
                    txttab.Text + "\n " + tab.ToString());
                    i++;
            }
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmmenu frmmenu = new frmmenu();
            frmmenu.Show();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtdig.Clear();
            txttab.Clear();
            txtdig.Focus();
        }
    }
}
