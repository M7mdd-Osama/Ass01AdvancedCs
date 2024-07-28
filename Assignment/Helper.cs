using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Helper
    {
        public static void SWAP<T>(ref T X, ref T Y)
        {
            T Temp = X;
            X = Y;
            Y = Temp;
        }

        public static void BubbleSort(int[] array)
        {
            if (array is not null)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    bool swapped = false;
                    for (int K = 0; K < array.Length - i - 1; K++)
                    {
                        if (array[K] > array[K + 1])
                        {
                            SWAP<int>(ref array[K], ref array[K + 1]);
                            swapped = true;
                        }
                    }
                    if (!swapped)
                        break;
                }
            }
        }
    }
}
