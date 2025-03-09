namespace MoodleQuizGenerator
{
    public interface IController
    {
        IModel Model { set; }
        IView View { set; }

        void speichern(Quizfrage quizfrage);
        void suchen(Quizfrage quizfrage);
        void loeschen(Quizfrage quizfrage);
    }
}