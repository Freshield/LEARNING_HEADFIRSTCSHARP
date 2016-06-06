using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Chp7_Test2
{
    class ScaryScary : FunnyFunny, IScaryClown
    {
        private int numberOfScaryThings;

        public ScaryScary(string funnyThingIHave,int numberOfScaryThings)
            :base(funnyThingIHave)
        {
            this.numberOfScaryThings = numberOfScaryThings;
        }

        public string ScaryThingIHave
        {
            get
            {
                return "I have " + numberOfScaryThings + " spiders, you can not have my " + base.funnyThingIHave;
            }
        }

        public void ScareLittleChildren()
        {
            MessageBox.Show("Boo! Gotcha!" + ScaryThingIHave);
        }
    }
}
