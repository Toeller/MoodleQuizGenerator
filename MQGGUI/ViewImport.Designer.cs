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
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(61, 32);
            label1.TabIndex = 0;
            label1.Text = "Pfad";
            // 
            // textBoxPfad
            // 
            textBoxPfad.Font = new Font("Segoe UI", 14F);
            textBoxPfad.Location = new Point(14, 49);
            textBoxPfad.Margin = new Padding(3, 4, 3, 4);
            textBoxPfad.Name = "textBoxPfad";
            textBoxPfad.Size = new Size(879, 39);
            textBoxPfad.TabIndex = 1;
            // 
            // buttonPfadWaehlen
            // 
            buttonPfadWaehlen.Location = new Point(901, 49);
            buttonPfadWaehlen.Margin = new Padding(3, 4, 3, 4);
            buttonPfadWaehlen.Name = "buttonPfadWaehlen";
            buttonPfadWaehlen.Size = new Size(37, 43);
            buttonPfadWaehlen.TabIndex = 2;
            buttonPfadWaehlen.Text = "...";
            buttonPfadWaehlen.UseVisualStyleBackColor = true;
            buttonPfadWaehlen.Click += buttonPfadWaehlen_Click;
            // 
            // buttonImportieren
            // 
            buttonImportieren.DialogResult = DialogResult.OK;
            buttonImportieren.Font = new Font("Segoe UI", 14F);
            buttonImportieren.Location = new Point(14, 245);
            buttonImportieren.Margin = new Padding(3, 4, 3, 4);
            buttonImportieren.Name = "buttonImportieren";
            buttonImportieren.Size = new Size(141, 43);
            buttonImportieren.TabIndex = 6;
            buttonImportieren.Text = "Importieren";
            buttonImportieren.UseVisualStyleBackColor = true;
            // 
            // buttonPraefix
            // 
            buttonPraefix.Location = new Point(901, 165);
            buttonPraefix.Margin = new Padding(3, 4, 3, 4);
            buttonPraefix.Name = "buttonPraefix";
            buttonPraefix.Size = new Size(37, 43);
            buttonPraefix.TabIndex = 9;
            buttonPraefix.Text = "...";
            buttonPraefix.UseVisualStyleBackColor = true;
            buttonPraefix.Click += buttonPraefix_Click;
            // 
            // textBoxPraefix
            // 
            textBoxPraefix.Font = new Font("Segoe UI", 14F);
            textBoxPraefix.Location = new Point(14, 165);
            textBoxPraefix.Margin = new Padding(3, 4, 3, 4);
            textBoxPraefix.Name = "textBoxPraefix";
            textBoxPraefix.Size = new Size(879, 39);
            textBoxPraefix.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(14, 128);
            label2.Name = "label2";
            label2.Size = new Size(144, 32);
            label2.TabIndex = 7;
            label2.Text = "Output XML";
            // 
            // ViewImport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 313);
            Controls.Add(buttonPraefix);
            Controls.Add(textBoxPraefix);
            Controls.Add(label2);
            Controls.Add(buttonImportieren);
            Controls.Add(buttonPfadWaehlen);
            Controls.Add(textBoxPfad);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
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