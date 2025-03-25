using System.Runtime.CompilerServices;

namespace MoodleQuizGenerator
{
    public class ModelCSV : IModel
    {
        IController IModel.Controller { set => throw new NotImplementedException(); }
        IView IModel.View { set => throw new NotImplementedException(); }

        void IModel.loeschen(Quizfrage quizfrage)
        {
            throw new NotImplementedException();
        }

        void IModel.speichern(Quizfrage quizfrage)
        {
            throw new NotImplementedException();
        }

        List<Quizfrage> IModel.suchen(Quizfrage quizfrage, string praefix, bool anzahlFragenFix, string path)
        {
            List<Quizfrage> ergebnis= new List<Quizfrage>();
            Quizfrage treffer;

            try
            {
                // Set a variable to the My Documents path.
                //string docPath = ".";
                string docPath = path;
                //Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                var files = Directory.EnumerateFiles(docPath, "*.csv", SearchOption.AllDirectories);
                foreach (string dateiname in files)
                {
                    List<string> list = new List<string>();
                    using (StreamReader r = new StreamReader(dateiname))
                    {
                        string line;
                        while ((line = r.ReadLine()) != null)
                        {
                            list.Add(line);
                        }
                    }

                    int lineNumber = 0;
                    foreach (string line in list)
                    {
                        lineNumber++;
                        // Mit einem Backslash maskierte Semikola bearbeiten
                        string alteredLine=line.Replace("\\;", "&semicolon&");
                        string[] subs = alteredLine.Split(';');
                        for (int i= 0;i < subs.Length;i++)
                        {
                            subs[i]=subs[i].Replace("&semicolon&", ";");
                        }

                        if (subs[0] == "Nr." || subs[0] == "Nr" || subs[0] == "Nummer" || subs[0] == "NR." || subs[0] == "NR")
                        {
                            continue;
                        }

                        if (subs.Length < 6)
                        {
                            Console.WriteLine("Mindestanzahl von 6 Eintraegen pro Zeile nicht gegeben in Datei: "
                                + dateiname + " in Zeile " + Convert.ToString(lineNumber));
                            continue;
                        }

                        if (subs[0] == "")
                        {
                            Console.WriteLine("Fragennummer fehlt in Datei: " 
                                + dateiname + " in Zeile "+ Convert.ToString(lineNumber));
                            continue;
                        }

                        int number;
                        if (int.TryParse(subs[0], out number)==false)
                        {
                            Console.WriteLine("Erster Eintrag in einer Zeile ist keine Fragennummer: " 
                                + dateiname + " in Zeile " + Convert.ToString(lineNumber));
                            //continue;
                        }

                        if (subs[1] == "")
                        {
                            Console.WriteLine("Frage fehlt in einer Zeile der Datei: " 
                                + dateiname + " in Zeile " + Convert.ToString(lineNumber));
                            continue;
                        }

                        if((dateiname.Split(praefix)).Length <= 1)
                        {
                            Console.WriteLine("Dateiname ist nicht korrekt: " 
                                + dateiname + " in Zeile " + Convert.ToString(lineNumber));
                            continue;
                        }

                        if (anzahlFragenFix == true)
                        {
                            if (subs.Length == 12)
                            {

                                bool subsNotEmpty = true;
                                for(int i = 2; i < 12; i++)
                                {
                                    if (subs[i] == "") subsNotEmpty = false;
                                }
                                if(subsNotEmpty==false){
                                    Console.WriteLine("Inhalt fehlt in einer Zeile der Datei: " 
                                        + dateiname + " in Zeile " + Convert.ToString(lineNumber));
                                    continue;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Falsche Anzahl an Argumenten(" + subs.Length + ") in Datei "
                                    + dateiname + " in Zeile " + Convert.ToString(lineNumber));
                            }
                        }

                        if (subs.Length % 2 != 0)
                        {
                            Console.WriteLine("Ungerade Anzahl an Einträgen in einer Zeile der Datei: " 
                                + dateiname + " in Zeile " + Convert.ToString(lineNumber));
                            continue;
                        }
                 
                        bool zweierPaareKonsistent = true;
                        int anzahlSubsPaareGefuellt = 1;
                        for(int i = 0; i < subs.Length / 2 - 1; i++)
                        {
                            if (subs[2 * (i + 1)] == "")
                            {
                                if (subs[2 * (i + 1)+1] != "")
                                {
                                    zweierPaareKonsistent = false;
                                }
                            }
                            if (subs[2 * (i + 1)] != "")
                            {
                                if (subs[2 * (i + 1) + 1] == "")
                                {
                                    zweierPaareKonsistent = false;
                                }
                                else
                                {
                                    anzahlSubsPaareGefuellt++;
                                }
                            }
                        }

                        if (anzahlSubsPaareGefuellt <3)
                        {
                            Console.WriteLine("Zu wenige Antworten in einer Zeile der Datei: " 
                                + dateiname + " in Zeile " + Convert.ToString(lineNumber));
                            continue;
                        }

                        if (zweierPaareKonsistent == false)
                        {
                            Console.WriteLine("Mindestens ein Antwort/Richtig-Oder-Falsch-Paar ist nicht konsistent in einer Zeile der Datei: " 
                                + dateiname + " in Zeile " + Convert.ToString(lineNumber));
                            continue;
                        }

                        bool mindestensEineRichtigeAntwort = false;
                        bool mindestensEineFalscheAntwort = false;
                        for (int i = 0; i < subs.Length / 2 - 1; i++)
                        {
                            if (subs[2 * (i + 1) + 1].ToUpper() == "R")
                            {
                                mindestensEineRichtigeAntwort = true;
                            }
                            if (subs[2 * (i + 1) + 1].ToUpper() == "F")
                            {
                                mindestensEineFalscheAntwort = true;
                            }
                        }
                        if (mindestensEineRichtigeAntwort==false || mindestensEineFalscheAntwort==false)
                        {
                            Console.WriteLine("In einer Zeile fehlt mindestens eine richtige und mindestens eine falsche Antwort in der Datei: " 
                                + dateiname + " in Zeile " + Convert.ToString(lineNumber));
                            continue;
                        }

                        bool antwortenRichtigOderFalsch=true;
                        for (int i = 0; i < subs.Length / 2 - 1; i++)
                        {
                            if(subs[2 * (i + 1) + 1] != "")
                            {
                                if (subs[2 * (i + 1) + 1].ToUpper() != "R" && subs[2 * (i + 1) + 1].ToUpper() != "F")
                                {
                                    antwortenRichtigOderFalsch = false;
                                }
                            }
                        }
                        if (antwortenRichtigOderFalsch == false)
                        {
                            Console.WriteLine("In einer Zeile sind nicht alle Antworten als richtig oder falsch markiert in der Datei: " 
                                + dateiname + " in Zeile " + Convert.ToString(lineNumber));
                            continue;
                        }

                        int rcount = 0;
                        int acount = 0;

                        string fractionR = "0";
                        string fractionF = "0";

                        treffer = new Quizfrage("", "", new List<string>(), new List<string>());
                        treffer.Fragennummer = subs[0];
                        treffer.Frage = subs[1];

                        for (int i = 2; i < subs.Length; i += 2)
                        {
                            if(subs[i] != "")
                            {
                                if (subs[i + 1].ToUpper() == "R")
                                {
                                    rcount++;
                                }
                                acount++;
                            }
                        }

                        fractionR = Convert.ToString(
                                                        Math.Round(
                                                                    (100 / Convert.ToDouble(rcount))
                                                                    , 5
                                                                    )
                                                        , new System.Globalization.CultureInfo("en-US")
                                                    );
                        fractionF = Convert.ToString(
                                                        Math.Round(
                                                                    ((double)-100.0 / ((double)acount - Convert.ToDouble(rcount)))
                                                                    , 5
                                                                    )
                                                        , new System.Globalization.CultureInfo("en-US")
                                                    );

                        for (int i = 2; i < subs.Length; i += 2)
                        {
                            if (subs[i] != "")
                            {
                                treffer.Antworten.Add(subs[i]);
                                if (subs[i + 1].ToUpper() == "R")
                                {
                                    treffer.Fractions.Add(fractionR);
                                }
                                else
                                {
                                    treffer.Fractions.Add(fractionF);
                                }
                                treffer.AnzahlAntworten++;
                            }
                        }

                        ergebnis.Add(treffer);     
                    }
                }

            }
            catch (UnauthorizedAccessException uAEx)
            {
                Console.WriteLine(uAEx.Message);
            }
            catch (PathTooLongException pathEx)
            {
                Console.WriteLine(pathEx.Message);
            }
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Modelcsv");
            //    //Console.WriteLine(files);
            //    Console.WriteLine(ex.Message);
            //}

            return ergebnis;
        }

        List<Quizfrage> IModel.suchen(Quizfrage quizfrage)
        {
            throw new NotImplementedException();
        }

        List<Quizfrage> IModel.suchen(string path)
        {
            throw new NotImplementedException();
        }
    }
}
