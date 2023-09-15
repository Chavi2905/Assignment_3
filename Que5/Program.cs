using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Que5
{
    // Assembly A

    
        public class Bank
        {
            protected internal double accountBalance;

            public Bank(double initialBalance)
            {
                accountBalance = initialBalance;
            }

        public void DisplayBalance()
        {
            
            
                Console.WriteLine($"Account Balance: {accountBalance:C}");
            
        }
        }
    
}
