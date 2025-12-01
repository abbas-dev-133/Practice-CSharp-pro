using System.Collections.Generic;

namespace PersonManagement
{
    public class PersonManager
    {
        private static int _lastId=0;
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
            _lastId++;
            person.Id = _lastId;
            persons.Add(person);
        }
        public void RemovePerson(Person person)
        {
            _lastId--;
            persons.Remove(person);
        }
    }
}
