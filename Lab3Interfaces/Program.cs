using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the dog's name");
            string dogName = Console.ReadLine();
            Console.WriteLine("Enter the dog's colour");
            string dogColour = Console.ReadLine();
            Console.WriteLine("Enter the dog's height");
            string dogHeight = Console.ReadLine();
            Console.WriteLine("Enter the dog's age");
            string dogAge = Console.ReadLine();

            IAnimal dog = new Dog(dogName,dogColour,dogHeight,dogAge);
            Console.WriteLine(dog.Name);
            Console.WriteLine(dog.Colour);
            Console.WriteLine(dog.Height);
            Console.WriteLine(dog.Age);
            Console.WriteLine(dog.Cry());
            dog.Eat();

            Console.WriteLine("Enter the cat's name");
            string catName = Console.ReadLine();
            Console.WriteLine("Enter the cat's colour");
            string catColour = Console.ReadLine();
            Console.WriteLine("Enter the cat's height");
            string catHeight = Console.ReadLine();
            Console.WriteLine("Enter the cat's age");
            string catAge = Console.ReadLine();

            IAnimal cat = new Cat(catName,catColour,catHeight,catAge);
            Console.WriteLine(cat.Name);
            Console.WriteLine(cat.Colour);
            Console.WriteLine(cat.Height);
            Console.WriteLine(cat.Age);
            Console.WriteLine(cat.Cry());
            cat.Eat();

            List<IAnimal> animalList = new List<IAnimal>();
            IAnimal dog1 = new Dog("Gump", "Black", "100", "5");
            IAnimal dog2 = new Dog("Hachiko", "Golden", "200", "80");
            IAnimal cat1 = new Cat("Tom", "Blue", "80", "10");
            IAnimal cat2 = new Cat("Audi", "TriColor", "90", "10");

            animalList.Add(dog1);
            animalList.Add(dog2);
            animalList.Add(cat1);
            animalList.Add(cat2);

            foreach(IAnimal animal in animalList)
            {
                Console.WriteLine(animal.Name);
            }
        }
    }
}
