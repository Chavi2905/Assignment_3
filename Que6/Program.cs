using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Que6
{
    public class Animal
    {
        public string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }
    }

    // Derived class Dog
    public class Dog : Animal
    {
        public Dog(string name) : base(name)
        {
        }

        public void Bark()
        {
            Console.WriteLine($"{Name} says woof!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the name of the animal: ");
            string animalName = Console.ReadLine();

     
            Dog myDog = new Dog(animalName);

          
            Console.WriteLine($"My animal's name is {myDog.Name}");
            myDog.Bark();
        }
    }
}
