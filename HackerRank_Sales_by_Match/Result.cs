using System.Collections.Generic;
using System.Linq;

namespace HackerRank_Sales_by_Match
{
    class Result
    {
        public static int sockMerchant(int n, List<int> ar)
        {
            int totalApparences = 0;
            int pairsCount = 0;

            var numbersToFind = ar.Distinct().ToList();

            foreach (var item in numbersToFind)
            {
                for (int i = 0; i < ar.Count(); i++)
                {
                    if (item.Equals(ar[i]))
                    {
                        totalApparences++;

                        if (totalApparences % 2 == 0)
                        {
                            pairsCount++;
                            totalApparences = 0;
                        }
                    }
                }

                totalApparences = 0;
            }
            return pairsCount;
        }
    }
}