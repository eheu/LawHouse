using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic.Models;

namespace GUI
{
    public partial class UserControlEmployees : UserControl
    {
        GUIForm gui;
        public UserControlEmployees(GUIForm guiForm)
        {
            gui = guiForm;
            InitializeComponent();
            //Load of clients into the objectlistview
            SetObjectListViewEmployee();
            //Load of Speciality into Combobox
            SetComboBoxSpeciality();
            ListBox_UCEmployeeTCEdit_EditEmployee_ShowSpeciality.DisplayMember = "Name";
            ListBox_UCEmployeeTCEdit_EditEmployee_ShowSpeciality.ValueMember = "ID";
        }

        private void UserControlEmployees_MouseEnter(object sender, EventArgs e)
        {
            gui.toggleMenuPanel();
        }

        private void button_UCEmployeeTCFind_CreateEmployee_Click(object sender, EventArgs e)
        {
            TabControl_UCEmployee.SelectedTab = TC_UCEmployeeTC_CreateEmployee;
        }

        private void button_UCEmployeeTCCreate_FindEmployee_Click(object sender, EventArgs e)
        {
            TabControl_UCEmployee.SelectedTab = TC_UCEmployeeTC_FindEmployee;
        }

        private void button_UCEmployeeTCEdit_Back_FindEmployee_Click(object sender, EventArgs e)
        {
            TabControl_UCEmployee.SelectedTab = TC_UCEmployeeTC_FindEmployee;
        }

        private void SetObjectListViewEmployee()
        {
            List<Employee> Employeelist = gui.EmployeeRepository.GetAll();
            objectListView_UCEmployeeTCFind_FindEmployee.SetObjects(Employeelist);
        }

        private void SetComboBoxSpeciality()
        {
            List<Speciality> SpecialityList = gui.SpecialityRepository.GetAll();
            comboBox_UCEmployeeTCEdit_EditEmployee_Speciality.DataSource = SpecialityList;
            comboBox_UCEmployeeTCEdit_EditEmployee_Speciality.DisplayMember = "Name";
            comboBox_UCEmployeeTCEdit_EditEmployee_Speciality.ValueMember = "ID";
            comboBox_UCEmployeeTCEdit_EditEmployee_Speciality.SelectedIndex = -1;
            comboBox_UCEmployeeTCEdit_EditEmployee_Speciality.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBox_UCEmployeeTCEdit_EditEmployee_Speciality.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void button_UCEmployeeTCEdit_EditEmployee_AddSpeciality_Click(object sender, EventArgs e)
        {
            if (!ListBox_UCEmployeeTCEdit_EditEmployee_ShowSpeciality.Items.Contains((Speciality)comboBox_UCEmployeeTCEdit_EditEmployee_Speciality.SelectedItem))
                ListBox_UCEmployeeTCEdit_EditEmployee_ShowSpeciality.Items.Add((Speciality)comboBox_UCEmployeeTCEdit_EditEmployee_Speciality.SelectedItem);
        }
    }
}
