using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Que9
{
    public class Division
    {
        protected double DivideNumbers(double dividend, double divisor)
        {
            if (divisor == 0)
            {
                Console.WriteLine("Cannot divide by zero.");
                return double.NaN;
            }
            return dividend / divisor;
        }
    }

    // Derived class Calculator
    public class Calculator : Division
    {
        public double PerformDivision(double dividend, double divisor)
        {
            // Access the protected method from the base class
            return DivideNumbers(dividend, divisor);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the dividend: ");
            double dividend = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the divisor: ");
            double divisor = Convert.ToDouble(Console.ReadLine());

            Calculator calculator = new Calculator();

            double result = calculator.PerformDivision(dividend, divisor);

            Console.WriteLine($"Result of division: {result}");
            Console.ReadLine();
        }
    }
}
