using MoodleQuizGenerator;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;


namespace MQGGUI
{
    public partial class ViewMain : Form, IView
    {
        private IModel modelQuelle;
        private IModel modelZiel;
        private List<Quizfrage> quizfrageList = [];
        private CheckBox[] checkBoxes;
        private TextBox[] textBoxes;
        private Quizfrage aktuelleQuizfrage;
        private int index;
        private ViewImport viewImportDialog;
        public ViewMain()
        {
            InitializeComponent();
            viewImportDialog = new ViewImport();
            checkBoxes = [checkBoxAntwort1, checkBoxAntwort2, checkBoxAntwort3, checkBoxAntwort4, checkBoxAntwort5];
            textBoxes = [textBoxAntwort1, textBoxAntwort2, textBoxAntwort3, textBoxAntwort4, textBoxAntwort5];
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
                    AktuelleQuizfrage = quizfrageList[index];
                }
            }
        }

        public Quizfrage AktuelleQuizfrage
        {
            get => aktuelleQuizfrage;
            set
            {
                aktuelleQuizfrage = value;
                groupBoxVorschau.Text = (index + 1).ToString() + "/" + this.quizfrageList.Count.ToString();
                labelFrage.Text = aktuelleQuizfrage.Frage;
                if (aktuelleQuizfrage.AnzahlAntworten <= 5)
                {
                    for (int i = 0; i < checkBoxes.Length; i++)
                    {
                        CheckBox checkBox = checkBoxes[i];
                        if (aktuelleQuizfrage.Antworten.Count > i)
                        {
                            checkBox.Text = aktuelleQuizfrage.Antworten[i];
                            if (double.Parse(aktuelleQuizfrage.Fractions[i]) > 0)
                                checkBox.Checked = true;
                            else
                                checkBox.Checked = false;
                        }
                    }
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
            if (viewImportDialog.ShowDialog(this) == DialogResult.OK)
            {
                textBoxPraefix.Text = viewImportDialog.textBoxPraefix.Text;
                textBoxArbeitspfad.Text = viewImportDialog.textBoxPfad.Text;

                List<Quizfrage> quizfragen = modelQuelle.suchen(new Quizfrage("", "", new List<string>(), new List<string>()), textBoxPraefix.Text, (numericUpDownAnzahlFragen.Value != 5), textBoxArbeitspfad.Text);
                this.quizfrageList = quizfragen;
                // Dateiname der XML-Datei-Ausgabe mit klarem Bezug versehen
                (modelZiel as ModelXML).Path = textBoxArbeitspfad.Text + "\\" + textBoxPraefix.Text + DateTime.Now.ToString("yyMMdd") + ".xml";

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
        }

        private void buttonZurueck_Click(object sender, EventArgs e)
        {
            Index--;
        }

        private void buttonVor_Click(object sender, EventArgs e)
        {
            Index++;
        }

        private void buttonBearbeiten_Click(object sender, EventArgs e)
        {
            if (buttonBearbeiten.Text == "bearbeiten")
            {
                fuellenTextBoxen();
                bearbeitenModusEin();

            }
            else
            {
                bearbeitenFuellenQuizfrage();
                bearbeitenModusAus();


                #region countChecked

                int rcount = 0;

                foreach (CheckBox checkBox in checkBoxes)
                {
                    if (checkBox.Checked)
                        rcount++;
                }

                string fractionR = Convert.ToString(Math.Round(
                    (100 / Convert.ToDouble(rcount)), 5)
                             , new System.Globalization.CultureInfo("en-US"));
                string fractionF = Convert.ToString(Math.Round(
                    ((double)-100.0 / (5 - Convert.ToDouble(rcount))), 5)
                             , new System.Globalization.CultureInfo("en-US"));

                for (int i = 0; i < checkBoxes.Length; i++)
                {
                    CheckBox checkBox = checkBoxes[i];
                    if (checkBox.Checked)
                        aktuelleQuizfrage.Fractions[i] = fractionR;
                    else
                        aktuelleQuizfrage.Fractions[i] = fractionF;
                }

                #endregion

                //Dateiname der XML - Datei - Ausgabe mit klarem Bezug versehen
                (modelZiel as ModelXML).Path = textBoxArbeitspfad.Text + "\\" + textBoxPraefix.Text.Split("2")[0] + DateTime.Now.ToString("yyMMdd") + ".xml";

                // Kategoriename gleichsetzen mit dem Praefix
                (modelZiel as ModelXML).defineInitialXElement("MQGImport" + DateTime.Now.ToString("yyMMdd"));
                int questioncount = 0;
                foreach (Quizfrage quizfrage in quizfrageList)
                {
                    modelZiel.speichern(quizfrage);
                    questioncount++;
                }

                //Index = 0;
                labelImportierteFragen.Text = "Gespeicherte Fragen: " + questioncount;
            }
        }

        private void buttonNeu_Click(object sender, EventArgs e)
        {
            if (buttonNeu.Text != "speichern")
            {
                buttonBearbeiten.Enabled = false;
                buttonNeu.Text = "speichern";
                bearbeitenModusEin();
                foreach (CheckBox checkBox in checkBoxes)
                {
                    checkBox.Checked = false;
                }
            }
            else
            {
                buttonNeu.Text = "neu..";
                Quizfrage quizfrage = new Quizfrage();
                quizfrage.AnzahlAntworten = 5;
                //quizfrage.Antworten.Clear();
                quizfrage.Fragennummer = "4711";
                quizfrage.Frage = textBoxFrage.Text;
                quizfrage.Antworten = new List<string>();
                foreach (CheckBox checkBox in checkBoxes)
                {
                    quizfrage.Antworten.Add(checkBox.Text);
                }


                quizfrage.Fractions = new List<string>();
                int rcount = 0;
                foreach (CheckBox checkBox in checkBoxes)
                {
                    if (checkBox.Checked)
                        rcount++;
                }

                string fractionR = Convert.ToString(Math.Round(
                    (100 / Convert.ToDouble(rcount)), 5)
                             , new System.Globalization.CultureInfo("en-US"));
                string fractionF = Convert.ToString(Math.Round(
                    ((double)-100.0 / (5 - Convert.ToDouble(rcount))), 5)
                             , new System.Globalization.CultureInfo("en-US"));

                foreach (CheckBox checkBox in checkBoxes)
                {
                    if (checkBox.Checked)
                        quizfrage.Fractions.Add(fractionR);
                    else
                        quizfrage.Fractions.Add(fractionF);
                }

                quizfrageList.Add(quizfrage);

                // Dateiname der XML-Datei-Ausgabe mit klarem Bezug versehen
                (modelZiel as ModelXML).Path = textBoxArbeitspfad.Text + "\\" + textBoxPraefix.Text.Split("2")[0] + DateTime.Now.ToString("yyMMdd") + ".xml";

                // Kategoriename gleichsetzen mit dem Praefix
                (modelZiel as ModelXML).defineInitialXElement("MQGImport" + DateTime.Now.ToString("yyMMdd"));
                int questioncount = 0;
                foreach (Quizfrage qf in quizfrageList)
                {
                    modelZiel.speichern(qf);
                    questioncount++;
                }

                Index = 0;
                labelImportierteFragen.Text = "Gespeicherte Fragen: " + questioncount;

                buttonBearbeiten.Enabled = true;
                bearbeitenModusAus();

            }

        }

        private void bearbeitenModusEin()
        {
            buttonBearbeiten.Text = "speichern";

            labelFrage.Text = string.Empty;
            textBoxFrage.Visible = true;
            labelFrage.Visible = false;

            for (int i = 0; i < checkBoxes.Length; i++)
            {
                CheckBox checkBox = checkBoxes[i];
                TextBox textBox = textBoxes[i];

                checkBox.Text = string.Empty;
                textBox.Visible = true;
            }

            buttonVor.Visible = false;
            buttonZurueck.Visible = false;
        }

        private void bearbeitenFuellenQuizfrage()
        {
            aktuelleQuizfrage.Frage = textBoxFrage.Text;
            labelFrage.Text = textBoxFrage.Text;

            for (int i = 0; i < checkBoxes.Length; i++)
            {
                CheckBox checkBox = checkBoxes[i];
                TextBox textBox = textBoxes[i];

                aktuelleQuizfrage.Antworten[i] = textBox.Text;
                checkBox.Text = textBox.Text;
            }
        }

        private void fuellenTextBoxen()
        {
            textBoxFrage.Text = labelFrage.Text;

            for (int i = 0; i < checkBoxes.Length; i++)
            {
                CheckBox checkBox = checkBoxes[i];
                TextBox textBox = textBoxes[i];
                textBox.Text = checkBox.Text;
            }
        }


        private void bearbeitenModusAus()
        {
            buttonBearbeiten.Text = "bearbeiten";
            buttonVor.Visible = true;
            buttonZurueck.Visible = true;

            textBoxFrage.Text = string.Empty;
            textBoxFrage.Visible = false;
            labelFrage.Visible = true;

            foreach (TextBox textBox in textBoxes)
            {
                textBox.Text = string.Empty;
                textBox.Visible = false;
            }
        }

        private void buttonXMLOeffenen_Click(object sender, EventArgs e)
        {
            //List<Quizfrage> quizfragen = modelZiel.suchen(new Quizfrage("", "", new List<string>(), new List<string>()), textBoxPraefix.Text, (numericUpDownAnzahlFragen.Value != 5), textBoxArbeitspfad.Text);
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                List<Quizfrage> quizfragen = modelZiel.suchen(ofd.FileName);
                string[] fileNameSplitted = ofd.FileName.Split("\\");
                textBoxArbeitspfad.Text = String.Join("\\", fileNameSplitted.Take(fileNameSplitted.Count() - 1).ToArray());
                textBoxPraefix.Text = fileNameSplitted.Last();

                this.quizfrageList = quizfragen;

                Index = 0;
                labelImportierteFragen.Text = "Geöffnete Fragen: " + quizfrageList.Count;
            }
        }

        private void buttonLoeschen_Click(object sender, EventArgs e)
        {
            quizfrageList.RemoveAt(index);
            (modelZiel as ModelXML).Path = textBoxArbeitspfad.Text + "\\" + textBoxPraefix.Text.Split("2")[0] + DateTime.Now.ToString("yyMMdd") + ".xml";

            // Kategoriename gleichsetzen mit dem Praefix
            (modelZiel as ModelXML).defineInitialXElement("MQGImport" + DateTime.Now.ToString("yyMMdd"));
            int questioncount = 0;
            foreach (Quizfrage qf in quizfrageList)
            {
                modelZiel.speichern(qf);
                questioncount++;
            }

            Index = 0;
            labelImportierteFragen.Text = "Fragen: " + questioncount;
        }

        private void buttonNeuXML_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            sfd.FilterIndex = 1;
            sfd.RestoreDirectory = true;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string[] fileNameSplitted = sfd.FileName.Split("\\");
                textBoxArbeitspfad.Text = String.Join("\\", fileNameSplitted.Take(fileNameSplitted.Count() - 1).ToArray());
                textBoxPraefix.Text = fileNameSplitted.Last().Replace(".xml", "");
            }
        }
    }
}
