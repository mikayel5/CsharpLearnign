using ChessShortDistance.Models;


namespace ChessShortDistance
{
    public class KnightPath
    {
        const int N = 8;

        static bool[,] visited = new bool[N, N];
        static Position[] pathStack = new Position[N * N];
        static Position[] bestPath = new Position[N * N];
        static int bestCount = N * N;
   

        enum KnightMove
        {
            UpLeft, UpRight, DownLeft, DownRight,
            LeftUp, LeftDown, RightUp, RightDown
        }

        static (int dx, int dy) GetOffset(KnightMove move)
        {
            switch (move)
            {
                case KnightMove.UpLeft: return (-2, -1);
                case KnightMove.UpRight: return (-2, 1);
                case KnightMove.DownLeft: return (2, -1);
                case KnightMove.DownRight: return (2, 1);
                case KnightMove.LeftUp: return (-1, -2);
                case KnightMove.LeftDown: return (1, -2);
                case KnightMove.RightUp: return (-1, 2);
                case KnightMove.RightDown: return (1, 2);
            }
            return (0, 0);
        }

        static void DFS(Position cur, Position target, int depth)
        {
            pathStack[depth] = cur;

            if (cur.Row == target.Row && cur.Col == target.Col)
            {
                if (depth < bestCount)
                {
                    bestCount = depth;

                    for (int i = 0; i <= depth; i++)
                        bestPath[i] = pathStack[i];
                }
                return;
            }

            if (depth >= bestCount) return;

            foreach (KnightMove move in Enum.GetValues(typeof(KnightMove)))
            {
                var offset = GetOffset(move);
                int nx = cur.Row + offset.dx;
                int ny = cur.Col + offset.dy;

                if (nx >= 0 && nx < N &&
                    ny >= 0 && ny < N &&
                    !visited[nx, ny])
                {
                    visited[nx, ny] = true;

                    DFS(new Position(nx, ny), target, depth + 1);

                    visited[nx, ny] = false; 
                }
            }
        }

        public static void RunProgram()
        {
            visited = new bool[N, N];
            pathStack = new Position[N * N];
            bestPath = new Position[N * N];
            bestCount = N * N;

            Position start = new Position(2, 1);
            Position end = new Position(7, 7);

            visited[start.Row, start.Col] = true;

            DFS(start, end, 0);

            Console.WriteLine($"Minimal Steps: {bestCount}");
            Console.WriteLine("Knight path:");

            for (int i = 0; i <= bestCount; i++)
            {
                Console.WriteLine($"({bestPath[i].Row}, {bestPath[i].Col})");
            }
        }
    }
}
