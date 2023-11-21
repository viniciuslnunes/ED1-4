using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projTransporte
{
    class Garagem
    {
        #region Atributos

        private int id;
        private string local;
        private int count = 0;
        private int countPessoas = 0;
        private Queue<int> pessoas = new Queue<int>();
        private Stack<Veiculo> veiculos = new Stack<Veiculo>();
        #endregion

        #region Propriedades

        public int Id { get => id; set => id = value; }
        public string Local { get => local; set => local = value; }
        public int Count { get => count; set => count = value; }
        public int CountPessoas { get => countPessoas; set => countPessoas = value; }
        public Queue<int> Pessoas { get => pessoas; set => pessoas = value; }
        public Stack<Veiculo> Veiculos { get => veiculos; set => veiculos = value; }
        #endregion

        #region Construtores

        public Garagem(int id, string local)
        {
            this.Id = id;
            this.Local = local;
        }

        public Garagem(int id)
        {
            this.Id = id;
        }

        public Garagem()
        {
        }
        #endregion

        #region Métodos

        public int qtdeDeveiculos()
        {
            return Veiculos.Count;
        }
        public int potencialDeTransporte()
        {
            int count = 0;
            foreach (Veiculo v in Veiculos)
            {
                count += v.Lotacao;
            }
            return count;

        }
        public bool vaiViajar()
        {
            if (Veiculos.Count > 0)
            {
                if (Pessoas.Count >= Veiculos.Peek().Lotacao)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public void addPessoas()
        {
            Pessoas.Enqueue(CountPessoas++);
        }
        public void removePessoas()
        {
            Pessoas.Dequeue();
        }
        public override bool Equals(object obj)
        {
            return this.Id.Equals(((Garagem)obj).Id);
        }
        #endregion
    }

}
