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
            int size = int.Parse(Console.ReadLine());
            int first = 0;
            int last = 0;
            int count = 0;
            string[] buffer = new string[size];
            while (true)
            {
                string line = Console.ReadLine();
                if (line.Equals("Q"))
                    return;
                if (line.StartsWith("A"))
                {
                    string[] strs = line.Split();
                    int n = int.Parse(strs[1]);
                    for (int i = 0; i < n; i++)
                    {
                        buffer[last++] = Console.ReadLine();
                        count++;
                        if (count > size)
                        {
                            first++;
                            count = size;
                        }
                        if (last == size)
                            last = 0;
                        if (first == size)
                            first = 0;
                    }
                }
                else if (line.StartsWith("R"))
                {
                    string[] strs = line.Split();
                    int n = int.Parse(strs[1]);
                    while (n > 0 && count > 0)
                    {
                        first++;
                        if (first == size)
                            first = 0;
                        count--;
                        n--;
                    }
                }
                else if (line.StartsWith("L"))
                {
                    int n = count;
                    int i = first;
                    while (n > 0)
                    {
                        Console.WriteLine(buffer[i++]);
                        if (i == size)
                            i = 0;
                        n--;
                    }
                }
            }
        }
    }
}
