using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test1
{
    class DinnerParty
    {
        public decimal CostOfBeveragesPerPerson;
        public decimal CostOfDecorations = 0;
        public int NumberOfPeople;
        public bool HealthyOption;

        const int CostOfFoodPerPerson = 25;

        public void SetHealthyOption(bool choice)
        {
            if (HealthyOption)
            {
                CostOfBeveragesPerPerson = 5;
            }
            else
            {
                CostOfBeveragesPerPerson = 20;
            }
        }

        public void CalculateCostOfDecorations(bool fancy)
        {
            if (fancy)
            {
                CostOfDecorations = (NumberOfPeople * 15) + 50;
            }
            else
            {
                CostOfDecorations = (NumberOfPeople * 7.5m) + 30;
            }
        }

        public decimal CalculateCost(bool healthyOption)
        {
            decimal totalCost = CostOfDecorations + ((CostOfBeveragesPerPerson + CostOfFoodPerPerson) * NumberOfPeople);

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
