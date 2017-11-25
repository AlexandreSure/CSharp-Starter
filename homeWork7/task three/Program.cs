using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_three
{
    //Реализовать программу из предыдущего урока с шаблоном документа на отпуск в Windows Forms.Сделать 
    //несколько текстовых полей(TextBox), куда человек вводит данные, а по нажатии кнопки “Сделать”:
    //видит готовое заявление на отпуск.

    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
