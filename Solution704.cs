using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler_2206
{
    internal class Solution704
    {
        public int Search(int[] nums, int target)
        {
            int index = -1;
            for(int i = nums.Length-1; i >= 0; i--)
            {
                if (nums[i] == target)
                {
                    return index = i;
                }
            }
            return index;


        }

    }
}
