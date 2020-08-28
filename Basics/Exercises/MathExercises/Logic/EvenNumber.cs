using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathExercises.Logic
{
    public class EvenNumber
    {
        public int[] GetEvenNumber(int minimNumber, int maxNumber)
        {
            int[] evenNumber;
            double elements = (maxNumber - minimNumber) / 2.00;
            int intElements = Convert.ToInt32(Math.Ceiling(elements));

            evenNumber = new int[intElements];

            int i = minimNumber;
            int j = 0;
            while (i <= maxNumber)
            {
                if (i % 2 == 0)
                {
                    evenNumber[j] = i;
                    j++;
                }
                i++;
            }

            return evenNumber;
        }

    }
}
