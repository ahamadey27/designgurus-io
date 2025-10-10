using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace data_structures_algorithms.Matrix
{
    /*You are given an m x n matrix accounts where accounts[i][j] is the amount of money the i​​​​​​​​​​​th​​​​ customer has in the j​​​​​​​​​​​th​​​​ bank. public class RichestCustomerWealth

    Return the wealth that the richest customer has.

    Imagine every customer has multiple bank accounts, with each account holding a certain amount of money. The total wealth of a customer is calculated by summing all the money across all their multiple. */
    public static class RichestCustomerWealth
    {
        public static int maximumWealth(int[][] accounts)
        {
            //Initialize maxWealth to 0
            int maxWealth = 0;

            //Loop through each customer's accounts 
            foreach (int[] customer in accounts)
            {
                //Variable to store the wealth of the current customer
                int wealth = 0;

                //Loop through each account of the wealth customer to sum them up
                foreach (int account in customer)
                {
                    wealth += account;
                }

                //Update maxWealth if the current customer's wealth is greater 
                if (wealth > maxWealth)
                {
                    maxWealth = wealth;
                }
            }
            return maxWealth;
        }

        
    }
}