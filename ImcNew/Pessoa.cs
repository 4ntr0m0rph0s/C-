using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImcNew
{
    class Pessoa
    {
        private string Nome;
        private string Email;
        private int Idade;
        private long CPF;

        public Pessoa(string Nome, string Email, int Idade, long CPF)
        {
            this.Nome = Nome;
            this.Email = Email;
            this.Idade = Idade;
            this.CPF = CPF;
        }

        public string nome
        {
            get { return Nome; }
            set { nome = Nome; }
        }
        
        public string email
        {
            get { return Email; }
            set { email = Email; }
        }

        public int idade
        {
            get { return Idade; }
            set { idade = Idade; }
        }

        public long Cpf
        {
            get { return CPF; }
            set { Cpf = CPF; }
        }
    }
}
