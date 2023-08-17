using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP02
{
    class Curso
    {
        private Escola[] osCurso;

        public Escola[] OsCurso { get => osCurso;}

        public Curso(int max, int maxp)
        {
            this.osCurso = new Escola[max];
            for(int i=0; i < max; i++)
            {
                this.osCurso[i] = new Escola(maxp);
            }
        }

        public void adicionarEscola(Escola e, int dia)
        {
            this.osCurso[dia - 1] = e;
        }

        public string pesquisarAluno(Aluno p)
        {
            foreach(Escola e in this.osCurso)
            {
                for(int i = 0; i < e.QtdeMaxAlunos; i++)
                {
                    if (e.OsAlunos[i].Email.Equals(p.Email))
                    {
                        return "Aluno " + e.OsAlunos[i].Nome + " está inscrito(a) no Escola: '"+e.Descricao+"'.\n";
                    }
                }
            }
            return "";
        }

        public int qtdeAlunos()
        {
            int total = 0;
            foreach (Escola e in this.osCurso)
            {
                for (int i = 0; i < e.QtdeMaxAlunos; i++)
                {
                    if (e.OsAlunos[i].Nome != "")
                    {
                        total++;
                    }
                }
            }
            return total;
        }

        public string listaCurso()
        {
            foreach(Escola e in this.osCurso)
            {
                if (e.Id != 0)
                {
                    Console.WriteLine("Escola: " + e.ToString() + "Total de Alunos: " + e.qtdeAlunos() + ".\n\n");
                }
            }
            return "";
        }
    }
}
