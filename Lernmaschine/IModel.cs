namespace Lernmaschine
{
    internal interface IModel
    {
        IView View { set; }
        IController Controller { set; }

        public void einfuegen(Karteikarte karteikarte);
        public void loeschen(Karteikarte karteikarte);
        public void aendern(Karteikarte karteikarte);
        public List<Karteikarte> suchen(Karteikarte karteikarte);
    }
}