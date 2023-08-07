using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade31_07_23
{
    class Vendedor
    {
        private int id;
        private string nome;
        private double percComissao;
        private Venda[] asVendas;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public double PercComissao { get => percComissao; set => percComissao = value; }

        public Vendedor(int id, string nome, double percComissao)
        {
            this.id = id;
            this.nome = nome;
            this.percComissao = percComissao;
            this.asVendas = new Venda[31];
            for(int i = 0; i < 31; i++)
            {
                this.asVendas[i] = new Venda();
            }
        }

        public Vendedor()
        {
            this.nome = "";
            this.percComissao = 0;
            this.asVendas = new Venda[31];
            for(int i = 0; i < 31; i++)
            {
                this.asVendas[i] = new Venda();
            }
        }

        public string Dados()
        {
            return String.Format("| {0,2} | {1,15} | R${2,15} | R${3,15} |\n",this.id.ToString(),this.nome,this.valorVendas().ToString(),this.ValorComissao().ToString());               
        }

        public void registrarVenda(int dia, Venda venda)
        {
            asVendas[dia] = venda;
        }

        public double valorVendas()
        {
            double total = 0;
            foreach(Venda dia in this.asVendas)
            {
                total += dia.Valor;
            }
            return total;
        }

        public double ValorComissao()
        {
            double totalcomissao = 0;
            foreach(Venda c in this.asVendas)
            {
                totalcomissao+=(c.Valor*(this.PercComissao/100));
            }
            return totalcomissao;
        }

        public override bool Equals(object obj)
        {
            return this.nome.Equals(((Vendedor)obj).nome);
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}
