using System;
using System.IO;
using System.Windows.Forms;

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

            ////Adobe Reader.
            //HelpPDFReader.LoadFile(path);

            ////File open
            //Process process = new Process();
            //ProcessStartInfo startInfo = new ProcessStartInfo();
            //process.StartInfo = startInfo;
            //startInfo.Arguments = "/A \"page=2\"";
            //startInfo.Arguments = path;

            //Console.WriteLine(path);
            //startInfo.FileName = path;
            //process.Start();

            webBrowser1.Navigate(path);
        }
    }
}
