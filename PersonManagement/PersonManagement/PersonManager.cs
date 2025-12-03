using System.Collections.Generic;

namespace PersonManagement
{
    public class PersonManager
    {
        private static int _lastId = 0;
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
        public OperationResult AddPerson(Person person)
        {
            var validation = person.Validate();
            if (!validation.IsSuccess)
                return validation; 

            _lastId++;
            person.Id = _lastId;
            persons.Add(person);

            return OperationResult.Success("شخص با موفقیت اضافه شد.");
        }
        public void RemovePerson(Person person)
        {
            _lastId--;
            persons.Remove(person);
            RefreshId(person.Id);
        }
        public void RefreshId(int id)
        {
            _lastId = 0;
            foreach (var person in persons)
            {
                _lastId++;
                person.Id = _lastId;
            }
        }
    }
}
