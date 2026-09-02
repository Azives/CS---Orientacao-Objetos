using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consumo_de_um_Veiculo
{
    public partial class Consumo : Form
    {
        Carro Car;
        
        public Consumo()
        {
            InitializeComponent();
            txtNivelCombustivel.ReadOnly = true;
            txtDistanciaPercorrida.ReadOnly = true;
            txtAutonomia.ReadOnly = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNivelCombustivel_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCriarCarro_Click(object sender, EventArgs e)
        {
            if (txtModelo.Text == "" || txtConsumo.Text == "" || txtNivelCombustivel.Text == ""||txtDistanciaPercorrida.Text =="" || !int.TryParse(txtConsumo.Text, out int resul))
            {
                MessageBox.Show("Porfavor informe os valores");
            }
            else
            {
                Car = new Carro(txtModelo.Text, double.Parse(txtConsumo.Text), double.Parse(txtNivelCombustivel.Text), double.Parse(txtDistanciaPercorrida.Text));
                txtModelo.ReadOnly = true;
                txtConsumo.ReadOnly = true;
                txtNivelCombustivel.ReadOnly = true;
                txtDistanciaPercorrida.ReadOnly = true;

                MessageBox.Show("Carro criado com sucesso");
            }
        }

        private void txtDistanciaPercorrida_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAbastecer_Click(object sender, EventArgs e)
        {
            
            if (txtLitros.Text != "" && int.TryParse(txtLitros.Text,out int resultado))
            {
                Car.Abastecer(double.Parse(txtLitros.Text));
                txtNivelCombustivel.Text = Car.NivelCombustivel.ToString();
            }
            else
            {
                MessageBox.Show("Porfavor insira a quantidade de litros de combustivel a ser abastecido");
            }
        }

        private void btnAndar_Click(object sender, EventArgs e)
        {
            if (txtDistancia.Text != "" && int.TryParse(txtLitros.Text, out int resultado))
            {
                if (Car.Andar(double.Parse(txtDistancia.Text)))
                {
                    txtDistanciaPercorrida.Text = Car.DistanciaPercorrida.ToString();
                    txtNivelCombustivel.Text = Car.NivelCombustivel.ToString();
                }
                else
                {
                    MessageBox.Show("Combustivel insuficiente para a viagem");
                }
            }
            else
            {
                MessageBox.Show("Porfavor insira a distancia a ser percorrida");

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            txtAutonomia.Text = Car.CalcularAutonomia().ToString();
        }

        private void Consumo_Load(object sender, EventArgs e)
        {

        }
    }
}
