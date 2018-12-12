using System;
using System.IO;
using System.Windows.Forms;
using Spire.Pdf;
using Spire.Pdf.Actions;
using Spire.Pdf.General;
using Spire.PdfViewer.Forms;

namespace GUI
{
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
        }

        private void HelpForm_Load(object sender, EventArgs e)
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), @"PDFTest.pdf");

            PdfDocument doc = new PdfDocument();
            doc.LoadFromFile(path);
            PdfDestination destination = new PdfDestination(doc.Pages[2]);
            PdfGoToAction action = new PdfGoToAction(destination);
            //action.Destination.Zoom = 1F;
            doc.AfterOpenAction = action;
            doc.SaveToFile("PDFTest.pdf", FileFormat.PDF);

            this.HelpPDFReader.LoadFromFile(path);
        }
    }
}
