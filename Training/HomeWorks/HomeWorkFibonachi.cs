//using System;
//using System.Collections.Generic;
//using System.Reflection;
//using System.Text;

//namespace Training.HomeWorks
//{
//    public class HomeWorkFibonachi
//    {
//        public static void RunProgram()
//        {
//            Console.Write("Enter an amount: ");
//            string indexText = Console.ReadLine();


//            if (int.TryParse(indexText, out int index))
//            {
//                int number = PrintNumber(index);
//                Console.WriteLine($"Number :{number}.");

//            }
//            else
//            {
//                Console.WriteLine("You did not enter a valid amount");
//            }
//        }
//        // Array
//        public static int PrintNumber(int number)
//        {

//            int first = 0;
//            int second = 1;
//            int next;

//            for (int i = 0; i <= number; i++)
//            {
//                if (number == 0) return first;
//                if (number == 1) return second;
//                else
//                {
//                    next = first + second;
//                    first = second;
//                    second = next;

//                }
//                return second;
//            }

//        }

//    }
//}
