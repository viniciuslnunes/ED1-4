using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projTransporte
{
    class Viagens
    {
        #region Atributos

        public Queue<Viagem> viagens = new Queue<Viagem>();
        #endregion

        #region Propriedades

        public Queue<Viagem> _Viagens { get{ return viagens; } set{ viagens = value; } }

        #endregion

        #region Métodos

        public void incluir(Viagem viagem)
        {
            _Viagens.Enqueue(viagem);
        }

        #endregion
    }
}
