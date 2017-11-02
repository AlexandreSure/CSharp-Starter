using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_three
{
    class Program
    {
        static double MathMethod(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
        static void Main(string[] args)
        {
            #region a
            Console.WriteLine("Insert x1:");
            double x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Insert y1:");
            double y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Insert x2:");
            double x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Insert y2:");
            double y2 = double.Parse(Console.ReadLine());
            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("{0:F2}", r);
            Console.ReadKey();
            #endregion
            #region b
            Console.WriteLine("Insert x1:");
            double x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Insert y1:");
            double y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Insert x2:");
            double x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Insert y2:");
            double y2 = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:F2}", MathMethod(x1, y1, x2, y2));
            Console.ReadKey();
            #endregion
        }
    }
}
