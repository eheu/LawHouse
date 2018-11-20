using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class UserControlCases : UserControl
    {
        GUIForm gui;
        public UserControlCases(GUIForm guiForm)
        {
            gui = guiForm;
            InitializeComponent();
        }

        private void FindbtnCreate_Click(object sender, EventArgs e)
        {
            TabControlCases.SelectedTab = CreateCase;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            TabControlCases.SelectedTab = FindCase;
        }

        private void EditBtnFind_Click(object sender, EventArgs e)
        {
            TabControlCases.SelectedTab = FindCase;
        }

        private void FindbtnEdit_Click(object sender, EventArgs e)
        {
            TabControlCases.SelectedTab = EditCase;
        }

        private void EditbtnCreate_Click(object sender, EventArgs e)
        {
            TabControlCases.SelectedTab = CreateCase;
        }

        private void CreatebtnEdit_Click(object sender, EventArgs e)
        {
            TabControlCases.SelectedTab = EditCase;
        }

        private void FindCase_MouseEnter(object sender, EventArgs e)
        {
            gui.toggleMenuPanel();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            //// Call the OnPaint method of the base class.  
            //base.OnPaint(e);
            //// Call methods of the System.Drawing.Graphics object.  
            //e.Graphics.DrawString(Text, Font, new SolidBrush(ForeColor), ClientRectangle);
        }
    }
}
