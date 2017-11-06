using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_four
{
    class Program
    {
        static bool Verification(string login, string pass, bool a)
        {
            if (login == "root")
            {
                if (pass == "GeekBrains")
                {
                    a = true;
                }
            }
            return a;
        }

        static void Main(string[] args)
        {
            bool a = false;
            int count = 0;
            do
            {
                Console.WriteLine("Insert login:");
                string login = Console.ReadLine();
                Console.WriteLine("Insert password:");
                string pass = Console.ReadLine();
                a = Verification(login, pass, a);
                if (a == true)
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
