using System;

namespace ChessShortDistance
{
    public class KnightPath
    {
        const int N = 8;

        static bool[,] visited = new bool[N, N];
        static Cell[] pathStack = new Cell[N * N];
        static Cell[] bestPath = new Cell[N * N];
        static int bestCount = N * N;

        struct Cell
        {
            public int X, Y;

            public Cell(int x, int y)
            {
                X = x;
                Y = y;
            }
        }

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

        static void DFS(Cell cur, Cell target, int depth)
        {
            pathStack[depth] = cur;

            if (cur.X == target.X && cur.Y == target.Y)
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
                int nx = cur.X + offset.dx;
                int ny = cur.Y + offset.dy;

                if (nx >= 0 && nx < N &&
                    ny >= 0 && ny < N &&
                    !visited[nx, ny])
                {
                    visited[nx, ny] = true;

                    DFS(new Cell(nx, ny), target, depth + 1);

                    visited[nx, ny] = false; // backtracking
                }
            }
        }

        // Делаем метод public чтобы вызвать из Program.cs
        public static void RunProgram()
        {
            // СБРОС состояния (очень важно)
            visited = new bool[N, N];
            pathStack = new Cell[N * N];
            bestPath = new Cell[N * N];
            bestCount = N * N;

            Cell start = new Cell(2, 1);
            Cell end = new Cell(7, 7);

            visited[start.X, start.Y] = true;

            DFS(start, end, 0);

            Console.WriteLine($"Minimal Steps: {bestCount}");
            Console.WriteLine("Knight path:");

            for (int i = 0; i <= bestCount; i++)
            {
                Console.WriteLine($"({bestPath[i].X}, {bestPath[i].Y})");
            }
        }
    }
}
