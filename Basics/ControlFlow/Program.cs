using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlFlow.Models;

namespace ControlFlow
{
    class Program
    {
       public static void Main(string[] args)
        {
           Console.WriteLine("Que categría es su hotel?");
           int category = Int32.Parse(Console.ReadLine());
            Categories userInput = (Categories)category;

            switch (userInput) 
            {
                case Categories.OneStar:
                    Console.WriteLine("Su hotel es de una estrella");
                    break;
                case Categories.TwoStar:
                    Console.WriteLine("Su hotel es de dos estrellas");
                    break;
                case Categories.ThreeStar:
                    Console.WriteLine("Su hotel es de tres estrellas");
                    break;
                case Categories.FourStar:
                    Console.WriteLine("Su hotel es de cuatro estrellas");
                    break;
                case Categories.FiveStar:
                    Console.WriteLine("Su hotel es de cinco estrellas");
                    break;
            }
            Console.WriteLine("Digite una tecla para finalizar");
            Console.ReadKey();
        }
    }
}
