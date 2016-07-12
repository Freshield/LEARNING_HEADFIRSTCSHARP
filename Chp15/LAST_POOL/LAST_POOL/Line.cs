using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LAST_POOL
{
    class Line
    {
        public string[] Words;
        public int Value;
        public Line(string[] Words, int Value)
        {
            this.Words = Words;
            this.Value = Value;
        }
    }
}
