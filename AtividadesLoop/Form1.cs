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
    public partial class frmmenu : Form
    {
        public frmmenu()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ex1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmw1 frmw1 = new frmw1();
            frmw1.Show();
        }

        private void ex1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmdw1 frmdw1 = new frmdw1();
            frmdw1.Show();
        }

        private void ex1ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmfor1 frmfor1 = new frmfor1();
            frmfor1.Show();
        }

        private void ex2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmw2 frmw2 = new frmw2();
            frmw2.Show();
        }

        private void ex2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmdw2 frmdw2 = new frmdw2();
            frmdw2.Show();
        }

        private void ex2ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmfor2 frmfor2 = new frmfor2();
            frmfor2.Show();
        }

        private void exercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmex3 frmex3 = new frmex3();
            frmex3.Show();
        }
    }
}
