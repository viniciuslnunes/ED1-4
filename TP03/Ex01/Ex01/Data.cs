using System;
using System.Collections.Generic;
using System.Text;

namespace Ex01
{
    class Data
    {
        private int dia, mes, ano;

        #region Getters Setters
        public int Dia { get => dia; set => dia = value; }
        public int Mes { get => mes; set => mes = value; }
        public int Ano { get => ano; set => ano = value; }
        #endregion

        public void setData(int dia, int mes, int ano)
        {
            this.dia = dia;
            this.mes = mes;
            this.ano = ano;
        }

        public override string ToString()
        {
            return ("{0}/{1}/{2}", dia.ToString("d2"), mes.ToString("d2"), ano.ToString("d4")).ToString();
        }
    }
}
