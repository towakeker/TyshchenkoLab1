using System;

namespace Lab_1_task_3
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.Title = "Anton Tyshchenko LAB1";
           Console.WriteLine("Enter the employee's last name:");
           string lastName = Console.ReadLine();

           Console.WriteLine("Enter the employee's first name:");
           string firstName = Console.ReadLine();
           string position = "";
           while (string.IsNullOrEmpty(position))
           {
               Console.WriteLine("Enter the employee's position (1 for Junior, 2 for Middle, 3 for Senior):");

               if (!int.TryParse(Console.ReadLine(), out int positionChoice))
               {
                   Console.WriteLine("Invalid input for position. Try again.");
                   continue;
               }

               switch (positionChoice)
               {
                   case 1:
                       position = "Junior";
                       break;
                   case 2:
                       position = "Middle";
                       break;
                   case 3:
                       position = "Senior";
                       break;
                   default:
                       Console.WriteLine("Invalid position choice. Try again.");
                       break;
               }
           }

           Employee employee = new Employee(lastName, firstName);
           employee.SetPosition(position);

           int experience;
           while (true)
           {
               Console.Write("Enter the employee's experience (in years): ");
               if (int.TryParse(Console.ReadLine(), out experience) && experience >= 0)
                   break;

               Console.WriteLine("Invalid experience input. Please enter a non-negative integer.");
           }

           employee.SetExperience(experience);
           employee.DisplayInfo();

           Console.ReadKey();
        }
    }
}