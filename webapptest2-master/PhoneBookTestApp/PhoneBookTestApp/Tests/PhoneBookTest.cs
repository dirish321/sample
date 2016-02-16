using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using PhoneBookTestApp;

namespace PhoneBookTestAppTests
{

    [TestFixture]
    public class PhoneBookTest
    {
        [Test]
        public void addPerson()
        {
            //Arrange
            var pBook = new PhoneBook();
            var person = new Person()
            {
                Name = "test person"
            };

            //Act
            pBook.AddPerson(person);

            Assert.Pass();
        }

        [Test]
        public void findPerson()
        {
            //Arrange
            var pBook = new PhoneBook();

            //Act
            var p = pBook.FindPerson("John Smith");

            Assert.IsNull(p);
        }

    }

    // ReSharper restore InconsistentNaming 
}