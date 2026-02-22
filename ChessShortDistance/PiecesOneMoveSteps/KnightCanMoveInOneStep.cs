using ChessShortDistance.Models;

namespace ChessShortDistance
{
    public class KnightCanMoveInOneStep
    {
        public static bool Run(Position start, Position end)
        {
            int dx = Math.Abs(start.Row - end.Row);
            int dy = Math.Abs(start.Col - end.Col);

            return (dx == 2 && dy == 1) ||
                   (dx == 1 && dy == 2);

        }

    }
}
