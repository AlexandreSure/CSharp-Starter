using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_three
{
    class Fraction
    {
        public int nu; //numerator
        public int de; //denominator
        public Fraction Plus(Fraction b)
        {
            Fraction sum = new Fraction
            {
                nu = b.nu + this.nu,
                de = b.de + this.de
            };
            return sum;
        }
        public Fraction Minus(Fraction b)
        {
            Fraction sum = new Fraction
            {
                nu = b.nu - this.nu,
                de = b.de - this.de
            };
            return sum;
        }
        public Fraction Multi(Fraction b)
        {
            Fraction sum = new Fraction
            {
                nu = b.nu * this.nu,
                de = b.de * this.de
            };
            return sum;
        }
        public Fraction Div(Fraction b)
        {
            Fraction sum = new Fraction
            {
                nu = b.de * this.nu,
                de = b.nu * this.de
            };
            return sum;
        }
        public string FormatFractionToString()
        {
            return nu + "/" + de;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Fraction a = new Fraction
            {
                nu = 6,
                de = 8
            };
            Fraction b = new Fraction
            {
                nu = 3,
                de = 7
            };
            Fraction sum = new Fraction();
            sum = a.Plus(b);
            Console.WriteLine(sum.FormatFractionToString());
            sum = a.Minus(b);
            Console.WriteLine(sum.FormatFractionToString());
            sum = a.Multi(b);
            Console.WriteLine(sum.FormatFractionToString());
            sum = a.Div(b);
            Console.WriteLine(sum.FormatFractionToString());
            Console.ReadKey();
        }
    }
}
