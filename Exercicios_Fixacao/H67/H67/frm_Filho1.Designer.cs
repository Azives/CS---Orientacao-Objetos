namespace H67
{
    partial class frm_Filho1
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
            this.ltb_lista1 = new System.Windows.Forms.ListBox();
            this.ltb_lista2 = new System.Windows.Forms.ListBox();
            this.btn_PassarLista = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ltb_lista1
            // 
            this.ltb_lista1.FormattingEnabled = true;
            this.ltb_lista1.ItemHeight = 16;
            this.ltb_lista1.Items.AddRange(new object[] {
            "Valtemir 1",
            "Valtemir 2",
            "Valtemir 3"});
            this.ltb_lista1.Location = new System.Drawing.Point(33, 16);
            this.ltb_lista1.Name = "ltb_lista1";
            this.ltb_lista1.Size = new System.Drawing.Size(159, 84);
            this.ltb_lista1.TabIndex = 0;
            // 
            // ltb_lista2
            // 
            this.ltb_lista2.FormattingEnabled = true;
            this.ltb_lista2.ItemHeight = 16;
            this.ltb_lista2.Location = new System.Drawing.Point(33, 106);
            this.ltb_lista2.Name = "ltb_lista2";
            this.ltb_lista2.Size = new System.Drawing.Size(159, 84);
            this.ltb_lista2.TabIndex = 1;
            // 
            // btn_PassarLista
            // 
            this.btn_PassarLista.Location = new System.Drawing.Point(33, 196);
            this.btn_PassarLista.Name = "btn_PassarLista";
            this.btn_PassarLista.Size = new System.Drawing.Size(159, 48);
            this.btn_PassarLista.TabIndex = 2;
            this.btn_PassarLista.Text = "Passar";
            this.btn_PassarLista.UseVisualStyleBackColor = true;
            this.btn_PassarLista.Click += new System.EventHandler(this.btn_PassarLista_Click);
            // 
            // frm_Filho1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 303);
            this.Controls.Add(this.btn_PassarLista);
            this.Controls.Add(this.ltb_lista2);
            this.Controls.Add(this.ltb_lista1);
            this.Name = "frm_Filho1";
            this.Text = "Filho 1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ltb_lista1;
        private System.Windows.Forms.ListBox ltb_lista2;
        private System.Windows.Forms.Button btn_PassarLista;
    }
}