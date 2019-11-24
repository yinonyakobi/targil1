//added comment
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * yinon yakobi 324160910
 * 
 * michael boxenhorn 212309041
 */

namespace part1
{

    class Program
    {
        public const int ArraySize = 20;
        public const int MinRand = 18;
        public const int MaxRand = 122;
        static Random r = new Random(DateTime.Now.Millisecond);
        static void Main(string[] args)
        {
            int[] A = new int[ArraySize];
            int[] B = new int[ArraySize];
            int[] C = new int[ArraySize];

            for (int i = 0; i < ArraySize; ++i)
            {
                A[i] = r.Next(MinRand, MaxRand);
                B[i] = r.Next(MinRand, MaxRand);

                C[i] = A[i] - B[i];
                if (C[i] < 0) C[i] = -C[i];
            }

            printArray(A);
            printArray(B);
            printArray(C);
        }

        private static void printArray(int[] arr)
        {
            foreach (int i in arr)
            {
                Console.Write("{0, -4}", i);
            }
            Console.WriteLine();
        }
    }
}
