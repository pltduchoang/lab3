using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Interface
{
    internal class Dog : IAnimal

    {
        private string name;
        private string colour;
        private string height;
        private string age;
        string IAnimal.Name { get => name; set => name = value; }
        string IAnimal.Colour { get => colour; set => colour = value; }
        string IAnimal.Height { get => height; set => height = value; }
        string IAnimal.Age { get => age; set => age = value; }

        public Dog (string name, string colour, string height, string age)
        {
            this.name = name;
            this.colour = colour;
            this.height = height;
            this.age = age;
        }

        string IAnimal.Cry()
        {
            string message = string.Format("Woof!");
            return message;
        }

        void IAnimal.Eat()
        {
            Console.WriteLine("Dog eats meat"); ;
        }
    }
}
