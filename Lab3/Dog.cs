using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Dog : Animal
    {
        public Dog(string name, string colour, double age) : base(name, colour, age)
        {
        }

        public override void Eat()
        {
            string message = string.Format("Dogs eat meat");
            Console.WriteLine(message);
        }
    }
}
