using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_one
{
    class Program
    {
        static void Main(string[] args)
        {
            #region a
            Console.WriteLine("Insert your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Insert your surname:");
            string surname = Console.ReadLine();
            Console.WriteLine("Insert your age:");
            string age = Console.ReadLine();
            Console.WriteLine("Insert your height:");
            string height = Console.ReadLine();
            Console.WriteLine("Insert your weight:");
            string weight = Console.ReadLine();
            Console.WriteLine(name + " " + surname + " " + age + " " + height + " " + weight);
            Console.ReadKey();
            #endregion
            #region b
            Console.WriteLine("Insert your name:");
            string name = Console.ReadLine();
            string.Format("Name:{0}", name);
            Console.WriteLine("Insert your surname:");
            string surname = Console.ReadLine();
            string.Format("Surname:{0}", surname);
            Console.WriteLine("Insert your age:");
            string age = Console.ReadLine();
            string.Format("Age:{0} years old", age);
            Console.WriteLine("Insert your height(cm):");
            string height = Console.ReadLine();
            string.Format("Height:{0} cm", height);
            Console.WriteLine("Insert your weight(kg):");
            string weight = Console.ReadLine();
            string.Format("Weight:{0} kg", weight);
            Console.WriteLine("{0} {1} {2} {3} {4}", name, surname, age, height, weight);
            Console.ReadKey();
            #endregion
            #region c
            Console.WriteLine("Insert your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Insert your surname:");
            string surname = Console.ReadLine();
            Console.WriteLine("Insert your age:");
            string age = Console.ReadLine();
            Console.WriteLine("Insert your height(cm):");
            string height = Console.ReadLine();
            Console.WriteLine("Insert your weight(kg):");
            string weight = Console.ReadLine();
            string result = $"{name} {surname} {age} {height} {weight}";
            Console.WriteLine(result);
            Console.ReadKey();
            #endregion
        }
    }
}
