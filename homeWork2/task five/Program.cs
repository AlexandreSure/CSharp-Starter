using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_five
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert your weight(kg):");
            double weight = double.Parse(Console.ReadLine());
            Console.WriteLine("Insert your height(m):");
            double height = double.Parse(Console.ReadLine());
            double BMI = weight / (height * height);
            double a;
            if(BMI < 18.5)
            {
                a = (24.99 - BMI) * (height * height);
                Console.WriteLine("Your BMI is {0:F2}. You're thin. You need {1:F2} kg more.", BMI, a);
            }
            else if(BMI > 18.5 && BMI < 24.99)
            {
                Console.WriteLine("Your BMI is {0:F2}, it's okay!", BMI);
            }
            else if(BMI > 30)
            {
                a = (BMI - 24.99) * (height * height);
                Console.WriteLine("Your BMI is {0:F2}. You're fat. You need {1:F2} kg less.", BMI, a);
            }
            Console.ReadKey();
        }
    }
}
