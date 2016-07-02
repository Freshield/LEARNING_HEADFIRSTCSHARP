using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace extend_testing
{
    static class SuperSoldierSerum
    {
        public static string BreakWalls(this OrdinaryHuman h, double wallDensity)
        {
            return ("I broke throught a wall of " + wallDensity + " density.");
        }
    }
}
