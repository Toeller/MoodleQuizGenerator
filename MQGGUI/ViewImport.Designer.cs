namespace MQGGUI
{
    partial class ViewImport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBoxPfad = new TextBox();
            buttonPfadWaehlen = new Button();
            buttonImportieren = new Button();
            buttonPraefix = new Button();
            textBoxPraefix = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(50, 25);
            label1.TabIndex = 0;
            label1.Text = "Pfad";
            // 
            // textBoxPfad
            // 
            textBoxPfad.Font = new Font("Segoe UI", 14F);
            textBoxPfad.Location = new Point(12, 37);
            textBoxPfad.Name = "textBoxPfad";
            textBoxPfad.Size = new Size(770, 32);
            textBoxPfad.TabIndex = 1;
            // 
            // buttonPfadWaehlen
            // 
            buttonPfadWaehlen.Location = new Point(788, 37);
            buttonPfadWaehlen.Name = "buttonPfadWaehlen";
            buttonPfadWaehlen.Size = new Size(32, 32);
            buttonPfadWaehlen.TabIndex = 2;
            buttonPfadWaehlen.Text = "...";
            buttonPfadWaehlen.UseVisualStyleBackColor = true;
            buttonPfadWaehlen.Click += buttonPfadWaehlen_Click;
            // 
            // buttonImportieren
            // 
            buttonImportieren.DialogResult = DialogResult.OK;
            buttonImportieren.Font = new Font("Segoe UI", 14F);
            buttonImportieren.Location = new Point(12, 184);
            buttonImportieren.Name = "buttonImportieren";
            buttonImportieren.Size = new Size(123, 32);
            buttonImportieren.TabIndex = 6;
            buttonImportieren.Text = "Importieren";
            buttonImportieren.UseVisualStyleBackColor = true;
            // 
            // buttonPraefix
            // 
            buttonPraefix.Location = new Point(788, 124);
            buttonPraefix.Name = "buttonPraefix";
            buttonPraefix.Size = new Size(32, 32);
            buttonPraefix.TabIndex = 9;
            buttonPraefix.Text = "...";
            buttonPraefix.UseVisualStyleBackColor = true;
            buttonPraefix.Click += buttonPraefix_Click;
            // 
            // textBoxPraefix
            // 
            textBoxPraefix.Font = new Font("Segoe UI", 14F);
            textBoxPraefix.Location = new Point(12, 124);
            textBoxPraefix.Name = "textBoxPraefix";
            textBoxPraefix.Size = new Size(770, 32);
            textBoxPraefix.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(12, 96);
            label2.Name = "label2";
            label2.Size = new Size(60, 25);
            label2.TabIndex = 7;
            label2.Text = "Präfix";
            // 
            // ViewImport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 235);
            Controls.Add(buttonPraefix);
            Controls.Add(textBoxPraefix);
            Controls.Add(label2);
            Controls.Add(buttonImportieren);
            Controls.Add(buttonPfadWaehlen);
            Controls.Add(textBoxPfad);
            Controls.Add(label1);
            Name = "ViewImport";
            Text = "ViewImport";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        public TextBox textBoxPfad;
        private Button buttonPfadWaehlen;
        private Button buttonImportieren;
        private Button buttonPraefix;
        public TextBox textBoxPraefix;
        private Label label2;
    }
}