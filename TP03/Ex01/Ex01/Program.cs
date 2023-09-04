using System;

namespace Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = -1, dia, mes, ano;
            string nome, email, telefone;
            Contato contato = new Contato();
            Contatos agenda = new Contatos();
            Data data = new Data();

            do
            {
                Console.WriteLine("0. Sair" +
                                  "\n1.Adicionar contato" +
                                  "\n2.Pesquisar contato" +
                                  "\n3.Alterar contato" +
                                  "\n4.Remover contato" +
                                  "\n5.Listar contatos");
                Console.Write("Opção: ");
                op = int.Parse(Console.ReadLine());

                Console.Clear();

                switch (op)
                {
                    #region Sair

                    case 0:
                        Console.WriteLine("Saindo");

                        break;

                    #endregion

                    #region Adicionar

                    case 1:
                        Console.Write("Informe o nome do Contato: ");
                        nome = Console.ReadLine();

                        Console.Write("Informe o email do Contato: ");
                        email = Console.ReadLine();

                        Console.Write("Informe o telefone do Contato: ");
                        telefone = Console.ReadLine();


                        Console.Write("Informe o dia de nascimento do contato: ");
                        dia = int.Parse(Console.ReadLine());

                        Console.Write("Informe o mês de nascimento do contato: ");
                        mes = int.Parse(Console.ReadLine());

                        Console.Write("Informe o ano de nascimento do contato: ");
                        ano = int.Parse(Console.ReadLine());


                        data.setData(dia, mes, ano);

                        contato = new Contato(email, nome, telefone, data);

                        Console.Clear();

                        if (agenda.adicionar(contato))
                            Console.WriteLine("Contato adicionado!");
                        else
                            Console.WriteLine("Contato não adicionado!");


                        break;

                    #endregion

                    #region Consultar

                    case 2:
                        Console.WriteLine("Informe o nome do contato: ");
                        contato.Nome = Console.ReadLine();

                        contato = agenda.pesquisar(contato);

                        Console.Clear();

                        if (contato != null)
                            Console.WriteLine(contato.ToString());
                        else
                            Console.WriteLine("Contato não localizado!");

                        break;

                    #endregion

                    #region Alterar

                    case 3:
                        Console.WriteLine("Informe o nome do contato: ");
                        contato.Nome = Console.ReadLine();

                        contato = agenda.pesquisar(contato);

                        Console.Clear();

                        if (contato != null)
                        {
                            Console.Write("Informe o novo nome do Contato: ");
                            contato.Nome = Console.ReadLine();

                            Console.Write("Informe o novo email do Contato: ");
                            contato.Email = Console.ReadLine();

                            Console.Write("Informe o novo telefone do Contato: ");
                            contato.Telefone = Console.ReadLine();
                            
                            Console.WriteLine(agenda.alterar(contato) ? "Contato alterado!" : "Contato não alterado!");
                        }
                        else
                            Console.WriteLine("Contato não localizado!");

                        break;

                    #endregion

                    #region Remover

                    case 4:
                        Console.WriteLine("Informe o nome do contato: ");
                        contato.Nome = Console.ReadLine();

                        contato = agenda.pesquisar(contato);

                        Console.Clear();

                        if (contato != null)
                        {
                            agenda.remover(contato);

                            Console.WriteLine("Contato removido!");
                        }
                        else
                            Console.WriteLine("Contato não localizado!");

                        break;

                    #endregion

                    #region Listar

                    case 5:
                        foreach (Contato c in agenda.Agenda)
                        {
                            Console.WriteLine(c.ToString());
                            Console.WriteLine("\n---------------------------------------------\n");
                        }

                        break;
                    #endregion

                    default:
                        Console.WriteLine("Opção Inválida");
                        break;
                }

                Console.ReadKey();
                Console.Clear();


            } while (op != 0);
        }
    }
}
