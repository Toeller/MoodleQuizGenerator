namespace MoodleQuizGenerator
{
    public interface IModel
    {
        IController Controller { set; }
        IView View { set; }

        void speichern(Quizfrage quizfrage);
        List<Quizfrage> suchen(Quizfrage quizfrage);
        List<Quizfrage> suchen(Quizfrage quizfrage, string praefix, bool anzahlFragenFix, string path=".");
        List<Quizfrage> suchen(string path);
        void loeschen(Quizfrage quizfrage);
    }
}