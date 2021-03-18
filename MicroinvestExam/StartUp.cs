using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace MicroinvestExam
{
    class StartUp
    {
        static int getMinimumCost(int k, int[] c)
        {
            var cycles = c.Length / k;
            var rest = c.Length % k;
            if (rest != 0) cycles += 1;
            var sum = 0;
            var flowers = new List<int>(c.OrderByDescending(x => x));
            for (int i = 0; i < cycles; i++)
            {
                if (flowers.Count >= k)
                {
                    sum += flowers.Take(k).Sum() * (1 + i);
                    flowers.RemoveRange(0, k);
                }
                else
                {
                    sum += flowers.Sum() * (1 + i);
                }
            }

            return sum;

        }

        static void Main(string[] args)
        {
            string[] nk = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp))
                ;
            int minimumCost = getMinimumCost(k, c);

            Console.WriteLine(minimumCost);
        }
    }

}

