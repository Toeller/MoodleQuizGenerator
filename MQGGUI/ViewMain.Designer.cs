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
            ((System.ComponentModel.ISupportInitialize)numericUpDownAnzahlFragen).BeginInit();
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
            // textBoxPräfix
            // 
            textBoxPraefix.Location = new Point(12, 94);
            textBoxPraefix.Name = "textBoxPräfix";
            textBoxPraefix.Size = new Size(100, 23);
            textBoxPraefix.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(118, 77);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 2;
            label2.Text = "Anzahl Fragen";
            // 
            // numericUpDownAnzahlFragen
            // 
            numericUpDownAnzahlFragen.Location = new Point(118, 95);
            numericUpDownAnzahlFragen.Name = "numericUpDownAnzahlFragen";
            numericUpDownAnzahlFragen.Size = new Size(120, 23);
            numericUpDownAnzahlFragen.TabIndex = 4;
            numericUpDownAnzahlFragen.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(244, 77);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 5;
            label3.Text = "penalty";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(350, 76);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 6;
            label4.Text = "defaultgrade";
            // 
            // textBoxPenalty
            // 
            textBoxPenalty.Location = new Point(244, 95);
            textBoxPenalty.Name = "textBoxPenalty";
            textBoxPenalty.Size = new Size(100, 23);
            textBoxPenalty.TabIndex = 7;
            // 
            // textBoxDefaultgrade
            // 
            textBoxDefaultgrade.Location = new Point(350, 95);
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
            textBoxPfad.Size = new Size(438, 23);
            textBoxPfad.TabIndex = 10;
            textBoxPfad.MouseClick += textBoxPfad_MouseClick;
            // 
            // buttonImport
            // 
            buttonImport.Location = new Point(12, 147);
            buttonImport.Name = "buttonImport";
            buttonImport.Size = new Size(100, 23);
            buttonImport.TabIndex = 11;
            buttonImport.Text = "importieren";
            buttonImport.UseVisualStyleBackColor = true;
            buttonImport.Click += buttonImport_Click;
            // 
            // ViewMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
