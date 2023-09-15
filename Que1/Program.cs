using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Que1
{
    internal class Program
    {
        class MyClass
        {
            private int x;
            private int y;
           

            public void SetValue(int value1,int value2)
            {
                x = value1;
                y = value2;
                
            }

            public int GetValue()
            {
                return x+y; 
            }
        }

        class main
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter an integer value:");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter an integer value:");
                int y = Convert.ToInt32(Console.ReadLine());

                MyClass obj = new MyClass();
                int sum= obj.GetValue();    

                Console.WriteLine("Value set in the class: " + obj.GetValue());
                Console.ReadLine();
            }
        }
       

    }
}
