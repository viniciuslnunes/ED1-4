using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade21_11_03
{
    class Guiche
    {
        private int id;
        private Queue<Senha> atendimentos;

        public int Id { get => id; set => id = value; }
        internal Queue<Senha> Atendimentos { get => atendimentos; set => atendimentos = value; }

        public Guiche()
        {
            this.id = 0;
            this.atendimentos = new Queue<Senha>();
        }

        public Guiche(int id)
        {
            this.id = id;
            this.atendimentos = new Queue<Senha>();
        }

        public bool chamar(Queue<Senha> filaSenhas)
        {
            bool chamar=false;
            if (filaSenhas.Count > 0)
            {
                atendimentos.Enqueue(filaSenhas.Peek());
                filaSenhas.Dequeue();
                chamar = true;
            }           
            return chamar;
        }

    }
}
