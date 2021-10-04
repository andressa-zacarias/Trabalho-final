using System;
using TrabalhoFinal.User;
using TrabalhoFinal.Login;

namespace TrabalhoFinal
{
    class Program
    {
        static void Main(string[] args)
        {
        Run[] run = new Run[]
        {
            new RegisteredEmail(),
            new Register(),
        };
        for (int i= 0; i <run.Length; i++)
        {
            run[i].Run();
            PrintSeparator();
        }
        }

        private static void PrintSeparator()
        {
            System.Console.WriteLine();
            System.Console.WriteLine("===============");
            System.Console.WriteLine();
            
        
            //Console.WriteLine("Digite o valor que você deseja inserir na conta:");
           // string cash = Console.ReadLine();

            //Financial_postings o = //new Financial_postings(new Financial(cash));
        }

        
    }
}