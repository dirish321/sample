using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookTestApp
{
    public interface IPersonRepository
    {
        void SavePerson(Person person);
    }
}
