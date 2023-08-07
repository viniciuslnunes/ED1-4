using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade31_07_23
{
    class Vendedores
    {

        private Vendedor[] osVendedores;
        private int max;
        private int qtde;

        public int Qtde
        {
            get { return qtde; }
        }

        public Vendedores()
        {
            this.qtde = 0;
            this.max = 10;
            this.osVendedores = new Vendedor[max];
            for(int i = 0; i < this.max; i++)
            {
                this.osVendedores[i] = new Vendedor();
            }
        }

        public bool AddVendedor(Vendedor v)
        {
            bool podeAdicionar=(this.qtde<this.max);
            if (podeAdicionar)
            {
                this.osVendedores[this.qtde] = v;
                this.qtde++;
            }
            return podeAdicionar;
        }

        public bool DelVendedor(Vendedor v)
        {
            bool temVendedor = false;
            foreach (Vendedor c in this.osVendedores)
            {
                if (c.Equals(v))
                {
                    if (c.valorVendas()!=0)
                    {
                        Console.WriteLine("Vendedor tem vendas registradas, impossível excluir!");                     
                    }
                    
                    else
                    {
                        c.Id = 0;
                        c.Nome = "";
                        c.PercComissao = 0;
                        temVendedor = true;
                        qtde--;
                    }

                }
            }
            return temVendedor;
        }

        public Vendedor SearchVendedor(Vendedor v)
        {
            Vendedor vendedorEncontrado = new Vendedor();
            int i = 0;
            while (i < this.max && !this.osVendedores[i].Equals(v))
            {
                i++;
            }
            if (i < this.max)
            {
                vendedorEncontrado = this.osVendedores[i];
            }
            return vendedorEncontrado;
        }

        public string MostraVendedores()
        {
            string ret = "";
            Console.WriteLine(String.Format("| {0,2} | {1,15} | {2,17} | {3,17} |","ID","Nome","TotalVendas","TotalComissão"));
            foreach(Vendedor v in this.osVendedores)
            {
                if (v.Id > 0)
                { ret += v.Dados(); }
            }
            return ret;
        }

        public double ValorVendas()
        {
            double total = 0;
            foreach(Vendedor v in this.osVendedores)
            {
                total += v.valorVendas() ;
            }
            return total;
        }

        public double ValorComissao()
        {
            double totalcomissao = 0;
            foreach(Vendedor v in this.osVendedores)
            {
                totalcomissao += v.ValorComissao();
            }
            return totalcomissao;
        }

    }
}
