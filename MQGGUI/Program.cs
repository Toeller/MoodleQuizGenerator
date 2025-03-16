using MoodleQuizGenerator;
namespace MQGGUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            IModel modelZiel = new ModelXML();
            IModel modelQuelle = new ModelCSV();
            IView viewMain = new ViewMain();
            IController controller = new Controller();

            viewMain.ModelQuelle = modelQuelle;
            viewMain.ModelZiel = modelZiel;
           
            Application.Run((Form)viewMain);
        }
    }
}