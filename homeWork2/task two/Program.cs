using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_two
{
    class Program
    {
        static int NumberOfDigits(int a, int count)
        {
            while (a != 0)
            {
                a = a / 10;
                count++;
            }
            return count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Insert digit:");
            int a = int.Parse(Console.ReadLine());
            int count = 0;
            Console.WriteLine(NumberOfDigits(a, count));
            Console.ReadKey();
        }
    }
}
