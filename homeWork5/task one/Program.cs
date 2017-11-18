using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace task_one
{
    //Шкрабов Александр
    //Создать программу, которая будет проверять корректность ввода логина.Корректным логином будет строка от 2-х до 10-ти
    //символов, содержащая только буквы или цифры, и при этом цифра не может быть первой.

    //а) без использования регулярных выражений;
    //б) ** с использованием регулярных выражений.
    class Program
    {
        static void Main(string[] args)
        {
            #region a
            //Console.WriteLine("Введите Ваш логин:");
            //string s = Console.ReadLine();
            //char[] c = s.ToCharArray();
            //bool flag = false;
            //if (c.Length >= 2 && c.Length <= 10)
            //{
            //    for (int i = 0; i < c.Length; i++)
            //    {
            //        if (Char.IsLetterOrDigit(c[i]))
            //        {
            //            flag = true;
            //        }
            //        else flag = false;
            //    }
            //    if (!flag || char.IsNumber(c[0]))
            //    {
            //        Console.WriteLine("Логин не может иметь цифру на первом месте или что-либо, кроме букв и цифр.");
            //    }
            //    else Console.WriteLine("Логин корректный.");
            //}
            //else Console.WriteLine("Логин должен содержать от 2-ух до 10-ти букв или цифр.");
            //Console.ReadKey();
            #endregion
            #region b
            Regex Ver = new Regex(@"^[a-zA-Z]{1}[a-zA-Z0-9]{1,9}$");
            Console.WriteLine("Введите ваш логин:");
            string s = Console.ReadLine();
            if (Ver.IsMatch(s))
            {
                Console.WriteLine("Ваш логин корректный.");
            }
            else Console.WriteLine("Ваш логин некорректный.");
            Console.ReadKey();
            #endregion
        }
    }
}
