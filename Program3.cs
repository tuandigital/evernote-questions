using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EvernoteContest1
{

    class Program
    {
        static Dictionary<string, int> dict = new Dictionary<string, int>();


        static int ComparisonByFreqency(string x, string y)
        {
            int xFreq = dict[x];
            int yFreq = dict[y];
            if ((xFreq < yFreq) || (xFreq == yFreq && x.CompareTo(y) > 0))
                return 1;
            if ((xFreq > yFreq) || (xFreq == yFreq && x.CompareTo(y) < 0))
                return -1;
            return 0;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] strs = new string[n];

            for (int i = 0; i < n; i++)
            {
                string str = Console.ReadLine();
                strs[i] = str;
                if (!dict.ContainsKey(str))
                    dict[str] = 1;
                else
                    dict[str]++;
            }
            Array.Sort<string>(strs, ComparisonByFreqency);
            int k = int.Parse(Console.ReadLine());
            int index = 0;
            string prev = "";
            while (k > 0)
            {
                if (strs[index].Equals(prev))
                    index++;
                else
                {
                    Console.WriteLine(strs[index]);
                    prev = strs[index];
                    k--;
                }
                if (index == n)
                    break;
            }
        }

    }
}
