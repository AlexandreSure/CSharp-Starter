using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

namespace task_four
{
    //В файле могут встречаться номера телефонов, записанные в формате xx-xx-xx, xxx-xxx или xxx-xx-xx.Вывести все номера телефонов, 
    //которые содержатся в файле.
    class Program
    {
        static void Numbers(string path)
        {
            Regex rx = new Regex(@"\d{2}(-\d{2}){2}|\d{3}-\d{3}|\d{3}(-\d{2}){2}");
            string input = File.ReadAllText(path);
            var numbers = rx.Matches(input);
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
            Numbers("C:\\CSharp\\numbers.txt");
            Console.ReadKey();
        }
    }
}
