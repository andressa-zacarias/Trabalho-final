using System;

namespace TrabalhoFinal.User
{
    public class Person
    {
        public Person(int id, string name, Email email, Password password, Cpf cpf)
        {
            if (name == "")
            throw new SystemException("Name cannot be empty");
            Id = id;
            Name = name;
            Email = email;
            Cpf = cpf;
            Password = password;
                   
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public Email Email { get; set; }

        public Password Password { get; set; }

        public Cpf Cpf { get; set; }
    }
}
