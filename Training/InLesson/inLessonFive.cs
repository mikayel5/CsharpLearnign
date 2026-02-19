using System;
using System.Collections.Generic;
using System.Text;

namespace Training.InLesson
{
    public class inLessonFive
    {

        public static void RunFibonachi()
        {
            Console.Write("Please enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Fibonacci(0, 1, 1, number);
        }

        public static void Fibonacci(int a, int b, int counter, int number)
        {
            Console.Write(a + " ");
            if (counter <= number)
                Fibonacci(b, a + b, counter + 1, number);

        }




    }
}
