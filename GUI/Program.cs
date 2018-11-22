using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;
using BusinessLogic;
using DataAccess;

namespace GUI
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
                Application.Run(container.Resolve<GUIForm>());
            }
        }
    }
}
