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
    public partial class UserControlCases : UserControl
    {
        GUIForm gui;
        public UserControlCases(GUIForm guiForm)
        {
            gui = guiForm;
            InitializeComponent();
        }

        private void UserControlCases_MouseEnter(object sender, EventArgs e)
        {
            gui.toggleMenuPanel();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = CreateCase;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = FindCase;
        }

        private void EditBtnFind_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = FindCase;
        }
    }
}
