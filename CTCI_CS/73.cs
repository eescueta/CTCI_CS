using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCI_CS
{
    public class Solution73
    {
        public void SetZeroes(int[,] matrix)
        {
            // find first row with zroes
            int firstZeroRow = -1;
            for (int i = 0; i < matrix.GetLength(0);  i++)
            {
                if (firstZeroRow >= 0)
                    break;

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        firstZeroRow = i;
                        break;
                    }
                }
            }

            if (firstZeroRow < 0) return;
            int test = matrix.GetLength(1);
            // set rows to zeroes and record Columns
            for (int i = firstZeroRow + 1; i < matrix.GetLength(0); i++)
            {
                bool isRowZero = false;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        isRowZero = true;
                        matrix[firstZeroRow, j] = 0;
                    }
                }

                if (isRowZero)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
            

            // set columns to zeroes
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                if (matrix[firstZeroRow, i] == 0)
                {
                    for (int j = 0; j < matrix.GetLength(0); j++)
                    {
                        matrix[j, i] = 0;
                    }
                }
                else
                {
                    matrix[firstZeroRow, i] = 0;
                }
            }

        }
    }
    class _73
    {
    }
}
