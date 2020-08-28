    using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathExercises.Logic
{
    public class PrimeNumbers
    {
        public List<int> GetPrimeNumbers(int minNumber, int maxNumber)
        {
            List<int> primeNumbers = new List<int>();
            
            for (int i = minNumber; i <= maxNumber; i++)
            {
                int validator = 0;

                if (i >= 2)
                {
                    for (int k = 2; k <= i/2; k++)
                    {
                        if (i % k == 0)
                        {
                            validator++;
                            break;
                        }
                    }

                    if(validator == 0)
                        primeNumbers.Add(i);
                }
            }

            return primeNumbers;
        } 
    }
}
