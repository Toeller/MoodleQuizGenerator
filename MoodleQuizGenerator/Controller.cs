namespace MoodleQuizGenerator
{
    public class Controller : IController
    {
        private IModel model;
        private IView view;
        IModel IController.Model { set => model=value; }
        IView IController.View { set => view=value; }

        void IController.loeschen(Quizfrage quizfrage)
        {
            throw new NotImplementedException();
        }

        void IController.speichern(Quizfrage quizfrage)
        {
            throw new NotImplementedException();
        }

        void IController.suchen(Quizfrage quizfrage)
        {
            throw new NotImplementedException();
        }
    }
}