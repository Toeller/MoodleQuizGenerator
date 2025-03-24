
namespace Lernmaschine
{
    internal class Controller : IController
    {
        private IModel model;
        private IView view;

        IModel IController.Model { set => model=value; }
        IView IController.View { set => view=value; }

        void IController.aendern(Karteikarte karteikarte)
        {
            throw new NotImplementedException();
        }

        void IController.einfuegen(Karteikarte karteikarte)
        {
            model.einfuegen(karteikarte);
        }

        void IController.loeschen(Karteikarte karteikarte)
        {
            model.loeschen(karteikarte);
        }

        List<Karteikarte> IController.suchen(Karteikarte karteikarte)
        {
            throw new NotImplementedException();
        }
    }
}