using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;

namespace Lernmaschine
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>

        private static IView view;
        private static IController controller;
        private static IModel model;

        [STAThread]
        static void Main()
        {
            //Process.Start("C:/xampp/xampp_start.exe");

            ApplicationConfiguration.Initialize();
            model = new Model();
            view = new View();
            controller = new Controller();

            model.View = view;
            model.Controller = controller;

            view.Model = model;
            view.Controller = controller;

            controller.View = view;
            controller.Model = model;
            Application.Run((Form)view);
        }
    }
}