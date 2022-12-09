using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler_2206
{
    internal class Solution977
    {
        public int[] SortedSquares(int[] nums)
        {
            int[] squaredArr = new int[nums.Length];
            int count = nums.Length-1;

            int lo = 0;
            int hi = nums.Length - 1;

            while(count >= 0)
            {
                if (Math.Abs(nums[hi]) >= Math.Abs(nums[lo]))
                {
                    squaredArr[count--] = (int)Math.Pow(Math.Abs(nums[hi]),2);
                    hi = hi - 1;
                }
                else
                {
                    squaredArr[count--] = (int)Math.Pow(Math.Abs(nums[lo]), 2);
                    lo = lo + 1;
                }
            }

            return squaredArr;
        }
        
    }
}

