using System;

namespace TP02
{
    class Program
    {
        static void Main(string[] args)
        {
            bool menuexit = false;
            string choice;
            int num;

            Eventos eventos = new Eventos(6, 10);

            Console.WriteLine("Bem vindo!");
            Console.WriteLine("");
            Console.WriteLine("Criando um ciclo de 6 eventos (1 evento por dia, de segunda a sábado...");
            Console.WriteLine("");

            while (!menuexit)
            {
                Console.WriteLine("");
                Console.WriteLine("-|-|-|-|-|-|-|-|-|-|-");
                Console.WriteLine("Selecione uma opção: ");
                Console.WriteLine("0. Sair");
                Console.WriteLine("1. Adicionar evento");
                Console.WriteLine("2. Pesquisar evento");
                Console.WriteLine("3. Listar eventos");
                Console.WriteLine("4. Adicionar participante");
                Console.WriteLine("5. Pesquisar participante");
                Console.WriteLine("6. Informar quantidade total de participantes nos eventos");
                Console.WriteLine("");

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
                        AdicionarEvento();
                        break;

                    case 2:
                        PesquisarEvento();
                        break;

                    case 3:
                        ListarEventos();
                        break;

                    case 4:
                        AdicionarParticipante();
                        break;

                    case 5:
                        PesquisarParticipante();
                        break;

                    case 6:
                        TotalParticipantes();
                        break;
                }

            }

            Console.WriteLine("Obrigado e volte sempre!");
            Console.WriteLine("");

            Console.ReadKey();

            void AdicionarEvento()
            {
                string descricao, choice;
                int id, qtdemaxparticipantes, dia;

                Console.WriteLine("Adicionando um evento...");
                do
                {
                    Console.WriteLine("Digite o numero de ID do evento: ");
                    choice = Console.ReadLine();
                    Console.WriteLine("");
                } while (!Int32.TryParse(choice, out id) || id < 0);

                Console.WriteLine("Digite a descrição do evento: ");
                descricao = Console.ReadLine();
                Console.WriteLine("");

                do
                {
                    Console.WriteLine("Digite a quantidade máxima de participantes no evento: ");
                    choice = Console.ReadLine();
                    Console.WriteLine("");
                } while (!Int32.TryParse(choice, out qtdemaxparticipantes) || qtdemaxparticipantes < 0);

                Evento evento = new Evento(id, descricao, qtdemaxparticipantes);

                do
                {
                    Console.WriteLine("Digite o dia da semana que acontecerá o evento (1 para segunda, 2 para terça... 6 para sábado): ");
                    choice = Console.ReadLine();
                    Console.WriteLine("");
                } while (!Int32.TryParse(choice, out dia) || dia < 0|| dia>6);

                eventos.adicionarEvento(evento, dia);

                Console.WriteLine("");
                Console.WriteLine("Evento adicionado!");
                Console.WriteLine("");
            }

            void PesquisarEvento()
            {
                string choice;
                int id;

                Evento eventoprocurado = new Evento(1);

                Console.WriteLine("Pesquisando um evento...");
                do
                {
                    Console.WriteLine("Digite o numero de ID do evento a ser procurado: ");
                    choice = Console.ReadLine();
                    Console.WriteLine("");
                } while (!Int32.TryParse(choice, out id) || id < 0);

                eventoprocurado.Id = id;

                foreach(Evento e in eventos.OsEventos)
                {
                    if (e.Id.Equals(eventoprocurado.Id))
                    {
                        Console.WriteLine("Evento encontrado:");
                        Console.WriteLine(e.ToString());
                        Console.WriteLine("Participante(s) do evento "+e.Descricao+": ");

                        foreach(Participante p in e.OsParticipantes)
                        {
                            if (p.Email != "")
                            {
                                Console.WriteLine(p.ToString());
                            }
                        }
                    }
                }

                Console.WriteLine();
            }

            void ListarEventos()
            {
                eventos.listaEventos();
            }

            void AdicionarParticipante()
            {
                string email, nome, choice;
                int id;
                
                Console.WriteLine("Adicionando um participante...");
                Console.WriteLine("Digite o email do participante: ");
                email = Console.ReadLine();
                Console.WriteLine("");

                Console.WriteLine("Digite o nome do participante: ");
                nome = Console.ReadLine();
                Console.WriteLine("");

                Participante participante = new Participante(email, nome);

                Console.WriteLine("Lista dos eventos criados: ");
                eventos.listaEventos();

                Evento eventoprocurado = new Evento(1);

                do
                {
                    Console.WriteLine("Digite o numero de ID do evento a ser adicionado o participante: ");
                    choice = Console.ReadLine();
                    Console.WriteLine("");
                } while (!Int32.TryParse(choice, out id) || id < 0);

                eventoprocurado.Id = id;

                foreach(Evento e in eventos.OsEventos)
                {
                    if (e.Id.Equals(eventoprocurado.Id))
                    {
                        Console.WriteLine("Status da operação: "+e.InscreverParticipante(participante));
                    }

                }

            }

            void PesquisarParticipante()
            {
                string email;

                Console.WriteLine("Pesquisando um participante...");
                Console.WriteLine("Digite o email do participante a ser pesquisado: ");
                email = Console.ReadLine();
                Console.WriteLine("");

                Participante participantepesquisado = new Participante(email, "");

                Console.WriteLine(eventos.pesquisarParticipante(participantepesquisado));

            }

            void TotalParticipantes()
            {
                Console.WriteLine("Quantidade total de participantes inscritos: " + eventos.qtdeParticipantes());
            }

        }
           
    }
}
