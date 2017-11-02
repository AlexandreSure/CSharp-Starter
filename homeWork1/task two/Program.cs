using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_two
{
    class Program
    {
        static void Main(string[] args)
        {
            #region a
            Console.WriteLine("Insert weight(kg):");
            double weight = double.Parse(Console.ReadLine());
            Console.WriteLine("Insert height(m):");
            double height = double.Parse(Console.ReadLine());
            double BMI = weight / (height * height);
            Console.WriteLine(BMI);
            Console.ReadKey();
            #endregion
        }
    }
}
