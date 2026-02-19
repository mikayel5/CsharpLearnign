namespace Training.InLesson
{
    public class inLesson_4
    {
        public static void RunTimesTable()
        {
            bool isNumber;
            do
            {
                Console.WriteLine("Enter a number between 0 and 255: ");
                isNumber = byte.TryParse(Console.ReadLine(), out byte number);
                if (isNumber)
                {
                    TimesTable(number);
                }
                else
                {
                    Console.WriteLine("You did not enter a valid number");
                }
            } while (isNumber);
        }



        public static void TimesTable(byte number)
        {
            Console.WriteLine($"This is the {number}");

            for (int row = 1; row <= 12; row++)
            {
                Console.WriteLine($"{row}  x {number} = {row * number}");
            }
            Console.WriteLine();
        }

        



    }
}
