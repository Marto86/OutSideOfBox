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
        static int getMinimumCost(int n, int k, int[] c)
        {
            Array.Sort(c);
            Array.Reverse(c);
            int result = 0, m;
            for (int i = 0; i < n; i++)
            {
                double d = i / k;
                m = Convert.ToInt32(Math.Floor(d)) + 1;
                result += c[i] * m;
            }
            return result;

        }

        static void Main(String[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] c_temp = Console.ReadLine().Split(' ');
            int[] c = Array.ConvertAll(c_temp, Int32.Parse);
            int minimumCost = getMinimumCost(n, k, c);
            Console.WriteLine(minimumCost);
        }
    }

}

