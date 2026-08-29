namespace H5B
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_b2 = new System.Windows.Forms.Button();
            this.btn_b1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_b2
            // 
            this.btn_b2.BackColor = System.Drawing.Color.MintCream;
            this.btn_b2.Location = new System.Drawing.Point(12, 12);
            this.btn_b2.Name = "btn_b2";
            this.btn_b2.Size = new System.Drawing.Size(370, 426);
            this.btn_b2.TabIndex = 3;
            this.btn_b2.Text = "Mostrar Manto";
            this.btn_b2.UseVisualStyleBackColor = false;
            this.btn_b2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_b1
            // 
            this.btn_b1.BackColor = System.Drawing.Color.MintCream;
            this.btn_b1.Location = new System.Drawing.Point(418, 12);
            this.btn_b1.Name = "btn_b1";
            this.btn_b1.Size = new System.Drawing.Size(370, 426);
            this.btn_b1.TabIndex = 2;
            this.btn_b1.Text = "Mostrar Bola";
            this.btn_b1.UseVisualStyleBackColor = false;
            this.btn_b1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_b2);
            this.Controls.Add(this.btn_b1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Escolha";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_b2;
        private System.Windows.Forms.Button btn_b1;
    }
}

