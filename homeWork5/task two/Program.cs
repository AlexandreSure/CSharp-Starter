using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace task_two
{
    //Разработать методы для решения следующих задач.Дано сообщение:

    //а) Вывести только те слова сообщения, которые содержат не более чем n букв;
    //б) Удалить из сообщения все слова, которые заканчиваются на заданный символ;
    //в) Найти самое длинное слово сообщения;
    //г) Найти все самые длинные слова сообщения.
    //Постараться разработать класс MyString.
    class Program
    {
        static void A(string s, int n)
        {
            string[] str = s.Split(' ');
            string temp = string.Empty;
            for (int i = 0; i < str.Length; i++)
            {
                temp = str[i].ToString();
                if (n>=temp.Length)
                {
                    Console.WriteLine(temp);
                }
            }
        }
        static string B(string s, string c)
        {
            string[] str = s.Split(' ');
            string temp = string.Empty;
            string snew = string.Empty;
            c = $"{c}$";
            Regex rx = new Regex(@c);
            for (int i = 0; i < str.Length; i++)
            {
                temp = str[i].ToString();
                if (!rx.IsMatch(temp))
                {
                    snew += temp + " ";
                }
            }
            return snew;
        }
        static string C(string s)
        {
            string[] str = s.Split(' ');
            string temp = string.Empty;
            string max = string.Empty;
            for (int i = 0; i < str.Length; i++)
            {
                temp = str[i].ToString();
                if (max.Length < temp.Length)
                {
                    max = temp;
                }
            }
            return max;
        }
        static string D(string s)
        {
            string[] str = s.Split(' ');
            string temp = string.Empty;
            string max = string.Empty;
            string result = string.Empty;
            for (int i = 0; i < str.Length; i++)
            {
                temp = str[i].ToString();
                if (max.Length < temp.Length)
                {
                    max = temp;
                }
            }
            for (int i = 0; i < str.Length; i++)
            {
                temp = str[i].ToString();
                if (max.Length == temp.Length)
                {
                    result = result + " " + temp;
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сообщение:");
            string s = Console.ReadLine();
            Console.WriteLine("Введите n:");
            int n = int.Parse(Console.ReadLine());
            A(s, n);
            Console.WriteLine("Введите символ:");
            string c = Console.ReadLine();
            Console.WriteLine(B(s, c));
            Console.WriteLine(C(s));
            Console.WriteLine(D(s));
            Console.ReadKey();
        }
    }
}
