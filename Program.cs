using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Hello ! Welcome to the Calculator program.");

            try
            {
                int num1 = ReadIntegerInput("num1");
                int num2 = ReadIntegerInput("num2");

                int result = num1 / num2;
                Console.WriteLine($"The Result is {result} ");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception: {e.Message}");
            }
            finally
            {
                Console.WriteLine("Thank you for using the program !!");
            }
            Console.ReadKey();
        }

        static int ReadIntegerInput(string prompt)
        {
            while (true)
            {
                 Console.Write($"Enter {prompt}: ");
                 string input = Console.ReadLine() ?? "";
                 if (!int.TryParse(input,out int result) || string.IsNullOrEmpty(input))
                    {
                        Console.WriteLine($"Invalid input! Please enter a valid integer!!");
                        continue;
                    }
                  return Convert.ToInt32(input);
            }
        }
    }
}
