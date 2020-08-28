using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathExercises.Logic;

namespace MathExercises
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Ejecuta obtener Numeros Impares
            //OddNumbers od = new OddNumbers();
            //int[] oddNumbers = od.GetOddNumber(1, 100);

            //for (int i = 0; i < oddNumbers.Length; i++)
            //{
            //    Console.WriteLine("Los numero impares " + oddNumbers[i].ToString());
            //}

            //Console.ReadKey();


            //Ejecuta obtener Numeros Pares
            //EvenNumber even = new EvenNumber();
            //int[] evenNumber = even.GetEvenNumber(1, 100);

            //int i = 0;
            //while (i < evenNumber.Length)
            //{
            //    Console.WriteLine("Los números pares" + evenNumber[i].ToString());
            //    i++;
            //}

            //Console.ReadKey();

            //Refactorizacion para Numeros Pares e Impares
            //Number number = new Number();
            //int[] numbers = number.GetNumber(1, 100, false);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine("Los numero son: " + numbers[i].ToString());
            //}

            //Console.ReadKey();

            //Codigo para imprimir numeros primos
            //PrimeNumbers prime = new PrimeNumbers();
            //List<int> numbers = prime.GetPrimeNumbers(1, 100);

            //foreach(int number in numbers)
            //{
            //    Console.WriteLine("Los números primos son: " + number.ToString());
            //}

            //Console.ReadKey();

            //Matriz de Informacion de Cliente
            //List<ClientInfoMatrix> cif = new List<ClientInfoMatrix>();
            //Console.WriteLine("¿Cuántos clientes deseas consultar?");
            //string noClients = Console.ReadLine();

            //int clients;
            //Int32.TryParse(noClients, out clients);

            //for (int i = 0; i < clients; i++) 
            //{
            //    //Esto instancia un nuevo objeto de la clase
            //    ClientInfoMatrix newClient = new ClientInfoMatrix();

            //    Console.WriteLine("Cual es su primer nombre?");
            //    newClient.FirstName = Console.ReadLine();

            //    Console.WriteLine("Cual es su primer apellido?");
            //    newClient.LastName = Console.ReadLine();

            //    Console.WriteLine("Cual es su edad?");
            //    newClient.Age = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("Cual es su fecha de nacimiento?");
            //    newClient.Birthday = Convert.ToDateTime(Console.ReadLine());

            //    //Agregar clientes
            //    cif.Add(newClient);
            //}

            //Console.ReadKey();

            //Ejecutar suma de Matrices
            Console.WriteLine("Cuantas filas tiene la matriz A ?");
            int rowNumbersA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Cuantas columnas tiene la matriz A ?");
            int columnNumbersA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Cuantas filas tiene la matriz B ?");
            int rowNumbersB = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Cuantas columnas tiene la matriz B ?");
            int columnNumbersB = Convert.ToInt32(Console.ReadLine());
            
            if (rowNumbersA == rowNumbersB && columnNumbersA == columnNumbersB)
            {
                int[,] matrixA = AsignData(rowNumbersA, columnNumbersA);
                int[,] matrixB = AsignData(rowNumbersB, columnNumbersB);

                int[,] matrixC = Sum(matrixA, matrixB); 
            }
            else
            {
                Console.WriteLine("Lo sentimos la matriz que esta intentando sumar no tienen la mismas dimensiones");
            }

            Console.ReadKey();

            #region Local_Methods
            int[,] AsignData(int rows, int columns)
            {
                int[,] matrix = new int[rows, columns];

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        Console.WriteLine("Cual es el valor para el elemento " + (i + 1).ToString() + (j + 1).ToString());
                        matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                return matrix;
            }

            int[,] Sum(int[,] matrixOne, int[,] matrixTwo)
            {
                int[,] matrix = new int[rowNumbersA, columnNumbersA];

                for (int i = 0; i < rowNumbersA; i++) 
                {
                    for (int j = 0; j < columnNumbersA; j++)
                    {
                        matrix[i,j] = matrixOne[i,j] + matrixTwo[i,j];
                    }
                }

                return matrix;
            }
            #endregion
        }
    }
}
