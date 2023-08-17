using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade21_09_17
{
    class Aluno
    {
        private string email;
        private string nome;

        public string Email { get => email; set => email = value; }
        public string Nome { get => nome; set => nome = value; }

        public Aluno(string email, string nome)
        {
            this.email = email;
            this.nome = nome;
        }

        public Aluno() : this("", "") { }

        public bool PodeMatricular(Eventos e)
        {
            bool PodeMatricular = true;
            int xpart = 0;
            foreach(Evento i in e.OsEventos)
            {
                foreach(Aluno p in i.OsAlunos)
                {
                    if(this.email == p.email)
                    {
                        xpart++;
                    }
                }
            }
            if (xpart>1)
            {
                PodeMatricular = false;
            }

            return PodeMatricular;
        }

        public override bool Equals(object obj)
        {
            return this.email.Equals(((Aluno)obj).email);
        }

        public override string ToString()
        {
            return this.email + " - " + this.nome + "\n";
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}
