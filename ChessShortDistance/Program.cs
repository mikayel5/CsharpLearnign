using ChessShortDistance;
using ChessShortDistance.Enums;
using ChessShortDistance.Models;
using ChessShortDistance.PiecesOneMoveSteps.ChessShortDistance;
using System;
using System.IO.Pipelines;
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
        if (Enum.TryParse(PicesName, true, out Pices piece))
        {
            switch (piece)
            {
                case Pices.Rook:
                    if (RookCanMoveInOneStep.Run(start, end))
                    {
                        Console.WriteLine($"{Pices.Rook} can reach in ONE move!");
                        Console.WriteLine($"({start.Row}, {start.Col})");
                        Console.WriteLine($"({end.Row}, {end.Col})");
                        return;
                    }
                    else
                    {
                        Console.WriteLine($"{Pices.Rook} CAN NOT reach in ONE move!");
                    }
                    break;

                case Pices.Knight:
                    if (KnightCanMoveInOneStep.Run(start, end))
                    {
                        Console.WriteLine($"{Pices.Knight} can reach in ONE move!");
                        Console.WriteLine($"({start.Row}, {start.Col})");
                        Console.WriteLine($"({end.Row}, {end.Col})");
                        return;
                    }
                    else
                    {
                        Console.WriteLine($"{Pices.Knight} CAN NOT reach in ONE move!");
                    }
                    break;

                default:
                    Console.WriteLine("This piece is not implemented yet.");
                    break;
            }
        }
        //KnightPath.RunProgram();


    }


}
