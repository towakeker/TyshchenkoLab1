using System;

namespace Lab_1_task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Anton Tyshchenko LAB1";
            converter converter = InitConverter();
            MainOperation(converter);
        }
            private static converter InitConverter()
            {

                double usd = converter.GetDoubleInput("Input USD to UAH rate:");
                double eur = converter.GetDoubleInput("Input EUR to UAH rate:");
                double pln = converter.GetDoubleInput("Input PLN to UAH rate:");

                return new converter(usd, eur, pln);
            }

            private static void MainOperation(converter converter)
            {

                switch (converter.GetIntInput("Select operation:\n 1 - Convertation form UAH\n 2 - Convertation to UAH\n 3 - Exit ", 1, 3))
                {
                    case 1:
                        ConvertFromUAH(converter);
                        break;
                    case 2:
                        ConvertToUAH(converter);
                        break;
                    case 3:
                        return;
                }
                MainOperation(converter);
            }

            private static void ConvertFromUAH(converter converter)
            {

                int currency = converter.GetIntInput("Select currency:\n 1 - USD\n 2 - EUR\n 3 - PLN", 1, 3);
                double amount = converter.GetDoubleInput("Input UAH amount:");

                switch (currency)
                {
                    case 1:
                        Console.WriteLine($"UAH to USD: {converter.ConvertToUSD(amount)}");
                        break;
                    case 2:
                        Console.WriteLine($"UAH to EUR: {converter.ConvertToEUR(amount)}");
                        break;
                    case 3:
                        Console.WriteLine($"UAH to PLN: {converter.ConvertToPLN(amount)}");
                        break;
                }
            }

            private static void ConvertToUAH(converter converter)
            {

                int currency = converter.GetIntInput("Select currency:\n 1 - USD\n 2 - EUR\n 3 - PLN", 1, 3);
                double amount = converter.GetDoubleInput("Input UAH amount:");

                switch (currency)
                {
                    case 1:
                        Console.WriteLine($"USD to UAH: {converter.ConvertFromUSD(amount)}");
                        break;
                    case 2:
                        Console.WriteLine($"EUR to UAH: {converter.ConvertFromEUR(amount)}");
                        break;
                    case 3:
                        Console.WriteLine($"PLN to UAH: {converter.ConvertFromPLN(amount)}");
                        break;
                }
        }
    }
}