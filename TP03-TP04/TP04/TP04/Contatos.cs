﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP04
{
    class Contatos
    {
        private List<Contato> agenda = new List<Contato>();

        public List<Contato> Agenda { get => agenda; set => agenda = value; }

        public bool adicionar(Contato c)
        {
            agenda.Add(new Contato(c.Email, c.Nome, c.Telefone, c.DtNasc));

            return true;
        }

        public Contato pesquisar(Contato c)
        {
            return agenda.Find(agenda => agenda.Equals(c));
        }

        public bool alterar(Contato c)
        {
            int i;

            i = agenda.FindIndex(agenda => agenda.Equals(c));

            agenda[i].Nome = c.Nome;
            agenda[i].Telefone = c.Telefone;
            agenda[i].Email = c.Email;

            return true;
        }

        public bool remover(Contato c)
        {
            int i;

            i = agenda.FindIndex(agenda => agenda.Equals(c));

            agenda.RemoveAt(i);

            return true;
        }
    }
}
