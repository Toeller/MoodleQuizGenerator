using System.Diagnostics;

namespace Lernmaschine
{
    public partial class View : Form, IView
    {
        public View()
        {
            InitializeComponent();
            radioButtonEditieren.Checked = true;
        }
        private IModel model;
        private IController controller;
        private Karteikarte karteikarte = new Karteikarte();
        private List<Karteikarte> karteikarten = new List<Karteikarte>();
        private int index = 0;

        IModel IView.Model { set => model = value; }
        IController IView.Controller { set => controller = value; }
        public int Index
        {
            get => index;
            set
            {
                if (Karteikarten.Count >= 0 && value >= 0 && value < Karteikarten.Count)
                {
                    index = value;
                    Karteikarte = Karteikarten[index];
                }
            }
        }

        public Karteikarte Karteikarte
        {
            get => karteikarte;
            set
            {
                karteikarte = value;
                textBoxVorderseite.Text = karteikarte.Vorderseite;
                textBoxRueckseite.Text = karteikarte.Rueckseite;
            }
        }

        public List<Karteikarte> Karteikarten
        {
            get => karteikarten;
            set
            {
                karteikarten = value;
                Index = 0;
            }

        }

        void IView.anzeigen(Karteikarte karteikarte)
        {
            throw new NotImplementedException();
        }

        private void buttonSpeichern_Click(object sender, EventArgs e)
        {
            if (buttonSpeichern.Text == "ändern" && buttonNeu.Text != "abbrechen")
            {
                textBoxVorderseite.Enabled = true;
                textBoxRueckseite.Enabled = true;
                buttonSpeichern.Text = "speichern";
                buttonNeu.Text = "abbrechen";
            }
            else
            {
                Karteikarte.Vorderseite = textBoxVorderseite.Text;
                Karteikarte.Rueckseite = textBoxRueckseite.Text;

                if (buttonSpeichern.Text == "speichern")
                    controller.einfuegen(Karteikarte);
                else if (buttonSpeichern.Text == "neuanlegen")
                {
                    Karteikarte.Karteikartennummer = -1;
                    controller.einfuegen(Karteikarte);
                }
                textBoxVorderseite.Enabled = false;
                textBoxRueckseite.Enabled = false;
                buttonSpeichern.Text = "ändern";
                buttonNeu.Text = "neu";

            }
        }

        private void buttonSuchen_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonLoeschen_Click(object sender, EventArgs e)
        {
            controller.loeschen(Karteikarte);
        }

        private void buttonAnfang_Click(object sender, EventArgs e)
        {
            Index = 0;
        }

        private void buttonZurueck_Click(object sender, EventArgs e)
        {
            if (Index > 0)
            {
                Index--;
            }
        }

        private void buttonVor_Click(object sender, EventArgs e)
        {
            if (Index < Karteikarten.Count - 1)
            {
                Index++;
            }
        }

        private void buttonEnde_Click(object sender, EventArgs e)
        {
            Index = Karteikarten.Count - 1;
        }

        private void buttonFalsch_Click(object sender, EventArgs e)
        {
            Karteikarte.Fach = "1";
            controller.einfuegen(Karteikarte);
            Index++;
        }

        private void buttonRichtig_Click(object sender, EventArgs e)
        {
            Karteikarte.Fach=(Convert.ToInt32(Karteikarte.Fach) + 1).ToString();
            controller.einfuegen(Karteikarte);
            if(Index<Karteikarten.Count-1)
                Index++;
            else
            {
                Index=0;
                radioButtonLesen.Checked=true;
            }
        }

        private void radioButtonEditieren_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonEditieren.Checked)
            {
                buttonAnfang.Visible = true;
                buttonZurueck.Visible = true;
                buttonEnde.Visible = true;
                buttonVor.Visible = true;

                buttonSpeichern.Visible = true;
                buttonSuchen.Visible = true;
                buttonLoeschen.Visible = true;
                buttonNeu.Visible = true;

                buttonFalsch.Visible = false;
                buttonRichtig.Visible = false;
            }
        }

        private void radioButtonLernen_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonLernen.Checked)
            {
                buttonAnfang.Visible = false;
                buttonZurueck.Visible = false;
                buttonEnde.Visible = false;
                buttonVor.Visible = false;

                buttonSpeichern.Visible = false;
                buttonSuchen.Visible = false;
                buttonLoeschen.Visible = false;
                buttonNeu.Visible =false;

                buttonFalsch.Visible = true;
                buttonRichtig.Visible = true;

                Index = 0;
            }
        }

        private void radioButtonLesen_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonLesen.Checked)
            {
                buttonAnfang.Visible = true;
                buttonZurueck.Visible = true;
                buttonEnde.Visible = true;
                buttonVor.Visible = true;

                buttonSpeichern.Visible = false;
                buttonSuchen.Visible = false;
                buttonLoeschen.Visible = false;
                buttonNeu.Visible = false;

                buttonFalsch.Visible = false;
                buttonRichtig.Visible = false;
            }
        }

        private void View_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Process.Start("C:/xampp/xampp_stop.exe");
        }

        private void buttonNeu_Click(object sender, EventArgs e)
        {
            if(buttonNeu.Text != "abbrechen")
            {
                textBoxVorderseite.Text = string.Empty;
                textBoxRueckseite.Text = string.Empty;
                textBoxVorderseite.Enabled = true;
                textBoxRueckseite.Enabled=true;
                buttonNeu.Text = "abbrechen";
                buttonSpeichern.Text = "neuanlegen";
            }
            else
            {
                buttonNeu.Text = "neu";
                textBoxVorderseite.Enabled = false;
                textBoxRueckseite.Enabled = false;
                if(buttonSpeichern.Text== "neuanlegen")
                    Index = Index;
                buttonSpeichern.Text = "ändern";
            }
        }

        void IView.anzeigen(List<Karteikarte> karteikarten)
        {
            this.Karteikarten = karteikarten;
        }
    }
}
