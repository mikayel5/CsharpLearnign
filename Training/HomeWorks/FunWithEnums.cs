using System;
using System.Collections.Generic;
using System.Text;

namespace Training.HomeWorks
{
    public enum EmpTypueEnum
    {
        Manager,
        Grunt,
        Contractror,
        VicePresident
    }
    public class FunWithEnums
    {


        public static void AskForBonus(EmpTypueEnum e)
        {
            switch (e)
            {
                case EmpTypueEnum.Manager:
                    Console.WriteLine("How about stock options instead?");
                    // H e желаете ли взамен фондовые опционы?
                    break;

                case EmpTypueEnum.Grunt:
                    Console.WriteLine("You have got to be kidding...");
                    // В ы должно быть шутите...

                    break;


                case EmpTypueEnum.Contractror:
                    Console.WriteLine("You already get enough cash...");
                    // В ы уже получаете вполне достаточно...
                    break;


                case EmpTypueEnum.VicePresident:
                    Console.WriteLine("VERY GOOD, Sir!");
                    // Очень хорошо, сэр!

                    break;

            }
        }


    }
}
