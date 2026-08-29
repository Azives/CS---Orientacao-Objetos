namespace H3B
{
    partial class CollectionsExampleForm
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
            this.btnShowNames = new System.Windows.Forms.Button();
            this.tb_t1 = new System.Windows.Forms.TextBox();
            this.btn_temirbtn = new System.Windows.Forms.Button();
            this.tb_voidreturn = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnShowNames
            // 
            this.btnShowNames.Location = new System.Drawing.Point(83, 112);
            this.btnShowNames.Name = "btnShowNames";
            this.btnShowNames.Size = new System.Drawing.Size(120, 23);
            this.btnShowNames.TabIndex = 0;
            this.btnShowNames.Text = "Show Control Names";
            this.btnShowNames.UseVisualStyleBackColor = true;
            this.btnShowNames.Click += new System.EventHandler(this.btnShowNames_Click);
            // 
            // tb_t1
            // 
            this.tb_t1.Location = new System.Drawing.Point(597, 112);
            this.tb_t1.Name = "tb_t1";
            this.tb_t1.Size = new System.Drawing.Size(120, 22);
            this.tb_t1.TabIndex = 1;
            this.tb_t1.TextChanged += new System.EventHandler(this.tb_t1_TextChanged);
            // 
            // btn_temirbtn
            // 
            this.btn_temirbtn.Location = new System.Drawing.Point(537, 245);
            this.btn_temirbtn.Name = "btn_temirbtn";
            this.btn_temirbtn.Size = new System.Drawing.Size(180, 65);
            this.btn_temirbtn.TabIndex = 2;
            this.btn_temirbtn.Text = "botao valtinho";
            this.btn_temirbtn.UseVisualStyleBackColor = true;
            // 
            // tb_voidreturn
            // 
            this.tb_voidreturn.Location = new System.Drawing.Point(83, 288);
            this.tb_voidreturn.Name = "tb_voidreturn";
            this.tb_voidreturn.Size = new System.Drawing.Size(100, 22);
            this.tb_voidreturn.TabIndex = 3;
            this.tb_voidreturn.Text = "void return";
            // 
            // CollectionsExampleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_voidreturn);
            this.Controls.Add(this.btn_temirbtn);
            this.Controls.Add(this.tb_t1);
            this.Controls.Add(this.btnShowNames);
            this.Name = "CollectionsExampleForm";
            this.Text = "Collections Example";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowNames;
        private System.Windows.Forms.TextBox tb_t1;
        private System.Windows.Forms.Button btn_temirbtn;
        private System.Windows.Forms.TextBox tb_voidreturn;
    }
}

