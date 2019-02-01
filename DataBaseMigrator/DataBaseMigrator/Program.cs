using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Xpo.DB;
using Models;
using Unity;
using Unity.Resolution;

namespace DataBaseMigrator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var container = DependencyManager<assets>.GetConfiguredContainer())
            {

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(container.Resolve<Form1>(new ParameterOverride("option",AutoCreateOption.DatabaseAndSchema)));
                
            }
        }
    }
}
