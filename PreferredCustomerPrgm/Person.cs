using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreferredCustomerPrgm
{
    abstract class Person
    {
        public Person(string name, string address, string phoneNumb)
        {
            Name = name;
            Address = address;
            PhoneNumber = phoneNumb;
        }
        public Person()
        {
            Name = "";
            Address = "";
            PhoneNumber = "";
        }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
    }
}
