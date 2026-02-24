using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISDH1
{
    internal class Program
    {
        static int SumEqualToK(int[] arr, int K)
        {
            Dictionary<int, int> prefixCount = new Dictionary<int, int>();
            int prefixSum = 0;
            int count = 0;
            prefixCount[0] = 1;

            for (int i = 0; i < arr.Length; i++)
            {
                prefixSum += arr[i];
                if (prefixCount.ContainsKey(prefixSum - K))
                {
                    count += prefixCount[prefixSum - K];
                }
                if (!prefixCount.ContainsKey(prefixSum))
                {
                    prefixCount[prefixSum] = 0;
                }
                prefixCount[prefixSum]++;
            }
            return count;
        }

        static int UniqueInArray(int[] arr)
        {
            Dictionary<int, int> lastIndex = new Dictionary<int, int>();

            int left = 0;
            int maxLength = 0;

            for (int right = 0; right < arr.Length; right++)
            {
                int current = arr[right];
                if (lastIndex.ContainsKey(current) && lastIndex[current] >= left)
                {
                    left = lastIndex[current] + 1;
                }
                lastIndex[current] = right;
                int windowLength = right - left + 1;
                if (windowLength > maxLength)
                {
                    maxLength = windowLength;
                }
            }
            return maxLength;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("------- 1 -------");
            int[] arr = { 1, 2, 3, -2, 2 };
            int K = 3;

            Console.WriteLine(SumEqualToK(arr, K));


            Console.WriteLine("------- 2 -------");
            int[] arr2 = { 1, 2, 1, 3, 4, 2, 3 };
            Console.WriteLine(UniqueInArray(arr2));
        }
    }
}
