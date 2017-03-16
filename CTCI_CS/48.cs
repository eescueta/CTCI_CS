using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCI_CS
{
    public class Solution48
    {
        public void Rotate(int[,] matrix)
        {
            //matrix.GetLength(0); // get length of row
            //matrix.GetLength(1); // get length of columns

            // reverse columns
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int start = 0;
                int end = matrix.GetLength(1) - 1;

                while (start < end)
                {
                    int tmp = matrix[start, i];
                    matrix[start, i] = matrix[end, i];
                    matrix[end, i] = tmp;
                    start++;
                    end--;
                }

            }

            // flip over diagonal
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                for (int j = i + 1; j < matrix.GetLength(0); j++)
                {
                    int tmp = matrix[i, j];
                    matrix[i, j] = matrix[j, i];
                    matrix[j, i] = tmp;
                }
            }

        }
    }

    class _48
    {
    }
}
