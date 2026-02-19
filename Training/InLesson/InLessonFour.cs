using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Training.InLesson
{
    public class InLessonFour
    {
        public static void RunCalculateTax()
        {

            Console.Write("Enter an amount: ");
            string amountInText = Console.ReadLine();
            Console.Write("Enter a two-letter region code: ");
            string region = Console.ReadLine();

            if (decimal.TryParse(amountInText, out decimal amount))
            {
                decimal taxToPay = CalculateTax(amount, region);
                Console.WriteLine($"You must pay {taxToPay} in sales tax.");

            }
            else
            {
                Console.WriteLine("You did not enter a valid amount");
            }

        }
        static decimal CalculateTax(decimal amount, string twoLetterRegionCode)
        {


            decimal rate = 0.0M;
            switch (twoLetterRegionCode)
            {
                case "CH":
                    rate = 0.08M;
                    break;

                case "GB":
                case "FR":
                    rate = 0.2M;
                    break;
                case "CA":
                    rate = 0.0825M;
                    break;
                default:
                    rate = 0.06M;
                    break;
            }
            return amount * rate;
        }
    }

}

