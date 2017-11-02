using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_five
{
    class Program
    {
        static void Print(string msg, int x, int y, ConsoleColor foregroundcolor)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = foregroundcolor;
            Console.WriteLine(msg);
        }
        static void Main(string[] args)
        {
            #region a
            string name = "Alexandre";
            string surname = "Shkrabov";
            string city = "Saint-Petersburg";
            Console.WriteLine("My name is {0}\nMy surname is {1}\nI'm from {2}", name, surname, city);
            Console.ReadKey();
            #endregion
            #region b
            string name = "Alexandre";
            string surname = "Shkrabov";
            string city = "Saint-Petersburg";
            int x;
            int y;
            x = Console.WindowWidth / 2 - name.Length / 2;
            y = Console.WindowHeight / 2;
            Console.SetCursorPosition(x, y);
            Console.WriteLine(name);
            x = Console.WindowWidth / 2 - name.Length / 2;
            y = Console.WindowHeight / 2 + 1;
            Console.SetCursorPosition(x, y);
            Console.WriteLine(surname);
            x = Console.WindowWidth / 2 - name.Length / 2;
            y = Console.WindowHeight / 2 + 2;
            Console.SetCursorPosition(x, y);
            Console.WriteLine(city);
            Console.ReadKey();
            #endregion
            #region c
            string name = "Alexandre";
            string surname = "Shkrabov";
            string city = "Saint-Petersburg";
            Print(name, 50, 13, ConsoleColor.DarkGreen);
            Print(surname, 59, 14, ConsoleColor.DarkMagenta);
            Print(city, 66, 15, ConsoleColor.DarkYellow);
            Console.ReadKey();
            #endregion
        }
    }
}
