namespace Training.HomeWorks
{
    public enum Square
    {
        A1 = 00, A2 = 01, A3 = 02, A4 = 03, A5 = 04, A6 = 05, A7 = 06, A8 = 07,
        B1 = 10, B2 = 11, B3 = 12, B4 = 13, B5 = 14, B6 = 15, B7 = 16, B8 = 17,
        C1 = 20, C2 = 21, C3 = 22, C4 = 23, C5 = 24, C6 = 25, C7 = 26, C8 = 27,
        D1 = 30, D2 = 31, D3 = 32, D4 = 33, D5 = 34, D6 = 35, D7 = 36, D8 = 37,
        E1 = 40, E2 = 41, E3 = 42, E4 = 43, E5 = 44, E6 = 45, E7 = 46, E8 = 47,
        F1 = 50, F2 = 51, F3 = 52, F4 = 53, F5 = 54, F6 = 55, F7 = 56, F8 = 57,
        G1 = 60, G2 = 61, G3 = 62, G4 = 63, G5 = 64, G6 = 65, G7 = 66, G8 = 67,
        H1 = 70, H2 = 71, H3 = 72, H4 = 73, H5 = 74, H6 = 75, H7 = 76, H8 = 77
    }

    public class Chess
    {
         static int N = 8;

         static int[] dx = { 2, 1, -1, -2, -2, -1, 1, 2 };
         static int[] dy = { 1, 2, 2, 1, -1, -2, -2, -1 };

         static int[,] minStepsBoard = new int[N, N];

        public static void RunProgram()
        {
           
            for (int i = 0; i < N; i++)
                for (int j = 0; j < N; j++)
                    minStepsBoard[i, j] = int.MaxValue;

            Console.Write("Start (ex: A1): ");
            string startInput = Console.ReadLine();

            Console.Write("End (ex: H8): ");
            string targetInput = Console.ReadLine();

            if (!Enum.TryParse(startInput, true, out Square startSquare) ||
                !Enum.TryParse(targetInput, true, out Square targetSquare))
            {
                Console.WriteLine("Invalid input");
                return;
            }

            GetCoordinates(startSquare, out int startX, out int startY);
            GetCoordinates(targetSquare, out int targetX, out int targetY);

            FindPath(startX, startY, targetX, targetY, 0);

            int result = minStepsBoard[targetX, targetY];

            if (result == int.MaxValue)
                Console.WriteLine("Path not found");
            else
                Console.WriteLine($"Minimum steps: {result}");
        }

         static void GetCoordinates(Square sq, out int x, out int y)
        {
            int val = (int)sq;
            x = val / 10;
            y = val % 10;
        }

        private static void FindPath(int x, int y, int tX, int tY, int step)
        {
            if (x < 0 || x >= N || y < 0 || y >= N)
                return;

            if (step >= minStepsBoard[x, y])
                return;

            minStepsBoard[x, y] = step;

            if (x == tX && y == tY)
                return;

            for (int i = 0; i < 8; i++)
                FindPath(x + dx[i], y + dy[i], tX, tY, step + 1);
        }
    }
}
