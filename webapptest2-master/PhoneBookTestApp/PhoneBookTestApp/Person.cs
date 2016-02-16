using System;

namespace PhoneBookTestApp
{
    public class Person
    {
        public string Name;
        public string PhoneNumber;
        public string Address;

        public override string ToString()
        {
            return String.Format("Name : {0}, Address : {1}, PhoneNumber : {2}",
                                                Name, Address, PhoneNumber); 
        }
    }
}