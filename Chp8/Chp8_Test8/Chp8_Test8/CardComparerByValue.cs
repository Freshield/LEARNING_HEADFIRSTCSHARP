using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chp8_Test8
{
    class CardComparerByValue : IComparer<Card>
    {
        public int Compare(Card x, Card y)
        {

            if (x.kind < y.kind)
            {
                return -1;
            }
            else if (x.kind > y.kind)
            {
                return 1;
            }

            if (x.number < y.number)
            {
                return -1;
            }
            else if (x.number > y.number)
            {
                return 1;
            }
            return 0;
        }
    }
}
