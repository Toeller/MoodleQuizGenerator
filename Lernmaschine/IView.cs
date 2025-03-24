namespace Lernmaschine
{
    internal interface IView
    {
        IModel Model { set; }
        IController Controller { set; }

        void anzeigen(Karteikarte karteikarte);
        void anzeigen(List<Karteikarte> karteikarten);
    }
}