﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using GUI;

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
        private void FindCase_MouseEnter(object sender, EventArgs e)
        {
            gui.toggleMenuPanel();
        }



        private void button_UCCaseTCFind_CreateCase_Click(object sender, EventArgs e)
        {
            TabControl_UCCases.SelectedTab = TC_UCCaseTC_CreateCase;
        }

        private void button_UCCaseTCEdit_FindCase_Click(object sender, EventArgs e)
        {
            TabControl_UCCases.SelectedTab = TC_UCCaseTC_FindCase;
        }

        private void button_UCCaseTCEdit_ManageCase_Click(object sender, EventArgs e)
        {
            TabControl_UCCases.SelectedTab = TC_UCCaseTC_ManageCase;
        }

        private void button_UCCaseTCCreate_FindCase_Click(object sender, EventArgs e)
        {
            TabControl_UCCases.SelectedTab = TC_UCCaseTC_FindCase;
        }

        private void button_UCCaseTCManage_FindCase_Click(object sender, EventArgs e)
        {
            TabControl_UCCases.SelectedTab = TC_UCCaseTC_FindCase;
        }

        private void button_UCCaseTCManage_EditCase_Click(object sender, EventArgs e)
        {
            TabControl_UCCases.SelectedTab = TC_UCCaseTC_EditCase;
        }

        private void button_UCCaseTCCreate_CreateCase_Click(object sender, EventArgs e)
        {
            Case @case = new Case();
            gui.CaseRepository.Create(@case);
        }
    }
}
