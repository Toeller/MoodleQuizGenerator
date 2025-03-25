namespace MQGGUI
{
    partial class ViewMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBoxPraefix = new TextBox();
            label2 = new Label();
            numericUpDownAnzahlFragen = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            textBoxPenalty = new TextBox();
            textBoxDefaultgrade = new TextBox();
            label5 = new Label();
            textBoxPfad = new TextBox();
            buttonImport = new Button();
            groupBoxVorschau = new GroupBox();
            buttonNeu = new Button();
            buttonLoeschen = new Button();
            buttonBearbeiten = new Button();
            textBoxAntwort5 = new TextBox();
            textBoxAntwort4 = new TextBox();
            textBoxAntwort3 = new TextBox();
            textBoxAntwort2 = new TextBox();
            textBoxAntwort1 = new TextBox();
            textBoxFrage = new TextBox();
            buttonVor = new Button();
            buttonZurueck = new Button();
            checkBoxAntwort5 = new CheckBox();
            checkBoxAntwort4 = new CheckBox();
            checkBoxAntwort3 = new CheckBox();
            checkBoxAntwort2 = new CheckBox();
            checkBoxAntwort1 = new CheckBox();
            labelFrage = new Label();
            buttonPfadwahl = new Button();
            buttonPraefixwahl = new Button();
            labelImportierteFragen = new Label();
            buttonXMLOeffenen = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAnzahlFragen).BeginInit();
            groupBoxVorschau.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 76);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 0;
            label1.Text = "Präfix";
            // 
            // textBoxPraefix
            // 
            textBoxPraefix.Location = new Point(12, 94);
            textBoxPraefix.Name = "textBoxPraefix";
            textBoxPraefix.Size = new Size(292, 23);
            textBoxPraefix.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 141);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 2;
            label2.Text = "Anzahl Fragen";
            // 
            // numericUpDownAnzahlFragen
            // 
            numericUpDownAnzahlFragen.Location = new Point(12, 159);
            numericUpDownAnzahlFragen.Name = "numericUpDownAnzahlFragen";
            numericUpDownAnzahlFragen.Size = new Size(120, 23);
            numericUpDownAnzahlFragen.TabIndex = 4;
            numericUpDownAnzahlFragen.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(138, 141);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 5;
            label3.Text = "penalty";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(244, 141);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 6;
            label4.Text = "defaultgrade";
            // 
            // textBoxPenalty
            // 
            textBoxPenalty.Location = new Point(138, 159);
            textBoxPenalty.Name = "textBoxPenalty";
            textBoxPenalty.Size = new Size(100, 23);
            textBoxPenalty.TabIndex = 7;
            // 
            // textBoxDefaultgrade
            // 
            textBoxDefaultgrade.Location = new Point(244, 158);
            textBoxDefaultgrade.Name = "textBoxDefaultgrade";
            textBoxDefaultgrade.Size = new Size(100, 23);
            textBoxDefaultgrade.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 9);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 9;
            label5.Text = "Pfad";
            // 
            // textBoxPfad
            // 
            textBoxPfad.Location = new Point(12, 27);
            textBoxPfad.Name = "textBoxPfad";
            textBoxPfad.Size = new Size(469, 23);
            textBoxPfad.TabIndex = 10;
            // 
            // buttonImport
            // 
            buttonImport.Location = new Point(12, 199);
            buttonImport.Name = "buttonImport";
            buttonImport.Size = new Size(100, 23);
            buttonImport.TabIndex = 11;
            buttonImport.Text = "importieren";
            buttonImport.UseVisualStyleBackColor = true;
            buttonImport.Click += buttonImport_Click;
            // 
            // groupBoxVorschau
            // 
            groupBoxVorschau.Controls.Add(buttonNeu);
            groupBoxVorschau.Controls.Add(buttonLoeschen);
            groupBoxVorschau.Controls.Add(buttonBearbeiten);
            groupBoxVorschau.Controls.Add(textBoxAntwort5);
            groupBoxVorschau.Controls.Add(textBoxAntwort4);
            groupBoxVorschau.Controls.Add(textBoxAntwort3);
            groupBoxVorschau.Controls.Add(textBoxAntwort2);
            groupBoxVorschau.Controls.Add(textBoxAntwort1);
            groupBoxVorschau.Controls.Add(textBoxFrage);
            groupBoxVorschau.Controls.Add(buttonVor);
            groupBoxVorschau.Controls.Add(buttonZurueck);
            groupBoxVorschau.Controls.Add(checkBoxAntwort5);
            groupBoxVorschau.Controls.Add(checkBoxAntwort4);
            groupBoxVorschau.Controls.Add(checkBoxAntwort3);
            groupBoxVorschau.Controls.Add(checkBoxAntwort2);
            groupBoxVorschau.Controls.Add(checkBoxAntwort1);
            groupBoxVorschau.Controls.Add(labelFrage);
            groupBoxVorschau.Location = new Point(12, 228);
            groupBoxVorschau.Name = "groupBoxVorschau";
            groupBoxVorschau.Size = new Size(907, 348);
            groupBoxVorschau.TabIndex = 12;
            groupBoxVorschau.TabStop = false;
            groupBoxVorschau.Text = "Vorschau";
            // 
            // buttonNeu
            // 
            buttonNeu.Location = new Point(356, 310);
            buttonNeu.Name = "buttonNeu";
            buttonNeu.Size = new Size(75, 23);
            buttonNeu.TabIndex = 16;
            buttonNeu.Text = "neu..";
            buttonNeu.UseVisualStyleBackColor = true;
            buttonNeu.Click += buttonNeu_Click;
            // 
            // buttonLoeschen
            // 
            buttonLoeschen.Location = new Point(599, 310);
            buttonLoeschen.Name = "buttonLoeschen";
            buttonLoeschen.Size = new Size(75, 23);
            buttonLoeschen.TabIndex = 15;
            buttonLoeschen.Text = "löschen";
            buttonLoeschen.UseVisualStyleBackColor = true;
            buttonLoeschen.Click += buttonLoeschen_Click;
            // 
            // buttonBearbeiten
            // 
            buttonBearbeiten.Location = new Point(475, 310);
            buttonBearbeiten.Name = "buttonBearbeiten";
            buttonBearbeiten.Size = new Size(75, 23);
            buttonBearbeiten.TabIndex = 14;
            buttonBearbeiten.Text = "bearbeiten";
            buttonBearbeiten.UseVisualStyleBackColor = true;
            buttonBearbeiten.Click += buttonBearbeiten_Click;
            // 
            // textBoxAntwort5
            // 
            textBoxAntwort5.Location = new Point(106, 281);
            textBoxAntwort5.Name = "textBoxAntwort5";
            textBoxAntwort5.Size = new Size(795, 23);
            textBoxAntwort5.TabIndex = 13;
            textBoxAntwort5.Visible = false;
            // 
            // textBoxAntwort4
            // 
            textBoxAntwort4.Location = new Point(106, 252);
            textBoxAntwort4.Name = "textBoxAntwort4";
            textBoxAntwort4.Size = new Size(795, 23);
            textBoxAntwort4.TabIndex = 12;
            textBoxAntwort4.Visible = false;
            // 
            // textBoxAntwort3
            // 
            textBoxAntwort3.Location = new Point(106, 223);
            textBoxAntwort3.Name = "textBoxAntwort3";
            textBoxAntwort3.Size = new Size(795, 23);
            textBoxAntwort3.TabIndex = 11;
            textBoxAntwort3.Visible = false;
            // 
            // textBoxAntwort2
            // 
            textBoxAntwort2.Location = new Point(106, 194);
            textBoxAntwort2.Name = "textBoxAntwort2";
            textBoxAntwort2.Size = new Size(795, 23);
            textBoxAntwort2.TabIndex = 10;
            textBoxAntwort2.Visible = false;
            // 
            // textBoxAntwort1
            // 
            textBoxAntwort1.Location = new Point(106, 165);
            textBoxAntwort1.Name = "textBoxAntwort1";
            textBoxAntwort1.Size = new Size(795, 23);
            textBoxAntwort1.TabIndex = 9;
            textBoxAntwort1.Visible = false;
            // 
            // textBoxFrage
            // 
            textBoxFrage.Location = new Point(106, 22);
            textBoxFrage.Multiline = true;
            textBoxFrage.Name = "textBoxFrage";
            textBoxFrage.Size = new Size(795, 137);
            textBoxFrage.TabIndex = 8;
            textBoxFrage.Visible = false;
            // 
            // buttonVor
            // 
            buttonVor.Location = new Point(826, 310);
            buttonVor.Name = "buttonVor";
            buttonVor.Size = new Size(75, 23);
            buttonVor.TabIndex = 7;
            buttonVor.Text = "->";
            buttonVor.UseVisualStyleBackColor = true;
            buttonVor.Click += buttonVor_Click;
            // 
            // buttonZurueck
            // 
            buttonZurueck.Location = new Point(106, 310);
            buttonZurueck.Name = "buttonZurueck";
            buttonZurueck.Size = new Size(75, 23);
            buttonZurueck.TabIndex = 6;
            buttonZurueck.Text = "<-";
            buttonZurueck.UseVisualStyleBackColor = true;
            buttonZurueck.Click += buttonZurueck_Click;
            // 
            // checkBoxAntwort5
            // 
            checkBoxAntwort5.AutoSize = true;
            checkBoxAntwort5.Location = new Point(14, 283);
            checkBoxAntwort5.Name = "checkBoxAntwort5";
            checkBoxAntwort5.Size = new Size(78, 19);
            checkBoxAntwort5.TabIndex = 5;
            checkBoxAntwort5.Text = "Antwort 5";
            checkBoxAntwort5.UseVisualStyleBackColor = true;
            // 
            // checkBoxAntwort4
            // 
            checkBoxAntwort4.AutoSize = true;
            checkBoxAntwort4.Location = new Point(14, 254);
            checkBoxAntwort4.Name = "checkBoxAntwort4";
            checkBoxAntwort4.Size = new Size(78, 19);
            checkBoxAntwort4.TabIndex = 4;
            checkBoxAntwort4.Text = "Antwort 4";
            checkBoxAntwort4.UseVisualStyleBackColor = true;
            // 
            // checkBoxAntwort3
            // 
            checkBoxAntwort3.AutoSize = true;
            checkBoxAntwort3.Location = new Point(14, 225);
            checkBoxAntwort3.Name = "checkBoxAntwort3";
            checkBoxAntwort3.Size = new Size(78, 19);
            checkBoxAntwort3.TabIndex = 3;
            checkBoxAntwort3.Text = "Antwort 3";
            checkBoxAntwort3.UseVisualStyleBackColor = true;
            // 
            // checkBoxAntwort2
            // 
            checkBoxAntwort2.AutoSize = true;
            checkBoxAntwort2.Location = new Point(14, 196);
            checkBoxAntwort2.Name = "checkBoxAntwort2";
            checkBoxAntwort2.Size = new Size(78, 19);
            checkBoxAntwort2.TabIndex = 2;
            checkBoxAntwort2.Text = "Antwort 2";
            checkBoxAntwort2.UseVisualStyleBackColor = true;
            // 
            // checkBoxAntwort1
            // 
            checkBoxAntwort1.AutoSize = true;
            checkBoxAntwort1.Location = new Point(14, 167);
            checkBoxAntwort1.Name = "checkBoxAntwort1";
            checkBoxAntwort1.Size = new Size(78, 19);
            checkBoxAntwort1.TabIndex = 1;
            checkBoxAntwort1.Text = "Antwort 1";
            checkBoxAntwort1.UseVisualStyleBackColor = true;
            // 
            // labelFrage
            // 
            labelFrage.AutoSize = true;
            labelFrage.Location = new Point(6, 25);
            labelFrage.Name = "labelFrage";
            labelFrage.Size = new Size(36, 15);
            labelFrage.TabIndex = 0;
            labelFrage.Text = "Frage";
            // 
            // buttonPfadwahl
            // 
            buttonPfadwahl.Location = new Point(487, 26);
            buttonPfadwahl.Name = "buttonPfadwahl";
            buttonPfadwahl.Size = new Size(29, 23);
            buttonPfadwahl.TabIndex = 13;
            buttonPfadwahl.Text = "...";
            buttonPfadwahl.UseVisualStyleBackColor = true;
            buttonPfadwahl.Click += buttonPfadwahl_Click;
            // 
            // buttonPraefixwahl
            // 
            buttonPraefixwahl.Location = new Point(315, 94);
            buttonPraefixwahl.Name = "buttonPraefixwahl";
            buttonPraefixwahl.Size = new Size(29, 23);
            buttonPraefixwahl.TabIndex = 14;
            buttonPraefixwahl.Text = "...";
            buttonPraefixwahl.UseVisualStyleBackColor = true;
            buttonPraefixwahl.Click += buttonPraefixwahl_Click;
            // 
            // labelImportierteFragen
            // 
            labelImportierteFragen.AutoSize = true;
            labelImportierteFragen.Location = new Point(138, 203);
            labelImportierteFragen.Name = "labelImportierteFragen";
            labelImportierteFragen.Size = new Size(117, 15);
            labelImportierteFragen.TabIndex = 15;
            labelImportierteFragen.Text = "Importierte Fragen: 0";
            // 
            // buttonXMLOeffenen
            // 
            buttonXMLOeffenen.Location = new Point(420, 199);
            buttonXMLOeffenen.Name = "buttonXMLOeffenen";
            buttonXMLOeffenen.Size = new Size(96, 23);
            buttonXMLOeffenen.TabIndex = 16;
            buttonXMLOeffenen.Text = "XML öffnen";
            buttonXMLOeffenen.UseVisualStyleBackColor = true;
            buttonXMLOeffenen.Click += buttonXMLOeffenen_Click;
            // 
            // ViewMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 630);
            Controls.Add(buttonXMLOeffenen);
            Controls.Add(labelImportierteFragen);
            Controls.Add(buttonPraefixwahl);
            Controls.Add(buttonPfadwahl);
            Controls.Add(groupBoxVorschau);
            Controls.Add(buttonImport);
            Controls.Add(textBoxPfad);
            Controls.Add(label5);
            Controls.Add(textBoxDefaultgrade);
            Controls.Add(textBoxPenalty);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(numericUpDownAnzahlFragen);
            Controls.Add(label2);
            Controls.Add(textBoxPraefix);
            Controls.Add(label1);
            Name = "ViewMain";
            Text = "MoodleQuizGenerator V0.2";
            ((System.ComponentModel.ISupportInitialize)numericUpDownAnzahlFragen).EndInit();
            groupBoxVorschau.ResumeLayout(false);
            groupBoxVorschau.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxPraefix;
        private Label label2;
        private NumericUpDown numericUpDownAnzahlFragen;
        private Label label3;
        private Label label4;
        private TextBox textBoxPenalty;
        private TextBox textBoxDefaultgrade;
        private Label label5;
        private TextBox textBoxPfad;
        private Button buttonImport;
        private GroupBox groupBoxVorschau;
        private Button buttonZurueck;
        private CheckBox checkBoxAntwort5;
        private CheckBox checkBoxAntwort4;
        private CheckBox checkBoxAntwort3;
        private CheckBox checkBoxAntwort2;
        private CheckBox checkBoxAntwort1;
        private Label labelFrage;
        private Button buttonVor;
        private Button buttonPfadwahl;
        private Button buttonPraefixwahl;
        private TextBox textBoxAntwort5;
        private TextBox textBoxAntwort4;
        private TextBox textBoxAntwort3;
        private TextBox textBoxAntwort2;
        private TextBox textBoxAntwort1;
        private TextBox textBoxFrage;
        private Button buttonBearbeiten;
        private Button buttonNeu;
        private Button buttonLoeschen;
        private Label labelImportierteFragen;
        private Button buttonXMLOeffenen;
    }
}
