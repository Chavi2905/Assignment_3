using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Que4
{
    // Base class Food with protected members
    public class Food
    {
        protected string name;
        protected double price;

        public Food(string name, double price)
        {
            this.name = name;
            this.price = price;
        }
    }

    // Derived class DerivedFood to access protected members of Food
    public class DerivedFood : Food
    {
        public DerivedFood(string name, double price) : base(name, price)
        {
        }

        public void DisplayFoodInfo()
        {
            Console.WriteLine($"Food Name: {name}");
            Console.WriteLine($"Price: {price:C}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the name of the food: ");
            string foodName = Console.ReadLine();

            Console.Write("Enter the price of the food: ");
            double foodPrice = Convert.ToDouble(Console.ReadLine());

            DerivedFood food = new DerivedFood(foodName, foodPrice);

            // Access protected members through the derived class
            food.DisplayFoodInfo();
        }
    }
}
