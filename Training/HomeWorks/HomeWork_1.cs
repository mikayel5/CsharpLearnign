using System;
using System.Collections.Generic;
using System.Text;

namespace Training.HomeWorks
{
    public class HomeWork_1
    {

        public static void Add(ref int numb)
        {
            if (numb < 100)
            {
                numb += 10;
            }
            else
            {

            }
        }

        public static void isEven(ref int numb)
        {
            if (numb % 2 == 0)
            {
                numb++;
            }
            else
            {

            }
        }

        public static void Greater(ref int numb1, ref int numb2)
        {
            int max;
            max = numb1;
            if (numb1 < numb2)
            {
                max = numb2;
                numb2 = 0;
            }
            else
            {
                numb1 = 0;
            }
        }

        public static void MaxLimit(ref int numb1, ref int numb2)
        {
            int maxLimit;
            maxLimit = numb2;
            if (numb1 > maxLimit)
            {
                numb1 = maxLimit;

            }


        }

        public static void AddFive(ref int numb1, ref int numb2)
        {
            int min = numb1;
            if (numb2 < numb1)
            {
                min = numb2;
                numb2 = numb2 + 5;
            }
            else
            {
                numb1 = numb1 + 5;
            }
        }

        public static void isNegative(ref int numb)
        {
            if (numb < 0)
            {
                numb = 0;
            }
        }

        public static void Decrease(ref int numb1, ref int numb2)
        {
            int max = numb1;
            if (numb2 > max)
            {
                numb2 = numb2 - 10;
            }
            else
            {
                numb1 = numb1 - 10;
            }
        }

        
    }
}