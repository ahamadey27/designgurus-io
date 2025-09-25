using System;
using data_structures_algorithms.Arrays;

public class Program
{
    public static void Main(string[] args)
    {
        // RunningSum runningsum = new RunningSum();
        // int[] input = new int[] { 1, 2, 3, 4, 5 };
        // int[] result = runningsum.runningSum(input);
        // Console.WriteLine("Running sum result: [{0}]", string.Join(", ", result));

        int[] nums1 = {1, 2, 2, 4, 6};
        Console.WriteLine(ReturnsTrue.containsDuplicate(nums1));
    }
}