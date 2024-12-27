using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;

            int result;

            string answer;

            Console.WriteLine("Hello ! Welcome to the Calculator program.");
            Console.WriteLine("Please enter your first number: ");

            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your second number: ");

            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What type of operation would you like to do?");
            Console.WriteLine("Please enter a for Addition, s for Subtraction, m for Multification or any other key for Devision !!!");

            answer = Console.ReadLine();

            if (answer == "a")
            {
                result = num1 + num2;
            }
            else if (answer == "s")
            {
                result = num1 - num2;
            }
            else if (answer == "m")
            {
                result = num1 * num2;
            }
            else
            {
                result = num1 / num2;
            }


            Console.WriteLine("The Result is "+ result);
            Console.WriteLine("Thank you for using the program !!");

            Console.ReadKey();
        }
    }
}
