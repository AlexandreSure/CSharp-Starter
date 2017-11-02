using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_four
{
    class Program
    {
        static void Main(string[] args)
        {
            #region a
            Console.WriteLine("Insert a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert b:");
            int b = int.Parse(Console.ReadLine());
            int c = a;
            a = b;
            b = c;
            Console.WriteLine("New a:{0}, New b:{1}", a, b);
            Console.ReadKey();
            #endregion
            #region b
            Console.WriteLine("Insert a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert b:");
            int b = int.Parse(Console.ReadLine());
            a ^= b;
            b ^= a;
            a ^= b;
            Console.WriteLine("New a:{0}, New b:{1}", a, b);
            Console.ReadKey();
            #endregion
        }
    }
}
