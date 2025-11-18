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
    public partial class frmdw1 : Form
    {
        public frmdw1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int i, num, tab;
            i = 1;
            num = Convert.ToInt32(txtdig.Text);
            do
            {
                tab = num * i;
                txttab.Text = String.Format(txttab.Text + "\n " + tab.ToString());
                i++;
            }
            while (i <= 9);
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
