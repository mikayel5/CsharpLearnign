
using ChessUniverse.Library;

public class ConvertProgram
{
    public static PiecePosition ConvertIndexes(string position)
    {
        char columnLetter = position[0];
        int rowNumber = int.Parse(position[1].ToString());

        int col = columnLetter - 'a';
        int row = 8 - rowNumber;

        return new PiecePosition(row, col);
    }

    public static void Run(out PiecePosition start, out PiecePosition end)
    {
        Console.Write("Write Start position (B1): ");
        string input1 = Console.ReadLine().ToLower();
        start = ConvertIndexes(input1);

        Console.WriteLine($"Start: {start.Row}, {start.Col}");

        Console.Write("Write End position (C3): ");
        string input2 = Console.ReadLine().ToLower();
        end = ConvertIndexes(input2);

        Console.WriteLine($"End: {end.Row}, {end.Col}");
    }
}