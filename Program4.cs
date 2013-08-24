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
            
            long[] numbers = new long[n];
            long[] left = new long[n];
            long[] right = new long[n];
            left[0] = 1;
            right[n - 1] = 1;
            for(int i = 0; i < n ; i++){
                long x = long.Parse(Console.ReadLine());
                numbers[i] = x;
                if (i  < n - 1)
                    left[i+1] = left[i] * x;
            }

            for(int j = n-1; j >= 0; j--){
                if (j > 0)
                    right[j - 1] = right[j] * numbers[j];
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(left[i] * right[i]);
            }
        }
    }
}
