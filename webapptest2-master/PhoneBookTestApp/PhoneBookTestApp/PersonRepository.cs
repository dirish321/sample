using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookTestApp
{
    public class PersonRepository : IPersonRepository
    {
        public void SavePerson(Person person)
        {
            var dbConnection = DatabaseUtil.GetConnection();
            var command = new SQLiteCommand(
                        "INSERT INTO PHONEBOOK (NAME, PHONENUMBER, ADDRESS) VALUES(?,?,?)",
                        dbConnection);
            command.Parameters.AddWithValue("Name",person.Name);
            command.Parameters.AddWithValue("PhoneNumber",person.PhoneNumber);
            command.Parameters.AddWithValue("Address",person.Address);
            command.ExecuteNonQuery();
        }
    }
}
