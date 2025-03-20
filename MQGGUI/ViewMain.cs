using MoodleQuizGenerator;

namespace MQGGUI
{
    public partial class ViewMain : Form, IView
    {
        private IModel modelQuelle;
        private IModel modelZiel;
        private List<Quizfrage> quizfrageList;
        private Quizfrage aktueleQuizfrage;
        private int index;
        public ViewMain()
        {
            InitializeComponent();
        }

        IModel IView.ModelQuelle { set => modelQuelle = value; }
        IController IView.Controller { set => throw new NotImplementedException(); }
        IModel IView.ModelZiel { set => modelZiel = value; }
        public int Index
        {
            get => index;
            set
            {
                if (value >= 0 && value < quizfrageList.Count)
                {
                    index = value;
                    AktueleQuizfrage = quizfrageList[index];
                }
            }
        }

        public Quizfrage AktueleQuizfrage
        {
            get => aktueleQuizfrage;
            set
            {
                aktueleQuizfrage = value;
                labelFrage.Text = aktueleQuizfrage.Frage;
                if (aktueleQuizfrage.AnzahlAntworten == 5)
                {
                    checkBoxAntwort1.Text = aktueleQuizfrage.Antworten[0];
                    if (double.Parse(aktueleQuizfrage.Fractions[0]) > 0)
                        checkBoxAntwort1.Checked = true;
                    else
                        checkBoxAntwort1.Checked = false;

                    checkBoxAntwort2.Text = aktueleQuizfrage.Antworten[1];
                    if (double.Parse(aktueleQuizfrage.Fractions[1]) > 0)
                        checkBoxAntwort2.Checked = true;
                    else
                        checkBoxAntwort2.Checked = false;

                    checkBoxAntwort3.Text = aktueleQuizfrage.Antworten[2];
                    if (double.Parse(aktueleQuizfrage.Fractions[2]) > 0)
                        checkBoxAntwort3.Checked = true;
                    else
                        checkBoxAntwort3.Checked = false;

                    checkBoxAntwort4.Text = aktueleQuizfrage.Antworten[3];
                    if (double.Parse(aktueleQuizfrage.Fractions[3]) > 0)
                        checkBoxAntwort4.Checked = true;
                    else
                        checkBoxAntwort4.Checked = false;

                    checkBoxAntwort5.Text = aktueleQuizfrage.Antworten[4];
                    if (double.Parse(aktueleQuizfrage.Fractions[4]) > 0)
                        checkBoxAntwort5.Checked = true;
                    else
                        checkBoxAntwort5.Checked = false;
                }
            }

        }

        void IView.anzeigen(List<Quizfrage> quizfragenListe)
        {
            throw new NotImplementedException();
        }

        void IView.anzeigen(Quizfrage quizfrage)
        {
            throw new NotImplementedException();
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            List<Quizfrage> quizfragen = modelQuelle.suchen(new Quizfrage("", "", new List<string>(), new List<string>()), textBoxPraefix.Text, (numericUpDownAnzahlFragen.Value != 5), textBoxPfad.Text);
            this.quizfrageList = quizfragen;
            // Dateiname der XML-Datei-Ausgabe mit klarem Bezug versehen
            (modelZiel as ModelXML).Path = textBoxPfad.Text + "\\" + textBoxPraefix.Text+DateTime.Now.ToString("yyMMdd")+ ".xml";

            // Kategoriename gleichsetzen mit dem Praefix
            (modelZiel as ModelXML).defineInitialXElement("MQGImport" + DateTime.Now.ToString("yyMMdd"));
            int questioncount = 0;
            foreach (Quizfrage quizfrage in quizfragen)
            {
                modelZiel.speichern(quizfrage);
                questioncount++;
            }

            Index = 0;
            labelImportierteFragen.Text = "Importierte Fragen: " + questioncount;
        }

        private void buttonZurueck_Click(object sender, EventArgs e)
        {
            Index--;
        }

        private void buttonVor_Click(object sender, EventArgs e)
        {
            Index++;
        }

        private void buttonPfadwahl_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                textBoxPfad.Text = fbd.SelectedPath;
            }
        }

        private void buttonPraefixwahl_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBoxPraefix.Text = ofd.FileName.Split('\\').Last();
            }
        }

        private void buttonBearbeiten_Click(object sender, EventArgs e)
        {
            if (buttonBearbeiten.Text == "bearbeiten")
            {
                bearbeitenModusEin();

            }
            else
            {
                bearbeitenModusAus();
                

                #region countChecked

                int rcount = 0;
                if (checkBoxAntwort1.Checked)
                    rcount++;
                if (checkBoxAntwort2.Checked)
                    rcount++;
                if (checkBoxAntwort3.Checked)
                    rcount++;
                if (checkBoxAntwort4.Checked)
                    rcount++;
                if (checkBoxAntwort5.Checked)
                    rcount++;

                string fractionR = Convert.ToString(Math.Round(
                    (100 / Convert.ToDouble(rcount)), 5)
                             , new System.Globalization.CultureInfo("en-US"));
                string fractionF = Convert.ToString(Math.Round(
                    ((double)-100.0 / (5 - Convert.ToDouble(rcount))), 5)
                             , new System.Globalization.CultureInfo("en-US"));
                if (checkBoxAntwort1.Checked)
                    aktueleQuizfrage.Fractions[0] = fractionR;
                else
                    aktueleQuizfrage.Fractions[0] = fractionF;

                if (checkBoxAntwort2.Checked)
                    aktueleQuizfrage.Fractions[1] = fractionR;
                else
                    aktueleQuizfrage.Fractions[1] = fractionF;

                if (checkBoxAntwort3.Checked)
                    aktueleQuizfrage.Fractions[2] = fractionR;
                else
                    aktueleQuizfrage.Fractions[2] = fractionF;

                if (checkBoxAntwort4.Checked)
                    aktueleQuizfrage.Fractions[3] = fractionR;
                else
                    aktueleQuizfrage.Fractions[3] = fractionF;

                if (checkBoxAntwort5.Checked)
                    aktueleQuizfrage.Fractions[4] = fractionR;
                else
                    aktueleQuizfrage.Fractions[4] = fractionF;




                #endregion



                //List<Quizfrage> quizfragen = modelQuelle.suchen(new Quizfrage("", "", new List<string>(), new List<string>()), textBoxPraefix.Text, (numericUpDownAnzahlFragen.Value != 5), textBoxPfad.Text);
                //this.quizfrageList = quizfragen;

                // Dateiname der XML-Datei-Ausgabe mit klarem Bezug versehen
                (modelZiel as ModelXML).Path = textBoxPfad.Text + "\\" + textBoxPraefix.Text + ".xml";

                // Kategoriename gleichsetzen mit dem Praefix
                (modelZiel as ModelXML).defineInitialXElement(textBoxPraefix.Text);

                foreach (Quizfrage quizfrage in quizfrageList)
                {
                    modelZiel.speichern(quizfrage);
                }

                //Index = 0;




            }
        }

        private void buttonNeu_Click(object sender, EventArgs e)
        {

        }

        private void bearbeitenModusEin()
        {
            buttonBearbeiten.Text = "speichern";

            fuellenTextBoxen();

            labelFrage.Text = string.Empty;
            textBoxFrage.Visible = true;
            labelFrage.Visible = false;

            checkBoxAntwort1.Text = string.Empty;
            textBoxAntwort1.Visible = true;

            checkBoxAntwort2.Text = string.Empty;
            textBoxAntwort2.Visible = true;

            checkBoxAntwort3.Text = string.Empty;
            textBoxAntwort3.Visible = true;

            checkBoxAntwort4.Text = string.Empty;
            textBoxAntwort4.Visible = true;
                        
            checkBoxAntwort5.Text = string.Empty;
            textBoxAntwort5.Visible = true;

            buttonVor.Visible = false;
            buttonZurueck.Visible = false;

            
        }

        private void bearbeitenFuellenQuizfrage()
        {
            aktueleQuizfrage.Frage = textBoxFrage.Text;
            labelFrage.Text = textBoxFrage.Text;
            aktueleQuizfrage.Antworten[0] = textBoxAntwort1.Text;
            checkBoxAntwort1.Text = textBoxAntwort1.Text;
            aktueleQuizfrage.Antworten[1] = textBoxAntwort2.Text;
            checkBoxAntwort2.Text = textBoxAntwort2.Text;
            aktueleQuizfrage.Antworten[2] = textBoxAntwort3.Text;
            checkBoxAntwort3.Text = textBoxAntwort3.Text;
            
            aktueleQuizfrage.Antworten[3] = textBoxAntwort4.Text;
            checkBoxAntwort4.Text = textBoxAntwort4.Text;
            

            aktueleQuizfrage.Antworten[4] = textBoxAntwort5.Text;
            checkBoxAntwort5.Text = textBoxAntwort5.Text;
        }

        private void fuellenTextBoxen()
        {
            textBoxFrage.Text = labelFrage.Text;
            

            textBoxAntwort1.Text = checkBoxAntwort1.Text;
            

            textBoxAntwort2.Text = checkBoxAntwort2.Text;
            

            textBoxAntwort3.Text = checkBoxAntwort3.Text;
            

            textBoxAntwort4.Text = checkBoxAntwort4.Text;
            

            textBoxAntwort5.Text = checkBoxAntwort5.Text;
            

            
        }


        private void bearbeitenModusAus()
        {
            bearbeitenFuellenQuizfrage();

            buttonBearbeiten.Text = "bearbeiten";
            buttonVor.Visible = true;
            buttonZurueck.Visible = true;

            //aktueleQuizfrage.Frage = textBoxFrage.Text;
            //labelFrage.Text = textBoxFrage.Text;
            textBoxFrage.Text = string.Empty;
            textBoxFrage.Visible = false;
            labelFrage.Visible = true;

            //aktueleQuizfrage.Antworten[0] = textBoxAntwort1.Text;
            //checkBoxAntwort1.Text = textBoxAntwort1.Text;
            textBoxAntwort1.Text = string.Empty;
            textBoxAntwort1.Visible = false;

            //aktueleQuizfrage.Antworten[1] = textBoxAntwort2.Text;
            //checkBoxAntwort2.Text = textBoxAntwort2.Text;
            textBoxAntwort2.Text = string.Empty;
            textBoxAntwort2.Visible = false;

            //aktueleQuizfrage.Antworten[2] = textBoxAntwort3.Text;
            //checkBoxAntwort3.Text = textBoxAntwort3.Text;
            textBoxAntwort3.Text = string.Empty;
            textBoxAntwort3.Visible = false;

            //aktueleQuizfrage.Antworten[3] = textBoxAntwort4.Text;
            //checkBoxAntwort4.Text = textBoxAntwort4.Text;
            textBoxAntwort4.Text = string.Empty;
            textBoxAntwort4.Visible = false;


            //aktueleQuizfrage.Antworten[4] = textBoxAntwort5.Text;
            //checkBoxAntwort5.Text = textBoxAntwort5.Text;
            textBoxAntwort5.Text = string.Empty;
            textBoxAntwort5.Visible = false;

            
        }
    }
}
