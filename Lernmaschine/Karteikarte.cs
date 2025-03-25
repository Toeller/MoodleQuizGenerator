namespace Lernmaschine
{
    public class Karteikarte
    {
        private int karteikartennummer;
        private string unterrichtsfach;
        private string thema;
        private string fach;
        private string vorderseite;
        private string rueckseite;

        public int Karteikartennummer { get => karteikartennummer; set => karteikartennummer = value; }
        public string Unterrichtsfach { get => unterrichtsfach; set => unterrichtsfach = value; }
        public string Thema { get => thema; set => thema = value; }
        public string Fach { get => fach; set => fach = value; }
        public string Vorderseite { get => vorderseite; set => vorderseite = value; }
        public string Rueckseite { get => rueckseite; set => rueckseite = value; }
    }
}