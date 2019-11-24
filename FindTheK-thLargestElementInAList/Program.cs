using System;

/*Given a list, find the k-th largest element in the list.
Input: list = [3, 5, 2, 4, 6, 8], k = 3
Output: 5
Here is a starting point:

def findKthLargest(nums, k):
  # Fill this in.

print findKthLargest([3, 5, 2, 4, 6, 8], 3)
# 5
*/

namespace FindTheK_thLargestElementInAList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            var solution = new Solution();
            solution.RunTest1();
        }
    }

    public class Solution
    {
        public int RunTest1()
        {
            int[] testArray = { 3, 5, 2, 4, 6, 8 };
            int k = 3;
            return findKthLargest(testArray, k);
        }

        public int findKthLargest(int[] inputArray, int kth)
        {
            int temp;

            for (int i = 0; i <= inputArray.Length - 2; i++)
            {
                for (int j = 0; j <= inputArray.Length - 2; j++)
                {
                    if (inputArray[j] > inputArray[j + 1])
                    {
                        temp = inputArray[j + 1];
                        inputArray[j + 1] = inputArray[j];
                        inputArray[j] = temp;
                    }

                }
                

            }

            return inputArray[inputArray.Length-kth];
        }
    }
}
        
