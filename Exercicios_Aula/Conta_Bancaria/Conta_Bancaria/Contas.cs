using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta_Bancaria
{
    class Contas
    {
        public string Nome { get; set; }
        public double Saldo { get; set; }
        public double Limite { get; set; }

        public Contas(string Nome, double Saldo, double Limite)
        {
            this.Nome = Nome;
            this.Saldo = Saldo;
            this.Limite = Limite;
        }

        public void Deposita(double Valor)
        {
            this.Saldo += Valor;
        }

        public bool Saca(double valor)
        {

            if (this.Saldo - valor < -this.Limite)
            {
                return false;
            }
            this.Saldo -= valor;
            return true;
        }



        public double Consulta()
        {
            return this.Saldo;
        }
    }
}
