using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task_four
{
    //а)Реализовать класс для работы с двумерным массивом.Реализовать конструктор, заполняющий массив случайными числами.
    //  Создать методы, которые возвращают сумму всех элементов массива, сумму всех элементов массива больше заданного,
    //  свойство, возвращающее минимальный элемент массива, свойство, возвращающее максимальный элемент массива, метод,
    //  возвращающий номер максимального элемента массива(через параметры, используя модификатор ref или out)

    //б)Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
    class DoubleArray
    {
        int[,] array;
        private DoubleArray() { }
        public DoubleArray(int q, int p, int min, int max)
        {
            array = new int[q, p];
            Random rnd = new Random();
            for (int i = 0; i < q; i++)
            {
                for (int j = 0; j < p; j++)
                {
                    array[i, j] = rnd.Next(min, max);
                }
            }
        }
        public int Sum()
        {
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sum += array[i, j];
                }
            }
            return sum;
        }
        public int Sum(int a)
        {
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i,j] > a)
                    {
                        sum += array[i, j];
                    }
                }
            }
            return sum;
        }//сумма элементов больше заданного
        public int Min
        {
            get
            {
                int min = array[0, 0];
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        if (min > array[i,j])
                        {
                            min = array[i, j];
                        }
                    }
                }
                return min;
            }
        }
        public int Max
        {
            get
            {
                int max = array[0, 0];
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        if (max < array[i, j])
                        {
                            max = array[i, j];
                        }
                    }
                }
                return max;
            }
        }
        public string Indexer(out int index0, out int index1)
        {
            string index = string.Empty;
            index0 = 0;
            index1 = 0;
            int max = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (max < array[i, j])
                    {
                        max = array[i, j];
                    }
                }
            }
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (max == array[i, j])
                    {
                        index0 = i;
                        index1 = j;
                        index = "[" + i + "," + j + "]";
                    }
                }
            }
            return index;
        }
        //public void Indexer(out int imax, out int jmax)
        //{
        //    imax = 0;
        //    jmax = 0;
        //    int max = array[0, 0];
        //    for (int i = 0; i < array.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < array.GetLength(1); j++)
        //        {
        //            if (max < array[i, j])
        //            {
        //                max = array[i, j];
        //            }
        //        }
        //    }
        //    for (int i = 0; i < array.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < array.GetLength(1); j++)
        //        {
        //            if (max == array[i, j])
        //            {
        //                imax = i;
        //                jmax = j;
        //            }
        //        }
        //    }
        //}
        public int GetLenght0
        {
            get
            {
                return array.GetLength(0);
            }
        }
        public int GetLenght1
        {
            get
            {
                return array.GetLength(1);
            }
        }
        public void Print()
        {
            foreach (int a in array)
            {
                Console.WriteLine(a);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DoubleArray array = new DoubleArray(4, 6, -100, 100);
            array.Print();
            Console.WriteLine("Sum: {0}", array.Sum());
            Console.WriteLine("Sum2: {0}", array.Sum(55));
            Console.WriteLine(array.Min);
            Console.WriteLine(array.Max);
            int index0;
            int index1;
            Console.WriteLine(array.Indexer(out index0, out index1));
            //int imax;
            //int jmax;
            //array.Indexer(out imax, out jmax);
            //Console.WriteLine($"[{imax},{jmax}]");
            Console.ReadKey();
        }
    }
}
