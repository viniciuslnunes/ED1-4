using System;

namespace Atividade31_07_23
{
    class Program
    {
        static void Main(string[] args)
        {

            bool menuexit = false;
            string choice;
            int num;

            Vendedores vendedores = new Vendedores();
            
            Console.WriteLine("Bem vindo!");
            Console.WriteLine("");

            while (!menuexit)
            {
                Console.WriteLine("");
                Console.WriteLine("No momento há um total de "+vendedores.Qtde+" vendedor(es) cadastrado(s).");
                Console.WriteLine("");
                Console.WriteLine("Selecione uma opção: ");
                Console.WriteLine("0. Sair");
                Console.WriteLine("1. Cadastrar vendedor");
                Console.WriteLine("2. Consultar vendedor");
                Console.WriteLine("3. Excluir vendedor");
                Console.WriteLine("4. Registar venda");
                Console.WriteLine("5. Listar vendedores");
                Console.WriteLine("");

                do
                {
                    Console.Write("Digite a opção desejada: ");
                    choice = Console.ReadLine();
                                    Console.WriteLine("");
                } while (!Int32.TryParse(choice, out num)||num<0||num>5);

                Console.WriteLine("");

                switch (num)
                {
                    case 0:
                        menuexit = true;
                            break;

                    case 1:
                        if (vendedores.Qtde < 10)
                        {
                            CadastrarVendedor();
                        }
                        else
                        {
                            Console.WriteLine("Não foi possível cadastrar, limite de vendedores atingidos.");
                            Console.WriteLine("");
                        }                       
                            break;

                    case 2:
                        ConsultarVendedor();
                        break;

                    case 3:
                        ExcluirVendedor();
                        break;

                    case 4:
                        RegistrarVenda();
                        break;

                    case 5:
                        ListarVendedores();
                        break;
                }
            }

            Console.WriteLine("Obrigado e volte sempre!");
            Console.WriteLine("");

            void CadastrarVendedor()
            {
                string nome, choice;
                int id;
                double percComissao;
                Console.WriteLine("Cadastrando um vendedor...");
                Console.Write("Digite o nome: ");
                nome = Console.ReadLine();

                do
                {
                    Console.Write("Digite o percentual de comissão das vendas: ");
                    choice = Console.ReadLine();
                } while (!double.TryParse(choice, out percComissao));

                id = vendedores.Qtde+1;

                Vendedor vendedor = new Vendedor(id, nome, percComissao);
                vendedores.AddVendedor(vendedor);
                Console.WriteLine("");
                Console.WriteLine("Vendedor " + nome + " cadastrado!");
                Console.WriteLine("");
            }

            void ConsultarVendedor()
            {
                string choice, nome;
                int id;
                double percComissao;

                Console.WriteLine("Consultando um vendedor...");
                Console.WriteLine("");
                do
                {
                    Console.WriteLine("Digite o ID do vendedor que deseja pesquisar (para maiores informações sobre os vendedores, utilize a opção nº 5): ");
                    choice = Console.ReadLine();
                } while (!Int32.TryParse(choice, out id)&&id<0&&id>10);
                Console.WriteLine("");
                Console.Write("Digite o nome que deseja pesquisar: ");
                nome = Console.ReadLine();
                Console.WriteLine("");
                do
                {
                    Console.Write("Digite o percentual de comissão das vendas que deseja pesquisar: ");
                    choice = Console.ReadLine();
                } while (!double.TryParse(choice, out percComissao));
                Console.WriteLine("");
                Console.WriteLine("Resultado da pesquisa:");
                Console.WriteLine("");
                Vendedor vendedorprocurado = new Vendedor(id, nome, percComissao);
                vendedorprocurado=vendedores.SearchVendedor(vendedorprocurado);

                if (vendedorprocurado.Id == 0)
                    {
                        Console.WriteLine("Vendedor não encontrado!");
                    }

                else
                    {
                    Console.WriteLine("ID do vendedor: " + vendedorprocurado.Id);
                    Console.WriteLine("Nome do vendedor: " + vendedorprocurado.Nome);
                    Console.WriteLine("Valor total das vendas: R$" + vendedorprocurado.valorVendas());
                    Console.WriteLine("Valor total das comissões: R$" + vendedorprocurado.ValorComissao());
                }

            }

            void ExcluirVendedor()
            {
                string nome, choice;
                int id;
                double percComissao;

                do
                {
                    Console.WriteLine("Digite o ID do vendedor que deseja excluir (para maiores informações sobre os vendedores, utilize a opção nº 5): ");
                    choice = Console.ReadLine();
                } while (!Int32.TryParse(choice, out id) && id < 0 && id > 10);

                Console.Write("Digite o nome que deseja excluir: ");
                nome = Console.ReadLine();
                do
                {
                    Console.Write("Digite o percentual de comissão das vendas que deseja excluir: ");
                    choice = Console.ReadLine();
                } while (!double.TryParse(choice, out percComissao));

                Vendedor vendedorexcluido = new Vendedor(id, nome, percComissao);
                vendedores.DelVendedor(vendedorexcluido);
            }

            void RegistrarVenda()
            {
                string choice, nome;
                int id, dia, qtde;
                double percComissao, valor;

                Console.WriteLine("Registrando venda diária...");
                Console.WriteLine("");
                do
                {
                    Console.WriteLine("Digite o ID do vendedor que deseja cadastrar a venda (para maiores informações sobre os vendedores, utilize a opção nº 5): ");
                    choice = Console.ReadLine();
                } while (!Int32.TryParse(choice, out id) && id < 0 && id > 10);
                Console.WriteLine("");
                Console.Write("Digite o nome que deseja cadastrar a venda: ");
                nome = Console.ReadLine();
                Console.WriteLine("");
                do
                {
                    Console.Write("Digite o percentual de comissão das vendas que deseja cadastrar a venda: ");
                    choice = Console.ReadLine();
                } while (!double.TryParse(choice, out percComissao));
                Console.WriteLine("");
                do
                {
                    Console.WriteLine("Digite dia da venda (1 a 31): ");
                    choice = Console.ReadLine();
                } while (!Int32.TryParse(choice, out dia) && dia < 1 && dia > 31);
                Console.WriteLine("");
                do
                {
                    Console.WriteLine("Digite a quantidade de vendas no dia informado: ");
                    choice = Console.ReadLine();
                } while (!Int32.TryParse(choice, out qtde) && qtde < 1);
                Console.WriteLine("");
                do
                {
                    Console.Write("Digite valor da venda no dia informado: R$");
                    choice = Console.ReadLine();
                } while (!double.TryParse(choice, out valor));

                Vendedor vendedorcomvenda = new Vendedor(id, nome, percComissao);
                vendedorcomvenda = vendedores.SearchVendedor(vendedorcomvenda);

                Venda venda = new Venda(qtde, valor);

                if (vendedorcomvenda.Id == 0)
                {
                    Console.WriteLine("Vendedor não encontrado!");
                }

                else
                {
                    vendedorcomvenda.registrarVenda(dia-1, venda);
                    Console.WriteLine("Venda registrada com sucesso!");
                }

                Console.WriteLine("");

            }

            void ListarVendedores()
            {
                Console.WriteLine("Listando todos os vendedores cadastrados...");
                Console.WriteLine("");
                Console.WriteLine(vendedores.MostraVendedores());
                Console.WriteLine("Valor total das vendas: R$" + vendedores.ValorVendas());
                Console.WriteLine("Valor total das comissões: R$" + vendedores.ValorComissao());
                Console.WriteLine("");

            }

            Console.ReadKey();

        }


    }
}
