using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test4
{
    class MenuMaker
    {
        public Random Randomizer;

        string[] Meats = { "beef", "salami", "turkey", "ham", "pastrami" };
        string[] Condiments = { "mustard", "brown", "honey", "mayo", "relish", "dressing" };
        string[] Breads = { "rye", "white", "wheat", "pumpernickel", "italian", "rool" };

        public string GetMenuItem()
        {
            string randomMeat = Meats[Randomizer.Next(Meats.Length)];
            string randomCondiment = Condiments[Randomizer.Next(Condiments.Length)];
            string randomBread = Breads[Randomizer.Next(Breads.Length)];

            return randomMeat + " with " + randomCondiment + " on " + randomBread;
        }
    }
}
