using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUE8
{
    public class MyClass
    {
        private void PrivateMethod()
        {
            Console.WriteLine("This is a private method.");
            Console.ReadLine();
        }

        public void PublicMethod()
        {
            Console.WriteLine("This is a public method.");
            PrivateMethod(); // Call the private method from the public method
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass myObject = new MyClass();

            // Call the public method, which in turn calls the private method
            myObject.PublicMethod();
        }
    }
}
