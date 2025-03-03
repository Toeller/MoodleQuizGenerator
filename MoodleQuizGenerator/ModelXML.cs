using System.Runtime.Serialization;
using System;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Numerics;

namespace MoodleQuizGenerator
{
    internal class ModelXML : IModel
    {
        private XDocument doc;
        private IController controller;
        private IView view;
        private string path="dasIsteinTest.xml";
        public string Path { get => path; set => path = value; }
        IController IModel.Controller { set => controller = value; }
        IView IModel.View { set => view = value; }

        void IModel.loeschen(Quizfrage quizfrage)
        {
            throw new NotImplementedException();
        }

        void IModel.speichern(Quizfrage quizfrage)
        {
            

            XComment com = new XComment("question: "+quizfrage.Fragennummer);
            XElement element = new XElement("question",
                new XAttribute("type" , "multichoice"),
                new XElement("name",
                    new XElement("text","Aufgabens")),
                new XElement("questiontext",
                    new XAttribute("format","html"),
                        new XElement("text",
                            new XCData("<p dir=\"ltr\" style=\"text-align: left;\">" +
                                quizfrage.Frage+"</p>"))),
                new XElement("generalfeedback",
                    new XAttribute("format", "html"),
                new XElement("text")),
            new XElement("defaultegrade", "5.0000000"),
            new XElement("penalty","0.0000000"),
            new XElement("hidden","0"),
            new XElement("idnumber"),
            new XElement("single","false"),
            new XElement("shuffleanswers","true"),
            new XElement("answernumbering","none"),
            new XElement("showstandardinstruction","0"),
            new XElement("correctfeedback",
                new XAttribute("format", "html"),
                new XElement("text","Die Antwort ist richtig.")),
            new XElement("partiallycorrectfeedback",
                new XAttribute("format", "html"),
                new XElement("text","Die Antwort ist teilweise richtig.")),
            new XElement("incorrectfeedback",
                new XAttribute("format","html"),
                new XElement("text","Die Antwort ist falsch.")),
            new XElement("shownumcorrect"),
            
            new XElement("answer",
                new XAttribute("fraction",quizfrage.Fraction1),
                new XAttribute("format","html"),
                new XElement("text",
                    new XCData("<p dir=\"ltr\" style=\"text-align: left;\">" +
                        quizfrage.Antwort1+"</p>")),
                new XElement("feedback",
                    new XAttribute("format","html"),
                    new XElement("text"))),
            
            new XElement("answer",
                new XAttribute("fraction",quizfrage.Fraction2),
                new XAttribute("format", "html"),
                new XElement("text", 
                    new XCData("<p dir=\"ltr\" style=\"text-align: left;\">" +
                        quizfrage.Antwort2+"</p>")),
                new XElement("feedback",
                    new XAttribute("format", "html"),
                    new XElement("text"))),

            new XElement("answer",
                new XAttribute("fraction",quizfrage.Fraction3),
                new XAttribute("format", "html"),
                new XElement("text", 
                    new XCData("<p dir=\"ltr\" style=\"text-align: left;\">" +
                        quizfrage.Antwort3+"</p>")),
                new XElement("feedback",
                    new XAttribute("format", "html"),
                    new XElement("text"))),
            new XElement("answer",
                new XAttribute("fraction",quizfrage.Fraction4),
                new XAttribute("format", "html"),
                new XElement("text",
                    new XCData("<p dir=\"ltr\" style=\"text-align: left;\">" +
                        quizfrage.Antwort4+"</p>")),
                new XElement("feedback",
                    new XAttribute("format", "html"),
                    new XElement("text"))),
            new XElement("answer",
                new XAttribute("fraction",quizfrage.Fraction5),
                new XAttribute("format", "html"),
                new XElement("text", 
                    new XCData("<p dir = \"ltr\" style=\"text-align: left;\">" +
                        quizfrage.Antwort5+"</p>")),
                new XElement("feedback",
                    new XAttribute("format", "html"),
                    new XElement("text")))
                   
                );
            doc.Element("quiz").Add(com);
            doc.Element("quiz").Add(element);
            doc.Save(path);


        }

        List<Quizfrage> IModel.suchen(Quizfrage quizfrage)
        {
            //Quizfrage erg = new Quizfrage();
            //List<Quizfrage> erList = new List<Quizfrage>();
            //IEnumerable<XElement> zwischenergebnis = doc.Descendants("Karteikarte");
            //int x = 1;
            //foreach (XElement el in zwischenergebnis)
            //{
            //    erg.Vorderseite = "Hallo";
            //    erg.Rueckseite = "Hello";
            //    erg.Fach = x;
            //    erList.Add(erg);
            //}

            //view.anzeigen(erList);
            List<Quizfrage> ergebnis=new List<Quizfrage>();
            ergebnis.Add(new Quizfrage("", "", "", "", "", "", "", "", "", "", "", ""));
            return ergebnis;

        }

        List<Quizfrage> IModel.suchen(Quizfrage quizfrage, string praefix)
        {
            throw new NotImplementedException();
        }

        public ModelXML()
        {
            //OpenFileDialog ofd = new OpenFileDialog();
            //if (ofd.ShowDialog() == DialogResult.OK)
            //{
            //    doc = XDocument.Load(ofd.FileName);
            //    path = ofd.FileName;
            //}
            //else
            //{
                string nameKategorie = "HabIchMirAusgedacht";
                doc = new XDocument(new XElement("quiz",
                    new XComment("question: 0"),
                    new XElement("question",
                        new XAttribute ("type","category"),
                        new XElement("category",
                            new XElement("text","$course$/top/"+nameKategorie)),
                        new XElement("info",
                            new XAttribute("format","moodle_auto_format"),
                            new XElement("text","Standardkategorie für Fragen, die im Kontext 'Ausdenken' freigegeben sind.")),
                        new XElement("idnumber"))));
            //}
        }
    }
}