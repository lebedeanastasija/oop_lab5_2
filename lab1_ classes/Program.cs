using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using MiniPaintAPI;


// static extern bool GetCursorPos(ref Point lp);



namespace lab1__classes
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        /// 
        //[DllImport("mini_paint_api.dll")]
        //static Assembly SampleAssembly = Assembly.LoadFrom("mini_paint_api.dll");
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Figures());
        }
    }
}
