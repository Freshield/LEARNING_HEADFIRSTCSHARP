using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Chp7_Test2
{
    class FunnyFunny : IClown
    {
        private string funnyThingIHave;
        public FunnyFunny(string funnyThingIHave)
        {
            this.funnyThingIHave = funnyThingIHave;
        }
        public string FunnyThingIHave 
        { 
            get 
            { 
               return funnyThingIHave; 
            } 
        }

        public void Honk()
        {
            MessageBox.Show("Honk honk! I have a " + FunnyThingIHave);
        }
    }
}
