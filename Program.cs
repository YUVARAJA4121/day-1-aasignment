using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables
            int age = 22;
            string name = "Arun";
            char grade = 'A';
            bool isEmployee = true;
            float height = 5.9f;
            double salary = 45000.50;
            decimal accountBalance = 25000.75m;
            long mobileNumber = 9876543210;
            byte marks = 95;

            // Print values
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Grade: " + grade);
            Console.WriteLine("Employee: " + isEmployee);
            Console.WriteLine("Height: " + height);
            Console.WriteLine("Salary: " + salary);
            Console.WriteLine("Account Balance: " + accountBalance);
            Console.WriteLine("Mobile Number: " + mobileNumber);
            Console.WriteLine("Marks: " + marks);

            Console.ReadLine();
        }
    }
}