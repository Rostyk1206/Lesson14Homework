using System;

namespace Lesson14Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first number:");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your second number:");
            int number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Choose math operation:'+', '-', '*', '/'");

            string operation = Console.ReadLine();
            switch (operation)
            {
                case ("+"):
                    {
                        int result = Calculator.Addition(number1, number2);
                        Console.WriteLine($"Result of addition:{result}");
                        break;
                    }
                case ("-"):
                    {
                        int result = Calculator.Subtraction(number1, number2);
                        Console.WriteLine($"Result of subtraction:{result}");
                        break;
                    }
                case ("/"):
                    {
                        int result = Calculator.Division(number1, number2);
                        Console.WriteLine($"Result of division:{result}");
                        break;
                    }
                case ("*"):
                    {
                        int result = Calculator.Multiplication(number1, number2);
                        Console.WriteLine($"Result of Multioplication:{result}");
                        break;
                    }
            }
        }
    }
}
