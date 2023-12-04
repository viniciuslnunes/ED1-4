using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projLocacao
{
    public class Contrato
    {
        private int id;
        DateTime datasaida, dataretorno;
        List<Equipamentos> tiponecessario;
        List<int> qtde;

        public int Id { get => id; set => id = value; }
        public DateTime Datasaida { get => datasaida; set => datasaida = value; }
        public DateTime Dataretorno { get => dataretorno; set => dataretorno = value; }
        public List<Equipamentos> Tiponecessario { get => tiponecessario; set => tiponecessario = value; }
        public List<int> Qtde { get => qtde; set => qtde = value; }

        public Contrato()
        {
            this.id = 0;
            this.datasaida = DateTime.Today;
            this.dataretorno = DateTime.MaxValue;
            this.tiponecessario = new List<Equipamentos>();
            this.qtde = new List<int>();
        }
    }
}