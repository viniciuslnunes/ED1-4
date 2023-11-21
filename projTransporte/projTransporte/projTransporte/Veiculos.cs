using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projTransporte
{
    class Veiculos
    {
        #region Atributos

        private List<Veiculo> veic;
        #endregion

        #region Propriedades

        public List<Veiculo> Veic { get => veic; set => veic = value; }

        #endregion

        #region Construtores

        public Veiculos(List<Veiculo> _veic)
        {
            Veic = _veic;
        }

        #endregion

        #region Métodos

        public void incluir(Veiculo veiculo)
        {
            Veiculo v = new Veiculo();
            foreach (Veiculo lveiculo in Veic)
            {
                Veic.Add(veiculo);

            }
        }
        #endregion
    }
}
