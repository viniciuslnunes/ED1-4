using System;

namespace TP07
{
    class Program
    {
        static void Main(string[] args)
        {
            bool menuexit = false;
            string choice;
            int num;

            Medicamentos lista = new Medicamentos();

            Console.WriteLine("Bem-vindo!");

            while (!menuexit)
            {
                Console.WriteLine("\n-|-|-|-|-|-|-|-|-|-|-");
                Console.WriteLine("Selecione uma opção: ");
                Console.WriteLine("0. Finalizar processo");
                Console.WriteLine("1. Cadastrar medicamento");
                Console.WriteLine("2. Consultar medicamento (sintetico)");
                Console.WriteLine("3. Consultar medicamento (analitico)");
                Console.WriteLine("4. Comprar medicamento");
                Console.WriteLine("5. Vender medicamento");
                Console.WriteLine("6. Listar medicamentos\n");

                do
                {
                    Console.WriteLine("Digite a opção desejada: ");
                    choice = Console.ReadLine();
                    Console.WriteLine("");
                } while (!Int32.TryParse(choice, out num) || num < 0 || num > 6);
                Console.WriteLine("");

                switch (num)
                {
                    case 0:
                        menuexit = true;
                        break;

                    case 1:
                        CadastrarMedicamento();
                        break;

                    case 2:
                        ConsultaSintetica();
                        break;

                    case 3:
                        ConsultaAnalitica();
                        break;

                    case 4:
                        ComprarMedicamento();
                        break;

                    case 5:
                        VenderMedicamento();
                        break;

                    case 6:
                        ListarMedicamento();
                        break;
                }
            }

            Console.WriteLine("Obrigado e volte sempre!\n");
            Console.ReadKey();

            void CadastrarMedicamento()
            {
                int id;
                string nome, laboratorio, choice;

                Console.WriteLine("Cadastrando um medicamento...");

                do
                {
                    Console.WriteLine("Digite o ID do medicamento: ");
                    choice = Console.ReadLine();
                } while (!Int32.TryParse(choice, out id));
                Console.WriteLine("");

                Console.WriteLine("Digite o nome do medicamento: ");
                nome = Console.ReadLine();
                Console.WriteLine("");

                Console.WriteLine("Digite o nome do laboratório: ");
                laboratorio = Console.ReadLine();
                Console.WriteLine("");

                Medicamento medicamento = new Medicamento(id, nome, laboratorio);
                lista.adicionarMedicamento(medicamento);
                Console.WriteLine("Medicamento cadastrado com sucesso!");
                Console.ReadKey();
            }

            void ConsultaSintetica()
            {
                int id;
                string choice;

                Console.WriteLine("Realizando uma consulta sintética...");
                do
                {
                    Console.WriteLine("Digite o ID do medicamento que deseja consultar: ");
                    choice = Console.ReadLine();
                } while (!Int32.TryParse(choice, out id));
                Console.WriteLine("");

                Medicamento medicamentoprocurado = new Medicamento(id, "", "");
                Medicamento medicamentoencontrado = lista.pesquisar(medicamentoprocurado);

                if (medicamentoencontrado.Id == 0)
                {
                    Console.WriteLine("Medicamento não encontrado!");
                }
                else
                {
                    Console.WriteLine("Medicamento encontrado: " + medicamentoencontrado.ToString());
                }
            }

            void ConsultaAnalitica()
            {
                int id;
                string choice;

                Console.WriteLine("Realizando uma consulta sintética...");
                do
                {
                    Console.WriteLine("Digite o ID do medicamento que deseja consultar: ");
                    choice = Console.ReadLine();
                } while (!Int32.TryParse(choice, out id));
                Console.WriteLine("");

                Medicamento medicamentoprocurado = new Medicamento(id, "", "");
                Medicamento medicamentoencontrado = lista.pesquisar(medicamentoprocurado);

                if (medicamentoencontrado.Id == 0)
                {
                    Console.WriteLine("Medicamento não encontrado!");
                }
                else
                {
                    Console.WriteLine("Medicamento encontrado: " + medicamentoencontrado.ToString());
                    Console.WriteLine("Lote(s) disponível(is):");
                    foreach(Lote l in medicamentoencontrado.Lotes)
                    {
                        Console.WriteLine(l.ToString());
                    }
                }
            }

            void ComprarMedicamento()
            {
                int id, id2, qtde, dia, mes, ano;
                DateTime datavenc;
                Console.WriteLine("Cadastrando um lote de medicamento...");

                do
                {
                    Console.WriteLine("Digite o ID do medicamento que deseja cadastrar um lote: ");
                    choice = Console.ReadLine();
                } while (!Int32.TryParse(choice, out id2));
                Console.WriteLine("");

                Medicamento medicamentoprocurado = new Medicamento(id2, "", "");
                Medicamento medicamentoencontrado=lista.pesquisar(medicamentoprocurado);
                if (medicamentoencontrado.Id == 0)
                {
                    Console.WriteLine("Medicamento não encontrado, cancelando a operação!");
                }

                else
                {
                    Console.WriteLine("Medicamento encontrado: " + medicamentoencontrado.ToString());

                    do
                    {
                        Console.WriteLine("Digite o ID do lote: ");
                        choice = Console.ReadLine();
                    } while (!Int32.TryParse(choice, out id));
                    Console.WriteLine("");

                    do
                    {
                        Console.WriteLine("Digite a quantidade de medicamento no lote: ");
                        choice = Console.ReadLine();
                    } while (!Int32.TryParse(choice, out qtde));
                    Console.WriteLine("");

                    do
                    {
                        Console.WriteLine("Digite o dia de vencimento: ");
                        choice = Console.ReadLine();
                    } while (!Int32.TryParse(choice, out dia) || dia > 31);
                    Console.WriteLine("");

                    do
                    {
                        Console.WriteLine("Digite o mês de vencimento: ");
                        choice = Console.ReadLine();
                    } while (!Int32.TryParse(choice, out mes) || mes > 12);
                    Console.WriteLine("");

                    do
                    {
                        Console.WriteLine("Digite o ano de vencimento: ");
                        choice = Console.ReadLine();
                    } while (!Int32.TryParse(choice, out ano) || ano < 2021);
                    Console.WriteLine("");

                    datavenc = new DateTime(ano, mes, dia);
                    Lote lote = new Lote(id, qtde, datavenc);

                    int achou=lista.ListaMedicamentos.FindIndex(x => x == medicamentoencontrado);
                    lista.ListaMedicamentos[achou].comprar(lote);
                    Console.WriteLine("Lote cadastrado!\n");
                }


            }

            void VenderMedicamento()
            {
                int id, qtde;
                Console.WriteLine("Realizando uma venda...");

                do
                {
                    Console.WriteLine("Digite o ID do medicamento que deseja cadastrar um lote: ");
                    choice = Console.ReadLine();
                } while (!Int32.TryParse(choice, out id));
                Console.WriteLine("");

                Medicamento medicamentoprocurado = new Medicamento(id, "", "");
                Medicamento medicamentoencontrado = lista.pesquisar(medicamentoprocurado);
                if (medicamentoencontrado.Id == 0)
                {
                    Console.WriteLine("Medicamento não encontrado, cancelando a operação!");
                }
                else
                {
                    Console.WriteLine("Medicamento encontrado: " + medicamentoencontrado.ToString());

                    do
                    {
                        Console.WriteLine("Digite a quantidade que deseja vender: ");
                        choice = Console.ReadLine();
                    } while (!Int32.TryParse(choice, out qtde)||id<0);
                    Console.WriteLine("");

                    int achou = lista.ListaMedicamentos.FindIndex(x => x == medicamentoencontrado);
                    Console.WriteLine(lista.ListaMedicamentos[achou].vender(qtde) ? "Venda realizada!" : "Venda não realizada!");

                }
            }

            void ListarMedicamento()
            {
                Console.WriteLine("Listando todos os medicamentos...");
                foreach (Medicamento m in lista.ListaMedicamentos)
                {
                    Console.WriteLine(m.ToString());
                }
            }
        }
    }
}
