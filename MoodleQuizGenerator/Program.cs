using System.Data;

namespace MoodleQuizGenerator
{
    internal class Program
    {
        private static IModel modelXML = new ModelXML();
        private static IModel modelCSV = new ModelCSV();
        private static IView view = new View();
        private static IController controller = new Controller();
        static void Main(string[] args)
        {
            modelXML.View = view;
            modelXML.Controller = controller;
            view.Model = modelXML;
            view.Controller = controller;
            controller.Model = modelXML;
            controller.View = view;

            string praefix = "Aufgabe";

            if (args.Length > 0)
            {
                Console.WriteLine("Suche nach Dateien mit Praefix:" + args[0]);
                praefix = args[0];
            }
            else
            {
                Console.Write("Praefix: ");
                praefix = Console.ReadLine();
            }
            List<Quizfrage> quizfragen = modelCSV.suchen(new Quizfrage("", "", "", "", "", "", "", "", "", "", "", ""), praefix);

            // Dateiname der XML-Datei-Ausgabe mit klarem Bezug versehen
            (modelXML as ModelXML).Path = praefix + ".xml";

            foreach (Quizfrage quizfrage in quizfragen)
            {
                modelXML.speichern(quizfrage);
            }
             
            Console.WriteLine("Ende!");
            Console.ReadLine();

            
        }
    }
}
