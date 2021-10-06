using System.Collections.Generic;
using TrabalhoFinal.User;
using TrabalhoFinal.Database;

namespace TrabalhoFinal.Processing
{
    public class PersonProcessing
    {
        private readonly UserDatabase userDatabase;

        public PersonProcessing(UserDatabase userDatabase)
        {
            this.userDatabase = userDatabase;
        }

        public LoginResult Login(Email email, Password password)
        {
            // Consultar o banco de dados
            // Ver se encontra uma pessoa com o email e senha indicados
            // Retorna um resultado login

            var personwithemail = userDatabase.SearchByEmail(email);
            if(personwithemail == null)
            {
                return new LoginResult(false, null);
            }
            if (personwithemail.Password.Value == password.Value)
            {
                return new LoginResult(true, personwithemail);
            }
            return new LoginResult(false, null);


            // SOLID
            // Single Responsibility - fazer uma coisa bem feita, limitar o impacto das mudanças
            // Open Closed
            // Liskov Substitution Principle
            // Interface Segregation
            // Dependency Inversion

            
        }

        public Person Register(string name, Email email, Cpf cpf, Password password)
        {
            var person = new Person(0, name, email, password, cpf);

            int id = userDatabase.Register(person);
            person.Id = id;

            return person;
        }

        public List<Person> List(Email emailFilter = null, string nameFilter = null)
        {
            // Recuperar o id ao cadastro no banco de dados
            // Setar o id na classe
            // pessoa.id = resultadoDoBancoDeDados;

            return new List<Person>();
        }
    }

    public class LoginResult
    {
        public LoginResult(bool success, Person personSuccessCase)
        {
            Success = success;
            PersonSuccessCase = personSuccessCase;
        }

        public bool Success { get; }
        public Person PersonSuccessCase { get; }
    }
}