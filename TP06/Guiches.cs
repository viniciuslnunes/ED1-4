using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade21_11_03
{
    class Guiches
    {
        private List<Guiche> listaGuiches;
        internal List<Guiche> ListaGuiches { get => listaGuiches; set => listaGuiches = value; }

        public Guiches()
        {
            this.listaGuiches = new List<Guiche>();
        }

        public void adicionar(Guiche guiche)
        {
            listaGuiches.Add(guiche);
        }

    }
}
