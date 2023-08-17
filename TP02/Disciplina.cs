using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP02
{
    class Disciplina
    {
        private int id;
        private string descricao;
        private int qtde;
        private int qtdeMaxAlunos;
        private Aluno[] osAlunos;

        public int Id { get => id; set => id = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public int qtdeMaxAlunos { get => qtdeMaxAlunos; set => qtdeMaxAlunos = value; }
        public Aluno[] OsAlunos { get => osAlunos; }
        public int Qtde { get => qtde;}

        public Disciplina(int id, string descricao, int qtdeMaxAlunos)
        {
            this.id = id;
            this.descricao = descricao;
            this.qtdeMaxAlunos = qtdeMaxAlunos;
            this.osAlunos = new Aluno[qtdeMaxAlunos];
            for(int i = 0; i < qtdeMaxAlunos; ++i)
            {
                this.osAlunos[i] = new Aluno();
            }
        }

        public Disciplina(int qtdeMaxAlunos)
            :this(0,"",qtdeMaxAlunos)
        {
            for (int i = 0; i < qtdeMaxAlunos; i++)
            {
                this.osAlunos[i] = new Aluno();
            }
        }

        public int MatricularAluno(Aluno p)
        {
            int op=0;

            if (qtde < qtdeMaxAlunos)
            {
                this.OsAlunos[qtde].Email = p.Email;
                this.OsAlunos[qtde].Nome = p.Nome;
                qtde++;
            }
            else
            {
                op = 1;
            }

            return op;
        }

        public int qtdeAlunos()
        {
            int total = 0;
            foreach(Aluno p in this.OsAlunos)
            {
                if (p.Email != "")
                {
                    total++;
                }
            }
            return total;
        }

        public string listaAlunos()
        {
            Console.WriteLine("Nome do(s) Aluno(s) no Disciplina " + this.Descricao + ":");
            foreach(Aluno p in this.osAlunos)
            {
                if (p.Nome != "")
                {
                    Console.WriteLine(p.ToString());
                }
            }
            return "";
        }

        public override bool Equals(object obj)
        {
            return this.id.Equals(((Disciplina)obj).id);
        }

        public override string ToString()
        {
            return this.id + " - " + this.descricao + " - " + this.qtdeMaxAlunos + "\n";
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}
