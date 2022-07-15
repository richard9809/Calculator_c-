using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;

            int result;
            string answer;

            Console.WriteLine("Hello, welcome to the calculator program!");

            Console.WriteLine("Please enter your first number");
            num1 = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Please enter your second line");
            num2 = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Choose the operation you would like to perform.");
            System.Console.WriteLine("Please enter a for addition, s for subtraction, m for multiplication and d for division");
            answer = Console.ReadLine();

            if(answer == "a")
            {
                result = num1 + num2;
                System.Console.WriteLine(result);
            }
            else if(answer == "s")
            {
                result = num1 - num2;
                System.Console.WriteLine(result);
            }
            else if(answer == "m")
            {
                result = num1 * num2;
                System.Console.WriteLine(result);
            }
            else if(answer == "d")
            {
                result = num1 / num2;
                System.Console.WriteLine(result);
            }
            else
            {
                System.Console.WriteLine("Choose the correct operation");
            }


            Console.ReadKey();
        }
    }
}