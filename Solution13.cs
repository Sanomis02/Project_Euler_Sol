using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler_2206
{

    public class Solution13
    {
        public int RomanToInt(string s)
        {

            if (s.Length > 15 || s.Length == 0) //Checks for the first constraint
            {
                Console.WriteLine("Too many symbols selected");
                return -1;
            }
            else
            {

                char[] symbols = s.ToCharArray();

                int[] numbers = charArrToIntArr(symbols);

                int sum = 0;

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (i + 1 >= numbers.Length)
                    {
                        sum = sum + numbers[i];
                        break;
                    }

                    if (numbers[i] < numbers[i + 1])
                    {
                        sum = sum + (numbers[i + 1] - numbers[i]);
                        if (i + 1 != numbers.Length)
                            i++;
                    }
                    else
                        sum = sum + numbers[i];
                }

                return sum;


            }


        }

        public int[] charArrToIntArr(char[] symbols)
        {

            int[] numbers = new int[symbols.Length];

            for (int i = 0; i < symbols.Length; i++)
            {
                switch (symbols[i])
                {
                    case 'I':
                        numbers[i] = 1;
                        break;
                    case 'V':
                        numbers[i] = 5;
                        break;
                    case 'X':
                        numbers[i] = 10;
                        break;
                    case 'L':
                        numbers[i] = 50;
                        break;
                    case 'C':
                        numbers[i] = 100;
                        break;
                    case 'D':
                        numbers[i] = 500;
                        break;
                    case 'M':
                        numbers[i] = 1000;
                        break;
                    default:
                        Console.WriteLine("Input symbols are not correctly formatted");
                        break;
                }
            }

            return numbers;
        }
    }
}