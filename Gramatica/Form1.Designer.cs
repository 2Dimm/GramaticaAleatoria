namespace Gramatica
{
    partial class Form1
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
            this.BtnDerivar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGramatica = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDerivacao = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSaida = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnDerivar
            // 
            this.BtnDerivar.Location = new System.Drawing.Point(12, 160);
            this.BtnDerivar.Name = "BtnDerivar";
            this.BtnDerivar.Size = new System.Drawing.Size(265, 23);
            this.BtnDerivar.TabIndex = 0;
            this.BtnDerivar.Text = "Derivar";
            this.BtnDerivar.UseVisualStyleBackColor = true;
            this.BtnDerivar.Click += new System.EventHandler(this.btnDerrivar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Insira a gramática";
            // 
            // txtGramatica
            // 
            this.txtGramatica.Location = new System.Drawing.Point(12, 33);
            this.txtGramatica.Name = "txtGramatica";
            this.txtGramatica.Size = new System.Drawing.Size(265, 78);
            this.txtGramatica.TabIndex = 2;
            this.txtGramatica.Text = "S:ABS|ab\nB:aB|a\nA:aa|a|&";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Processo de derivação";
            // 
            // txtDerivacao
            // 
            this.txtDerivacao.Location = new System.Drawing.Point(306, 33);
            this.txtDerivacao.Name = "txtDerivacao";
            this.txtDerivacao.ReadOnly = true;
            this.txtDerivacao.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.txtDerivacao.Size = new System.Drawing.Size(264, 196);
            this.txtDerivacao.TabIndex = 4;
            this.txtDerivacao.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Saída";
            // 
            // txtSaida
            // 
            this.txtSaida.Location = new System.Drawing.Point(12, 209);
            this.txtSaida.Name = "txtSaida";
            this.txtSaida.ReadOnly = true;
            this.txtSaida.Size = new System.Drawing.Size(265, 20);
            this.txtSaida.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(271, 39);
            this.label4.TabIndex = 7;
            this.label4.Text = "Instruções: cada não-terminal precisa estar em um linha \r\ne separado por dois pon" +
    "tos (:), sendo cada produção \r\nseparada por uma barra vertical (|)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 241);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSaida);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDerivacao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGramatica);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnDerivar);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Derivador aleatorio de gramática";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnDerivar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtGramatica;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtDerivacao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSaida;
        private System.Windows.Forms.Label label4;
    }
}

