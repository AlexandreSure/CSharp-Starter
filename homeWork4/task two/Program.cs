using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task_two
{
    //а) Дописать класс для работы с одномерным массивом.Реализовать конструктор, создающий массив заданной размерности
    //   и заполняющий массив числами от начального значения с заданным шагом.Создать свойство Sum, которые возвращают 
    //   сумму элементов массива, метод Inverse, меняющий знаки у всех элементов массива, Метод Multi, умножающий каждый
    //   элемент массива на определенное число, свойство MaxCount, возвращающее количество максимальных элементов.
    //   В Main продемонстрировать работу класса.
    //б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
    class MyArray
    {
        int[] array;
        public MyArray(int n, int el)
        {
            array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = el;
            }
        }
        public MyArray(string w)
        {
            string[] s = File.ReadAllLines(w);
            array = new int[s.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(s[i]);
            }
        }
        //public MyArray(int n, int min, int max)
        //{
        //    array = new int[n];
        //    Random rnd = new Random();
        //    for (int i = 0; i < n; i++)
        //    {
        //        array[i] = rnd.Next(min, max);
        //    }
        //}
        //заполнение через рандом. Не понял, как создавать два конструктора с одинаковым количеством параметров
        public MyArray(int n, int start, int step)
        {
            array = new int[n];
            n = array.Length;
            array[0] = start;
            for (int i = 1; i < array.Length; i++)
            {
                array[i] = start + step * i;
            }
        }
        public int Middle
        {
            get
            {
                int middle = 0;
                int sum = 0;
                int count = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    sum += array[i];
                    count++;
                }
                middle = sum / count;
                return middle;
            }
        }
        public int Max
        {
            get
            {
                int max = array[0];
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] > max)
                    {
                        max = array[i];
                    }
                }
                return max;
            }
        }
        public int Min
        {
            get
            {
                int min = array[0];
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] < min)
                    {
                        min = array[i];
                    }
                }
                return min;
            }
        }
        public int CountPositive
        {
            get
            {
                int count = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] > 0)
                    {
                        count++;
                    }
                }
                return count;
            }
        }
        public override string ToString()
        {
            string s = string.Empty;
            foreach (int v in array)
            {
                s += v + " ";
            }
            return s;
        }
        public int Sum()
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
        public void Inverse()
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = -array[i];
            }
        }
        public void Multi(int mu)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array[i] * mu;
            }
        }
        public int MaxCount()
        {
            int count = 0;
            int max = array.Max();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    count++;
                }
            }
            return count;
        }
        public int Length
        {
            get
            {
                return array.Length;
            }
        }
        public void WriteFile(string s)
        {
            string[] m = new string[array.Length];
            for (int i = 0; i < m.Length; i++)
            {
                m[i] = array[i].ToString();
            }
            File.WriteAllLines(s, m);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyArray a = new MyArray(5, 10, 5);
            Console.WriteLine(a.ToString());
            Console.WriteLine(a.Sum());
            a.Inverse();
            Console.WriteLine(a.ToString());
            a.Multi(2);
            Console.WriteLine(a.ToString());
            
            Console.WriteLine(a.MaxCount());
            MyArray b = new MyArray("C:\\CSharp\\massive.txt");
            Console.WriteLine(b.ToString());
            b.WriteFile("C:\\CSharp\\massive1.txt");
            Console.ReadKey();
        }
    }
}
