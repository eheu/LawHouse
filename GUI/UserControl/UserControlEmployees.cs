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
    public partial class UserControlEmployees : UserControl
    {
        GUIForm gui;
        public UserControlEmployees(GUIForm guiForm)
        {
            gui = guiForm;
            InitializeComponent();
        }

        private void UserControlEmployees_MouseEnter(object sender, EventArgs e)
        {
            //gui.toggleMenuPanel();
        }

        private void button_UCEmployeeTCFind_CreateEmployee_Click(object sender, EventArgs e)
        {
            TabControl_UCEmployee.SelectedTab = TC_UCEmployeeTC_CreateEmployee;
        }

        private void button_UCEmployeeTCCreate_FindEmployee_Click(object sender, EventArgs e)
        {
            TabControl_UCEmployee.SelectedTab = TC_UCEmployeeTC_FindEmployee;
        }
    }
}
