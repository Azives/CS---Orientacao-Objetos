namespace H67
{
    partial class frm_Hora67
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
            this.btn_ExpAnchor = new System.Windows.Forms.Button();
            this.performanceCounter1 = new System.Diagnostics.PerformanceCounter();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ExpAnchor
            // 
            this.btn_ExpAnchor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ExpAnchor.Location = new System.Drawing.Point(624, 176);
            this.btn_ExpAnchor.Name = "btn_ExpAnchor";
            this.btn_ExpAnchor.Size = new System.Drawing.Size(81, 74);
            this.btn_ExpAnchor.TabIndex = 0;
            this.btn_ExpAnchor.Text = "Exemplo Anchor e Opções";
            this.btn_ExpAnchor.UseVisualStyleBackColor = true;
            this.btn_ExpAnchor.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_Hora67
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 448);
            this.Controls.Add(this.btn_ExpAnchor);
            this.IsMdiContainer = true;
            this.Name = "frm_Hora67";
            this.Text = "Hora 6 a 7";
            this.Load += new System.EventHandler(this.Hora67_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ExpAnchor;
        private System.Diagnostics.PerformanceCounter performanceCounter1;
    }
}

