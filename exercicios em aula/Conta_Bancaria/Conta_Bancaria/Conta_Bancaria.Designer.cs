namespace Conta_Bancaria
{
    partial class Conta_Bancaria
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtnome = new TextBox();
            txtsaldo = new TextBox();
            txtvalor = new TextBox();
            txtlimite = new TextBox();
            btncriarconta = new Button();
            btnconsultar = new Button();
            btnsacar = new Button();
            btndepositar = new Button();
            nome = new Label();
            saldo = new Label();
            limite = new Label();
            valor = new Label();
            SuspendLayout();
            // 
            // txtnome
            // 
            txtnome.Location = new Point(160, 38);
            txtnome.Name = "txtnome";
            txtnome.Size = new Size(424, 23);
            txtnome.TabIndex = 0;
            // 
            // txtsaldo
            // 
            txtsaldo.Location = new Point(160, 67);
            txtsaldo.Name = "txtsaldo";
            txtsaldo.Size = new Size(233, 23);
            txtsaldo.TabIndex = 1;
            // 
            // txtvalor
            // 
            txtvalor.Location = new Point(213, 209);
            txtvalor.Name = "txtvalor";
            txtvalor.Size = new Size(198, 23);
            txtvalor.TabIndex = 2;
            // 
            // txtlimite
            // 
            txtlimite.Location = new Point(160, 96);
            txtlimite.Name = "txtlimite";
            txtlimite.Size = new Size(233, 23);
            txtlimite.TabIndex = 3;
            // 
            // btncriarconta
            // 
            btncriarconta.Location = new Point(45, 156);
            btncriarconta.Name = "btncriarconta";
            btncriarconta.Size = new Size(539, 39);
            btncriarconta.TabIndex = 4;
            btncriarconta.Text = "criar conta";
            btncriarconta.UseVisualStyleBackColor = true;
            btncriarconta.Click += btncriarconta_Click;
            // 
            // btnconsultar
            // 
            btnconsultar.Location = new Point(440, 259);
            btnconsultar.Name = "btnconsultar";
            btnconsultar.Size = new Size(120, 59);
            btnconsultar.TabIndex = 5;
            btnconsultar.Text = "consultar";
            btnconsultar.UseVisualStyleBackColor = true;
            btnconsultar.Click += btnconsultar_Click;
            // 
            // btnsacar
            // 
            btnsacar.Location = new Point(45, 259);
            btnsacar.Name = "btnsacar";
            btnsacar.Size = new Size(120, 59);
            btnsacar.TabIndex = 6;
            btnsacar.Text = "sacar";
            btnsacar.UseVisualStyleBackColor = true;
            btnsacar.Click += btnsacar_Click;
            // 
            // btndepositar
            // 
            btndepositar.Location = new Point(244, 259);
            btndepositar.Name = "btndepositar";
            btndepositar.Size = new Size(120, 59);
            btndepositar.TabIndex = 7;
            btndepositar.Text = "depositar";
            btndepositar.UseVisualStyleBackColor = true;
            btndepositar.Click += btndepositar_Click;
            // 
            // nome
            // 
            nome.AutoSize = true;
            nome.Location = new Point(45, 38);
            nome.Name = "nome";
            nome.Size = new Size(43, 15);
            nome.TabIndex = 8;
            nome.Text = "Nome:";
            // 
            // saldo
            // 
            saldo.AutoSize = true;
            saldo.Location = new Point(45, 67);
            saldo.Name = "saldo";
            saldo.Size = new Size(39, 15);
            saldo.TabIndex = 9;
            saldo.Text = "Saldo:";
            // 
            // limite
            // 
            limite.AutoSize = true;
            limite.Location = new Point(45, 96);
            limite.Name = "limite";
            limite.Size = new Size(43, 15);
            limite.TabIndex = 10;
            limite.Text = "Limite:";
            // 
            // valor
            // 
            valor.AutoSize = true;
            valor.Location = new Point(45, 209);
            valor.Name = "valor";
            valor.Size = new Size(36, 15);
            valor.TabIndex = 11;
            valor.Text = "Valor:";
            valor.Click += label1_Click;
            // 
            // Conta_Bancaria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 338);
            Controls.Add(valor);
            Controls.Add(limite);
            Controls.Add(saldo);
            Controls.Add(nome);
            Controls.Add(btndepositar);
            Controls.Add(btnsacar);
            Controls.Add(btnconsultar);
            Controls.Add(btncriarconta);
            Controls.Add(txtlimite);
            Controls.Add(txtvalor);
            Controls.Add(txtsaldo);
            Controls.Add(txtnome);
            Name = "Conta_Bancaria";
            Text = "Conta Bancaria";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtnome;
        private TextBox txtsaldo;
        private TextBox txtvalor;
        private TextBox txtlimite;
        private Button btncriarconta;
        private Button btnconsultar;
        private Button btnsacar;
        private Button btndepositar;
        private Label nome;
        private Label saldo;
        private Label limite;
        private Label valor;
    }
}
