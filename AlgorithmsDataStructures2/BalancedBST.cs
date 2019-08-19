using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmsDataStructures2
{
    public static class BalancedBST
    {
        public static int[] GenerateBBSTArray(int[] a)
        {
            
            if (a != null)
            {
                a = a.OrderBy(i => i).ToArray();
                int depth = -1;
                for (int size = a.Length; size != 0; depth++)
                    size >>= 1;

                int[] b = new int[(2 << (depth)) - 1];
                if (a.Length == b.Length)
                {
                    GetArray(b, a, 0);
                    return b;
                }
            }
            return null;
        }

        
        // a -- отсортированный (c - отрезанный)
        // b -- сбалансированый
        //
        public static void GetArray(int[] b, int[] a, int nx)
        {
            b[nx] = a[a.Length / 2];
            if (a.Length == 1) return;
            int[] c = new int[a.Length / 2];

            Array.Copy(a, 0, c, 0, a.Length / 2);
            GetArray(b, c, nx * 2 + 1);

            Array.Copy(a, a.Length / 2 + 1, c, 0, a.Length / 2);
            GetArray(b, c, nx * 2 + 2);
        }
    }
}