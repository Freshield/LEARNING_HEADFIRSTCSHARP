using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chp6_Test3
{
    class JewelThief : Locksmith
    {
        private Jewels stolenJewels = null;

        override public void ReturnContents(Jewels safeContents, Owner owner)
        {
            stolenJewels = safeContents;
            Console.WriteLine("I'm stealing the contents! " + stolenJewels.Sparkle());
        }
    }
}
