using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chp7_Test2
{
    interface IScaryClown : IClown
    {
        string ScaryThingIHave { get; }
        void ScareLittleChildren();

    }
}
