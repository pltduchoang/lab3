using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Enter the dog's name");
            string dogName = Console.ReadLine();
            Console.WriteLine("Enter the dog's colour");
            string dogColour = Console.ReadLine();
            Console.WriteLine("Enter the dog's age");
            double dogAge = double.Parse(Console.ReadLine());
            
            Dog dog = new Dog(dogName, dogColour, dogAge);
            Console.WriteLine(dog.Name);
            Console.WriteLine(dog.Colour);
            Console.WriteLine(dog.Age);
            dog.Eat();

            Console.WriteLine("Enter the cat's name");
            string catName = Console.ReadLine();
            Console.WriteLine("Enter the cat's colour");
            string catColour = Console.ReadLine();
            Console.WriteLine("Enter the cat's age");
            double catAge = double.Parse(Console.ReadLine());

            Cat cat = new Cat(catName, catColour, catAge);
            Console.WriteLine(cat.Name);
            Console.WriteLine(cat.Colour);
            Console.WriteLine(cat.Age);
            cat.Eat();
        }
    }
}
