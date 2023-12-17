using System;

namespace Lab_1_task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Anton Tyshchenko LAB1";
            Console.Write("Enter your login: ");
            string login = Console.ReadLine();

            Console.Write("Enter your first name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter your last name: ");
            string lastName = Console.ReadLine();

            int age;
            while (true)
            {
                Console.Write("Enter your age: ");
                if (int.TryParse(Console.ReadLine(), out age) && age > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Age should be a positive integer.");
                }
            }

            User user = new User(login, firstName, lastName, age);
            user.DisplayInfo();
        }
    }
}