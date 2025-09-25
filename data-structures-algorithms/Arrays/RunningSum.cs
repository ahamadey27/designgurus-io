using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace data_structures_algorithms.Arrays
{
    //Given a one-dimensional array of integers, create a new array that represents the running sum of the original array.
    public class RunningSum
    {
         public int[] runningSum(int[] nums) {
        //Check if array is null or empty and return empty element if true
        if (nums == null || nums.Length == 0)
        {
            return new int[0];
        }

        //Initialize empty array to store running result
        int[] result = new int[nums.Length];
        result[0] = nums[0];

        //Loop through the array, starting at index 1, adding the previous sum to the current value
        for (int i = 1; i < nums.Length; i++)
        {
            result[i] = result[i - 1] + nums[i];
        }

        //return new array with summed results 
        return result;
    }
        
    }
}