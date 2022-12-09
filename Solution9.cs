using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler_2206
{
    internal class Solution9
    {
        public bool IsPalindrome(int x)
        {
            char[] symbols = x.ToString().ToCharArray();
            bool isPalindrome = true;
            for(int i = symbols.Length-1; i >= 0; i--)
            {
                if(symbols[i] == symbols[symbols.Length - i - 1])
                {
                    isPalindrome = true;
                }
                else
                {
                    isPalindrome = false;
                    break;
                }
            }

            return isPalindrome;
        }

    }
}
