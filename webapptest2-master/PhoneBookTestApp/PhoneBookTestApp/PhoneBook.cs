using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace PhoneBookTestApp
{
    public class PhoneBook : IPhoneBook
    {
        private readonly List<Person> _persons;
        private readonly IPersonRepository _personRepository;

        public PhoneBook()
        {
            _persons = new List<Person>();
        }

        public PhoneBook(IPersonRepository personRepository) : this()
        {
            _personRepository = personRepository;
        }

        public void AddPerson(Person person)
        {
            _persons.Add(person);
        }

        public Person FindPerson(string name)
        {
            return _persons.FirstOrDefault(p => string.Equals(p.Name, name));
        }

        public void Persist()
        {
            foreach (var person in _persons)
            {
                _personRepository.SavePerson(person);
            }
        }

        public override string ToString()
        {
           var sb = new StringBuilder();

           foreach (var person in _persons)
           {
               sb.AppendLine(person.ToString());
           }

           return sb.ToString();
        }

    }
}