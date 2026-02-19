using System;
using System.Collections.Generic;
using System.Text;

namespace Training.HomeWorks
{
    public class HomeWork_2
    {
        public static void Triangle()
        {


            //Top
            //int rows = 8;

            //string[][] triangle = new string[rows][];
            //for (int i = 0; i < rows; i++)
            //{

            //    triangle[i] = new string[2 * i + 1];
            //    for (int k = 0; k < rows - 1 - i; k++)
            //    {
            //        Console.Write("  ");
            //    }


            //    for (int j = 0; j < triangle[i].Length; j++)
            //    {

            //        triangle[i][j] = "*";
            //        Console.Write(triangle[i][j] + " ");
            //    }
            //    Console.WriteLine();
            //}




            //Bottom

            int rows = 7;
            string[][] triangle = new string[rows][];

            for (int i = 0; i < rows; i++)
            {

                triangle[i] = new string[2 * (rows - 1 - i) + 1];


                for (int k = 0; k < i; k++)
                {
                    Console.Write("  ");
                }


                for (int j = 0; j < triangle[i].Length; j++)
                {
                    triangle[i][j] = "*";
                    Console.Write(triangle[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
