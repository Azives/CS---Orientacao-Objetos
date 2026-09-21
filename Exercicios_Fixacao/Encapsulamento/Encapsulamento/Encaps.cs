using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    internal class Encaps
    {
        static void Main()
        {
            Modelar c1 = new Modelar();
            c1.Numero = 1;
            c1.Saldo = 1000;
            c1.Limite = 500;

            Modelar c2 = new Modelar();
            c2.Numero = 2;
            c2.Saldo = 250;
            c2.Limite = 100;

            c2.Saldo = 400;

            System.Console.WriteLine(c1.Numero + " | " + c1.Saldo + " | " + c1.Limite);
            System.Console.WriteLine(c2.Numero + " | " + c2.Saldo + " | " + c2.Limite);
        }
    }
}
