using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Calculadoras
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void Calc1_Click(object sender, EventArgs e)
        {
            frmCalc1 objCalculadora1 = new frmCalc1();
            objCalculadora1.ShowDialog();
            //teste de commit github
        }

        private void Calc2_Click(object sender, EventArgs e)
        {
            frmCalc2 objCalculadora2 = new frmCalc2();
            objCalculadora2.ShowDialog();
        }

        private void tsmSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Saindo...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
