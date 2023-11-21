using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projTransporte
{
    class Viagem
    {
        #region Atributos

        private int ID;
        private Garagem origem;
        private Garagem destino;
        private Veiculo veiculo;
        #endregion

        #region Propriedades

        public int ID1 { get => ID; set => ID = value; }
        internal Garagem Origem { get => origem; set => origem = value; }
        internal Garagem Destino { get => destino; set => destino = value; }
        internal Veiculo Veiculo { get => veiculo; set => veiculo = value; }

        #endregion

        #region Contrutores

        public Viagem(int id, Garagem origem, Garagem destino, Veiculo veiculo)
        {
            this.ID1 = id;
            this.Origem = origem;
            this.Destino = destino;
            this.Veiculo = veiculo;
        }
        #endregion

    }
}
