using System.Collections.Generic;
using NUnit.Framework;

namespace PhoneBookTestApp
{
    public interface IPhoneBook
    {
        Person FindPerson(string name);
        void AddPerson(Person newPerson);
        void Persist();
    }
}