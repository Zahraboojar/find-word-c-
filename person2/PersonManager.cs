using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace person2
{
    internal class PersonManager
    {
        private static List<Person> persons;
        public PersonManager()
        {
            if (persons == null)
                persons = new List<Person>();
        }

        public void RemovePerson(Person person)
        {
            persons.Remove(person);
        }
        public void RemovePerson(int id)
        {
            Person person = null;

            foreach (var personsItem in persons)
            {
                if (personsItem.Id == id)
                {
                    person = personsItem;
                    break;
                }
            }
            persons.Remove(person);
        }

        internal IReadOnlyList<Person> GetPersons()
        {
            return persons;
        }

        internal void Add(Person person)
        {
            persons.Add(person);
        }

        internal void Edit(Person person, int index)
        {
            persons[index] = person;
        }
    }
}
