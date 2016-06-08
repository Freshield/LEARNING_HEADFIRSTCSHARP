using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chp8_Test6
{
    class Card
    {
        public int number;
        public Kind kind;

        public string Name { get { return number + " of " + kind; }}

        public override string ToString()
        {
            return number + " of " + kind;
        }
    }

    enum Kind
    {
        Ace = 1,
        Four = 2,
        Jack = 3,
        King = 4
    }
}
