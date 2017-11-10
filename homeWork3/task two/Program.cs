using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_two
{
    class Program
    {
        static void Main(string[] args)
        {
            #region a
            //bool b;
            //int a;
            //int res = 0;
            //string digit;
            //string s = string.Empty;
            //do
            //{
            //    digit = Console.ReadLine();
            //    b = int.TryParse(digit, out a);
            //    if (a > 0 && a % 2 == 1)
            //    {
            //        s += " " + a;
            //        res += a;
            //    }
            //}
            //while (a != 0);
            //Console.Clear();
            //Console.WriteLine($"Нечетные числа: {s}");
            //Console.WriteLine($"Их сумма: {res}");
            //Console.ReadKey();
            #endregion
            #region b
            int a = 0;
            int res = 0;
            string s = string.Empty;
            do
            {
                try
                {
                    a = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                if (a > 0 && a % 2 == 1)
                {
                    s += " " + a;
                    res += a;
                }
            }
            while (a != 0);
            Console.Clear();
            Console.WriteLine($"Нечетные числа: {s}");
            Console.WriteLine($"Их сумма: {res}");
            Console.ReadKey();
            #endregion
        }
    }
}
