using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test2
{
    class Farmer
    {
        public int BagsOfFeed { get;private set; }
        public int FeedMultiplier { get; set; }

        private int numberOfCows;
        private int feedMultiplier;

        public Farmer(int numberOfCows, int feedMultiplier)
        {
            this.feedMultiplier = feedMultiplier;
            NumberOfCows = numberOfCows;
        }



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
