using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Project_Euler_2206
{
    internal class Solution283
    {
        int lo, hi;
        public void MoveZeroes(int[] nums)
        {
            if (nums.Length == 1)
                return;

            for (int j = 0; j < nums.Length - 1; j++)
            {
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    lo = nums[i];
                    hi = nums[i + 1];

                    if (lo == 0 && hi != 0)
                    {
                        nums[i + 1] = lo;
                        nums[i] = hi;

                    }
                    else
                    {
 
                    }
                }
            }
              
        }
    }
}

