using System;

namespace TrabalhoFinal.User
{
    public class Person
    {
        public Person(int id, string name, Email email, Password password, Cpf cpf)
        {
            if (name == null)
            throw new SystemException("Name cannot be empty");
            Id = id;
            Name = name;
                   
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Cpf { get; set; }
    }
}
