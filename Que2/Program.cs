using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static Que2.Program;

namespace Que2
{
    internal class Program
    {
        public class Circle
        {
            private double radius;

            public Circle(double radius)
            {
                this.radius = radius;
            }

            public double CalculateArea()
            {
                return Math.PI * Math.Pow(radius, 2);
            }
        }

       
        public class AreaCalculator
        {
            public double GetCircleArea(Circle circle)
            {
                // Access the private radius field from the Circle class
                return circle.CalculateArea();
            }
        }

        class main
        {
            static void Main(string[] args)
            {
                Console.Write("Enter the radius of the circle: ");
                double radius = Convert.ToDouble(Console.ReadLine());

                Circle myCircle = new Circle(radius);
                AreaCalculator calculator = new AreaCalculator();

                double area = calculator.GetCircleArea(myCircle);

                Console.WriteLine($"The area of the circle with radius {radius} is {area}");
                Console.ReadLine();
            }
        }
       



    }
}
