using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP07
{
    class Medicamentos
    {
        private List<Medicamento> listaMedicamentos;
        public List<Medicamento> ListaMedicamentos { get => listaMedicamentos; set => listaMedicamentos = value; }

        public Medicamentos()
        {
            listaMedicamentos = new List<Medicamento>();
        }

        public void adicionarMedicamento(Medicamento medicamento)
        {
            listaMedicamentos.Add(medicamento);
        }

        public bool deletar(Medicamento medicamento)
        {
            bool deletar = false;
            foreach(Medicamento m in listaMedicamentos.ToList())
            {
                if (m.Id.Equals(medicamento.Id))
                {
                    if (m.qtdeDisponivel() > 0)
                    {
                        Console.WriteLine("Medicamento encontrado, mas possui " + m.qtdeDisponivel() + " unidade(s) disponível(is). Remoção não realizada! ");
                    }
                    else
                    {
                        listaMedicamentos.Remove(medicamento);
                        Console.WriteLine("Medicamento removido!");
                        deletar = true;
                    }
                }
            }
            return deletar;
        }

        public Medicamento pesquisar(Medicamento medicamento)
        {
            Medicamento medicamentoencontrado = new Medicamento();
            foreach(Medicamento m in listaMedicamentos)
            {
                if (m.Id.Equals(medicamento.Id))
                {
                    medicamentoencontrado = m;
                }
            }
            return medicamentoencontrado;
        }
    }
}
