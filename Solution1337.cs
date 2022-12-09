using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler_2206
{
    internal class Solution1337
    {
        public int[] KWeakestRows(int[][] mat, int k)
        {
            int[] indeces = new int[k];
            int[] soldiers = new int[mat.GetLength(0)];
            int[] civilians = new int[mat.GetLength(0)];

            int count = 0;
            for(int i = 0; i < mat.GetLength(0); i++)
            {
                for(int j = 0; j < mat.GetLength(0); j++)
                {
                    if (mat[i][j] == 1)
                    {
                        count++;
                    }
                    else
                        break;
                }

                soldiers[i] = count;
                civilians[i] = mat.GetLength(0) - count;
                count = 0;

            }

            for(int i = 0; i < k-1; i++)
            {
            }

            return indeces;

        }

    }
}
