namespace MoodleQuizGenerator
{
    public class Quizfrage
    {
        private string fragennummer;
        private string frage;
        private List<string> fractions;
        private List<string> antworten;
        int anzahlAntworten;

        public string Fragennummer { get => fragennummer; set => fragennummer = value; }
        public string Frage { get => frage; set => frage = value; }
        public List<string> Antworten { get => antworten; set => antworten = value; }
        public List<string> Fractions { get => fractions; set => fractions = value; }
        public int AnzahlAntworten { get => anzahlAntworten; set => anzahlAntworten = value; }


        public Quizfrage(string fragennummer,string frage,
                         List<string> fractions, List<string> antworten)
        {
            Fragennummer=fragennummer;
            Frage = frage;
            Antworten = antworten;
            Fractions = fractions;
            if (Antworten.Count != Fractions.Count)
            {
                throw new ArgumentException("Anzahl der Antworten und Fractions stimmen nicht überein.");
            }
            AnzahlAntworten = Antworten.Count;
        }

        public Quizfrage() { }
    }
}