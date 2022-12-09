using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler_2206
{
    public class Solution167
    {
        int lo, hi;
        public int[] TwoSum(int[] numbers, int target)
        {

            int[] indeces = new int[2];
            lo = 0; hi = numbers.Length - 1;
            while (numbers[lo] + numbers[hi] != target)
            {
                if (numbers[lo] + numbers[hi] > target)
                {
                    hi--;
                }
                else
                {
                    lo++;
                }
            }

            indeces[0] = lo + 1; indeces[1] = hi + 1;

            return indeces;

        }
    }
}
