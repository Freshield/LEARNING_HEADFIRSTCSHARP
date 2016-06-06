﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FindSomeone
{
    class Opponent
    {
        private Location myLocation;
        private Random random;

        public Opponent(Location startingLocation)
        {
            myLocation = startingLocation;
            random = new Random();
        }

        public void Move()
        {
            if (myLocation is IHasExteriorDoor)
            {
                IHasExteriorDoor LocationWithDoor = myLocation as IHasExteriorDoor;
                if (random.Next(2) == 1)
                {
                    myLocation = LocationWithDoor.DoorLocation;
                }
            }
            bool hidden = false;
            while (!hidden)
            {
                int rand = random.Next(myLocation.Exits.Length);
                myLocation = myLocation.Exits[rand];
                if (myLocation is IHidingPlace)
                {
                    hidden = true;
                }
            }
        }

        public bool Check(Location locationToCheck)
        {
            if (locationToCheck != myLocation)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
