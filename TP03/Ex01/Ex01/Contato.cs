using System;
using System.Collections.Generic;
using System.Text;

namespace Ex01
{
    class Contato
    {
        private string email, nome, telefone;
        private Data dtNasc;

        public Contato(string email, string nome, string telefone, Data dtNasc)
        {
            this.email = email;
            this.nome = nome;
            this.telefone = telefone;
            this.dtNasc = dtNasc;
        }

        public Contato() : this("", "", "", null) { }

        #region Getters Setters
        public string Email { get => email; set => email = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public Data DtNasc { get => dtNasc; set => dtNasc = value; } 
        #endregion



        public int getIdade()
        {
            int idade;

            idade = DateTime.Now.Year - dtNasc.Ano;

            if (dtNasc.Mes > DateTime.Now.Month || (dtNasc.Mes == DateTime.Now.Month && dtNasc.Dia < DateTime.Now.Day))
                idade--;

            return idade;
        }

        public override string ToString()
        {
            string ret;

            ret = "Nome    : " + nome +
                  "\nEmail   : " + email +
                  "\nTelefone: " + telefone +
                  "\nIdade   : " + getIdade();

            return ret;
        }

        public override bool Equals(object obj)
        {
            return this.nome.Equals(((Contato)obj).nome);
        }
    }
}