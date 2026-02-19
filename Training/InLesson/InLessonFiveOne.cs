using System;
using System.Collections.Generic;
using System.Text;

namespace Training.InLesson
{
    public class InLessonFiveOnecs
    {
        public static void RunMethodThree()
        {
            Console.Write("Please enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            RunMethod(number);
        }

        public static void RunMethod(int number)
        {
            if (number % 2 != 0)
                number = (number * 3) + 1;
            else
            {
                number = number / 2;
            }

            Console.Write(number + " ");
            if (number != 1)
            {
                RunMethod(number);
            }
        }
    }
}
