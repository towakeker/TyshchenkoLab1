using System;

namespace Lab_1_task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Anton Tyshchenko LAB1";
            address myAddress = new address("1841", "Urkaine", "Kyiv", "Drahomanova", "2", "86");
            myAddress.DisplayAddress();
        }
    }
}