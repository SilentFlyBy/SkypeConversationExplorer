using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkypeConversationExplorer
{
    public partial class ExportDialog : Form
    {
        public string FilePath { get; set; }
        public ExportDialog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (htmlRadioButton.Checked) saveFileDialog1.Filter = "HTML Document|*.html";
            else if (TextRadioButton.Checked) saveFileDialog1.Filter = "Text File|*.txt";
            else if (PdfRadioButton.Checked) saveFileDialog1.Filter = "PDF Document|*.pdf";
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = saveFileDialog1.FileName;
                FilePath = saveFileDialog1.FileName;
            }
        }
    }
}
