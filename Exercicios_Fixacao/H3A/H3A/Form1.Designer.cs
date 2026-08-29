namespace H3A
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
            this.btn_b1 = new System.Windows.Forms.Button();
            this.tb_t1 = new System.Windows.Forms.TextBox();
            this.tb_t2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_b1
            // 
            this.btn_b1.Location = new System.Drawing.Point(507, 12);
            this.btn_b1.Name = "btn_b1";
            this.btn_b1.Size = new System.Drawing.Size(281, 131);
            this.btn_b1.TabIndex = 0;
            this.btn_b1.Text = "Passar o Texto";
            this.btn_b1.UseVisualStyleBackColor = true;
            this.btn_b1.Click += new System.EventHandler(this.btn_b1_Click);
            // 
            // tb_t1
            // 
            this.tb_t1.Location = new System.Drawing.Point(12, 12);
            this.tb_t1.Name = "tb_t1";
            this.tb_t1.Size = new System.Drawing.Size(239, 22);
            this.tb_t1.TabIndex = 1;
            this.tb_t1.Text = "Vatemir Coding";
            this.tb_t1.TextChanged += new System.EventHandler(this.tb_t1_TextChanged);
            // 
            // tb_t2
            // 
            this.tb_t2.Location = new System.Drawing.Point(12, 121);
            this.tb_t2.Name = "tb_t2";
            this.tb_t2.Size = new System.Drawing.Size(239, 22);
            this.tb_t2.TabIndex = 2;
            this.tb_t2.TextChanged += new System.EventHandler(this.tb_t2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_t2);
            this.Controls.Add(this.tb_t1);
            this.Controls.Add(this.btn_b1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_b1;
        private System.Windows.Forms.TextBox tb_t1;
        private System.Windows.Forms.TextBox tb_t2;
    }
}

