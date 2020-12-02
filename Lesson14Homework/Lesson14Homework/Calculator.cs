using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson14Homework
{
    static class Calculator
    {
        public static int number1;
        public static int number2;

        public static int Addition(int number1, int number2)
        {
            int result = number1 + number2;
            return result;
        }
        public static int Subtraction(int number1, int number2)
        {
            int result = number1 - number2;
            return result;
        }
        public static int Multiplication(int number1, int number2)
        {
            int result = number1 * number2;
            return result;
        }
        public static int Division(int number1, int number2)
        {
            int result = number1 / number2;
            return result;
        }
    }
}
    

