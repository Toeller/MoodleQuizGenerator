using MoodleQuizGenerator;
using System.Xml.Linq;

namespace MQGMSTest
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            IModel model = new ModelXML();

            //String
            string defaultgrade = "1";
            string penalty = "2";
            string nameKategorie = "MQGImport" + DateTime.Now.ToString("yyMMdd");


            string fragenummer = "42";
            string frage = "Was ist die Antwort auf alle und so?";
            List<string> fractions = new List<string>();
            List<string> antworten = new List<string>();

            fractions.Add("1");
            fractions.Add("2");
            fractions.Add("3");
            fractions.Add("4");
            fractions.Add("5");

            antworten.Add("Antworttext 1");
            antworten.Add("Antworttext 2");
            antworten.Add("Antworttext 3");
            antworten.Add("Antworttext 4");
            antworten.Add("Antworttext 5");

            Quizfrage quizfrage = new Quizfrage(fragenummer, frage, fractions, antworten);


            XDocument expected = new XDocument(new XElement("quiz",
                new XComment("question: 0"),
                new XElement("question",
                    new XAttribute("type", "category"),
                    new XElement("category",
                        new XElement("text", "$course$/top/" + nameKategorie)),
                    new XElement("info",
                        new XAttribute("format", "moodle_auto_format"),
                        new XElement("text", "Standardkategorie für Fragen, die im Kontext 'Ausdenken' freigegeben sind.")),
                    new XElement("idnumber"))));

            XComment com = new XComment("question: " + quizfrage.Fragennummer);
            XElement element = new XElement("question",
                new XAttribute("type", "multichoice"),
                new XElement("name",
                    new XElement("text", "Aufgabens")),
                new XElement("questiontext",
                    new XAttribute("format", "html"),
                        new XElement("text",
                            new XCData("<p dir=\"ltr\" style=\"text-align: left;\">" +
                                quizfrage.Frage + "</p>"))),
                new XElement("generalfeedback",
                    new XAttribute("format", "html"),
                new XElement("text")),
            new XElement("defaultegrade", defaultgrade),
            new XElement("penalty", penalty),
            new XElement("hidden", "0"),
            new XElement("idnumber"),
            new XElement("single", "false"),
            new XElement("shuffleanswers", "true"),
            new XElement("answernumbering", "none"),
            new XElement("showstandardinstruction", "0"),
            new XElement("correctfeedback",
                new XAttribute("format", "html"),
                new XElement("text", "Die Antwort ist richtig.")),
            new XElement("partiallycorrectfeedback",
                new XAttribute("format", "html"),
                new XElement("text", "Die Antwort ist teilweise richtig.")),
            new XElement("incorrectfeedback",
                new XAttribute("format", "html"),
                new XElement("text", "Die Antwort ist falsch.")),
            new XElement("shownumcorrect")
                );

            for (int i = 0; i < quizfrage.AnzahlAntworten; i++)
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

            expected.Element("quiz").Add(com);
            expected.Element("quiz").Add(element);

            // Act


            (model as ModelXML).Defaultgrade = defaultgrade;
            (model as ModelXML).Penalty = penalty;
            model.speichern(quizfrage);

            // Assert
            XDocument actual = XDocument.Load("dasIsteinTest.xml");
            Assert.AreEqual(expected.ToString(), actual.ToString(), "XML was not created correctly");

        }
    }
}
