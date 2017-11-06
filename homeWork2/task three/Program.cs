using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_three
{
    class Program
    {
        static void Main(string[] args)
        {
            #region a
            int s = 0;
            while (true)
            {
                int a = int.Parse(Console.ReadLine());
                if (a != 0)
                {
                    if (a % 2 == 1)
                    {
                        s = s + a;
                    }
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("Sum: {0}", s);
            Console.ReadKey();
            #endregion
            #region b
            //int s = 0;
            //int a;
            //do
            //{
            //    a = int.Parse(Console.ReadLine());
            //    if (a > 0 && a % 2 == 1)
            //    {
            //        s += a;
            //    }
            //}
            //while (a != 0);
            //Console.WriteLine(s);
            //Console.ReadKey();
            #endregion
        }
    }
}
