using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestIneritance
{
    class Human : Animal
    {
        public override void eat()
        {
            Console.WriteLine("Human eat");
            base.eat();
        }
    }
}
