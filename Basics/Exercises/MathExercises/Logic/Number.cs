using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathExercises.Logic
{
    public class Number
    {
        public int[] GetNumber(int minNumber, int maxNumber, bool isEvenRequest)
        {
            int[] numbers;
            double elements = (maxNumber - minNumber) / 2.00;
            int intElements = (int)Math.Ceiling(elements);

            numbers = new int[intElements];
            int k = 0;

            for (int i = minNumber; i < maxNumber; i++)
            {
                //Nested ifs
                if (isEvenRequest == true)
                {
                    if (i % 2 == 0)
                        AppendElement(i);
                }
                else if (i % 2 != 0)
                    AppendElement(i);
            }

            return numbers;

            void AppendElement(int i)
            {
                numbers[k] = i;
                k++;
            }
        }
    }
}