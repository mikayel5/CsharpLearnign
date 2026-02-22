using ChessShortDistance.Models;

namespace ChessShortDistance.PiecesOneMoveSteps
{
  

namespace ChessShortDistance
    {
        public class RookCanMoveInOneStep
        {
            public static bool Run(Position start, Position end)
            {
                int dx = Math.Abs(start.Row - end.Row);
                int dy = Math.Abs(start.Col - end.Col);

                return (dx == 1 && dy == 0) ||
                       (dx == 0 && dy == 1);

            }
        }
    }

}
