using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace PhoneBookTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var dbConnection = new SQLiteConnection("Data Source= MyDatabase.sqlite;Version=3;");
                dbConnection.Open();
                SQLiteCommand command =
                    new SQLiteCommand(
                        "drop table PHONEBOOK",
                        dbConnection);
                command.ExecuteNonQuery();
                DatabaseUtil.InitializeDatabase();

               //Add phonebooks to In-memory Phonebook Collection
                var phoneBook = new PhoneBook(new PersonRepository());
                phoneBook.AddPerson(new Person()
                {
                    Name = "John Smith",
                    Address = "1234 Sand Hill Dr, Royal Oak, MI",
                    PhoneNumber = "(248) 123-4567"
                });
                phoneBook.AddPerson(new Person()
                {
                    Name = "Cynthia Smith",
                    Address = "875 Main St, Ann Arbor, MI",
                    PhoneNumber = "(824) 128-8758"
                });

                //Print phonebook
                Console.WriteLine("---------PRINT Phonebook");
                Console.WriteLine(phoneBook.ToString());

                //get and print cynthia
                Console.WriteLine("---------PRINT Cynthia");
                var person = phoneBook.FindPerson("Cynthia Smith");
                Console.WriteLine(person.ToString());

                //persist in-memory phonebook collection to DB
                phoneBook.Persist();

                Console.WriteLine("Press Enter to exit");
                Console.ReadLine();
            }
            finally
            {
                DatabaseUtil.CleanUp();
            }
        }

        static void PrintPerson(Person person)
        {
            Console.WriteLine("Name : {0}, Address : {1}, PhoneNumber : {2}",
                                                person.Name, person.Address, person.PhoneNumber); 
        }
    }
}
