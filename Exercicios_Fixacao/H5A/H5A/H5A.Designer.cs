namespace H5A
{
    partial class H5A
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(H5A));
            this.btn_b1 = new System.Windows.Forms.Button();
            this.btn_b2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_b1
            // 
            this.btn_b1.Image = ((System.Drawing.Image)(resources.GetObject("btn_b1.Image")));
            this.btn_b1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_b1.Location = new System.Drawing.Point(482, 12);
            this.btn_b1.Name = "btn_b1";
            this.btn_b1.Size = new System.Drawing.Size(306, 146);
            this.btn_b1.TabIndex = 0;
            this.btn_b1.Text = "Direita -->";
            this.btn_b1.UseVisualStyleBackColor = true;
            this.btn_b1.Click += new System.EventHandler(this.btn_b1_Click);
            // 
            // btn_b2
            // 
            this.btn_b2.Image = global::H5A.Properties.Resources._175608189568abaee765b8a_1756081895_3x2_md;
            this.btn_b2.Location = new System.Drawing.Point(12, 12);
            this.btn_b2.Name = "btn_b2";
            this.btn_b2.Size = new System.Drawing.Size(306, 146);
            this.btn_b2.TabIndex = 1;
            this.btn_b2.Text = "<-- Esquerda";
            this.btn_b2.UseVisualStyleBackColor = true;
            this.btn_b2.Click += new System.EventHandler(this.btn_b2_Click);
            // 
            // H5A
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_b2);
            this.Controls.Add(this.btn_b1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "H5A";
            this.Text = "H5A";
            this.Load += new System.EventHandler(this.H5A_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_b1;
        private System.Windows.Forms.Button btn_b2;
    }
}

