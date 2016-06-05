using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Chp6_Test4
{
    class MySubclass : MyBaseClass
    {
        public MySubclass(string baseClassNeedThis, int anotherValue) : base(baseClassNeedThis)
        {
            MessageBox.Show("This is the subclass: " + baseClassNeedThis + " and " + anotherValue);
        }
    }
}
