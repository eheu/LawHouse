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
    public partial class UserControlHelp : UserControl
    {
        GUIForm gui;
        public UserControlHelp(GUIForm guiForm)
        {
            gui = guiForm;
            InitializeComponent();
        }

        private void UserControlHelp_MouseEnter(object sender, EventArgs e)
        {
            gui.toggleMenuPanel();
        }
    }
}
