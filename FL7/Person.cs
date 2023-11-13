using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FL7
{
    class Person
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public Person()
        {
                
        }
        public Person(string firstname, string lastname)
        {
            Firstname = firstname;
            Lastname = lastname;
        }

        public string Greet()
        {
            return $"Hej, jag heter {Firstname} i förnamn";
        }
    }

}
