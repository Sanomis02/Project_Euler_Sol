using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler_2206
{
    internal class Solution14
    {
        public string LongestCommonPrefix(string[] strs)
        {
            int count = 0;
            bool isPrefix = true;
            StringBuilder ans = new StringBuilder("");
            int j = 0;
            int i = 0;

            int minima = strs[0].Length;
            foreach(string str in strs)
            {
                if(str.Length < minima)
                {
                    minima = str.Length;
                }
            }

            if (strs.Length == 1)
            {
                return strs[0];
            }
            if (strs[0].Length == 0)
            {
                Console.WriteLine("Wrong input");
                return "";
            }

            for (i = 0; i < strs.Length - 1; i++)
            {
                for (j = i + 1; j < strs.Length; j++)
                {
                    if (count < minima && strs[i][count] == strs[j][count])
                    {
                        isPrefix = true;
                    }
                    else
                    {
                        isPrefix = false;
                        break;
                    }

                }

                if (isPrefix)
                {
                    ans.Append(strs[i][count]);
                    count++;
                    j = 0;
                    i = -1;

                }
                else
                    break;
            }

            return ans.ToString();

        }
    }
}
