using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projTransporte
{
    class Veiculo
    {
        #region Atributos

        private int id;
        private string placa;
        private int lotacao;

        #endregion

        #region Propriedades

        public int Id { get => id; set => id = value; }
        public string Placa { get => placa; set => placa = value; }
        public int Lotacao { get => lotacao; set => lotacao = value; }

        #endregion

        #region Construtores

        public Veiculo() { }
        public Veiculo(int id)
        {
            this.Id = id;
        }
        public Veiculo(int _id, string _placa, int _lotacao)
        {
            this.Id = _id;
            this.Placa = _placa;
            this.Lotacao = _lotacao;
        }
        #endregion

        #region Métodos
        public override bool Equals(object obj)
        {

            return this.Id.Equals(((Veiculo)obj).Id);
        }
        #endregion
    }
}
