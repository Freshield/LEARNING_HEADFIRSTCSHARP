using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chp8_Test8
{
    class Card
    {
        public int number;
        public Kind kind;

        public Card(int number, Kind kind)
        {
            this.number = number;
            this.kind = kind;
        }

        public string Name { get { return number + " of " + kind; }}

        public override string ToString()
        {
            return number + " of " + kind;
        }

        public static bool DoesCardMatch(Card cardToCheck, Kind kind)
        {
            if (cardToCheck.kind == kind)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool DoesCardMatch(Card cardToCheck, int value)
        {
            if (cardToCheck.number == value)
            {
                return true;
            }
            else
            {
                return false;
            }
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
