namespace H67
{
    partial class frm_opcoes
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
            this.lbl_NomeUsuario = new System.Windows.Forms.Label();
            this.tb_NomeUsuario = new System.Windows.Forms.TextBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.chk_PronptSair = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbl_NomeUsuario
            // 
            this.lbl_NomeUsuario.AutoSize = true;
            this.lbl_NomeUsuario.Location = new System.Drawing.Point(40, 41);
            this.lbl_NomeUsuario.Name = "lbl_NomeUsuario";
            this.lbl_NomeUsuario.Size = new System.Drawing.Size(122, 16);
            this.lbl_NomeUsuario.TabIndex = 1;
            this.lbl_NomeUsuario.Text = "Nome do Usuario : ";
            // 
            // tb_NomeUsuario
            // 
            this.tb_NomeUsuario.Location = new System.Drawing.Point(156, 38);
            this.tb_NomeUsuario.Name = "tb_NomeUsuario";
            this.tb_NomeUsuario.Size = new System.Drawing.Size(200, 22);
            this.tb_NomeUsuario.TabIndex = 0;
            this.tb_NomeUsuario.TextChanged += new System.EventHandler(this.tb_NomeUsuario_TextChanged);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancelar.Location = new System.Drawing.Point(362, 70);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 2;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_Ok
            // 
            this.btn_Ok.Location = new System.Drawing.Point(362, 38);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(75, 23);
            this.btn_Ok.TabIndex = 3;
            this.btn_Ok.Text = "Ok";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // chk_PronptSair
            // 
            this.chk_PronptSair.AutoSize = true;
            this.chk_PronptSair.Location = new System.Drawing.Point(156, 94);
            this.chk_PronptSair.Name = "chk_PronptSair";
            this.chk_PronptSair.Size = new System.Drawing.Size(199, 20);
            this.chk_PronptSair.TabIndex = 4;
            this.chk_PronptSair.Text = "Prompt Pra Comfirmar Saida";
            this.chk_PronptSair.UseVisualStyleBackColor = true;
            // 
            // frm_opcoes
            // 
            this.AcceptButton = this.btn_Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancelar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chk_PronptSair);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.tb_NomeUsuario);
            this.Controls.Add(this.lbl_NomeUsuario);
            this.Name = "frm_opcoes";
            this.Text = "0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_NomeUsuario;
        private System.Windows.Forms.TextBox tb_NomeUsuario;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.CheckBox chk_PronptSair;
    }
}