using System;
using System.Collections.Generic;
using System.Text;

namespace Training
{
    public class NumberUtils
    {


        public static int Add(int x, int y)
        {
            int ans = x + y;

            x = 1000;
            y = 8888;

            return ans;
        }


        public static void AddUsingOutParams(int x , int y, out int ans)
        {
            ans = x + y;
        }

        public static void inputNumbers(int number, out bool isEven)
        {
            if (number % 2 == 0)
            {
                isEven = true;
            }
            else
            {
                isEven = false;

            }
        }


       public static void CountDigits(int number, out int count)
        {
            count = 0; if (number == 0) { count = 1; return; }
            if (number < 0)
            {
                number = -number; // Make the number positive
            }
            while (number > 0)
            {
                count++; number /= 10;
            }
        }


     public static void MinMaxReturn(int a, int b, int c, out int min, out int max)
        {

            min = a;
            max = a;
            if (b < min)
            {
                min = b;
            }
            if (b > max)
            {
                max = b;

            }

            if (c < min)
            {
                min = c;
            }
            if (c > max)
            {
                max = c;

            }
        }



        public static void SwapStrings(ref string s1, ref string s2)
        {
            string tempStr = s1;
            s1 = s2;
            s2 = tempStr;

        }
    }
}
