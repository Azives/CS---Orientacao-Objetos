using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace proj2
{
     class Contato
    {
        public int Idade;
        public string Nome, Estado,Email;

        public Contato()
        {
            this.Estado = "SP";
        }

        public void Set(string Nome, string Email, string Estado, int Idade)
        {
            this.Nome = Nome;
            this.Email = Email;
            this.Estado = Estado;
            this.Idade = Idade;
        }

        public Contato Get()
        {
            return this;
        }
    }
}
