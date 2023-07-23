using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // task-1
            // Console.WriteLine("Hello, World!");
            //task-2
            //Console.Write("Please enter your name: ");
            //string name = Console.ReadLine();
            //Console.WriteLine($"Hello, {name}!");

            //Task-3

            //Console.Write("Enter the first integer: ");
            //int num1 = int.Parse(Console.ReadLine());

            //Console.Write("Enter the second integer: ");
            //int num2 = int.Parse(Console.ReadLine());

            // Addition
            //int sum = num1 + num2;
            //Console.WriteLine($"Addition: {num1} + {num2} = {sum}");

            //Subtraction
            //int difference = num1 - num2;
            //Console.WriteLine($"Subtraction: {num1} - {num2} = {difference}");

            // Multiplication
            //int product = num1 * num2;
            //Console.WriteLine($"Multiplication: {num1} * {num2} = {product}");

            // Division
            //if (num2 != 0)
            //{
            //    double divisionResult = (double)num1 / num2;
            //    Console.WriteLine($"Division: {num1} / {num2} = {divisionResult}");
            //}
            //else
            //{
            //    Console.WriteLine("Division by zero is not allowed.");
            //}

            //Modulus
            //int modulusResult = num1 % num2;
            //Console.WriteLine($"Modulus: {num1} % {num2} = {modulusResult}");

            //task-4

            //Console.Write("Enter an integer: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine($"{number} is an even number.");
            //}
            //else
            //{
            //    Console.WriteLine($"{number} is an odd number.");
            //} 

            //task-5

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //task-6

            //int[] numbers = { 78, 56, 60, 81, 94 }; 
            //int sum = 0;
            //foreach (int number in numbers)
            //{
            //    sum += number;
            //}
            //double average = (double)sum / numbers.Length;
            //Console.WriteLine($"Sum: {sum}");
            //Console.WriteLine($"Average: {average}");

            //task-7

            //    Console.Write("Enter a positive integer: ");
            //    int number = int.Parse(Console.ReadLine());

            //    if (number >= 0)
            //    {
            //        long factorial = CalculateFactorial(number);
            //        Console.WriteLine($"Factorial of {number} is: {factorial}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Please enter a non-negative integer.");
            //    }
            //}

            //static long CalculateFactorial(int n)
            //{
            //    if (n == 0 || n == 1)
            //    {
            //        return 1;
            //    }
            //    else
            //    {
            //        return n * CalculateFactorial(n - 1);
            //    }

            //task-8
            int age;

            while (true)
            {
                Console.Write("Enter your age: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out age))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
            }

            if (age < 18)
            {
                Console.WriteLine("You are a minor.");
            }
            else if (age >= 18 && age < 65)
            {
                Console.WriteLine("You are an adult.");
            }
            else
            {
                Console.WriteLine("You are a senior.");
            }


        }
    }
}
