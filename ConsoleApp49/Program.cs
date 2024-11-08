using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp49
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Enter first number: ");
                string firstInput = Console.ReadLine();
                int firstNumber = int.Parse(firstInput);

                Console.WriteLine("Enter second number: ");
                string secondInput = Console.ReadLine();
                int secondNumber = int.Parse(secondInput);

                int result = firstNumber / secondNumber;
                Console.WriteLine($"division result: {result}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: it's impossible to divide by zero.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: enter correct integers.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Program is done.");
            }
        }
    }
}
