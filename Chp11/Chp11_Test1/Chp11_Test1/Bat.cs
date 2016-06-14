﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chp11_Test1
{
    class Bat
    {
        private BatCallback hitBallCallback;
        public Bat(BatCallback callbackDelegate)
        {
            this.hitBallCallback = new BatCallback(callbackDelegate);
        }
        public void HitTheBall(BallEventArgs e)
        {
            if (hitBallCallback != null)
            {
                hitBallCallback(e);
            }
        }
    }
}
