using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chp7_Test1
{
    class Bee : IStingPatrol
    {
        public int AlertLevel { get; set; }

        public int StingerLength { get; set; }

        public bool LookForEnemies()
        {
            return false;
        }

        public int SharpenStinger(int length)
        {
            return length;
        }

    }
}
