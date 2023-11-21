using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projTransporte
{
    class Transporte
    {
        #region Atributos
        private Veiculo veiculo;
        private int qtdTransportada;
        #endregion

        #region Propriedades

        public int QtdTransportada { get => qtdTransportada; set => qtdTransportada = value; }
        public Veiculo Veiculo { get => veiculo; set => veiculo = value; }
        #endregion

        #region Construtor

        public Transporte(Veiculo veiculo)
        {
            this.Veiculo = veiculo;
            this.QtdTransportada = veiculo.Lotacao;
        }
        #endregion

    }
}
