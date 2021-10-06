using System;
using System.Text.RegularExpressions;
using TrabalhoFinal.User;
using TrabalhoFinal.Processing;
using TrabalhoFinal.Database;
using TrabalhoFinal.Financial;
using System.IO;
using System.Text;
//using CsvHelper;

namespace TrabalhoFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            var userDatabase = new UserDatabase();
            var personProcessing = new PersonProcessing(userDatabase);
            var categoryDatabase = new CategoryDatabase();
            var categoryProcessing = new CategoryProcessing(categoryDatabase);
            

            // INTERAÇÃO COM USUÁRIO
            //var login = new Login();
            //login.Run();
            
            
            Console.WriteLine("Type your name: ");
            string name = Console.ReadLine();
            if (name == "")
                throw new System.Exception("Name cannot be empty");



            Console.WriteLine("Type your e-mail: ");
            string email = Console.ReadLine();
            var mail = new Email(email);

            Console.WriteLine("Type your CPF: ");
            string cpf = Console.ReadLine();
            var cpf1 = new Cpf(cpf);

            Console.WriteLine("Create a numeric password composed by 6 numbers (for example 123456) ");
            string password = Console.ReadLine();
            var pwrd = new Password(password);

            Person person = personProcessing.Register(name, mail, cpf1, pwrd);



            var PersonId = userDatabase.Register(person);
            var foundPerson = userDatabase.SearchById(2);

            Console.WriteLine("Id: {0}", PersonId);

            Console.WriteLine("Pessoa: {0}", foundPerson.Name);
            Console.WriteLine("Register Successed");


            Console.WriteLine("\n");
            Console.WriteLine("TELA DE LOGIN");
            Console.WriteLine("====================" + "\n");





            Console.WriteLine("Type your e-mail: ");
            string emailLogin = Console.ReadLine();
            var mailLogin = new Email(emailLogin);

            Console.WriteLine("Type your password: ");
            string passwordLogin = Console.ReadLine();
            var pwrdLogin = new Password(passwordLogin);


            var login1 = personProcessing.Login(mailLogin, pwrdLogin);
            if (login1.Success)
            {
                Console.WriteLine("Login Successed: {0}", login1.PersonSuccessCase.Name);

                // System.Console.WriteLine("\n" + "TELA DA CATEGORIAS" + "\n" + "==========" + "\n" + "Favor Cadastrar um Lançamento: ");

                // Console.WriteLine("Digite o nome do lançamento: ");
                // string postingName = Console.ReadLine();
                // if (postingName == "")
                //     throw new System.Exception("Name cannot be empty");

                // System.Console.WriteLine("o formato da data de lançamento deve ser como neste exemplo: Jan 1, 2009");
                // System.Console.WriteLine("informe a data: ");
                
                // string dateInput = Console.ReadLine();
                // var parsedDate = DateTime.Parse(dateInput);

                // System.Console.WriteLine("informe o tipo de lançamento"+"\n"+"(Crédito ou Débito): ");
                // string tipo = Console.ReadLine();

                


                // Category posting = CategoryProcessing.RegisterCategory(1, postingName, parsedDate, type);

                // var categoryId = categoryDatabase.RegisterCategory(posting);



                // Console.WriteLine("Cadastro Realizado com Sucesso: " + posting.CategoryName + " "+ parsedDate + " "+ type);

                /*
                System.Console.WriteLine("Deseja cadastrar mais um lançamento(1 para sim ou 2 para não): ");
                string escolha = Console.ReadLine();
                var escolhaInt = int.Parse(escolha);
                System.Console.WriteLine(escolhaInt);
                */

                




            }
            else
            {
                Console.WriteLine("Access denied!");

            }

            //    var pessoa =  {
            //         "nome": "Gabriel",
            //         "id": 2,
            //         "email": "gabriel.carecoso@gmail.com",
            //         "senha": 123
            //     }



            // Verificar os inputs
            // Fazer parse
            // Direcionar para as classes de processo necessárias/apropriadas
            // Mostrar o resultado


            //new RepositorioPessoas()

            //criar método para criar arquivo de texto(csv) ler, gravar,excluir
            
        
            //Console.WriteLine("Digite o valor que você deseja inserir na conta:");
           // string cash = Console.ReadLine();

            //Financial_postings o = //new Financial_postings(new Financial(cash));
        }

        
    }
}