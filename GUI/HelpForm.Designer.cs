namespace GUI
{
    partial class HelpForm
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
            this.HelpPDFReader = new Spire.PdfViewer.Forms.PdfDocumentViewer();
            this.SuspendLayout();
            // 
            // HelpPDFReader
            // 
            this.HelpPDFReader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.HelpPDFReader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HelpPDFReader.Location = new System.Drawing.Point(0, 0);
            this.HelpPDFReader.MultiPagesThreshold = 60;
            this.HelpPDFReader.Name = "HelpPDFReader";
            this.HelpPDFReader.Size = new System.Drawing.Size(720, 554);
            this.HelpPDFReader.TabIndex = 0;
            this.HelpPDFReader.Text = "pdfDocumentViewer1";
            this.HelpPDFReader.Threshold = 60;
            this.HelpPDFReader.ZoomMode = Spire.PdfViewer.Forms.ZoomMode.Default;
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(720, 554);
            this.Controls.Add(this.HelpPDFReader);
            this.Name = "HelpForm";
            this.Text = "HelpForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HelpForm_FormClosed);
            this.Load += new System.EventHandler(this.HelpForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Spire.PdfViewer.Forms.PdfDocumentViewer HelpPDFReader;
    }
}