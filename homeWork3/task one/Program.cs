using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork3
{
    //Шкрабов Александр
    //1. а) Дописать структуру Complex, добавив метод вычитания комплексных чисел.Продемонстрировать работу структуры;

    //   б) Дописать класс Complex, добавив методы вычитания и произведения чисел.Проверить работу класса;
    struct Complex
    {
        public double im;
        public double re;
        public Complex Plus(Complex x)
        {
            Complex y;
            y.im = im + x.im;
            y.re = re + x.re;
            return y;
        }
        public Complex Minus(Complex x)
        {
            Complex y;
            y.im = im - x.im;
            y.re = re - x.re;
            return y;
        }
        public Complex Multi(Complex x)
        {
            Complex y;
            y.im = x.im * re + x.re * im;
            y.re = x.re * re - x.im * im;
            return y;
        }
        public string FormatComplexToString()
        {
            if (im < 0)
            {
                if (re < 0)
                {
                    return "(" + re + ")" + "+" + "(" + im + ")" + "i";
                }
                else
                {
                    return re + "+" + "(" + im + ")" + "i";
                }
            }
            else
            {
                return re + "+" + im + "i";
            }
        }
    }
    class Complex
    {
        public double im;
        public double re;
        public Complex Plus(Complex x)
        {
            Complex y = new Complex
            {
                im = this.im + x.im,
                re = this.re + x.re
            };
            return y;
        }
        public Complex Minus(Complex x)
        {
            Complex y = new Complex
            {
                im = this.im - x.im,
                re = this.re - x.re
            };
            return y;
        }
        public Complex Multi(Complex x)
        {
            Complex y = new Complex()
            {
                im = x.im * this.re + x.re * this.im,
                re = x.re * this.re - x.im * this.im
            };
            return y;
        }
        public string FormatComplexToString()
        {
            if (im < 0)
            {
                if (re < 0)
                {
                    return "(" + re + ")" + "+" + "(" + im + ")" + "i";
                }
                else
                {
                    return re + "+" + "(" + im + ")" + "i";
                }
            }
            else
            {
                return re + "+" + im + "i";
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            #region by structure
            Complex a;
            a.im = 2;
            a.re = 3;
            Complex b;
            b.im = 4;
            b.re = 5;
            Complex c = a.Plus(b);
            Console.WriteLine(c.FormatComplexToString());
            c = a.Minus(b);
            Console.WriteLine(c.FormatComplexToString());
            c = a.Multi(b);
            Console.WriteLine(c.FormatComplexToString());
            Console.ReadKey();
            #endregion
            #region by class
            Complex a = new Complex
            {
                im = 2,
                re = 3
            };
            Complex b = new Complex
            {
                im = 4,
                re = 5
            };
            Complex c = new Complex();
            c = a.Plus(b);
            Console.WriteLine(c.FormatComplexToString());
            c = a.Minus(b);
            Console.WriteLine(c.FormatComplexToString());
            c = a.Multi(b);
            Console.WriteLine(c.FormatComplexToString());
            Console.ReadKey();
            #endregion
        }
    }
}
