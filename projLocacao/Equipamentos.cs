using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projLocacao
{
    public class Equipamentos
    {
        private string tipo;
        private double valorlocação;
        private Queue<Equipamento> lote;

        public string Tipo { get => tipo; set => tipo = value; }
        public double Valorlocação { get => valorlocação; set => valorlocação = value; }
        public Queue<Equipamento> Lote { get => lote; set => lote = value; }

        public Equipamentos()
        {
            this.tipo = "";
            this.valorlocação = 0;
            this.lote = new Queue<Equipamento>();
        }

        public Equipamentos(string tipo, double valorlocação)
        {
            this.tipo = tipo;
            this.valorlocação = valorlocação;
            this.lote = new Queue<Equipamento>();
        }

        public void InserirEquipamento(Equipamento equipamento)
        {
            lote.Enqueue(equipamento);
        }

        public Equipamento RemoverEquipamento(Equipamento equipamento)
        {
            Equipamento equipamentoremovido = new Equipamento();
            equipamentoremovido = lote.First();
            lote.Dequeue();
            return equipamentoremovido;
        }
    }
}