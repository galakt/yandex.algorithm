using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> row = new LinkedList<int>(new int[] { 1, 1 });

            for (int i = 2; i < 9; i++)
            {
                LinkedListNode<int> first = row.First;
                LinkedListNode<int> next = first.Next;

                while (next != null)
                {
                    var newNode = new LinkedListNode<int>(first.Value + next.Value);
                    row.AddAfter(first, newNode);

                    first = next;
                    next = first.Next;
                }

                /*
                var counter = 0;
                foreach (var i1 in row)
                {
                    if (i1 == i)
                    {
                        counter += 1;
                    }
                }

                Console.WriteLine($"N={i}, CountN={counter}");
                */

                var res = "";
                foreach (var i1 in row)
                {
                    res += i1 + " ";
                }
                Console.WriteLine(res);
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
