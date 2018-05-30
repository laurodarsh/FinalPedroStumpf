using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploEstatico
{
    public class Pessoa
    {
        public static int nFumantes = 0;

        private string nome;
        private string email;
        private bool fumante;

        public Pessoa(string nome, string email, bool fumante)
        {
            this.Nome = nome;
            this.Email = email;
            this.Fumante = fumante;

            if(this.Fumante)
            {
                nFumantes++;
            }
        }

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public bool Fumante
        {
            get
            {
                return fumante;
            }

            set
            {
                fumante = value;
            }
        }
    }
}
