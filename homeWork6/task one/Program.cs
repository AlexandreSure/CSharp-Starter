using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task_one
{
    //Александр Шкрабов
    //Изменить программу вывода функции так, чтобы можно было передавать функции типа double (double, double). 
    //Продемонстрировать работу на функции с функцией a* x^2 и функцией a* sin(x).
    class Program
    {
        public delegate double Function(double x, double a);
        public static void Table(Function F, double x, double a)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (x <= a)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x, a));
                x += 1;
            }
            Console.WriteLine("---------------------");
        }
        static public double FirstFunction(double x, double a)
        {
            return a * (Math.Pow(x, 2));
        }
        static public double SecondFunction(double x, double a)
        {
            return a*(Math.Sin(x));
        }
        static void Main(string[] args)
        {
            Table(new Function(FirstFunction), -2, 2);
            Table(new Function(SecondFunction), -2, 2);
            Console.ReadKey();
        }
    }
}
