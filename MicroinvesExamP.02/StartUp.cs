using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;

namespace MicroinvesExamP._02
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int [] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < input.Length - 1; i++)
            {
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (input[i] + input[j] == num)
                    {
                        Console.WriteLine($"There is mach on index {i} and {j}");
                    }
                }
            }

        }
    }
}
//1 3 4 9