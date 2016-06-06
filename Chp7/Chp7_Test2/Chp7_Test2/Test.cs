using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Chp7_Test2
{
    class Test
    {
        public int Number { get; set; }

        public Test(int number)
        {
            Number = number;
        }

        public void show()
        {
            MessageBox.Show(Number+"");
        }
    }
}
