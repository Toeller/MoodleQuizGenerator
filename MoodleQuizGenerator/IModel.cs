namespace MoodleQuizGenerator
{
    public interface IModel
    {
        IController Controller { set; }
        IView View { set; }

        void speichern(Quizfrage quizfrage);
        List<Quizfrage> suchen(Quizfrage quizfrage);
        List<Quizfrage> suchen(Quizfrage quizfrage, string praefix, bool anzahlFragenFix);
        void loeschen(Quizfrage quizfrage);
    }
}