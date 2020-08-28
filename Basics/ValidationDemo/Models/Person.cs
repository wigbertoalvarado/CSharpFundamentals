using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationDemo.Models
{
    public enum TypeOfPerson 
    {
        Underage = 1,
        Adult = 2,
        Elder = 3
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public TypeOfPerson PersonType { get; set; }
        public int Age { get; set; }
    }
}
