using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;

namespace HackerRankSolutions
{
    public static class DataStructure
    {
        public static List<int> dynamicArray(int n, List<List<int>> queries)
        {
            List<List<int>> arr = new List<List<int>>();
            int lastAnswer = 0;
            List<int> lastAnswers = new List<int>();

            for (int i = 0; i < n; i++)
            {
                arr.Add(new List<int>());
            }

            foreach (var query in queries)
            {
                var idx = (query[1] ^ lastAnswer) % n;
                switch (query.First())
                {
                    case 1:
                        arr[idx].Add(query.Last());
                        break;
                    case 2:
                        lastAnswer = arr[idx][query.Last() % arr[idx].Count];
                        lastAnswers.Add(lastAnswer);
                        break;
                }
            }
            return lastAnswers;
        }

        public static List<int> rotateLeft(int d, List<int> arr)
        {
            for (int i = 0; i < d; i++)
            {
                int temp = arr.First();
                arr.RemoveAt(0);
                arr.Add(temp);
            }
            return arr;
        }
    }
}