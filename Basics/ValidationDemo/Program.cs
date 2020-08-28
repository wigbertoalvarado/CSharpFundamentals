using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidationDemo.Models;

namespace ValidationDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Instanciando objeto de la clase Person
            Person persona = new Person() 
            {
                FirstName = "Manuel",
                LastName = "Rodriguez",
                PersonType = TypeOfPerson.Adult,
                Age = 25
            };
            
            //Instanciando y luego asignando objeto de la clase Person
            Person persona2 = new Person();
            persona2.FirstName = "Daniela";
            persona2.LastName = "Gutierrez";
            persona2.PersonType = TypeOfPerson.Elder;
            persona2.Age = 65;

            var comparisonOfPersons = CompareTypeOfPersons(persona.PersonType, persona2.PersonType);
            Console.WriteLine("Son el mismo tipo de persona: " + (comparisonOfPersons ? "Si" : "No"));
        }

        public static bool CompareTypeOfPersons(TypeOfPerson type1, TypeOfPerson type2)
        {
            if (type1 == type2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
