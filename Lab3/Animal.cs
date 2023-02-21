using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public abstract class Animal
    {
        private string name;
        private string colour;
        private double age;

        public string Name { get { return name; } set { name = value; } }
        public string Colour { get { return colour; } set { colour = value; } }

        public double Age { get { return age; } set { age = value; } }

        public Animal (string name, string colour, double age)
        {
            this.name = name;
            this.colour = colour;
            this.age = age;
        }

        abstract public void Eat();
    }
}
