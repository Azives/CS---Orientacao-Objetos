using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encapsulamento
{
    public class Livro
    {
        static int id = 0; 
        string titulo="";
        public int codigo { get; private set; }

        private string ano;
        public string Ano 
        {
            get
            {
                return this.ano;
            }
            set
            {
                int resultado;
                if (int.TryParse(value, out resultado) && resultado <= DateTime.Today.Year)
                {
                    this.ano = resultado.ToString();
                }
                else
                {
                    MessageBox.Show("Ano invalido");
                }
            } 
        }

        public string Titulo
        {
            get
            {
                return this.titulo;
            }

            set
            {
                if (value != "")
                {
                    this.titulo = value;
                }
                else
                { 
                    MessageBox.Show("Título não preenchido!!", "AVISO!!!");
                }

            }
        }

        static int geraid()
        {
            return ++Livro.id;
        }
        public Livro()
        {
            this.codigo = Livro.geraid();
        }

        
    }
}
