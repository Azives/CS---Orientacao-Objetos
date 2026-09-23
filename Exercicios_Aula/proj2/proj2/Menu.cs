using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj2
{
    class Menu
    {
        public void Cadastrar(List<Contato> Ag)
        {
            Ag.Add(new Contato());
            Console.Write("Nome: ");
            Ag[Ag.Count-1].Nome = Console.ReadLine();
            Console.Write("E-mail: ");
            Ag[Ag.Count-1].Email = Console.ReadLine(); 
            Console.Write("Estado: (2 caracteres, exemplo \"SP\" ");
            Ag[Ag.Count-1].Estado = Console.ReadLine();
            Console.Write("Idade: ");
            Ag[Ag.Count-1].Idade = Int32.Parse(Console.ReadLine());
            
        }

        public void Imprimir(Contato C, bool tudo)
        {


            Console.Write("- Nome: " + C.Nome + " - E-mail: " + C.Email);


            if (tudo == false)
            {
                Console.WriteLine(" -");
            }

            else
            {
                Console.WriteLine(" - Estado: " + C.Estado + " - Idade: " + C.Idade + " -");
            }

        }

        public void Imprimirt(List<Contato> Ag, bool modo)
        {
            
            foreach(Contato C in Ag)
            {
                this.Imprimir(C, true);
            }    

        }

        public void MM(List<Contato> Ag)
        {
            int Op, mode;
            string est;


            do
            {
                Console.Clear()
                Console.WriteLine("****** AGENDA DE CONTATOS ******");
                Console.WriteLine();
                Console.WriteLine("[1] - Cadastrar");
                Console.WriteLine("[2] - Imprimir");
                Console.WriteLine("[3] - Achar Estado");
                Console.WriteLine("[4] - Achar mais velho");
                Console.WriteLine("[5] - Sair");
                Console.Write("Opção: ");
                Op = Int32.Parse(Console.ReadLine());

                switch (Op)
                {
                    case 1:
                        Console.Clear();
                        Cadastrar(Ag);
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("(1 = Todos os dados; 2 = Nome e E-mail)");
                        Console.Write("Opção: ");
                        mode = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        Imprime_Total(Ag, Tam, mode);
                        break;
                    case 3:
                        Console.Clear();
                        Console.Write("digite o estado: ");
                        est = Console.ReadLine();
                        Console.Clear();
                        Acha_IdadeEstado(Ag, Tam, 18, est);
                        break;
                    case 4:
                        Console.Clear();
                        if (Acha_Velha(Ag, Tam) >= 0)
                        {
                            Imprime_Contato(Ag, Acha_Velha(Ag, Tam), true);
                        }
                        else
                        {
                            Console.WriteLine("Lista vazia ");
                        }
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("Opção inválida!!");
                        break;
                }

                Console.ReadKey(); //Espera pra ver o resultado do processamento

            } while (Op != 5);

        }
    }



}
