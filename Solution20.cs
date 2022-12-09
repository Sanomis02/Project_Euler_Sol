using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler_2206
{
    internal class Solution20
    {
        public bool IsValid(string s)
        {
            bool isValid = false;
            int length = s.Length;
            if (length % 2 != 0)
            {
                return isValid;
            }

            for (int i = 0; i < length/2; i++)
            {
                switch (s[i])
                {
                    case '(':
                        isValid = false;
                        for (int j = i + 1; j < length; j++)
                        {
                            if (s[j] == ')')
                            {
                                if ((j-i+1) % 2 == 0)
                                {
                                    isValid = true;
                                    break;
                                }
                            }
                            else
                                isValid = false;
                        }
                        break;
                    case '[':
                        isValid = false;
                        for (int j = i + 1; j < length; j++)
                        {
                            if (s[j] == ']')
                            {
                                if ((j - i + 1) % 2 == 0)
                                {
                                    isValid = true;
                                    break;
                                }
                            }
                            else
                                isValid = false;
                        }
                        break;
                    case '{':
                        isValid = false;
                        for (int j = i + 1; j < length; j++)
                        {
                            if (s[j] == '}')
                            {
                                if ((j - i + 1) % 2 == 0)
                                {
                                    isValid = true;
                                    break;
                                }
                            }
                            else
                                isValid = false;
                        }
                        break;

                    default:
                        break;
                }
            }

            return isValid;



        }
    }

}