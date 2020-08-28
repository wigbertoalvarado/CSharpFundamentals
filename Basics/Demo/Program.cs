using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Models;

namespace Demo
{
    class Program
    {
        public static void Main(string[] args)
        {
            Persona person = new Persona();

            Console.WriteLine("Please enter your name:");
            person.Name = Console.ReadLine();

            Console.WriteLine("Please enter your lastname");
            person.LastName = Console.ReadLine();

            Console.WriteLine("Enter your Age");
            person.Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your birthday");
            person.Birthday = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Enter your Height");
            person.Height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter your Wight");
            person.Weight = Convert.ToDouble(Console.ReadLine());
                        
            var futureAge = person.CalculateFutureAge();
            Console.WriteLine("This is your future age: " + futureAge.ToString());

            var fullName = person.GetFullname();
            Console.WriteLine("This is your Full Name: " + fullName);
        }
    }
}
