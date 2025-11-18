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
    public partial class frmfor1 : Form
    {
        public frmfor1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int i, num, tab;
            num = Convert.ToInt32(txtdig.Text);
            for (i = 1; i <= 9; i++)
            {
                tab = num * i;
                txttab.Text = String.Format(txttab.Text + "\n " + tab.ToString());
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

