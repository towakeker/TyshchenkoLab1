using System;

namespace Lab_1_task_3
{
    public class Employee
    {
        private string lastName;
        private string firstName;
        private string position;
        private int experience;

        public Employee(string lastName, string firstName)
        {
            this.lastName = lastName;
            this.firstName = firstName;
        }

        public void SetPosition(string position)
        {
            this.position = position;
        }

        public void SetExperience(int experience)
        {
            this.experience = experience;
        }

        public double CalculateSalary()
        {
            double baseSalary = 20000;
            double positionMultiplier = 1.0;
            switch (position)
            {
                case "Junior":
                    positionMultiplier = 0.8;
                    break;
                case "Middle":
                    positionMultiplier = 1.0;
                    break;
                case "Senior":
                    positionMultiplier = 2.0;
                    break;
            }

            double salary = baseSalary * positionMultiplier * (1 + experience / 100.0);

            return salary;
        }

        public double CalculateTax()
        {
            double salary = CalculateSalary();
            double taxRate = 0.2;

            double tax = salary * taxRate;
            return tax;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Employee Information:");
            Console.WriteLine($"Last Name: {lastName}");
            Console.WriteLine($"First Name: {firstName}");
            Console.WriteLine($"Position: {position}");
            Console.WriteLine($"Salary: {CalculateSalary()}");
            Console.WriteLine($"Tax: {CalculateTax()}");
        }
    }
}