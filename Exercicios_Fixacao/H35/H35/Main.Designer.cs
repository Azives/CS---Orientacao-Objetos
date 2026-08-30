namespace H35
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tb_stackoverflow = new System.Windows.Forms.TextBox();
            this.btn_direita = new System.Windows.Forms.Button();
            this.btn_esquerda = new System.Windows.Forms.Button();
            this.btn_transftext = new System.Windows.Forms.Button();
            this.tb_textemisor = new System.Windows.Forms.TextBox();
            this.tb_textreceptor = new System.Windows.Forms.TextBox();
            this.btn_mostrainf = new System.Windows.Forms.Button();
            this.btn_mostrarbola = new System.Windows.Forms.Button();
            this.btn_mostrarmanto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_stackoverflow
            // 
            this.tb_stackoverflow.Location = new System.Drawing.Point(12, 374);
            this.tb_stackoverflow.Name = "tb_stackoverflow";
            this.tb_stackoverflow.Size = new System.Drawing.Size(776, 22);
            this.tb_stackoverflow.TabIndex = 0;
            this.tb_stackoverflow.TextChanged += new System.EventHandler(this.tb_stackoverflow_TextChanged);
            // 
            // btn_direita
            // 
            this.btn_direita.Location = new System.Drawing.Point(540, 12);
            this.btn_direita.Name = "btn_direita";
            this.btn_direita.Size = new System.Drawing.Size(248, 154);
            this.btn_direita.TabIndex = 1;
            this.btn_direita.Text = "Direita ->";
            this.btn_direita.UseVisualStyleBackColor = true;
            this.btn_direita.Click += new System.EventHandler(this.btn_direita_Click);
            // 
            // btn_esquerda
            // 
            this.btn_esquerda.Location = new System.Drawing.Point(12, 12);
            this.btn_esquerda.Name = "btn_esquerda";
            this.btn_esquerda.Size = new System.Drawing.Size(248, 154);
            this.btn_esquerda.TabIndex = 2;
            this.btn_esquerda.Text = "<- Esquerda";
            this.btn_esquerda.UseVisualStyleBackColor = true;
            this.btn_esquerda.Click += new System.EventHandler(this.btn_esquerda_Click);
            // 
            // btn_transftext
            // 
            this.btn_transftext.Location = new System.Drawing.Point(12, 172);
            this.btn_transftext.Name = "btn_transftext";
            this.btn_transftext.Size = new System.Drawing.Size(248, 91);
            this.btn_transftext.TabIndex = 3;
            this.btn_transftext.Text = "Tranferir Texto";
            this.btn_transftext.UseVisualStyleBackColor = true;
            this.btn_transftext.Click += new System.EventHandler(this.btn_transftext_Click);
            // 
            // tb_textemisor
            // 
            this.tb_textemisor.Location = new System.Drawing.Point(12, 269);
            this.tb_textemisor.Name = "tb_textemisor";
            this.tb_textemisor.Size = new System.Drawing.Size(248, 22);
            this.tb_textemisor.TabIndex = 4;
            this.tb_textemisor.Text = "Valtemir Coding";
            // 
            // tb_textreceptor
            // 
            this.tb_textreceptor.Location = new System.Drawing.Point(12, 297);
            this.tb_textreceptor.Name = "tb_textreceptor";
            this.tb_textreceptor.Size = new System.Drawing.Size(248, 22);
            this.tb_textreceptor.TabIndex = 5;
            this.tb_textreceptor.TextChanged += new System.EventHandler(this.tb_textreceptor_TextChanged);
            // 
            // btn_mostrainf
            // 
            this.btn_mostrainf.Location = new System.Drawing.Point(275, 12);
            this.btn_mostrainf.Name = "btn_mostrainf";
            this.btn_mostrainf.Size = new System.Drawing.Size(248, 307);
            this.btn_mostrainf.TabIndex = 6;
            this.btn_mostrainf.Text = "Mostrar Informacoes";
            this.btn_mostrainf.UseVisualStyleBackColor = true;
            this.btn_mostrainf.Click += new System.EventHandler(this.btn_mostrainf_Click);
            // 
            // btn_mostrarbola
            // 
            this.btn_mostrarbola.Location = new System.Drawing.Point(540, 172);
            this.btn_mostrarbola.Name = "btn_mostrarbola";
            this.btn_mostrarbola.Size = new System.Drawing.Size(248, 68);
            this.btn_mostrarbola.TabIndex = 7;
            this.btn_mostrarbola.Text = "Mostrar Bola";
            this.btn_mostrarbola.UseVisualStyleBackColor = true;
            this.btn_mostrarbola.Click += new System.EventHandler(this.btn_mostrarbola_Click);
            // 
            // btn_mostrarmanto
            // 
            this.btn_mostrarmanto.Location = new System.Drawing.Point(540, 251);
            this.btn_mostrarmanto.Name = "btn_mostrarmanto";
            this.btn_mostrarmanto.Size = new System.Drawing.Size(248, 68);
            this.btn_mostrarmanto.TabIndex = 8;
            this.btn_mostrarmanto.Text = "Mostrar Manto";
            this.btn_mostrarmanto.UseVisualStyleBackColor = true;
            this.btn_mostrarmanto.Click += new System.EventHandler(this.btn_mostrarmanto_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_mostrarmanto);
            this.Controls.Add(this.btn_mostrarbola);
            this.Controls.Add(this.btn_mostrainf);
            this.Controls.Add(this.tb_textreceptor);
            this.Controls.Add(this.tb_textemisor);
            this.Controls.Add(this.btn_transftext);
            this.Controls.Add(this.btn_esquerda);
            this.Controls.Add(this.btn_direita);
            this.Controls.Add(this.tb_stackoverflow);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_stackoverflow;
        private System.Windows.Forms.Button btn_direita;
        private System.Windows.Forms.Button btn_esquerda;
        private System.Windows.Forms.Button btn_transftext;
        private System.Windows.Forms.TextBox tb_textemisor;
        private System.Windows.Forms.TextBox tb_textreceptor;
        private System.Windows.Forms.Button btn_mostrainf;
        private System.Windows.Forms.Button btn_mostrarbola;
        private System.Windows.Forms.Button btn_mostrarmanto;
    }
}

