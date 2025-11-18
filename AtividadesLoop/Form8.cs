using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.MonthCalendar;

namespace AtividadesLoop
{
    public partial class frmex3 : Form
    {
        double areatotal = 0.0, larg = 0.0, comp = 0.0, area = 0.0;
        DialogResult resultado = DialogResult.Yes;
        public frmex3()
        {
            InitializeComponent();
        }

        private void btnvolt_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmmenu frmmenu = new frmmenu();
            frmmenu.Show();
        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            {
                comp = Convert.ToDouble(txtcomp.Text);
                larg = Convert.ToDouble(txtlarg.Text);
                area = comp * larg;
                areatotal += area;
                txtareat.Text = area.ToString();

                resultado = MessageBox.Show("Deseja adicionar mais um cômodo?", "Continuar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    txtcomp.Clear();
                    txtlarg.Clear();
                    txtareat.Clear();
                    txtlarg.Focus();
                }
                else if (resultado == DialogResult.No)
                {
                    txtareat.Text = areatotal.ToString();
                }
            }
        }

        private void btnlimp_Click(object sender, EventArgs e)
        {
            txtareat.Clear();
            txtcomp.Clear();
            txtlarg.Clear();
            txtcomp.Focus();
        }
    }
}

