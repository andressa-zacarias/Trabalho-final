using System;
using System.Collections.Generic;
using System.Linq;
using TrabalhoFinal.User;

namespace TrabalhoFinal.Database
{
    public class UserDatabase
    {
        private int lastId = 0;
        private List<Person> dataBase = new List<Person>();
        
        public int Register(Person person)
        {
            var newId = ++lastId;
            person.Id = newId;
            dataBase.Add(person);
            return newId;
        }

        public Person SearchById(int id)
        {
            foreach (var person in dataBase)
            {
                if (person.Id == id)
                    return person;
            }

            return null;
        }

        public Person SearchByEmail(Email email)
        {
            foreach (var person in dataBase)
            {
                if (person.Email.Value == email.Value)
                    return person;
            }

            return null;
        }

        public List<Person> List(/*filtros, se houver*/)
        {
            return dataBase.ToList();
        }

        public bool Update(Person person)
        {
            for (int i = 0; i < dataBase.Count; i++)
            {
                if (dataBase[i].Id == person.Id)
                {
                    dataBase[i] = person;
                    return true;
                }
            }

            return false;
        }

        public bool Delete(Person person)
        {
            for (int i = 0; i < dataBase.Count; i++)
            {
                if (dataBase[i].Id == person.Id)
                {
                    dataBase.RemoveAt(i);
                    return true;
                }
            }

            return false;
        }
    }
}    