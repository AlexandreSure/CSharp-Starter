using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_three
{
    //Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.Регистр можно не учитывать.

    //а) с использованием методов C#
    //б) * разработав собственный алгоритм
    class Program
    {
        #region a
        static bool EqualsStrings(string s, string s1)
        {
            char[] c = s.ToCharArray();
            char[] c1 = s1.ToCharArray();
            Array.Sort(c);
            Array.Sort(c1);
            return c.SequenceEqual(c1);
        }
        #endregion
        #region b
        static bool EqualsStrings1(string s, string s1)
        {
            char[] c = s.ToCharArray();
            char[] c1 = s1.ToCharArray();
            if (c.Length == c1.Length)
            {
                for (int i = 0; i < c.Length; i++)
                    for (int j = 0; j < c.Length - 1; j++)
                        if (c[j] > c[j + 1])
                        {
                            var t = c[j];
                            c[j] = c[j + 1];
                            c[j + 1] = t;
                        }
                for (int i = 0; i < c1.Length; i++)
                    for (int j = 0; j < c1.Length - 1; j++)
                        if (c1[j] > c1[j + 1])
                        {
                            var t = c1[j];
                            c1[j] = c1[j + 1];
                            c1[j + 1] = t;
                        }
                bool a = true;
                for (int i = 0; i < c.Length; i++)
                {
                    if (c[i] != c1[i])
                    {
                        a = false;
                        break;
                    }
                }
                return a;
            }
            else return false;
        }
        #endregion
        static void Main(string[] args)
        {

            Console.WriteLine("Введите первую строку:");
            string s = Console.ReadLine();
            Console.WriteLine("Введите вторую строку:");
            string s1 = Console.ReadLine();
            Console.WriteLine(EqualsStrings(s, s1));
            Console.WriteLine(EqualsStrings1(s, s1));
            Console.ReadKey();
        }
    }
}
