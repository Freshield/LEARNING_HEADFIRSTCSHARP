using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test2
{
    class Farmer
    {
        public int BagsOfFeed { get;private set; }
        public int FeedMultiplier { get { return feedMultiplier; } }

        private int numberOfCows;
        private int feedMultiplier;
        public int NumberOfCows
        {
            get
            {
                return numberOfCows;
            }

            set
            {
                numberOfCows = value;
                BagsOfFeed = numberOfCows * FeedMultiplier;
            }
        }
    }
}
