using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyExtensions
{
    static class HumanEtensions
    {
        public static bool IsDistressCall(this string s)
        {
            if (s.Contains("Help"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
