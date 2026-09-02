namespace Consumo_de_um_Veiculo
{
    partial class Consumo
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
            this.btnCriarCarro = new System.Windows.Forms.Button();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtNivelCombustivel = new System.Windows.Forms.TextBox();
            this.txtConsumo = new System.Windows.Forms.TextBox();
            this.txtDistanciaPercorrida = new System.Windows.Forms.TextBox();
            this.txtLitros = new System.Windows.Forms.TextBox();
            this.txtAutonomia = new System.Windows.Forms.TextBox();
            this.txtDistancia = new System.Windows.Forms.TextBox();
            this.lbModelo = new System.Windows.Forms.Label();
            this.lbNivelCombustivel = new System.Windows.Forms.Label();
            this.lbConsumo = new System.Windows.Forms.Label();
            this.lbDistanciaPercorrida = new System.Windows.Forms.Label();
            this.lbLitros = new System.Windows.Forms.Label();
            this.lbDistancia = new System.Windows.Forms.Label();
            this.lbAutonomia = new System.Windows.Forms.Label();
            this.btnAbastecer = new System.Windows.Forms.Button();
            this.btnAndar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCriarCarro
            // 
            this.btnCriarCarro.Location = new System.Drawing.Point(286, 30);
            this.btnCriarCarro.Name = "btnCriarCarro";
            this.btnCriarCarro.Size = new System.Drawing.Size(123, 23);
            this.btnCriarCarro.TabIndex = 0;
            this.btnCriarCarro.Text = "Criar Carro";
            this.btnCriarCarro.UseVisualStyleBackColor = true;
            this.btnCriarCarro.Click += new System.EventHandler(this.btnCriarCarro_Click);
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(154, 30);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(100, 20);
            this.txtModelo.TabIndex = 1;
            // 
            // txtNivelCombustivel
            // 
            this.txtNivelCombustivel.Location = new System.Drawing.Point(154, 82);
            this.txtNivelCombustivel.Name = "txtNivelCombustivel";
            this.txtNivelCombustivel.Size = new System.Drawing.Size(100, 20);
            this.txtNivelCombustivel.TabIndex = 2;
            this.txtNivelCombustivel.Text = "0";
            this.txtNivelCombustivel.TextChanged += new System.EventHandler(this.txtNivelCombustivel_TextChanged);
            // 
            // txtConsumo
            // 
            this.txtConsumo.Location = new System.Drawing.Point(154, 56);
            this.txtConsumo.Name = "txtConsumo";
            this.txtConsumo.Size = new System.Drawing.Size(100, 20);
            this.txtConsumo.TabIndex = 3;
            // 
            // txtDistanciaPercorrida
            // 
            this.txtDistanciaPercorrida.Location = new System.Drawing.Point(154, 108);
            this.txtDistanciaPercorrida.Name = "txtDistanciaPercorrida";
            this.txtDistanciaPercorrida.Size = new System.Drawing.Size(100, 20);
            this.txtDistanciaPercorrida.TabIndex = 4;
            this.txtDistanciaPercorrida.Text = "0";
            this.txtDistanciaPercorrida.TextChanged += new System.EventHandler(this.txtDistanciaPercorrida_TextChanged);
            // 
            // txtLitros
            // 
            this.txtLitros.Location = new System.Drawing.Point(154, 134);
            this.txtLitros.Name = "txtLitros";
            this.txtLitros.Size = new System.Drawing.Size(100, 20);
            this.txtLitros.TabIndex = 5;
            // 
            // txtAutonomia
            // 
            this.txtAutonomia.Location = new System.Drawing.Point(154, 186);
            this.txtAutonomia.Name = "txtAutonomia";
            this.txtAutonomia.Size = new System.Drawing.Size(100, 20);
            this.txtAutonomia.TabIndex = 6;
            // 
            // txtDistancia
            // 
            this.txtDistancia.Location = new System.Drawing.Point(154, 160);
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Size = new System.Drawing.Size(100, 20);
            this.txtDistancia.TabIndex = 7;
            // 
            // lbModelo
            // 
            this.lbModelo.Location = new System.Drawing.Point(12, 33);
            this.lbModelo.Name = "lbModelo";
            this.lbModelo.Size = new System.Drawing.Size(136, 13);
            this.lbModelo.TabIndex = 0;
            this.lbModelo.Text = "Modelo";
            // 
            // lbNivelCombustivel
            // 
            this.lbNivelCombustivel.Location = new System.Drawing.Point(12, 85);
            this.lbNivelCombustivel.Name = "lbNivelCombustivel";
            this.lbNivelCombustivel.Size = new System.Drawing.Size(136, 13);
            this.lbNivelCombustivel.TabIndex = 8;
            this.lbNivelCombustivel.Text = "Nivel Combustivel";
            // 
            // lbConsumo
            // 
            this.lbConsumo.Location = new System.Drawing.Point(12, 59);
            this.lbConsumo.Name = "lbConsumo";
            this.lbConsumo.Size = new System.Drawing.Size(136, 13);
            this.lbConsumo.TabIndex = 9;
            this.lbConsumo.Text = "Consumo KM/L";
            this.lbConsumo.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbDistanciaPercorrida
            // 
            this.lbDistanciaPercorrida.Location = new System.Drawing.Point(12, 111);
            this.lbDistanciaPercorrida.Name = "lbDistanciaPercorrida";
            this.lbDistanciaPercorrida.Size = new System.Drawing.Size(136, 13);
            this.lbDistanciaPercorrida.TabIndex = 10;
            this.lbDistanciaPercorrida.Text = "Distancia Percorrida";
            // 
            // lbLitros
            // 
            this.lbLitros.Location = new System.Drawing.Point(12, 137);
            this.lbLitros.Name = "lbLitros";
            this.lbLitros.Size = new System.Drawing.Size(136, 13);
            this.lbLitros.TabIndex = 11;
            this.lbLitros.Text = "Litros a Abastecer";
            // 
            // lbDistancia
            // 
            this.lbDistancia.Location = new System.Drawing.Point(12, 163);
            this.lbDistancia.Name = "lbDistancia";
            this.lbDistancia.Size = new System.Drawing.Size(136, 13);
            this.lbDistancia.TabIndex = 12;
            this.lbDistancia.Text = "Distancia a Percorrer";
            // 
            // lbAutonomia
            // 
            this.lbAutonomia.Location = new System.Drawing.Point(12, 189);
            this.lbAutonomia.Name = "lbAutonomia";
            this.lbAutonomia.Size = new System.Drawing.Size(136, 13);
            this.lbAutonomia.TabIndex = 13;
            this.lbAutonomia.Text = "Autonomia";
            // 
            // btnAbastecer
            // 
            this.btnAbastecer.Location = new System.Drawing.Point(286, 56);
            this.btnAbastecer.Name = "btnAbastecer";
            this.btnAbastecer.Size = new System.Drawing.Size(123, 23);
            this.btnAbastecer.TabIndex = 14;
            this.btnAbastecer.Text = "Abastecer";
            this.btnAbastecer.UseVisualStyleBackColor = true;
            this.btnAbastecer.Click += new System.EventHandler(this.btnAbastecer_Click);
            // 
            // btnAndar
            // 
            this.btnAndar.Location = new System.Drawing.Point(286, 82);
            this.btnAndar.Name = "btnAndar";
            this.btnAndar.Size = new System.Drawing.Size(123, 23);
            this.btnAndar.TabIndex = 15;
            this.btnAndar.Text = "Andar";
            this.btnAndar.UseVisualStyleBackColor = true;
            this.btnAndar.Click += new System.EventHandler(this.btnAndar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(286, 108);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Calcular Autnomia";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Consumo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAndar);
            this.Controls.Add(this.btnAbastecer);
            this.Controls.Add(this.lbAutonomia);
            this.Controls.Add(this.lbDistancia);
            this.Controls.Add(this.lbLitros);
            this.Controls.Add(this.lbDistanciaPercorrida);
            this.Controls.Add(this.lbConsumo);
            this.Controls.Add(this.lbNivelCombustivel);
            this.Controls.Add(this.lbModelo);
            this.Controls.Add(this.txtDistancia);
            this.Controls.Add(this.txtAutonomia);
            this.Controls.Add(this.txtLitros);
            this.Controls.Add(this.txtDistanciaPercorrida);
            this.Controls.Add(this.txtConsumo);
            this.Controls.Add(this.txtNivelCombustivel);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.btnCriarCarro);
            this.Name = "Consumo";
            this.Text = "Consumo Combustivel";
            this.Load += new System.EventHandler(this.Consumo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCriarCarro;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtNivelCombustivel;
        private System.Windows.Forms.TextBox txtConsumo;
        private System.Windows.Forms.TextBox txtDistanciaPercorrida;
        private System.Windows.Forms.TextBox txtLitros;
        private System.Windows.Forms.TextBox txtAutonomia;
        private System.Windows.Forms.TextBox txtDistancia;
        private System.Windows.Forms.Label lbModelo;
        private System.Windows.Forms.Label lbNivelCombustivel;
        private System.Windows.Forms.Label lbConsumo;
        private System.Windows.Forms.Label lbDistanciaPercorrida;
        private System.Windows.Forms.Label lbLitros;
        private System.Windows.Forms.Label lbDistancia;
        private System.Windows.Forms.Label lbAutonomia;
        private System.Windows.Forms.Button btnAbastecer;
        private System.Windows.Forms.Button btnAndar;
        private System.Windows.Forms.Button button2;
    }
}

