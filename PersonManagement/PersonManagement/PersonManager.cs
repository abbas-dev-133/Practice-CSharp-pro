using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonManagement
{
    public class PersonManager
    {
        private static List<Person> persons;
        public PersonManager()
        {
            if (persons == null)
                persons = new List<Person>();
        }
        public IReadOnlyList<Person> GetPersons()
        {
            return persons;
        }
        public void AddPerson(Person person)
        {
            persons.Add(person);
        }
        public void RemovePerson(Person person)
        {
            persons.Remove(person);
        }

    }
}
