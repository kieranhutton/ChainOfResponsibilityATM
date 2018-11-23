using System;

namespace ChainOfResponsibilityATM
{
    public class RandomGenerator
    {
        public static double GenerateInputMoney()
        {
            Random RandomNumber = new Random();
            int Money;
            return inputMoney[Money = RandomNumber.Next(11)];
        }

        public static string GenerateName()
        {
            Random RandomNumber = new Random();
            int Name;
            return inputNames[Name = RandomNumber.Next(9)];
        }


         public static string[] inputNames =
         {
            "Kieran",
            "Paul",
            "Scott",
            "Swapna",
            "Suneel",
            "Peter",
            "Roland",
            "Lawrence",
            "Andy",
            "Roy"
         };

        public static double[] inputMoney =
        {
            0.01,
            0.02,
            0.05,
            0.10,
            0.20,
            0.50,
            1.00,
            2.00,
            5.00,
            10.00,
            20.00,
            50.00

        };
    }
}