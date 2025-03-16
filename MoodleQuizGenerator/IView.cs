namespace MoodleQuizGenerator
{
    public interface IView
    {
        IModel ModelQuelle { set; }
        IModel ModelZiel { set; }
        IController Controller { set; }


        void anzeigen(List<Quizfrage> quizfragenListe);
        void anzeigen(Quizfrage quizfrage);
    }
}