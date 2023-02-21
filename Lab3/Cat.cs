using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Cat : Animal
    {
        public Cat(string name, string colour, double age) : base(name, colour, age)
        {
        }

        public override void Eat()
        {
            string message = string.Format("Cat eat mice");
            Console.WriteLine(message);
        }
    }
}
