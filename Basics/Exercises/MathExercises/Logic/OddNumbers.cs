using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathExercises.Logic
{
    public class OddNumbers
    {
        public int[] GetOddNumber(int minimumNumber, int maxNumber) 
        {
            int[] oddNumbers;

            double elements = (maxNumber - minimumNumber) / 2.00;
            int intElements = Convert.ToInt32(Math.Ceiling(elements));

            oddNumbers = new int[intElements];

            int j = 0;
            for (int i = minimumNumber; i <= maxNumber; i++)
            {
                if (i % 2 != 0)
                {
                    oddNumbers[j] = i;
                    j++;
                }
            }

            return oddNumbers;
        }
    }
}
