using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EvernoteContest1
{

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] res = new int[4];
            for (int i = 0; i < 4; i++)
                res[i] = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                for (int j = 0; j < 4; j++)
                {
                    if (x > res[j])
                    {
                        for (int k = 3; k > j; k--)
                            res[k] = res[k - 1];
                        res[j] = x;
                        break;
                    }
                }
            }
            for (int i = 0; i < 4; i++)
                if (res[i] != int.MinValue)
                    Console.WriteLine(res[i]);
        }

    }
}
