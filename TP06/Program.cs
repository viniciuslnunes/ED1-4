using System;

namespace Atividade21_11_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Guiches guiches=new Guiches();
            Guiche guiche1 = new Guiche(1);
            guiches.adicionar(guiche1);
            Senhas senhas = new Senhas();
            guiche1.chamar(senhas.FilaSenhas);
            senhas.gerar();
            Console.WriteLine(senhas.FilaSenhas.Count);
            senhas.gerar();
            Console.WriteLine(senhas.FilaSenhas.Count);
            foreach(Senha s in senhas.FilaSenhas)
            {
                Console.WriteLine(s.dadosParciais());
            }
        }
    }
}
