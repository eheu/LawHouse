using System;
using System.IO;
using System.Windows.Forms;

namespace GUI
{
    public partial class HelpForm : Form
    {
        GUIForm gui;
        public HelpForm(GUIForm guiForm)
        {
            InitializeComponent();
            gui = guiForm;
        }
        /// <summary>
        /// Loads the HelpPDF Form
        /// </summary>
        private void HelpForm_Load(object sender, EventArgs e)
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), @"PDFTest.pdf");
            this.HelpPDFReader.LoadFromFile(path);
        }
        /// <summary>
        /// Set the Helpform to null on GUI form
        /// </summary>
        private void HelpForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            gui.helpForm = null;
        }
    }
}
