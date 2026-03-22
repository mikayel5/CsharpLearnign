using ChessUniverse.Library;

internal class Program
{
    public static void PrintBoard(ChessBoard chessBoard)
    {
        Console.WriteLine("    a  b  c  d  e  f  g  h");
        for (int row = 0; row < 8; row++)
        {
            Console.Write($"{8 - row} ");
            for (int col = 0; col < 8; col++)
            {
                bool isLightSquare = (row + col) % 2 == 0;
                Console.BackgroundColor = isLightSquare ? ConsoleColor.Gray
                    : ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.Black;
                var piece = chessBoard[row, col];
                char symbol = piece?.GetSymbol() ?? '.';
                Console.Write($" {symbol} ");
            }
            Console.ResetColor();
            Console.WriteLine();
        }
    }

    static void Main(string[] args)
    {
        ChessGame chessGame = new ChessGame();

        while (true)
        {
            PrintBoard(chessGame.Board);
            ConvertProgram.Run(out PiecePosition start, out PiecePosition end);
            bool success = chessGame.Move(start.Row, start.Col, end.Row, end.Col);
            if (!success)
            {
                Console.WriteLine("I cant go to this position please do again");
            }
        }
    }
}
