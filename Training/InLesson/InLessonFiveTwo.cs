using System;
using System.Collections.Generic;
using System.Text;

namespace Training.InLesson
{
    public class InLessonFiveTwo
    {
        public static void RunFactiorial()
        {
            Console.Write("Please enter a number: ");
            long number = Convert.ToInt32(Console.ReadLine());
            RunMethod(number);
        }

        public static long RunMethod( long number)
        {
          if (number == 0 || number == 1)
            {
                return 1;
            }

            return number * RunMethod(number - 1);

        }

    }
}
