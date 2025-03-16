using MoodleQuizGenerator;

namespace MQGGUI
{
    public partial class ViewMain : Form, IView
    {
        private IModel modelQuelle;
        private IModel modelZiel;
        public ViewMain()
        {
            InitializeComponent();
        }

        IModel IView.ModelQuelle { set => modelQuelle=value; }
        IController IView.Controller { set => throw new NotImplementedException(); }
        IModel IView.ModelZiel { set => modelZiel=value; }

        void IView.anzeigen(List<Quizfrage> quizfragenListe)
        {
            throw new NotImplementedException();
        }

        void IView.anzeigen(Quizfrage quizfrage)
        {
            throw new NotImplementedException();
        }

        private void textBoxPfad_MouseClick(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //doc = XDocument.Load(ofd.FileName);
                textBoxPfad.Text = Path.GetDirectoryName(ofd.FileName);
                textBoxPraefix.Text = ofd.FileName.Split('\\').Last();
            }

        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            List<Quizfrage> quizfragen = modelQuelle.suchen(new Quizfrage("", "", new List<string>(), new List<string>()), textBoxPraefix.Text, (numericUpDownAnzahlFragen.Value!=5),textBoxPfad.Text);

            // Dateiname der XML-Datei-Ausgabe mit klarem Bezug versehen
            (modelZiel as ModelXML).Path = textBoxPfad.Text+"\\"+textBoxPraefix.Text + ".xml";

            // Kategoriename gleichsetzen mit dem Praefix
            (modelZiel as ModelXML).defineInitialXElement(textBoxPraefix.Text);

            foreach (Quizfrage quizfrage in quizfragen)
            {
                modelZiel.speichern(quizfrage);
            }
        }
    }
}
