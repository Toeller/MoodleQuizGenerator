namespace Lernmaschine
{
    partial class View
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
            textBoxVorderseite = new TextBox();
            textBoxRueckseite = new TextBox();
            labelVorderseite = new Label();
            labelRueckseite = new Label();
            groupBoxModus = new GroupBox();
            radioButtonLesen = new RadioButton();
            radioButtonLernen = new RadioButton();
            radioButtonEditieren = new RadioButton();
            buttonSpeichern = new Button();
            buttonLoeschen = new Button();
            buttonSuchen = new Button();
            buttonAnfang = new Button();
            buttonZurueck = new Button();
            buttonVor = new Button();
            buttonEnde = new Button();
            buttonFalsch = new Button();
            buttonRichtig = new Button();
            buttonNeu = new Button();
            groupBoxModus.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxVorderseite
            // 
            textBoxVorderseite.Enabled = false;
            textBoxVorderseite.Location = new Point(12, 27);
            textBoxVorderseite.Multiline = true;
            textBoxVorderseite.Name = "textBoxVorderseite";
            textBoxVorderseite.Size = new Size(280, 181);
            textBoxVorderseite.TabIndex = 0;
            // 
            // textBoxRueckseite
            // 
            textBoxRueckseite.Enabled = false;
            textBoxRueckseite.Location = new Point(298, 27);
            textBoxRueckseite.Multiline = true;
            textBoxRueckseite.Name = "textBoxRueckseite";
            textBoxRueckseite.Size = new Size(280, 181);
            textBoxRueckseite.TabIndex = 1;
            // 
            // labelVorderseite
            // 
            labelVorderseite.AutoSize = true;
            labelVorderseite.Location = new Point(12, 9);
            labelVorderseite.Name = "labelVorderseite";
            labelVorderseite.Size = new Size(65, 15);
            labelVorderseite.TabIndex = 2;
            labelVorderseite.Text = "Vorderseite";
            // 
            // labelRueckseite
            // 
            labelRueckseite.AutoSize = true;
            labelRueckseite.Location = new Point(298, 9);
            labelRueckseite.Name = "labelRueckseite";
            labelRueckseite.Size = new Size(57, 15);
            labelRueckseite.TabIndex = 3;
            labelRueckseite.Text = "Rückseite";
            // 
            // groupBoxModus
            // 
            groupBoxModus.Controls.Add(radioButtonLesen);
            groupBoxModus.Controls.Add(radioButtonLernen);
            groupBoxModus.Controls.Add(radioButtonEditieren);
            groupBoxModus.Location = new Point(13, 307);
            groupBoxModus.Name = "groupBoxModus";
            groupBoxModus.Size = new Size(566, 55);
            groupBoxModus.TabIndex = 4;
            groupBoxModus.TabStop = false;
            groupBoxModus.Text = "Modus";
            // 
            // radioButtonLesen
            // 
            radioButtonLesen.AutoSize = true;
            radioButtonLesen.Location = new Point(505, 22);
            radioButtonLesen.Name = "radioButtonLesen";
            radioButtonLesen.Size = new Size(55, 19);
            radioButtonLesen.TabIndex = 2;
            radioButtonLesen.TabStop = true;
            radioButtonLesen.Text = "Lesen";
            radioButtonLesen.UseVisualStyleBackColor = true;
            radioButtonLesen.CheckedChanged += radioButtonLesen_CheckedChanged;
            // 
            // radioButtonLernen
            // 
            radioButtonLernen.AutoSize = true;
            radioButtonLernen.Location = new Point(252, 22);
            radioButtonLernen.Name = "radioButtonLernen";
            radioButtonLernen.Size = new Size(61, 19);
            radioButtonLernen.TabIndex = 1;
            radioButtonLernen.TabStop = true;
            radioButtonLernen.Text = "Lernen";
            radioButtonLernen.UseVisualStyleBackColor = true;
            radioButtonLernen.CheckedChanged += radioButtonLernen_CheckedChanged;
            // 
            // radioButtonEditieren
            // 
            radioButtonEditieren.AutoSize = true;
            radioButtonEditieren.Location = new Point(6, 22);
            radioButtonEditieren.Name = "radioButtonEditieren";
            radioButtonEditieren.Size = new Size(71, 19);
            radioButtonEditieren.TabIndex = 0;
            radioButtonEditieren.TabStop = true;
            radioButtonEditieren.Text = "Editieren";
            radioButtonEditieren.UseVisualStyleBackColor = true;
            radioButtonEditieren.CheckedChanged += radioButtonEditieren_CheckedChanged;
            // 
            // buttonSpeichern
            // 
            buttonSpeichern.Location = new Point(12, 214);
            buttonSpeichern.Name = "buttonSpeichern";
            buttonSpeichern.Size = new Size(192, 23);
            buttonSpeichern.TabIndex = 5;
            buttonSpeichern.Text = "ändern";
            buttonSpeichern.UseVisualStyleBackColor = true;
            buttonSpeichern.Click += buttonSpeichern_Click;
            // 
            // buttonLoeschen
            // 
            buttonLoeschen.Location = new Point(386, 214);
            buttonLoeschen.Name = "buttonLoeschen";
            buttonLoeschen.Size = new Size(192, 23);
            buttonLoeschen.TabIndex = 6;
            buttonLoeschen.Text = "löschen";
            buttonLoeschen.UseVisualStyleBackColor = true;
            buttonLoeschen.Click += buttonLoeschen_Click;
            // 
            // buttonSuchen
            // 
            buttonSuchen.Location = new Point(210, 214);
            buttonSuchen.Name = "buttonSuchen";
            buttonSuchen.Size = new Size(170, 23);
            buttonSuchen.TabIndex = 7;
            buttonSuchen.Text = "suchen";
            buttonSuchen.UseVisualStyleBackColor = true;
            buttonSuchen.Click += buttonSuchen_Click;
            // 
            // buttonAnfang
            // 
            buttonAnfang.Location = new Point(12, 243);
            buttonAnfang.Name = "buttonAnfang";
            buttonAnfang.Size = new Size(75, 23);
            buttonAnfang.TabIndex = 8;
            buttonAnfang.Text = "|<-";
            buttonAnfang.UseVisualStyleBackColor = true;
            buttonAnfang.Click += buttonAnfang_Click;
            // 
            // buttonZurueck
            // 
            buttonZurueck.Location = new Point(129, 243);
            buttonZurueck.Name = "buttonZurueck";
            buttonZurueck.Size = new Size(75, 23);
            buttonZurueck.TabIndex = 9;
            buttonZurueck.Text = "<-";
            buttonZurueck.UseVisualStyleBackColor = true;
            buttonZurueck.Click += buttonZurueck_Click;
            // 
            // buttonVor
            // 
            buttonVor.Location = new Point(386, 243);
            buttonVor.Name = "buttonVor";
            buttonVor.Size = new Size(75, 23);
            buttonVor.TabIndex = 10;
            buttonVor.Text = "->";
            buttonVor.UseVisualStyleBackColor = true;
            buttonVor.Click += buttonVor_Click;
            // 
            // buttonEnde
            // 
            buttonEnde.Location = new Point(503, 243);
            buttonEnde.Name = "buttonEnde";
            buttonEnde.Size = new Size(75, 23);
            buttonEnde.TabIndex = 11;
            buttonEnde.Text = "->|";
            buttonEnde.UseVisualStyleBackColor = true;
            buttonEnde.Click += buttonEnde_Click;
            // 
            // buttonFalsch
            // 
            buttonFalsch.BackColor = Color.Red;
            buttonFalsch.Location = new Point(298, 278);
            buttonFalsch.Name = "buttonFalsch";
            buttonFalsch.Size = new Size(139, 23);
            buttonFalsch.TabIndex = 12;
            buttonFalsch.Text = "falsch";
            buttonFalsch.UseVisualStyleBackColor = false;
            buttonFalsch.Click += buttonFalsch_Click;
            // 
            // buttonRichtig
            // 
            buttonRichtig.BackColor = Color.FromArgb(128, 255, 128);
            buttonRichtig.Location = new Point(443, 278);
            buttonRichtig.Name = "buttonRichtig";
            buttonRichtig.Size = new Size(135, 23);
            buttonRichtig.TabIndex = 13;
            buttonRichtig.Text = "richtig";
            buttonRichtig.UseVisualStyleBackColor = false;
            buttonRichtig.Click += buttonRichtig_Click;
            // 
            // buttonNeu
            // 
            buttonNeu.Location = new Point(210, 243);
            buttonNeu.Name = "buttonNeu";
            buttonNeu.Size = new Size(170, 23);
            buttonNeu.TabIndex = 14;
            buttonNeu.Text = "neu";
            buttonNeu.UseVisualStyleBackColor = true;
            buttonNeu.Click += buttonNeu_Click;
            // 
            // View
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(591, 377);
            Controls.Add(buttonNeu);
            Controls.Add(buttonRichtig);
            Controls.Add(buttonFalsch);
            Controls.Add(buttonEnde);
            Controls.Add(buttonVor);
            Controls.Add(buttonZurueck);
            Controls.Add(buttonAnfang);
            Controls.Add(buttonSuchen);
            Controls.Add(buttonLoeschen);
            Controls.Add(buttonSpeichern);
            Controls.Add(groupBoxModus);
            Controls.Add(labelRueckseite);
            Controls.Add(labelVorderseite);
            Controls.Add(textBoxRueckseite);
            Controls.Add(textBoxVorderseite);
            Name = "View";
            Text = "Lernmaschine V2.0";
            FormClosing += View_FormClosing;
            groupBoxModus.ResumeLayout(false);
            groupBoxModus.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxVorderseite;
        private TextBox textBoxRueckseite;
        private Label labelVorderseite;
        private Label labelRueckseite;
        private GroupBox groupBoxModus;
        private RadioButton radioButtonLernen;
        private RadioButton radioButtonEditieren;
        private RadioButton radioButtonLesen;
        private Button buttonSpeichern;
        private Button buttonLoeschen;
        private Button buttonSuchen;
        private Button buttonAnfang;
        private Button buttonZurueck;
        private Button buttonVor;
        private Button buttonEnde;
        private Button buttonFalsch;
        private Button buttonRichtig;
        private Button buttonNeu;
    }
}
