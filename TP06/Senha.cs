using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade21_11_03
{
    class Senha
    {
        private int id;
        private DateTime dataGerac;
        private DateTime horaGerac;
        private DateTime dataAtend;
        private DateTime horaAtend;

        public int Id { get => id; set => id = value; }
        public DateTime DataGerac { get => dataGerac; set => dataGerac = value; }
        public DateTime HoraGerac { get => horaGerac; set => horaGerac = value; }
        public DateTime DataAtend { get => dataAtend; set => dataAtend = value; }
        public DateTime HoraAtend { get => horaAtend; set => horaAtend = value; }

        public Senha (int id)
        {
            this.id = id;
            this.dataGerac = new DateTime();
            this.dataGerac = DateTime.Now;
            this.HoraGerac = new DateTime();
            this.HoraGerac = DateTime.Now;
            this.dataAtend = new DateTime();
            this.horaAtend = new DateTime();
        }

        public string dadosParciais()
        {
            return id + " - " + dataGerac.ToString("d") + " - " + HoraGerac.ToString("T");
        }

        public string dadosCompletos()
        {
            return id + " - "+ dataGerac.ToString("d") + " - "+ HoraGerac.ToString("T") + " - "+DataAtend.ToString("d") + " - "+ HoraAtend.ToString("T");
        }
    }
}
