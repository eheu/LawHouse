using System;
using System.Windows.Forms;
using Unity;
using Unity.RegistrationByConvention;

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