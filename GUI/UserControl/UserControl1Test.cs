﻿using System;
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
    public partial class UserControl1Test : UserControl
    {
        /// <summary>
        /// Det er vigtigt at vi laver den sammenhæng mellem GUIForm i constructoren, så den kan tilgå metoder i GUIForm klassen
        /// </summary>
        GUIForm gui; 
        public UserControl1Test(GUIForm guiForm)
        {
            gui = guiForm;
            InitializeComponent();
        }

        public void UserControl1Test_MouseEnter(object sender, EventArgs e)
        {
            gui.toggleMenuPanel(); 
        }
    }
}
