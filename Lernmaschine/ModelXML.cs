using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lernmaschine
{
    internal class ModelXML : IModel
    {
        private IView view;
        private IController controller;
        IView IModel.View { set => view=value; }
        IController IModel.Controller { set => controller=value; }

        void IModel.aendern(Karteikarte karteikarte)
        {
            throw new NotImplementedException();
        }

        void IModel.einfuegen(Karteikarte karteikarte)
        {
            throw new NotImplementedException();
        }

        void IModel.loeschen(Karteikarte karteikarte)
        {
            throw new NotImplementedException();
        }

        List<Karteikarte> IModel.suchen(Karteikarte karteikarte)
        {
            throw new NotImplementedException();
        }
    }
}
