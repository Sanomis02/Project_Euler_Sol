using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler_2206
{
    internal class Solution35
    {
        public int SearchInsert(int[] nums, int target)
        {
            int lo = 0;
            int hi = nums.Length - 1;
            int mid;

            int index = -1;

            while (hi - lo > 1)
            {
                mid = (hi + lo) / 2;
                if (target > nums[mid])
                {
                    lo = mid + 1;
                }
                else
                    hi = mid;

            }

            if (nums[hi] == target)
                return index = hi;
            else if (nums[lo] == target)
                return index = lo;
            else if (nums[hi] < target)
                return index = hi + 1;
            else
            {
                if (target > nums[lo])
                    return index = lo + 1;
                else
                    return index = lo;
            }

        }
        
    }
}
