using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace data_structures_algorithms.Arrays
{
    //Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.
    public static class ReturnsTrue
    {
        public static bool containsDuplicate(int[] nums)
        {
            HashSet<int> uniqueSet = new HashSet<int>();
            foreach (int x in nums)
            {       
                if (!uniqueSet.Add(x)) // If the set already contains the current element, return true
                {
                    return true;
                }
            }

            return false; // Return false if no duplicates found
        }
        
    }
}