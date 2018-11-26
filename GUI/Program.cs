using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;
using BusinessLogic;
using DataAccess;
using Unity.RegistrationByConvention;
using BusinessLogic.Interfaces;

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
                container.RegisterTypes(AllClasses.FromAssembliesInBasePath(), (c) => WithMappings.FromMatchingInterface(c));
                Application.Run(container.Resolve<GUIForm>());
            }
        }
    }
}