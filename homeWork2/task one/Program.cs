using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessonTwo
{
    class Program
    {
        static double MinOfThree(double a, double b, double c)
        {
            if (a<b&&a<c)
            {
                return a;
            }
            else if (b < a && b < c)
            {
                return b;
            }
            else
            {
                return c;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Insert a:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Insert b:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Insert c:");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine(MinOfThree(a, b, c));
            Console.ReadKey();
        }
    }
}
