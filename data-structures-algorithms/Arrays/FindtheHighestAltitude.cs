using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace data_structures_algorithms.Arrays
{
    public class FindtheHighestAltitude
    {
        public int largestAltitude(int[] gain)
        {
            int currentAltitude = 0;
            int maxAltitude = 0;

            foreach (int i in gain)
            {
                currentAltitude += i;
                maxAltitude = Math.Max(currentAltitude, maxAltitude);
            }

            return maxAltitude;
        }
    }
}