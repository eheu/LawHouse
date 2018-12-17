using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            //InitializeComponent();
        }

        private void HelpForm_Load(object sender, EventArgs e)
        {
            //HelpPDFReader.src = Properties.Resources.PDFTest.ToString();
            //HelpPDFReader.LoadFile(@"C:\Users\ok\source\repos\LawHouse\GUI\PDFtest.pdf");
           

            //string path = Path.Combine(Directory.GetCurrentDirectory(), @"PDFTest.pdf");

            //HelpPDFReader.src = path;

            //Process process = new Process();
            //ProcessStartInfo startInfo = new ProcessStartInfo();
            //process.StartInfo = startInfo;
            //startInfo.Arguments = "/A \"page=2\"";
            //startInfo.Arguments = path;

            //Console.WriteLine(path);
            //startInfo.FileName = path;
            //process.Start();
        }
    }
}
