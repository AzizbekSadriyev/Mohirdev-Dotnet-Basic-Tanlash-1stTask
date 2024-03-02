// Quyida ternary operator bilan ifodalangan kodni if-else yordamida ifodalang.

/*
using System;

class Program
{
    static void Main()
    {
        int x = 15;
        int y = 10;
        string result = (x > y)
            ? "x is greater than y"
            : (x < y)
                ? "x is less than y"
                : (x == y)
                    ? "x is equal to y"
                    : "x and y are not comparable";

        Console.WriteLine(result);
    }
}
*/

using Microsoft.VisualBasic;
using System.Runtime.ConstrainedExecution;

namespace Task
{
    public class SecondTask
    {
        public static void Task()
        {
            Console.Write("Enter the first number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            if( firstNumber > secondNumber )
            {
                Console.WriteLine("First number is greater than second number");
            }
            else
            {
                if( firstNumber < secondNumber )
                {
                    Console.WriteLine("First number is less than second number");
                }
                else
                {
                    if( firstNumber == secondNumber )
                    {
                        Console.WriteLine("First number is equal to second number");
                    }
                    else
                    {
                        Console.WriteLine("First and second numbers are not comparable");
                    }
                }
            }
        }
    }
}
