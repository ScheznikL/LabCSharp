using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR3_SH
{
    class MyValidate
    {
        public static bool IsInteger(string str)
        {
            bool isIntString = str.Any(char.IsDigit);
            if (string.IsNullOrEmpty(str) || string.IsNullOrWhiteSpace(str) || isIntString)
                return true;
            else
                return false;
        }
    }
}
