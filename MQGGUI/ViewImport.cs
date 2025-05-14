using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MQGGUI
{
    public partial class ViewImport : Form
    {
        public ViewImport()
        {
            InitializeComponent();
        }

        private void buttonPfadWaehlen_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                textBoxPfad.Text = fbd.SelectedPath;
            }
        }

        private void buttonPraefix_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBoxPraefix.Text = ofd.FileName.Split('\\').Last();
            }
        }
    }
}
