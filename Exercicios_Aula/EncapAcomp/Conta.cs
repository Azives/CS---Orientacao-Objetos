using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncapsulamentoExercicios
{
    public class Conta
    {
        private int Numero { get; set; }
        private double saldo;
        private static double limite;

        public double Limite
        {
            get
            {
                return Conta.limite;
            }
            set
            {
                Conta.limite = value;
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
                if (value + this.Limite >= 0)
                {
                    this.saldo = value;
                }
                else
                {
                    MessageBox.Show("Saldo Invalido!!!");
                }
            }
        }


        public Conta(int Numero, double Saldo, double Limite)
        {
            this.Numero = Numero;
            this.Saldo = Saldo;
            Conta.limite = Limite;
        }

        public void GravaConta(int Numero, double Saldo, double Limite)
        {
            this.Numero = Numero;
            this.Saldo = Saldo;
            Conta.limite = Limite;
        }

        public string DadosConta()
        {
            return "Conta: " + this.Numero + "\t Saldo: " + this.saldo;
        }

        public double SaldoDisp()
        {
            return (this.saldo + Conta.limite);
        }

    }
}
