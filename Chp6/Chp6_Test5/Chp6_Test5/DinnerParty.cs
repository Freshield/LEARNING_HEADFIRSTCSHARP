using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chp6_Test5
{
    class DinnerParty : Party
    {
        public decimal CostOfBeveragesPerPerson;

        public DinnerParty(int numberOfPeople, bool healthyOption,
            bool fancyDecorations)
            : base(numberOfPeople, fancyDecorations)
        {
            SetHealthyOption(healthyOption);
            CalculateCostOfDecorations(fancyDecorations);
            
        }


        public void SetHealthyOption(bool healthyOption)
        {
            if (healthyOption)
            {
                CostOfBeveragesPerPerson = 5;
            }
            else
            {
                CostOfBeveragesPerPerson = 20;
            }
        }


        public decimal CalculateCost(bool healthyOption)
        {
            decimal totalCost = base.CalculateCost() + (CostOfBeveragesPerPerson * NumberOfPeople);
            if (healthyOption)
            {
                return totalCost * 0.95m;
            }
            else
            {
                return totalCost;
            }
        }
    }
}
