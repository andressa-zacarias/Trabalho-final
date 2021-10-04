using System;
using TrabalhoFinal.User;

namespace TrabalhoFinal
{
    public class Register : Run
    {
        public void Run ()
        {
        
            //User_data p = new User_data("Andressa", new Email("teste@teste.com"), new Password("123456") , new Cpf("001.002.003-04"));

            Console.WriteLine("Para realizar o cadastro, digite o seu nome:");
            string name = Console.ReadLine();

            Console.WriteLine("Agora, digite o seu e-mail:");            
            string email = (Console.ReadLine());
            var mail = new Email(email);
            
            Console.WriteLine("Agora, digite uma senha numérica de até 6 números (por exempo 123456):");   
            string password = (Console.ReadLine());
            var pwrd = new Password(password);

            Console.WriteLine("Para protegermos sua conta, digite o seu CPF:");   
            string cpf = (Console.ReadLine());
            var CPF = new Cpf(cpf);

            //string id = (Console.ReadLine());

            Person p = new Person(1, name, new Email(email), new Password(password) , new Cpf(cpf));
        }
    }
}