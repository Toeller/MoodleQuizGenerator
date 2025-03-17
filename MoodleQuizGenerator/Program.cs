using System.Data;
using System.Xml.Linq;

namespace MoodleQuizGenerator
{
    internal class Program
    {
        private static IModel modelZiel = new ModelXML();
        private static IModel modelQuelle = new ModelCSV();
        private static IView view = new View();
        private static IController controller = new Controller();
        static void Main(string[] args)
        {
            modelZiel.View = view;
            modelZiel.Controller = controller;
            view.ModelZiel = modelZiel;
            view.Controller = controller;
            controller.Model = modelZiel;
            controller.View = view;

            string praefix = "Aufgabe";

            // ACHTUNG: Diese Klasse ist rein mit KI erzeugt.
            Kommandozeilenargumente kommandozeilenargumente = new Kommandozeilenargumente(args);

            // Kommandozeilenargument fuer die Abfrage, ob die Anzahl an Quizfragen festgelegt wurde
            bool anzahlFragenFix = true;
            if (kommandozeilenargumente.IstArgumentVorhanden("-f"))
            {
                string anzahlFragenFixStr = kommandozeilenargumente.HoleArgument("-f");
                if (anzahlFragenFixStr.ToLower() == "false")
                {
                    anzahlFragenFix = false;
                }
            }

            if (kommandozeilenargumente.IstArgumentVorhanden("-p"))
            {
                praefix = kommandozeilenargumente.HoleArgument("-p");
                Console.WriteLine("Suche nach Dateien mit Praefix:" + praefix);
            }
            else
            {
                Console.Write("Praefix: ");
                praefix = Console.ReadLine();
            }

            if (kommandozeilenargumente.IstArgumentVorhanden("-y"))
            {
                string penalty = kommandozeilenargumente.HoleArgument("-y");
                (modelZiel as ModelXML).Penalty = penalty;
            }

            if (kommandozeilenargumente.IstArgumentVorhanden("-g"))
            {
                string defaultgrade = kommandozeilenargumente.HoleArgument("-g");
                (modelZiel as ModelXML).Defaultgrade = defaultgrade;
            }


            List<Quizfrage> quizfragen = modelQuelle.suchen(new Quizfrage("", "", new List<string>(), new List<string>()), praefix, anzahlFragenFix);

            // Dateiname der XML-Datei-Ausgabe mit klarem Bezug versehen
            (modelZiel as ModelXML).Path = praefix + ".xml";

            // Kategoriename gleichsetzen mit dem Praefix

            //Überschreibt das setzen im Konstruktor!!!

            (modelXML as ModelXML).defineInitialXElement(praefix);

            foreach (Quizfrage quizfrage in quizfragen)
            {
                modelZiel.speichern(quizfrage);
            }
             
            Console.WriteLine("Ende!");
            Console.ReadLine();

            
        }
    }
}
