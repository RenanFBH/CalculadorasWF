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
    public partial class frmCalc1 : Form
    {
        public frmCalc1()
        {
            InitializeComponent();
        }
        private void btnAdicao_Click(object sender, EventArgs e)
        {
            double a, b, r;
            lblSinal.Text = "+";
            //tente, caso encontre um exceção de formato, mostre uma mensagem
            try
            {
                //Recolhendo valores das TextBox
                a = double.Parse(txtNum1.Text);
                b = double.Parse(txtNum2.Text);
                //Calculando
                r = a + b;
                //Mostrando o Resultado no Label
                lblResultado.Text = r.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Informe apenas números!");
            }
        }
        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            double a, b, r;
            lblSinal.Text = "-";
            //tente, caso encontre um exceção de formato, mostre uma mensagem
            try
            {
                //Recolhendo valores das TextBox
                a = double.Parse(txtNum1.Text);
                b = double.Parse(txtNum2.Text);
                //Calculando
                r = a - b;
                //Mostrando o Resultado no Label
                lblResultado.Text = r.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Informe apenas números!");
            }
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            double a, b, r;
            lblSinal.Text = "x";
            //tente, caso encontre um exceção de formato, mostre uma mensagem
            try
            {
                //Recolhendo valores das TextBox
                a = double.Parse(txtNum1.Text);
                b = double.Parse(txtNum2.Text);
                //Calculando
                r = a * b;
                //Mostrando o Resultado no Label
                lblResultado.Text = r.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Informe apenas números!");
            }
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            double a, b, r;
            lblSinal.Text = "÷";
            //tente, caso encontre um exceção de formato, mostre uma mensagem
            try
            { 
                //Recolhendo valores das TextBox
                a = double.Parse(txtNum1.Text);
                b = double.Parse(txtNum2.Text);
                if (b == 0)
                {
                    MessageBox.Show("Não é possível dividir por zero!");
                    return;
                }
                //Calculando
                r = a / b;
                //Mostrando o Resultado no Label
                lblResultado.Text = r.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Informe apenas números!");
            }
        }

        private void btnPotenciacao_Click(object sender, EventArgs e)
        {
            double a, b, r;
            lblSinal.Text = "^";
            //tente, caso encontre um exceção de formato, mostre uma mensagem
            try
            {
                //Recolhendo valores das TextBox
                a = double.Parse(txtNum1.Text);
                b = double.Parse(txtNum2.Text);
                if (b == 0 && a != 0)
                {
                    lblResultado.Text = "1";
                    return;
                }
                else if (b == 0 && a == 0)
                {
                    lblResultado.Text = "0";
                    return;
                }
                //Calculando
                r = Math.Pow(a, b);
                //Mostrando o Resultado no Label
                lblResultado.Text = r.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Informe apenas números!");
            }
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            double a, b, r;
            lblSinal.Text = "^";
            //tente, caso encontre um exceção de formato, mostre uma mensagem
            try
            {
                //Recolhendo valores das TextBox
                a = double.Parse(txtNum1.Text);
                b = double.Parse(txtNum2.Text);
                //Calculando
                r = Math.Pow(a, 1 / b);
                //Mostrando o Resultado no Label
                lblResultado.Text = r.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Informe apenas números!");
            }
        }

        private void btnMaiorMenor_Click(object sender, EventArgs e)
        {
            double a, b;
            lblSinal.Text = ">/</=";
            //tente, caso encontre um exceção de formato, mostre uma mensagem
            try
            {
                //Recolhendo valores das TextBox
                a = double.Parse(txtNum1.Text);
                b = double.Parse(txtNum2.Text);
                //Calculando
                if (a > b)
                {
                    lblResultado.Text = a + " > " + b;
                }
                else if (a < b)
                {
                    lblResultado.Text = a + " < " + b;
                }
                else
                {
                    lblResultado.Text = a + " = " + b;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Informe apenas números!");
            }
        }

        private void btnParImpar_Click(object sender, EventArgs e)
        {
            double a, b;
            lblSinal.Text = "Par/Impar";
            //tente, caso encontre um exceção de formato, mostre uma mensagem
            try
            {
                //Recolhendo valores das TextBox
                a = double.Parse(txtNum1.Text);
                b = double.Parse(txtNum2.Text);
                //Calculando
                if (a % 2 == 0 && b % 2 == 0)
                {
                    lblResultado.Text = a + " e " + b + " são Pares";
                }
                else if(a % 2 == 0 && b % 2 != 0)
                {
                    lblResultado.Text = a + " é Par, " + b + " é Impar";
                }
                else if (a % 2 != 0 && b % 2 == 0)
                {
                    lblResultado.Text = a + " é Impar, " + b + " é Par";
                }
                else
                {
                    lblResultado.Text = a + " e " + b + " são Impares";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Informe apenas números!");
            }
        }

        //-----------------------------------------------------------------------

        //Função para limpar
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //Limpando os txts e labels
            txtNum1.Clear();
            txtNum2.Clear();
            lblSinal.Text = "?";
            lblResultado.Text = "?";
            //Envia o foco para o txtPrimeiro
            txtNum1.Focus();
        }

        //Função para fechar o forms
        private void btnFechar_Click(object sender, EventArgs e)
        {
            //Fechando janela
            Close();
        }
    }
}
