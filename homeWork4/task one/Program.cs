using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_one
{   // Шкрабов Александр
    //
    // Дан целочисленный массив из 20 элементов.Элементы массива могут принимать целые значения от –10 000 
    // до 10 000 включительно.Написать программу, позволяющую найти и вывести количество пар элементов массива,
    // в которых хотя бы одно число делится на 3. В данной задаче под парой подразумевается два подряд идущих 
    // элемента массива.Например, для массива из пяти элементов: 6; 2; 9; –3; 6 – ответ: 4.
    class Program
    {
        static void Main(string[] args)
        {
            int[] ar = new int[20];
            Random rnd = new Random();
            for (int i = 0; i < ar.Length; i++)
            {
                ar[i] = rnd.Next(-10000, 10000);
            }
            int count = 0;
            for (int i = 10; i < ar.Length - 1; i++) //Находим пары(leght - 1, т.к. пар на один меньше)
            {
                if (ar[i] % 3 == 0 || ar[i + 1] % 3 == 0)
                {
                    count++;
                }

            }
            Console.WriteLine($"Количество пар: {count}");
            Console.ReadKey();
        }
    }
}
