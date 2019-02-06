using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            for (int t = 0; t < T; t++)
            {
                string input = Console.ReadLine();
                int count = 0, yr = 2018;
                if (input.EndsWith("+"))
                {
                    string[] str = input.Split(new[] { '+' });
                    for (int i = 0; i < str.Length - 1; i++)
                    {
                        count += 1;
                    }
                    yr = yr + count;
                    Console.WriteLine($"Happy New Year-{yr}");
                }
                else
                {
                    Console.WriteLine($"Happy New Year-{yr}");
                }
            }
        }
    }
}
