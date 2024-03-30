
namespace Projeto_Calculadoras
{
    partial class frmCalc1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAdicao = new System.Windows.Forms.Button();
            this.btnSubtracao = new System.Windows.Forms.Button();
            this.btnMultiplicacao = new System.Windows.Forms.Button();
            this.btnDivisao = new System.Windows.Forms.Button();
            this.btnPotenciacao = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnMaiorMenor = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.lblSinal = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblResultado, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtNum1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtNum2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblSinal, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 3);
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(252, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculadora de botões";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 3);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.button2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.button1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnAdicao, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSubtracao, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnMultiplicacao, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnDivisao, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnPotenciacao, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnFechar, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnLimpar, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnMaiorMenor, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 250);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(794, 197);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(161, 124);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 46);
            this.button2.TabIndex = 10;
            this.button2.Text = "Maior/Menor/Igual";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnMaiorMenor_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 46);
            this.button1.TabIndex = 9;
            this.button1.Text = "Raiz ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnRaiz_Click);
            // 
            // btnAdicao
            // 
            this.btnAdicao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdicao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicao.Location = new System.Drawing.Point(3, 26);
            this.btnAdicao.Name = "btnAdicao";
            this.btnAdicao.Size = new System.Drawing.Size(152, 46);
            this.btnAdicao.TabIndex = 1;
            this.btnAdicao.Text = "Adição";
            this.btnAdicao.UseVisualStyleBackColor = true;
            this.btnAdicao.Click += new System.EventHandler(this.btnAdicao_Click);
            // 
            // btnSubtracao
            // 
            this.btnSubtracao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSubtracao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtracao.Location = new System.Drawing.Point(161, 26);
            this.btnSubtracao.Name = "btnSubtracao";
            this.btnSubtracao.Size = new System.Drawing.Size(152, 46);
            this.btnSubtracao.TabIndex = 2;
            this.btnSubtracao.Text = "Subtração";
            this.btnSubtracao.UseVisualStyleBackColor = true;
            this.btnSubtracao.Click += new System.EventHandler(this.btnSubtracao_Click);
            // 
            // btnMultiplicacao
            // 
            this.btnMultiplicacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMultiplicacao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicacao.Location = new System.Drawing.Point(319, 26);
            this.btnMultiplicacao.Name = "btnMultiplicacao";
            this.btnMultiplicacao.Size = new System.Drawing.Size(152, 46);
            this.btnMultiplicacao.TabIndex = 3;
            this.btnMultiplicacao.Text = "Multiplicação ";
            this.btnMultiplicacao.UseVisualStyleBackColor = true;
            this.btnMultiplicacao.Click += new System.EventHandler(this.btnMultiplicacao_Click);
            // 
            // btnDivisao
            // 
            this.btnDivisao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDivisao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivisao.Location = new System.Drawing.Point(477, 26);
            this.btnDivisao.Name = "btnDivisao";
            this.btnDivisao.Size = new System.Drawing.Size(152, 46);
            this.btnDivisao.TabIndex = 4;
            this.btnDivisao.Text = "Divisão";
            this.btnDivisao.UseVisualStyleBackColor = true;
            this.btnDivisao.Click += new System.EventHandler(this.btnDivisao_Click);
            // 
            // btnPotenciacao
            // 
            this.btnPotenciacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPotenciacao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPotenciacao.Location = new System.Drawing.Point(636, 26);
            this.btnPotenciacao.Name = "btnPotenciacao";
            this.btnPotenciacao.Size = new System.Drawing.Size(153, 46);
            this.btnPotenciacao.TabIndex = 5;
            this.btnPotenciacao.Text = "Potenciação";
            this.btnPotenciacao.UseVisualStyleBackColor = true;
            this.btnPotenciacao.Click += new System.EventHandler(this.btnPotenciacao_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFechar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(636, 124);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(153, 46);
            this.btnFechar.TabIndex = 8;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLimpar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(477, 124);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(152, 46);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnMaiorMenor
            // 
            this.btnMaiorMenor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMaiorMenor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaiorMenor.Location = new System.Drawing.Point(319, 124);
            this.btnMaiorMenor.Name = "btnMaiorMenor";
            this.btnMaiorMenor.Size = new System.Drawing.Size(152, 46);
            this.btnMaiorMenor.TabIndex = 6;
            this.btnMaiorMenor.Text = "Par/Impar";
            this.btnMaiorMenor.UseVisualStyleBackColor = true;
            this.btnMaiorMenor.Click += new System.EventHandler(this.btnParImpar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblResultado.AutoSize = true;
            this.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResultado.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(387, 212);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(24, 24);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "?";
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label4, 3);
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(148, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(504, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "_______________________________________________________";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNum1
            // 
            this.txtNum1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNum1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNum1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum1.Location = new System.Drawing.Point(284, 75);
            this.txtNum1.Multiline = true;
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(229, 29);
            this.txtNum1.TabIndex = 6;
            this.txtNum1.Text = "X";
            this.txtNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNum2
            // 
            this.txtNum2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNum2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNum2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum2.Location = new System.Drawing.Point(284, 120);
            this.txtNum2.Multiline = true;
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(229, 29);
            this.txtNum2.TabIndex = 7;
            this.txtNum2.Text = "X";
            this.txtNum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSinal
            // 
            this.lblSinal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSinal.AutoSize = true;
            this.lblSinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSinal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinal.Location = new System.Drawing.Point(240, 124);
            this.lblSinal.Margin = new System.Windows.Forms.Padding(3, 0, 5, 0);
            this.lblSinal.Name = "lblSinal";
            this.lblSinal.Size = new System.Drawing.Size(21, 21);
            this.lblSinal.TabIndex = 8;
            this.lblSinal.Text = "?";
            this.lblSinal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmCalc1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmCalc1";
            this.Text = "Calculadora de Botões";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAdicao;
        private System.Windows.Forms.Button btnSubtracao;
        private System.Windows.Forms.Button btnMultiplicacao;
        private System.Windows.Forms.Button btnDivisao;
        private System.Windows.Forms.Button btnPotenciacao;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnMaiorMenor;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Label lblSinal;
    }
}