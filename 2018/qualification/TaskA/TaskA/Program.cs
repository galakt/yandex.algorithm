using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskA
{
    class Program
    {
        static void Main(string[] args)
        {
            var winNumbers = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(byte.Parse);
            var biletsCount = int.Parse(Console.ReadLine());

            var winNumbersSet = new HashSet<byte>(winNumbers);
            for (int i = 0; i < biletsCount; i++)
            {
                var numbers = Console.ReadLine().Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries).Select(byte.Parse).ToList();
                var luckyCount = 3;

                for (int j = 0; j < 6; j++)
                {
                    if (winNumbersSet.Contains(numbers[j]))
                    {
                        luckyCount -= 1;
                    }

                    if (luckyCount == 0)
                    {
                        break;
                    }

                    if (j + luckyCount == 6)
                    {
                        break;
                    }
                }

                if (luckyCount == 0)
                {
                    Console.WriteLine("Lucky");
                }
                else
                {
                    Console.WriteLine("Unlucky");
                }
            }
        }
    }
}
