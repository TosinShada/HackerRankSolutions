using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions
{
    public static class WarmUp
    {
        public static int diagonalDifference(List<List<int>> arr)
        {
            int firstSum = 0;
            int secondSum = 0;

            for (int i = 0; i < arr.Count; i++)
            {                 
                firstSum += arr[i][i];
                secondSum += arr[i][arr.Count - 1 - i];
            }
            return Math.Abs(firstSum - secondSum);
        }

        public static void plusMinus(List<int> arr)
        {
            int positiveSum = 0;
            int zeroSum = 0;
            int negativeSum = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] > 0)
                {
                    positiveSum++;
                }
                else if (arr[i] == 0)
                {
                    zeroSum++;
                }
                else
                {
                    negativeSum++;
                }
            }
            double postiveDecimal = (double)positiveSum / arr.Count;
            double zeroDecimal = (double)zeroSum / arr.Count;
            double negativeDecimal = (double)negativeSum / arr.Count;
            Console.WriteLine(postiveDecimal);
            Console.WriteLine(negativeDecimal);
            Console.WriteLine(zeroDecimal);
        }

        public static List<int> compareTriplets(List<int> a, List<int> b)
        {
            int aScore = 0;
            int bScore = 0;
            List<int> comparedList = new List<int>();

            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i])
                {
                    aScore++;
                }
                else if (a[i] < b[i])
                {
                    bScore++;
                }
            }
            comparedList.Add(aScore);
            comparedList.Add(bScore);
            return comparedList;
        }
    }
}
