using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Interfaces
{
    internal interface IAnimal
    {

        string Name { get; set; }
        string Colour { get; set; }
        string Height { get; set; }
        string Age { get; set; }
        
        void Eat();
        string Cry();
    }
}
