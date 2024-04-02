using System;
using System.Drawing;
using System.Windows.Forms;

namespace Projeto_Calculadoras
{
    public partial class frmCalc2 : Form
    {
        public frmCalc2()
        {
            InitializeComponent();
        }

        /* 31/03 - Para concluir a atividade, ainda devo arrumar o erro em que quando uma operação que não necessita de dois números é 
        utilizada x vezes em seguida o lblHist.text fica = "", e o calculo de porcentagem também deve ser modificado
        
           01/04 - Porcentagem aparentemente solucionada, encontrei + 2 bugs e já os arrumei.
         */

        //variáveis globais
        decimal vNumAnt;
        string vOperacao, somatoria = "";
        bool vLimpa, vLimpa2, vOperacaoDupla;
        Color corAnt;


        //Acionamento dos números
        private void f_numeros(object sender, EventArgs e)
        {
            string vNumero = ((Button)sender).Text;
            if (vLimpa2)
            {
                lblHist.Text = "";
                vLimpa2 = false;
            }
            if (lblVisor.Text == "0" || vLimpa == true) lblVisor.Text = ""; vLimpa = false;
            if (vNumero != "," || (vNumero == "," && !lblVisor.Text.Contains(",")))
            {
                if (vNumero == "," && lblVisor.Text == "")
                {
                    lblVisor.Text = "0,";
                }
                else
                {
                    lblVisor.Text += vNumero;
                }
            }
            lblVisor.Focus();
        }

        //Acionamento das operações
        private void f_operacoes(object sender, EventArgs e)
        {
            vNumAnt = decimal.Parse(lblVisor.Text);
            vOperacao = ((Button)sender).Text;
            lblHist.Text += vNumAnt + " " + vOperacao;
            if (vLimpa2) lblHist.Text = ""; vLimpa2 = false;
            //Operações que não precisam de 2 números 
            if (vOperacao == "²√" || vOperacao == "x²" || vOperacao == "¹/x" || vOperacao == "±")
            {
                switch (vOperacao)
                {
                    case "²√":
                        {
                            double num;
                            num = (double)vNumAnt;
                            lblVisor.Text = Math.Sqrt(num).ToString();
                            break;
                        }
                    case "x²":
                        {
                            double num;
                            num = (double)vNumAnt;
                            lblVisor.Text = Math.Pow(num, 2).ToString();
                            break;
                        }
                    case "¹/x":
                        {
                            try
                            {
                                lblVisor.Text = (1 / vNumAnt).ToString();
                            }
                            catch (DivideByZeroException)
                            {
                                lblHist.Text = "";
                                MessageBox.Show("Não é possível dividir por zero!");
                            }
                            break;
                        }
                    case "±":
                        {
                            lblVisor.Text = (vNumAnt * (-1)).ToString();
                            break;
                        }
                }
                //vLimpa para limpar o Visor após a operação
                vLimpa = true;
                //vLimpa 2 para limpar o Histórico após a operação
                vLimpa2 = true;
            }
            else if ((vOperacao == "+" && somatoria != vNumAnt.ToString()) || (vOperacao == "-" && somatoria != vNumAnt.ToString()) || (vOperacao == "×" && somatoria != vNumAnt.ToString()) || (vOperacao == "÷" && somatoria != vNumAnt.ToString()))
            {
                vLimpa = true;
                vLimpa2 = false;
            }
            else
            {
                vLimpa = true;
                vLimpa2 = true;
            }
            //Foco em lblVisor
            lblVisor.Focus();
        }

        //Acionamento do botão igual
        private void btnIgual_Click(object sender, EventArgs e)
        {
            string vOperacao2;
            try
            {
                vOperacao2 = ((Button)sender).Text;
            }
            catch (Exception)
            {
                vOperacao2 = "";
            }          
            decimal vNumPost = decimal.Parse(lblVisor.Text);
            decimal porcentagem;
            
            // Verifica se o evento foi acionado por uma tecla pressionada
            if (e is KeyEventArgs keyArgs && keyArgs.KeyCode == Keys.Return || vOperacao2 == "=")
            {
                // Verifica a operação
                switch (vOperacao)
                {
                    case "+":
                        lblVisor.Text = (vNumAnt + vNumPost).ToString();
                        lblHist.Text += " " + vNumPost + " = ";
                        break;
                    case "-":
                        lblVisor.Text = (vNumAnt - vNumPost).ToString();
                        lblHist.Text += " " + vNumPost + " = ";
                        break;
                    case "×":
                        lblVisor.Text = (vNumAnt * vNumPost).ToString();
                        lblHist.Text += " " + vNumPost + " = ";
                        break;
                    case "÷":
                        try
                        {
                            lblVisor.Text = (vNumAnt / vNumPost).ToString();
                            lblHist.Text += " " + vNumPost + " = ";
                        }
                        catch (DivideByZeroException)
                        {
                            MessageBox.Show("Não é possível dividir por zero!");
                        }
                        break;
                    default:
                        break;
                }
            }
            else if (vOperacao2 == "%")
            {
                lblHist.Text += " " + vNumPost +  "%" + " = ";
                porcentagem = vNumPost;
                if (lblHist.Text.Contains("-"))
                {
                    porcentagem = (porcentagem * (-1));
                    lblVisor.Text = (vNumAnt + ((vNumAnt / 100) * porcentagem)).ToString();
                }
                else if (lblHist.Text.Contains("+"))
                {
                    lblVisor.Text = (vNumAnt + ((vNumAnt / 100) * porcentagem)).ToString();
                }
                vOperacaoDupla = false;
                vLimpa2 = true;
                vLimpa = true;
            }

            // Limpando Visor e Histórico e deixando o foco em Visor
            somatoria += lblVisor.Text + " ";
            vLimpa2 = false;
            vLimpa = true;
            lblVisor.Focus();
        }


        //Acionamento dos Botões que apagam, CE, C e <-
        private void f_apagar(object sender, EventArgs e)
        {
            string apg = ((Button)sender).Text;
            switch (apg)
            {
                case "CE":
                    {
                        if (lblVisor.Text != "0") lblVisor.Text = "0";
                        break;
                    }
                case "C":
                    {
                        if (lblVisor.Text.Length > 0) lblVisor.Text = lblVisor.Text.Remove(0, lblVisor.Text.Length); lblVisor.Text = "0"; lblHist.Text = "";
                        break;
                    }
                case "<-":
                    {
                        if (lblVisor.Text.Length > 0)
                        {
                            if (lblVisor.Text != "0" && lblVisor.Text.Length == 1) lblVisor.Text = "0";
                            else if (lblVisor.Text == "0") { }
                            else lblVisor.Text = lblVisor.Text.Remove(lblVisor.Text.Length - 1, 1);
                        }
                        break;
                    }
                default:
                    break;
            }
        }

        //Evento Enter 
        private void frmCalc2_Enter(object sender, EventArgs e)
        {

        }

        //Recebendo o pressionamento de teclas
        private void frmCalc2_KeyDown(object sender, KeyEventArgs e)
        {
            //Muda cor ao pressionar tecla
            string tecla = e.KeyCode.ToString();
            //lblHist.Text = e.KeyCode.ToString();
            foreach (Control btn in tableLayoutPanel2.Controls)
            {
                if (btn is Button && tecla.Length == 7 && tecla != "Decimal")
                {
                    if (btn.Text == tecla.Substring(6, 1))
                    {
                        corAnt = btn.BackColor;
                        btn.BackColor = Color.Gray;
                    }
                }
                else if (btn is Button)
                {
                    switch (tecla)
                    {
                        case "Add":
                            {
                                if (btn.Text == "+")
                                {
                                    corAnt = btn.BackColor;
                                    btn.BackColor = Color.Gray;
                                }
                                break;
                            }
                        case "Subtract":
                            {
                                if (btn.Text == "-")
                                {
                                    corAnt = btn.BackColor;
                                    btn.BackColor = Color.Gray;
                                }
                                break;
                            }
                        case "Multiply":
                            {
                                if (btn.Text == "×")
                                {
                                    corAnt = btn.BackColor;
                                    btn.BackColor = Color.Gray;
                                }
                                break;
                            }
                        case "Divide":
                            {
                                if (btn.Text == "÷")
                                {
                                    corAnt = btn.BackColor;
                                    btn.BackColor = Color.Gray;
                                }
                                break;
                            }
                        case "OemOpenBrackets":
                            {
                                if (btn.Text == "¹/x")
                                {
                                    corAnt = btn.BackColor;
                                    btn.BackColor = Color.Gray;
                                }
                                break;
                            }
                        case "Oem6":
                            {
                                if (btn.Text == "x²")
                                {
                                    corAnt = btn.BackColor;
                                    btn.BackColor = Color.Gray;
                                }
                                break;
                            }
                        case "Oem7":
                            {
                                if (btn.Text == "²√")
                                {
                                    corAnt = btn.BackColor;
                                    btn.BackColor = Color.Gray;
                                }
                                break;
                            }
                        case "Oem5":
                            {
                                if (btn.Text == "%")
                                {
                                    corAnt = btn.BackColor;
                                    btn.BackColor = Color.Gray;
                                }
                                break;
                            }
                        case "None":
                            {
                                if (btn.Text == "±")
                                {
                                    corAnt = btn.BackColor;
                                    btn.BackColor = Color.Gray;
                                }
                                break;
                            }
                        case "Decimal":
                            {
                                //Oemcomma
                                if (btn.Text == ",")
                                {
                                    corAnt = btn.BackColor;
                                    btn.BackColor = Color.Gray;
                                }
                                break;
                            }
                        case "Return":
                            {
                                if (btn.Text == "=")
                                {
                                    corAnt = btn.BackColor;
                                    btn.BackColor = Color.Gray;
                                }
                                break;
                            }
                        case "C":
                            {
                                if (btn.Text == "C")
                                {
                                    corAnt = btn.BackColor;
                                    btn.BackColor = Color.Gray;
                                }
                                break;
                            }
                        case "X":
                            {
                                if (btn.Text == "CE")
                                {
                                    corAnt = btn.BackColor;
                                    btn.BackColor = Color.Gray;
                                }
                                break;
                            }
                        case "Back":
                            {
                                if (btn.Text == "<-")
                                {
                                    corAnt = btn.BackColor;
                                    btn.BackColor = Color.Gray;
                                }
                                break;
                            }
                    }
                }
            }
            //Sai do form ao pressionar esc
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }

            //Acionamento das teclas
            Button Bot = new Button();
            if (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9)
            {
                Bot.Text = tecla.Substring(6, 1);
                f_numeros(Bot, e);
            }
            else
            {
                switch (e.KeyCode.ToString())
                {
                    case "Add":
                        {
                            Bot.Text = "+";
                            f_operacoes(Bot, e);
                            break;
                        }
                    case "Subtract":
                        {
                            Bot.Text = "-";
                            f_operacoes(Bot, e);
                            break;
                        }
                    case "Multiply":
                        {
                            Bot.Text = "×";
                            f_operacoes(Bot, e);
                            break;
                        }
                    case "Divide":
                        {
                            Bot.Text = "÷";
                            f_operacoes(Bot, e);
                            break;
                        }
                    case "OemOpenBrackets":
                        {
                            Bot.Text = "¹/x";
                            f_operacoes(Bot, e);
                            break;
                        }
                    case "Oem6":
                        {
                            Bot.Text = "x²";
                            f_operacoes(Bot, e);
                            break;
                        }
                    case "Oem7":
                        {
                            Bot.Text = "²√";
                            f_operacoes(Bot, e);
                            break;
                        }
                    case "Oem5":
                        {
                            Bot.Text = "%";
                            btnIgual_Click(Bot, e);
                            break;
                        }
                    case "None":
                        {
                            Bot.Text = "±";
                            f_operacoes(Bot, e);
                            break;
                        }
                    case "Decimal":
                        {
                            Bot.Text = ",";
                            f_numeros(Bot, e);
                            break;
                        }
                    case "X":
                        {
                            Bot.Text = "CE";
                            f_apagar(Bot, e);
                            break;
                        }
                    case "C":
                        {
                            Bot.Text = "C";
                            f_apagar(Bot, e);
                            break;
                        }
                    case "Back":
                        {
                            Bot.Text = "<-";
                            f_apagar(Bot, e);
                            break;
                        }
                    case "Return":
                        {
                            btnIgual_Click(sender, e);
                            break;
                        }
                }
            }
        }

        //Faz os botões voltarem a cor normal
        private void frmCalc2_KeyUp(object sender, KeyEventArgs e)
        {
            string tecla = e.KeyCode.ToString();
            foreach (Control btn in tableLayoutPanel2.Controls)
            {
                if (btn is Button && tecla.Length == 7 && tecla != "Decimal")
                {
                    if (btn.Text == tecla.Substring(6, 1)) btn.BackColor = corAnt;
                }
                else if (btn is Button)
                {
                    switch (tecla)
                    {
                        case "Add":
                            {
                                if (btn.Text == "+") btn.BackColor = corAnt;
                                break;
                            }
                        case "Subtract":
                            {
                                if (btn.Text == "-") btn.BackColor = corAnt;
                                break;
                            }
                        case "Multiply":
                            {
                                if (btn.Text == "×") btn.BackColor = corAnt;
                                break;
                            }
                        case "Divide":
                            {
                                if (btn.Text == "÷") btn.BackColor = corAnt;
                                break;
                            }
                        case "OemOpenBrackets":
                            {
                                if (btn.Text == "¹/x") btn.BackColor = corAnt;
                                break;
                            }
                        case "Oem6":
                            {
                                if (btn.Text == "x²") btn.BackColor = corAnt;
                                break;
                            }
                        case "Oem7":
                            {
                                if (btn.Text == "²√") btn.BackColor = corAnt;
                                break;
                            }
                        case "Oem5":
                            {
                                if (btn.Text == "%") btn.BackColor = corAnt;
                                break;
                            }
                        case "None":
                            {
                                if (btn.Text == "±") btn.BackColor = corAnt;
                                break;
                            }
                        case "Decimal":
                            {
                                if (btn.Text == ",") btn.BackColor = corAnt;
                                break;
                            }
                        case "Return":
                            {
                                if (btn.Text == "=") btn.BackColor = corAnt;
                                break;
                            }
                        case "C":
                            {
                                if (btn.Text == "C") btn.BackColor = corAnt;
                                break;
                            }
                        case "X":
                            {
                                if (btn.Text == "CE") btn.BackColor = corAnt;
                                break;
                            }
                        case "Back":
                            {
                                if (btn.Text == "<-") btn.BackColor = corAnt;
                                break;
                            }
                    }
                }
            }
        }
    }
}
