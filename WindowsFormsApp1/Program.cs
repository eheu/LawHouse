using BusinessLogic;
using DataAccess;
using System;
using System.Windows.Forms;
using Unity;
using Unity.Injection;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            using (var container = new UnityContainer())
            {
                container.RegisterType<ICaseRepository, CaseRepository>();
                Application.Run(container.Resolve<Form1>());
            }
        }
    }
}
