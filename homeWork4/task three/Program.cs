using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task_three
{
    //Решить задачу с логинами из предыдущего урока, только логины и пароли считать из файла в массив.
    class Program
    {
        static bool Verification(string login, string pass)
        {
            string[] ver = File.ReadAllLines("C:\\CSharp\\loginNpass.txt");
            if (login == ver[0])
            {
                if (pass == ver[1])
                {
                    return true;
                }
                return false;
            }
            return false;
        }

        static void Main(string[] args)
        {
            int count = 0;
            do
            {
                Console.WriteLine("Insert login:");
                string login = Console.ReadLine();
                Console.WriteLine("Insert password:");
                string pass = Console.ReadLine();
                if (Verification(login, pass) == true)
                {
                    Console.WriteLine("Welcome {0}", login);
                    break;
                }
                else
                {
                    count++;
                    int attempt = 3 - count;
                    Console.WriteLine("Incorrent login or password, try again. {0} attemps left.", attempt);
                }
            }
            while (count < 3);
            Console.ReadKey();
        }
    }
}
