using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chp11_Test1
{
    class Ball
    {
        public event EventHandler BallInPlay;
        protected void OnBallInPlay(BallEventArgs e)
        {
            EventHandler ballInPlay = BallInPlay;
            if (ballInPlay != null)
            {
                ballInPlay(this, e);
            }
        }
        public Bat GetNewBat()
        {
            return new Bat(new BatCallback(OnBallInPlay));
        }
    }
}
