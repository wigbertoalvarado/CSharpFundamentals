using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Models
{
    public class Persona
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public DateTime Birthday { get; set; }
        public double Height { get; set; } //meters
        public double Weight { get; set; } //Pounds

        public int CalculateFutureAge() 
        {
            int Age = System.DateTime.Now.Year - Birthday.Year;
            return Age;
        }
        
        public string GetFullname()
        {
            return string.Concat(Name, " ", LastName);
        }
    }
}
