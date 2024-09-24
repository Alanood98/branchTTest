using System;
using System.Collections.Generic;

namespace test2
{
    internal class Program
    {
        static void Main(string[] args)



        internal class program
        {
            static void Main(string[] args)
            {
                while (true)
                {
                    Console.WriteLine("Menu:");
                    Console.WriteLine("1. Factorial Calculator");
                    Console.WriteLine("2. Prime Number Checker");
                    Console.WriteLine("3. Fibonacci Sequence Generator");
                    Console.WriteLine("4. GCD Calculator (Greatest Common Divisor)");
                    Console.WriteLine("5. Sum of Digits Calculator");
                    Console.WriteLine("6. Array Average Calculator");
                    Console.WriteLine("7. Vowel Counter");
                    Console.WriteLine("8. Temperature Converter (Celsius/Fahrenheit)");
                    Console.WriteLine("9. Word Counter");
                    Console.WriteLine("10. String Capitalization");
                    Console.WriteLine("0. Exit");

                    Console.WriteLine("Enter your choice: ");
                    int choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            CalculateFactorial();


                            static void CalculateFactorial()
                            {
                                Console.WriteLine("Enter a number: ");
                                int number = int.Parse(Console.ReadLine());

                                if (number < 0)
                                {
                                    Console.WriteLine("Error");
                                    return;
                                }

                                int factorial = 1;
                                for (int i = 1; i <= number; i++)
                                {
                                    factorial *= i;
                                }

                                Console.WriteLine("The factorial of {number} is: {factorial}");
                            }
                            break;