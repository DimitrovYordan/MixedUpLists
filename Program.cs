using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Receiving two arrays with numbers, bigger one with 2 numbers are constraints
            List<int> firstLine = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondLine = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> result = new List<int>();
            int first = 0;
            int second = 0;
            // 2. Unite two arrays in one without constraints, second start from end
            secondLine.Reverse();
            for (int i = 0; i < firstLine.Count; i++)
            {
                if (i == 0)
                {
                    if (firstLine.Count > secondLine.Count)
                    {
                        for (int k = firstLine.Count - 1; k < firstLine.Count; k++)
                        {
                            first = firstLine[firstLine.Count - 2];
                            firstLine.Remove(firstLine[k - 1]);
                            second = firstLine[k - 1];
                            firstLine.Remove(firstLine[k - 1]);
                        }

                    }
                    else
                    {
                        for (int k = secondLine.Count - 1; k < secondLine.Count; k++)
                        {
                            first = secondLine[secondLine.Count - 2];
                            secondLine.Remove(secondLine[k - 1]);
                            second = secondLine[k - 1];
                            secondLine.Remove(secondLine[k - 1]);
                        }

                    }

                }
                result.Add(firstLine[i]);
                result.Add(secondLine[i]);
            }
            // 3. Take numbers between constraints
            List<int> range = new List<int>();
            int temp = first;
            first = Math.Min(first, second);
            second = Math.Max(temp, second);
            for (int i = 0; i < result.Count; i++)
            {
                if (result[i] > first && result[i] < second)
                {
                    range.Add(result[i]);
                }

            }
            // 4. Print result split by " "
            range.Sort();
            Console.Write(string.Join(" ", range));
        }
    }
}
