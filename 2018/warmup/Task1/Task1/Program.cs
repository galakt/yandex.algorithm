using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries);
            var h = int.Parse(input[0]);
            var m = int.Parse(input[1]);

            Console.WriteLine(CalcX(h) + " " + CalcY(m));
        }

        static int CalcX(int h)
        {
            return (12 - h) % 12;
        }

        static int CalcY(int m)
        {
            return (60 - m) % 60;
        }
    }
}
