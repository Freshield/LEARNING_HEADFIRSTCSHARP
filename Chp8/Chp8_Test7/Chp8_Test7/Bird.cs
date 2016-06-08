using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chp8_Test7
{
    class Bird
    {
        public string Name { get; set; }
        public void Fly()
        {
            Console.WriteLine("Flap, flap");
        }
        public override string ToString()
        {
            return "A bird named " + Name;
        }
    }
}
