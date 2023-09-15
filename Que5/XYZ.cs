using System;
using System.Collections.Generic;{

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Que5
    internal class XYZ
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank(1000.00);

            // Access the protected internal member
            Console.WriteLine($"Initial Balance: {bank.accountBalance:C}");

            bank.DisplayBalance();
            Console.ReadLine();
        }
    }
}
