using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSumSubarrayProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { -2,3,4,-1,5,-10};

            Console.WriteLine(MaxSumSubarray(array));

            Console.ReadKey();
        }

        public static int MaxSumSubarray(int[] array)
        {
            int maxSum = 0;
            int currMax = 0;

            for (int i = 0; i < array.Length; i++)
            {
                currMax = Math.Max(currMax + array[i], array[i]);
                maxSum = Math.Max(currMax, maxSum);
            }

            return maxSum;
        }

    }
}
