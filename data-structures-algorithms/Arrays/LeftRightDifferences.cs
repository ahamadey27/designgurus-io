using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace data_structures_algorithms.Arrays
{
    public static class LeftRightDifferences
    {
        public static int[] findArrayDifference(int[] nums)
        {
            int n = nums.Length;
            int[] differenceArray = new int[n];

            int leftSum = 0;
            int rightSum = 0;

            //Calculate total sum of array
            foreach (int num in nums)
            {
                rightSum += num;
            }

            //Calculate the difference between the right and left sums for each element
            for (int i = 0; i < n; i++)
            {
                rightSum -= nums[i];
                differenceArray[i] = Math.Abs(rightSum - leftSum);
                leftSum += nums[i];
            }

            return differenceArray;

        }
        
    }
}