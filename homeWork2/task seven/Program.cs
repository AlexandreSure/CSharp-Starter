using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_seven
{
    class Program
    {
        #region a
        static void Recursion(int a, int b)
        {
            Console.Write("{0,1} ", a);
            if (a < b)
            {
                Recursion(a + 1, b);
            }
        }
        static void Main(string[] args)
        {
            int a = 55;
            int b = 255;
            Recursion(a, b);
            Console.ReadKey();
        }
        #endregion
        #region b
        //static void Main(string[] args)
        //{
        //    int a = 13;
        //    int b = 256;
        //    int s = 0;
        //    RecSum(a, b, ref s);
        //    Console.WriteLine(s);
        //    Console.ReadKey();
        //}
        //static int RecSum(int a, int b, ref int s)
        //{
        //    if (a < b)
        //    {
        //        s += a;
        //        RecSum(a + 1, b,ref s);
        //    }
        //    return s;
        //}
        #endregion
    }
}
