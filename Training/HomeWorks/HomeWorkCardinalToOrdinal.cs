using System;

namespace Training.HomeWorks
{
    public class HomeWorkCardinalToOrdinal
    {
        public static void RunCardinalToOrdinal()
        {
            for (int i = 1; i <= 40; i++)
            {
                string result = CardinalToOrdinal(i);
                Console.Write(result + " ");
            }
        }

        public static string CardinalToOrdinal(int number)
        {
            string suffix = "th";

            int lastTwo = number % 100;

            switch (lastTwo)
            {
                case 11:
                case 12:
                case 13:
                    suffix = "th";
                    break;

                default:
                    int lastDigit = number % 10;

                    switch (lastDigit)
                    {
                        case 1:
                            suffix = "st";
                            break;
                        case 2:
                            suffix = "nd";
                            break;
                        case 3:
                            suffix = "rd";
                            break;
                        default:
                            suffix = "th";
                            break;
                    }
                    break;
            }

            return number + suffix;
        }
    }
}
