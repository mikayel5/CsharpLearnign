using ChessShortDistance;
using ChessShortDistance.Enums;
using ChessShortDistance.Models;
using ChessShortDistance.PiecesOneMoveSteps.ChessShortDistance;
using System;
using System.Xml.Linq;

class Program
{
    static void Main()
    {
        Position start;
        Position end;

        ConvertPorgram.Run(out start, out end);
    
        Console.Write("Write Your Pices Name: ");
        string PicesName = Console.ReadLine().ToUpper();
        if (PicesName == "ROOK")
        {
            if (RookCanMoveInOneStep.Run(start, end))
            {
                Console.WriteLine("Rook can reach in ONE move!");
                Console.WriteLine($"({start.Row}, {start.Col})");
                Console.WriteLine($"({end.Row}, {end.Col})");
                return;
            }
            else
            {
                Console.WriteLine("Rook CAN NOT reach in ONE move!");
            }
        }
        {
            Console.WriteLine("Hi1");

            if (KnightCanMoveInOneStep.Run(start, end))
            {

                Console.WriteLine("Knight can reach in ONE move!");
                Console.WriteLine($"({start.Row}, {start.Col})");
                Console.WriteLine($"({end.Row}, {end.Col})");
                return;
            }
            else
            {

                Console.WriteLine("Knight CAN NOT reach in ONE move!");
            }
        }
        //KnightPath.RunProgram();


    }


}
