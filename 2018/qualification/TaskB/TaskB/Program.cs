using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskB
{
    class Program
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var inputArrays = new List<int[]>(2*n);
            var result = new StringBuilder(3*n);

            for (int i = 0; i < 2*n; i++)
            {
                var currentLine = Console.ReadLine().Split(new char[] { ' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                inputArrays.Add(currentLine);
            }

            foreach (var inputArray in inputArrays)
            {
                var prevRes = new int[n,n];
                for (int i = 0; i < n; i++)
                {
                    prevRes[0, i] = inputArray[i];
                }

                var r = BruteCol(prevRes, 0, inputArrays.Except(new List<int[]>{inputArray}), n);
                if (r != null)
                {
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            result.Append(r[i, j]);
                            result.Append(' ');
                        }
                    }
                    break;
                }
            }
            Console.WriteLine(result);
        }

        public static int[,] BruteCol(int[,] prevRes, int i, IEnumerable<int[]> availableArrays, int n)
        {
            foreach (var availableArray in availableArrays)
            {
                var success = true;
                for (int j = i; j >= 0; j--)
                {
                    if (availableArray[j] != prevRes[j,i])
                    {
                        success = false;
                        break;
                    }
                }

                if (success)
                {
                    for (int j = 0; j < n; j++)
                    {
                        prevRes[j,i] = availableArray[j];
                    }

                    return BruteRow(prevRes, i+1, availableArrays.Except(new List<int[]> {availableArray}), n);
                }
            }

            return null;
        }

        public static int[,] BruteRow(int[,] prevRes, int i, IEnumerable<int[]> availableArrays, int n)
        {
            if (i == n)
            {
                return prevRes;
            }

            foreach (var availableArray in availableArrays)
            {
                var success = true;
                for (int j = i-1; j >= 0; j--)
                {
                    if (availableArray[j] != prevRes[i, j])
                    {
                        success = false;
                        break;
                    }
                }

                if (success)
                {
                    for (int j = 0; j < n; j++)
                    {
                        prevRes[i, j] = availableArray[j];
                    }

                    return BruteCol(prevRes, i, availableArrays.Except(new List<int[]> { availableArray }), n);
                }
            }

            return null;
        }
    }
}
