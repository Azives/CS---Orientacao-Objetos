namespace H4B
{
    partial class H4B
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(H4B));
            this.tb_t1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_t1
            // 
            this.tb_t1.Location = new System.Drawing.Point(12, 249);
            this.tb_t1.Name = "tb_t1";
            this.tb_t1.Size = new System.Drawing.Size(776, 22);
            this.tb_t1.TabIndex = 0;
            this.tb_t1.TextChanged += new System.EventHandler(this.tb_t1_TextChanged);
            // 
            // H4B
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_t1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "H4B";
            this.Text = "H4B";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_t1;
    }
}

