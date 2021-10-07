using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions
{
    public static class Algorithm
    {
        public static List<int> climbingLeaderboard(List<int> ranked, List<int> player)
        {
            List<int> sortedList = ranked.Distinct().ToList();
            List<int> ranks = new List<int>();

            for (int i = 0; i < player.Count; i++)
            {
                int score = player[i];
                if (score > sortedList[0])
                {
                    ranks.Add(1);
                }
                else if (score < sortedList[sortedList.Count - 1])
                {
                    ranks.Add(sortedList.Count + 1);
                }
                else
                {
                    int index = BinarySearch(sortedList, score);
                    ranks.Add(index + 1);

                }
            }
            return ranks;
        }

        public static int BinarySearch(List<int> a, int score)
        {
            int min = 0;
            int max = a.Count - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (score == a[mid])
                {
                    return mid;
                }
                else if (a[mid] < score && score < a[mid - 1])
                {
                    return mid;
                }
                else if (a[mid] > score && score >= a[mid + 1])
                {
                    return mid + 1;
                }
                else if (a[mid] < score)
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return -1;
        }
    }
}
