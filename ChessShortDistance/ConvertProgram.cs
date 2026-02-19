using System;
using System.Collections.Generic;
using System.Text;

namespace ChessShortDistance
{
    public class ConvertPorgram
    {
        public static Position ConvertIndexes(string position)
        {
            char columnLetter = position[0];
            int rowNumber = int.Parse(position[1].ToString());

            int col = columnLetter - 'A';
            int row = 8 - rowNumber;

            Position CurrentPosition = new Position(row, col);
            return CurrentPosition;
        }


        public static void Run()
        {
            Console.Write("Write Start position(E2): ");
            string input1 = Console.ReadLine().ToUpper();

            Position startPosition = ConvertPorgram.ConvertIndexes(input1);
            Console.WriteLine("Start Position {0} , {1}", startPosition.Row, startPosition.Col);


            Console.Write("Write End position(D7): ");
            string input2 = Console.ReadLine().ToUpper();

            Position EndPosition = ConvertPorgram.ConvertIndexes(input2);
            Console.WriteLine("End Position {0} , {1}", EndPosition.Row, EndPosition.Col);

        }
    }
}
