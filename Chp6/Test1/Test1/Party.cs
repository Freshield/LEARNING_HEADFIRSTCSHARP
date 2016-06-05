using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test1
{
    class Party
    {
        const int CostOfFoodPerPerson = 25;
        private bool fancyDecorations;
        public decimal CostOfDecorations = 0;

        private int numberOfPeople;
        public virtual int NumberOfPeople
        {
            get
            {
                return numberOfPeople;
            }
            set
            {
                numberOfPeople = value;
                CalculateCostOfDecorations(fancyDecorations);
            }
        }

        public Party(int numberOfPeople, bool fancyDecorations)
        {
            this.fancyDecorations = fancyDecorations;
            this.NumberOfPeople = numberOfPeople;

        }

        public void CalculateCostOfDecorations(bool fancy)
        {
            fancyDecorations = fancy;
            if (fancy)
            {
                CostOfDecorations = (NumberOfPeople * 15) + 50;
            }
            else
            {
                CostOfDecorations = (NumberOfPeople * 7.5m) + 30;
            }
        }

        public virtual decimal CalculateCost()
        {
            decimal TotalCost = CostOfDecorations + (CostOfFoodPerPerson * NumberOfPeople);
            if (NumberOfPeople > 12)
            {
                TotalCost += 100;
            }
            return TotalCost;
        }
    }
}
