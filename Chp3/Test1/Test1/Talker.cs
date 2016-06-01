using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test1
{
    class Talker
    {
        public static int BlahBlahBlah(string thingToSay, int numberOfTimes)
        {
            string finalString = "";
            for (int count = 1; count <= numberOfTimes; count++)
            {
                finalString += thingToSay + "\n";
            }

            MessageBox.Show(finalString);
            return finalString.Length;
        }
    }
}
