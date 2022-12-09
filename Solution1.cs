using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler_2206
{
    public class Solution1
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int[] twoNum = new int[2];

            for(int i = 0; i < nums.Length-1; i++)
            {
                for(int j = i+1; j < nums.Length; j++)
                {
                    if(nums[i] + nums[j] == target)
                    {
                        twoNum[0] = i; twoNum[1] = j;
                        return twoNum;
                    }
                }
            }

            return twoNum;
           
        }
    }
}
