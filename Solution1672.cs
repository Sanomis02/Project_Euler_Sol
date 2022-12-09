using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler_2206
{
    internal class Solution1672
    {
        public int MaximumWealth(int[][] accounts)
        {
            int maxWealth = 0;
            int currentWealth = 0;
            for(int i = 0; i < accounts.GetLength(0);i++)
            {
                for(int j = 0; j < accounts[i].Length; j++)
                {
                    currentWealth = currentWealth + accounts[i][j];
                }

                if (currentWealth > maxWealth)
                    maxWealth = currentWealth;
                currentWealth = 0;
            }

            return maxWealth;

        }
    }
}
