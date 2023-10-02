using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade21_11_03
{
    class Senhas
    {
        private int proximoAtendimento;
        private Queue<Senha> filaSenhas;

        public int ProximoAtendimento { get => proximoAtendimento; set => proximoAtendimento = value; }
        internal Queue<Senha> FilaSenhas { get => filaSenhas; set => filaSenhas = value; }

        public Senhas()
        {
            this.proximoAtendimento = 1;
            this.filaSenhas = new Queue<Senha>();
        }

        public void gerar()
        {
            filaSenhas.Enqueue(new Senha(proximoAtendimento));
            proximoAtendimento++;
        }

    }
}
