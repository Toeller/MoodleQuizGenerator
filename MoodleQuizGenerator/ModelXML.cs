using System.Runtime.Serialization;
using System;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Numerics;

namespace MoodleQuizGenerator
{
    public class ModelXML : IModel
    {
        private XDocument doc;
        private IController controller;
        private IView view;
        private string path="dasIsteinTest.xml";
        private string penalty= "0.0000000";
        private string defaultgrade = "5.0000000";
        public string Path { get => path; set => path = value; }
        IController IModel.Controller { set => controller = value; }
        IView IModel.View { set => view = value; }
        public string Penalty { get => penalty; set => penalty = value; }
        public string Defaultgrade { get => defaultgrade; set => defaultgrade = value; }

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
            new XElement("defaultegrade", Defaultgrade),
            new XElement("penalty", Penalty),
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
            new XElement("shownumcorrect")
                );

            for(int i = 0; i < quizfrage.AnzahlAntworten; i++)
            {
                element.Add(new XElement("answer",
                    new XAttribute("fraction", quizfrage.Fractions[i]),
                    new XAttribute("format", "html"),
                    new XElement("text",
                        new XCData("<p dir = \"ltr\" style=\"text-align: left;\">" +
                            quizfrage.Antworten[i] + "</p>")),
                    new XElement("feedback",
                        new XAttribute("format", "html"),
                        new XElement("text"))));
            }

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
            ergebnis.Add(new Quizfrage("", "", new List<string>(), new List<string>()));
            return ergebnis;

        }

        

        public ModelXML()
        {
            //Ist das Kunst oder kann das weg?
            string nameKategorie = "MQGImport" + DateTime.Now.ToString("yyMMdd");
            defineInitialXElement(nameKategorie);
        }

        public void defineInitialXElement(string nameKategorie)
        {
            doc = new XDocument(new XElement("quiz",
                new XComment("question: 0"),
                new XElement("question",
                    new XAttribute("type", "category"),
                    new XElement("category",
                        new XElement("text", "$course$/top/" + nameKategorie)),
                    new XElement("info",
                        new XAttribute("format", "moodle_auto_format"),
                        new XElement("text", "Standardkategorie für Fragen, die im Kontext 'Ausdenken' freigegeben sind.")),
                    new XElement("idnumber"))));
        }

        List<Quizfrage> IModel.suchen(string path)
        {
            XDocument gefunden = XDocument.Load(path);
            
            List<Quizfrage> result = new List<Quizfrage>();

            Quizfrage erg;

            IEnumerable<XElement> zwischenergebnis = gefunden.Descendants("question").
                                                    Where(e=> e.Attribute("type").Value=="multichoice");
            int x = 1;
            foreach (XElement el in zwischenergebnis)
            {
                erg = new Quizfrage();
                //private string fragennummer;
                //private string frage;
                //private List<string> fractions;
                //private List<string> antworten;
                //int anzahlAntworten;
                erg.Fragennummer = "42";
                string fstring = el.Element("questiontext").Element("text").Value;
                fstring = fstring.Split("<p dir=\"ltr\" style=\"text-align: left;\">")[1];
                fstring = fstring.Split("</p>")[0];
                erg.Frage=fstring;
                //Loop über Antworten (5! ;-) )
                erg.Fractions = new List<string>();
                erg.Antworten= new List<string>();
                for (int i = 0; i < el.Elements("answer").Count(); i++)
                {
                    erg.Fractions.Add(el.Elements("answer").ElementAt(i).Attribute("fraction").Value);
                    string tmpstring = el.Elements("answer").ElementAt(i).Element("text").Value;
                    tmpstring=tmpstring.Split("<p dir = \"ltr\" style=\"text-align: left;\">")[1];
                    tmpstring=tmpstring.Split("</p>")[0];
                    erg.Antworten.Add(tmpstring);
                }
                erg.AnzahlAntworten = erg.Antworten.Count;
                result.Add(erg);
            }

           
            //List<Quizfrage> ergebnis = new List<Quizfrage>();
            //ergebnis.Add(new Quizfrage("", "", new List<string>(), new List<string>()));



            return result;
        }

        List<Quizfrage> IModel.suchen(Quizfrage quizfrage, string praefix, bool anzahlFragenFix, string path)
        {
            throw new NotImplementedException();
        }

        //List<Quizfrage> IModel.suchen(Quizfrage quizfrage, string praefix, bool anzahlFragenFix)
        //{
        //    throw new NotImplementedException();
        //}
    }
}