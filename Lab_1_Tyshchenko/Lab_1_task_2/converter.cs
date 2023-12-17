using System;

namespace Lab_1_task_2
{
    public class converter
    {
        private double UsdRate;
        private double EurRate;
        private double PlnRate;

        public converter(double usdRate, double eurRate, double plnRate)
        {
            UsdRate = usdRate;
            EurRate = eurRate;
            PlnRate = plnRate;
        }

        public double ConvertToUSD(double amountInUah) => amountInUah / UsdRate;
        public double ConvertFromUSD(double amountInUsd) => amountInUsd * UsdRate;

        public double ConvertToEUR(double amountInUah) => amountInUah / EurRate;
        public double ConvertFromEUR(double amountInEur) => amountInEur * EurRate;

        public double ConvertToPLN(double amountInUah) => amountInUah / PlnRate;
        public double ConvertFromPLN(double amountInPln) => amountInPln * PlnRate;

        public static double GetDoubleInput(string prompt)
        {
            Console.WriteLine(prompt);

            if (!double.TryParse(Console.ReadLine(), out double result))
            {
                Console.WriteLine("Please, input a correct value in double/float format.");
                return GetDoubleInput(prompt);
            }

            return result;
        }

        public static int GetIntInput(string prompt, int min, int max)
        {
            Console.WriteLine(prompt);

            if (!int.TryParse(Console.ReadLine(), out int result) || result < min || result > max)
            {
                Console.WriteLine($"Please, input a correct value in the range from {min} to {max}.");
                return GetIntInput(prompt, min, max);
            }

            return result;
        }
    }
}