using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_six
{
    class Program
    {
        static int SumDigits(int N)
        {
            int d, s = 0;
            while(N != 0)
            {
                d = N % 10;
                s = s + d;
                N = N / 10;
            }
            return s;
        }
        static bool GoodDigit(int N, int s)
        {
            {
                return N % s == 0;
            }
        }
        static void Main(string[] args)
        {
            int N = 1;
            int count = 0;
            DateTime start = DateTime.Now;
            while (N <= 10000000)
            { 
                bool a = GoodDigit(N, SumDigits(N));
                if(a == true)
                {
                    count++;
                }
                N++;
            }
            DateTime finish = DateTime.Now;
            Console.WriteLine("Number of 'good' digits:{0}", count);
            Console.WriteLine("Time for it:{0}", finish - start);
            Console.ReadKey();
        }
    }
}
