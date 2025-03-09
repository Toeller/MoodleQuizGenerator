namespace MoodleQuizGenerator
{
    public interface IView
    {
        IModel Model { set; }
        IController Controller { set; }


        void anzeigen(List<Quizfrage> quizfragenListe);
        void anzeigen(Quizfrage quizfrage);
    }
}