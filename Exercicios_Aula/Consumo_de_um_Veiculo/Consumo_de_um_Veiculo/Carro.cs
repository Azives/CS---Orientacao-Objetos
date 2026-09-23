using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consumo_de_um_Veiculo
{
    class Carro
    {
        public string Modelo { get; set; }
        public double ConsumoPorKm { get; set; }
        public double NivelCombustivel { get; set; }
        public double DistanciaPercorrida { get; set; }


        public Carro(string Modelo, double ConsumoPorKm,double NivelCombustivel, double DistanciaPercorrida)
        {
            this.Modelo = Modelo;
            this.ConsumoPorKm = ConsumoPorKm;
            this.NivelCombustivel = NivelCombustivel;
            this.DistanciaPercorrida = DistanciaPercorrida;
        }

        public void Abastecer(double Litros)
        {
            this.NivelCombustivel += Litros;
        }
        public bool Andar(double Distancia)
        {
            if(Distancia <= CalcularAutonomia())
            {
                this.DistanciaPercorrida += Distancia;
                this.NivelCombustivel -= Distancia/ this.ConsumoPorKm;
                return true;
            }
            else
            {
                return false;
            }
            
        }
        public double CalcularAutonomia()
        {    
            return this.ConsumoPorKm * this.NivelCombustivel;
        }
    }
}
