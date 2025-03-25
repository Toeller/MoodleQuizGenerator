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
        private List<Karteikarte> lernkarteikarten = new List<Karteikarte>();
        private List<Karteikarte> alleKarteikarten = new List<Karteikarte>();
        private int index = 0;
        private bool starup = true;

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
                comboBoxUnterrichtsfach.Text = karteikarte.Unterrichtsfach;
                comboBoxThema.Text = karteikarte.Thema;
                textBoxFach.Text = karteikarte.Fach;
            }
        }

        public List<Karteikarte> Karteikarten
        {
            get => karteikarten;
            set
            {
                karteikarten = value;
                if (buttonNeu.Text!="abbrechen")
                    Index = 0;
                comboBoxUnterrichtsfachFuellen();
                comboBoxThemaFuellen();
                
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
                comboBoxUnterrichtsfach.Enabled = true;
                comboBoxThema.Enabled = true;
                textBoxFach.Enabled = true;
                buttonSpeichern.Text = "speichern";
                buttonNeu.Text = "abbrechen";
            }
            else
            {
                Karteikarte.Vorderseite = textBoxVorderseite.Text;
                Karteikarte.Rueckseite = textBoxRueckseite.Text;
                Karteikarte.Unterrichtsfach = comboBoxUnterrichtsfach.Text;
                Karteikarte.Thema = comboBoxThema.Text;
                Karteikarte.Fach = textBoxFach.Text;

                if (buttonSpeichern.Text == "speichern")
                    controller.einfuegen(Karteikarte);
                else if (buttonSpeichern.Text == "neuanlegen")
                {
                    Karteikarte.Karteikartennummer = -1;
                    Karteikarte.Fach = "1";
                    controller.einfuegen(Karteikarte);
                }
                textBoxVorderseite.Enabled = false;
                textBoxRueckseite.Enabled = false;
                textBoxFach.Enabled = false;
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
            comboBoxUnterrichtsfach_SelectedIndexChanged(this,new EventArgs());
            //comboBoxThema_SelectedIndexChanged(this,new EventArgs());

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
            if (Index < Karteikarten.Count - 1)
            {
                Index++;
                buttonFalsch.Visible = false;
                buttonRichtig.Visible = false;
                buttonRueckseiteZeigen.Visible = true;
                textBoxRueckseite.Visible = false;
            }
            else
            {
                Index = 0;
                radioButtonLesen.Checked = true;
            }
        }

        private void buttonRichtig_Click(object sender, EventArgs e)
        {
            Karteikarte.Fach = (Convert.ToInt32(Karteikarte.Fach) + 1).ToString();
            controller.einfuegen(Karteikarte);
            if (Index < Karteikarten.Count - 1)
            {
                Index++;
                buttonFalsch.Visible = false;
                buttonRichtig.Visible = false;
                buttonRueckseiteZeigen.Visible = true;
                textBoxRueckseite.Visible = false;
            }
            else
            {
                Index = 0;
                radioButtonLesen.Checked = true;
            }
        }

        private void radioButtonEditieren_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonEditieren.Checked)
            {
                comboBoxUnterrichtsfach.Enabled = true;
                comboBoxThema.Enabled = true;
                Karteikarten = alleKarteikarten;
                textBoxRueckseite.Visible = true;

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
                lernkarteikartenLaden();

                comboBoxUnterrichtsfach.Enabled = false;
                comboBoxThema.Enabled = false;

                textBoxRueckseite.Visible = false;

                buttonAnfang.Visible = false;
                buttonZurueck.Visible = false;
                buttonEnde.Visible = false;
                buttonVor.Visible = false;

                buttonSpeichern.Visible = false;
                buttonSuchen.Visible = false;
                buttonLoeschen.Visible = false;
                buttonNeu.Visible = false;

                buttonRueckseiteZeigen.Visible = true;
                buttonFalsch.Visible = false;
                buttonRichtig.Visible = false;

                Index = 0;
            }
        }

        private void lernkarteikartenLaden()
        {
            lernkarteikarten = alleKarteikarten.Where(karteikarte => karteikarte.Unterrichtsfach == comboBoxUnterrichtsfach.Text).ToList();
            lernkarteikarten = lernkarteikarten.Where(karteikarte => karteikarte.Thema == comboBoxThema.Text).ToList();
            Karteikarten = lernkarteikarten;
        }

        private void radioButtonLesen_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonLesen.Checked)
            {
                Karteikarten = alleKarteikarten;
                textBoxRueckseite.Visible = true;

                comboBoxUnterrichtsfach.Enabled = true;
                comboBoxThema.Enabled = true;

                buttonAnfang.Visible = true;
                buttonZurueck.Visible = true;
                buttonEnde.Visible = true;
                buttonVor.Visible = true;

                buttonSpeichern.Visible = false;
                buttonSuchen.Visible = false;
                buttonLoeschen.Visible = false;
                buttonNeu.Visible = false;

                buttonRueckseiteZeigen.Visible = false;
                buttonFalsch.Visible = false;
                buttonRichtig.Visible = false;

                Index = 0;
            }
        }

        private void View_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Process.Start("C:/xampp/xampp_stop.exe");
        }

        private void buttonNeu_Click(object sender, EventArgs e)
        {
            if (buttonNeu.Text != "abbrechen")
            {
                textBoxVorderseite.Text = string.Empty;
                textBoxRueckseite.Text = string.Empty;
                comboBoxUnterrichtsfach.Text = string.Empty;
                comboBoxThema.Text = string.Empty;
                //comboBoxUnterrichtsfachFuellen();
                //comboBoxThemaFuellen();
                textBoxFach.Text = string.Empty;

                textBoxVorderseite.Enabled = true;
                textBoxRueckseite.Enabled = true;
                comboBoxUnterrichtsfach.Enabled = true;
                comboBoxThema.Enabled = true;
                textBoxFach.Enabled = true;
                buttonNeu.Text = "abbrechen";
                buttonSpeichern.Text = "neuanlegen";
            }
            else
            {
                buttonNeu.Text = "neu";
                textBoxVorderseite.Enabled = false;
                textBoxRueckseite.Enabled = false;
                textBoxFach.Enabled = false;
                if (buttonSpeichern.Text == "neuanlegen")
                    Index = Index;
                buttonSpeichern.Text = "ändern";
            }
        }

        private void comboBoxThemaFuellen()
        {
            //comboBoxThema.Items.Clear();
            foreach (Karteikarte k in Karteikarten)
            {
                bool themaGefunden = false;
                foreach (string s in comboBoxThema.Items)
                {
                    if (s == k.Thema)
                    {
                        themaGefunden = true;
                    }
                }
                if (!themaGefunden)
                {
                    comboBoxThema.Items.Add(k.Thema);
                }
            }
        }

        private void comboBoxUnterrichtsfachFuellen()
        {
            //comboBoxUnterrichtsfach.Items.Clear();
            foreach (Karteikarte k in Karteikarten)
            {
                bool unterrichtsfachGefunden = false;
                foreach (string s in comboBoxUnterrichtsfach.Items)
                {
                    if (s == k.Unterrichtsfach)
                    {
                        unterrichtsfachGefunden = true;
                    }
                }
                if (!unterrichtsfachGefunden)
                {
                    comboBoxUnterrichtsfach.Items.Add(k.Unterrichtsfach);
                }
            }
        }

        private void buttonRueckseiteZeigen_Click(object sender, EventArgs e)
        {
            textBoxRueckseite.Visible = true;
            buttonRichtig.Visible = true;
            buttonFalsch.Visible = true;
            buttonRueckseiteZeigen.Visible = false;
        }

        private void comboBoxUnterrichtsfach_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if(buttonNeu.Text=="neu")
                karteikarten = alleKarteikarten.Where(karteikarte => karteikarte.Unterrichtsfach == comboBoxUnterrichtsfach.Text).ToList();
            Karteikarten = karteikarten;
        }

        private void comboBoxThema_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if(buttonNeu.Text=="neu")
                karteikarten=alleKarteikarten.Where(karteikarte =>  karteikarte.Thema == comboBoxThema.Text &&
                                                                    karteikarte.Unterrichtsfach == comboBoxUnterrichtsfach.Text).ToList();
            Karteikarten= karteikarten;
        }

        void IView.anzeigen(List<Karteikarte> karteikarten)
        {
            //Karteikarten.Clear();
            //Karteikarten = karteikarten;
            alleKarteikarten.Clear();
            alleKarteikarten = karteikarten;
            if (starup)
            {
                Karteikarten = karteikarten;
                starup = false;
            }

        }
    }
}
