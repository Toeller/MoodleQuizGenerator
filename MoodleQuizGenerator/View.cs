
namespace MoodleQuizGenerator
{
    internal class View : IView
    {
        private IModel modelQuelle;
        private IModel modelZiel;
        private IController controller;
        IModel IView.ModelQuelle { set => modelQuelle=value; }
        IController IView.Controller { set => controller=value; }
        IModel IView.ModelZiel { set => modelZiel=value; }

        void IView.anzeigen(List<Quizfrage> quizfragenListe)
        {
            throw new NotImplementedException();
        }

        void IView.anzeigen(Quizfrage quizfrage)
        {
            throw new NotImplementedException();
        }
    }
}