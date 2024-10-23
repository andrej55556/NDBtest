using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NDBtest
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Users());
            //Application.Run(new Form2(2));
            //Application.Run(new Keys());
            //Application.Run(new Variants());
            //Application.Run(new NotKeys());
            //Application.Run(new NotKeysView());
            //Application.Run(new KeyAtr());
            //Application.Run(new FD());
            Application.Run(new LoginForm());
            //Application.Run(new TestForm("C:\\Users\\Таня\\source\\repos\\NDBtest\\NDBtest\\bin\\Debug\\Решения студентов\\-_Коттеджи (Попытка № 12).xlsx"));
        }
    }
}
