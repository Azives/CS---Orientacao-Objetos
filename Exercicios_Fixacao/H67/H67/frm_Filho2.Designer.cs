namespace H67
{
    partial class frm_Filho2
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
            this.btn_MostrarFilho1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_MostrarFilho1
            // 
            this.btn_MostrarFilho1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_MostrarFilho1.Location = new System.Drawing.Point(89, 164);
            this.btn_MostrarFilho1.Name = "btn_MostrarFilho1";
            this.btn_MostrarFilho1.Size = new System.Drawing.Size(78, 44);
            this.btn_MostrarFilho1.TabIndex = 1;
            this.btn_MostrarFilho1.Text = "mostrar filho 1";
            this.btn_MostrarFilho1.UseVisualStyleBackColor = true;
            this.btn_MostrarFilho1.Click += new System.EventHandler(this.btn_MostrarFilho1_Click);
            // 
            // frm_Filho2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 368);
            this.Controls.Add(this.btn_MostrarFilho1);
            this.Name = "frm_Filho2";
            this.Text = "Filho 2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_MostrarFilho1;
    }
}