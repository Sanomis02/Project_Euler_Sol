using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler_2206
{
    internal class Solution3
    {
        int maxCount = 0;
        int lo = 0;
        public string sub;


        public int LengthOfLongestSubstring(string s)
        {
            bool duplicate = false;

            HashSet<char> unique = new HashSet<char>(s);
            maxCount = unique.Count;

            while(maxCount >= 0)
            {
                lo = 0;
                while (lo <= s.Length - maxCount)
                {
                    duplicate = false;
                    sub = s.Substring(lo, maxCount);
                    for (int i = 0; i < sub.Length - 1 && duplicate == false; i++)
                    {
                        for (int j = 1; j < sub.Length && duplicate == false; j++)
                        {
                            if (sub[i] == sub[j] && i != j)
                            {
                                duplicate = true;
                                break;
                            }
                        }
                    }

                    if (duplicate == false)
                    {
                        return sub.Count();
                    }

                    lo++;
                }
                maxCount--;

            }

            return sub.Count();

        }
    }
}
