using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task_three
{
    //Подсчитать количество студентов:
    //а) учащихся на 5 и 6 курсах;
    //б)* подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся(частотный
    //массив);
    //в) отсортировать список по возрасту студента;
    //г) ** отсортировать список по курсу и возрасту студента.
    class Student
    {
        public string lastName;
        public string firstName;
        public string univercity;
        public string faculty;
        public int course;
        public string department;
        public int group;
        public string city;
        public int age;
        public Student(string firstName, string lastName, string univercity, string faculty, string department, int
        age, int course, int group, string city)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.univercity = univercity;
            this.faculty = faculty;
            this.department = department;
            this.course = course;
            this.age = age;
            this.group = group;
            this.city = city;
        }
    }
    class Program
    {
        static int MyDelegat(Student st1, Student st2)
        {
            return String.Compare(st1.firstName, st2.firstName);
        }
        static int MyDelegatAge(Student st1, Student st2)
        {
            return st1.age.CompareTo(st2.age);
        }
        static void Main(string[] args)
        {
            int bakalav = 0;
            int magistr = 0;
            int count5 = 0;
            int count6 = 0;
            List<Student> list = new List<Student>();
            DateTime dt = DateTime.Now;
            StreamReader sr = new StreamReader("C:\\CSharp\\students.txt");
            while (!sr.EndOfStream)
            {
                try
                {
                    string[] s = sr.ReadLine().Split(';');
                    list.Add(new Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), int.Parse(s[6]), int.Parse(s[7]), s[8]));
                    if (int.Parse(s[6]) < 5) bakalav++; else magistr++;
                    if (int.Parse(s[6]) == 5) count5++;
                    if (int.Parse(s[6]) == 6) count6++;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Ошибка!ESC - прекратить выполнение программы");
                    if (Console.ReadKey().Key == ConsoleKey.Escape) return;
                }
            }
            sr.Close();
            list.Sort(new Comparison<Student>(MyDelegat));
            list.Sort(new Comparison<Student>(MyDelegatAge));
            Console.WriteLine("Всего студентов:" + list.Count);
            Console.WriteLine("Магистров:{0}", magistr);
            Console.WriteLine("Бакалавров:{0}", bakalav);
            Console.WriteLine("Учатся на 5-ом курсе:{0}", count5);
            Console.WriteLine("Учатся на 6-ом курсе:{0}", count6);
            foreach (var v in list) Console.WriteLine(v.firstName);
            Console.WriteLine(DateTime.Now - dt);
            Console.ReadKey();
        }
    }
}
