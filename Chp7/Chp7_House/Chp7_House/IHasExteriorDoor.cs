using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chp7_House
{
    interface IHasExteriorDoor
    {
        public string DoorDescription { get; private set; }
        public Location DoorLocation { get; set; }
    }
}
