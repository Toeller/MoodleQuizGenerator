namespace Lernmaschine
{
    internal interface IController
    {
        IModel Model { set; }
        IView View { set; }

        public void einfuegen(Karteikarte karteikarte);
        public void loeschen(Karteikarte karteikarte);
        public void aendern(Karteikarte karteikarte);
        public List<Karteikarte> suchen(Karteikarte karteikarte);
    }
}