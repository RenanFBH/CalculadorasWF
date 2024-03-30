
namespace Projeto_Calculadoras
{
    partial class frmMenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCalc1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCalc2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmSair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCalc1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCalc1,
            this.tsmCalc2,
            this.toolStripSeparator2,
            this.tsmSair});
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.Black;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            // 
            // tsmCalc1
            // 
            this.tsmCalc1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tsmCalc1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsmCalc1.Name = "tsmCalc1";
            resources.ApplyResources(this.tsmCalc1, "tsmCalc1");
            this.tsmCalc1.Click += new System.EventHandler(this.Calc1_Click);
            // 
            // tsmCalc2
            // 
            this.tsmCalc2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tsmCalc2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsmCalc2.Name = "tsmCalc2";
            resources.ApplyResources(this.tsmCalc2, "tsmCalc2");
            this.tsmCalc2.Click += new System.EventHandler(this.Calc2_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // tsmSair
            // 
            this.tsmSair.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tsmSair.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsmSair.Name = "tsmSair";
            resources.ApplyResources(this.tsmSair, "tsmSair");
            this.tsmSair.Click += new System.EventHandler(this.tsmSair_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tableLayoutPanel1.BackgroundImage = global::Projeto_Calculadoras.Properties.Resources._5137843;
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Name = "label1";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 5, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel1.SetRowSpan(this.tableLayoutPanel2, 6);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.SystemColors.WindowFrame;
            resources.ApplyResources(this.tableLayoutPanel5, "tableLayoutPanel5");
            this.tableLayoutPanel2.SetColumnSpan(this.tableLayoutPanel5, 3);
            this.tableLayoutPanel5.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.button1, 0, 2);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel2.SetRowSpan(this.tableLayoutPanel5, 2);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tableLayoutPanel5.SetColumnSpan(this.label4, 2);
            this.label4.Name = "label4";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.tableLayoutPanel5.SetColumnSpan(this.label6, 2);
            this.label6.Name = "label6";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.tableLayoutPanel5.SetColumnSpan(this.button1, 2);
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Calc1_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.SystemColors.WindowFrame;
            resources.ApplyResources(this.tableLayoutPanel4, "tableLayoutPanel4");
            this.tableLayoutPanel2.SetColumnSpan(this.tableLayoutPanel4, 3);
            this.tableLayoutPanel4.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label8, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.btnCalc1, 0, 2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel2.SetRowSpan(this.tableLayoutPanel4, 2);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tableLayoutPanel4.SetColumnSpan(this.label5, 2);
            this.label5.Name = "label5";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.tableLayoutPanel4.SetColumnSpan(this.label8, 2);
            this.label8.Name = "label8";
            // 
            // btnCalc1
            // 
            resources.ApplyResources(this.btnCalc1, "btnCalc1");
            this.tableLayoutPanel4.SetColumnSpan(this.btnCalc1, 2);
            this.btnCalc1.Name = "btnCalc1";
            this.btnCalc1.UseVisualStyleBackColor = true;
            this.btnCalc1.Click += new System.EventHandler(this.Calc2_Click);
            // 
            // frmMenu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.ShowIcon = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenu_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmCalc1;
        private System.Windows.Forms.ToolStripMenuItem tsmCalc2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmSair;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCalc1;
    }
}

