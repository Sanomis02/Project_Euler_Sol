using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler_2206
{
    internal class Solution326
    {
        public bool IsPowerOfThree(int n)
        {
            if (n == 1)
                return true;
            if (n % 3 == 0 && n != 0)
            {
                if (n / 3 == 1)
                    return true;
                else
                {
                    int v = n / 3;
                    return IsPowerOfThree(v);
                }
            }
            else
                return false;
        }

    }
}
