using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chp7_Test1
{
    interface IStingPatrol
    {
        int AlertLevel { get; }
        int StingerLength { get; set; }
        bool LookForEnemies();
        int SharpenStinger(int length);
    }
}
