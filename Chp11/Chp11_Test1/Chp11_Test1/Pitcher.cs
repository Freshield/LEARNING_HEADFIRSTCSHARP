using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chp11_Test1
{
    class Pitcher
    {
        public Pitcher(Ball ball)
        {
            ball.BallInPlay += new EventHandler(ball_BallInPlay);
        }

        public void CatchBall()
        {
            Console.WriteLine("Pitcher: I caught the ball");
        }

        public void CoverFirstBase()
        {
            Console.WriteLine("Pictcher: I covered first base");
        }

        void ball_BallInPlay(object sender, EventArgs e)
        {
            if (e is BallEventArgs)
            {
                BallEventArgs ballEventArgs = e as BallEventArgs;
                if ((ballEventArgs.Distance < 95) && (ballEventArgs.Trajectory < 60))
                {
                    CatchBall();
                }
                else
                {
                    CoverFirstBase();
                }
            }
        }
    }
}
