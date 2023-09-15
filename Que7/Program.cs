using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Que7
{
    public class Multiplier
    {
        private int number; // Private property for multiplication

        public Multiplier(int initialValue)
        {
            number = initialValue;
        }

        // Public method to modify the value
        public void SetNumber(int newValue)
        {
            number = newValue;
        }

        // Public method to perform multiplication
        public int Multiply(int factor)
        {
            return number * factor;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an initial value: ");
            int initialValue = Convert.ToInt32(Console.ReadLine());

            Multiplier multiplier = new Multiplier(initialValue);

            Console.Write("Enter a factor for multiplication: ");
            int factor = Convert.ToInt32(Console.ReadLine());

            int result = multiplier.Multiply(factor);

            Console.WriteLine($"Result of multiplication: {result}");

            Console.Write("Enter a new value for multiplication: ");
            int newValue = Convert.ToInt32(Console.ReadLine());

            // Modify the value using the SetNumber method
            multiplier.SetNumber(newValue);

            result = multiplier.Multiply(factor);

            Console.WriteLine($"Updated result of multiplication: {result}");
        }
    }
   




}
