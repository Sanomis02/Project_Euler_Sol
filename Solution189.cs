using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler_2206
{
    internal class Solution189
    {
        int hi, lo, hold1, count;
        public void Rotate(ref int[] nums, int k)
        {
            count = nums.Length;

            if (count == 1)
                return;

            while (k > 0)
            {
                lo = nums[0];
                hi = nums[count - 1];

                for (int i = count - 2; i >= 1; i--)
                {
                    hold1 = nums[i];
                    nums[i + 1] = hold1;
                }

                nums[0] = hi;
                nums[1] = lo;
                k--;
            }
        }
    }
}
