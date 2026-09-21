using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{

    class Modelar
    {
        private int numero;
        private double saldo;
        private double limite;

        public int Numero
        {
            get
            {
                return this.numero;
            }
            set
            {
                this.numero = value;
            }
        }

        public double Saldo
        {
            get
            {
                return this.saldo;
            }
            set
            {
                this.saldo = value;
            }
        }

        public double Limite
        {
            get
            {
                return this.limite;
            }
            set
            {
                this.limite = value;
            }
        }
    }
}
