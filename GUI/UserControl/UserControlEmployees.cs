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
            //Load of SpecialityList and RoleList from DB
            List<Speciality> SpecialityList = gui.SpecialityRepository.GetAll();
            List<Role> Role = gui.RoleRepository.GetAll();

            //Settings of both Speciality comboboxes
            comboBox_UCEmployeeTCEdit_EditEmployee_Speciality.DataSource = SpecialityList;
            comboBox_UCEmployeeTCEdit_EditEmployee_Speciality.DisplayMember = "Name";
            comboBox_UCEmployeeTCEdit_EditEmployee_Speciality.ValueMember = "ID";
            comboBox_UCEmployeeTCEdit_EditEmployee_Speciality.SelectedIndex = -1;
            comboBox_UCEmployeeTCEdit_EditEmployee_Speciality.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBox_UCEmployeeTCEdit_EditEmployee_Speciality.AutoCompleteSource = AutoCompleteSource.ListItems;

            comboBox_UCEmployeeTCCreate_CreateEmployee_Speciality.DataSource = SpecialityList;
            comboBox_UCEmployeeTCCreate_CreateEmployee_Speciality.DisplayMember = "Name";
            comboBox_UCEmployeeTCCreate_CreateEmployee_Speciality.ValueMember = "ID";
            comboBox_UCEmployeeTCCreate_CreateEmployee_Speciality.SelectedIndex = -1;
            comboBox_UCEmployeeTCCreate_CreateEmployee_Speciality.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBox_UCEmployeeTCCreate_CreateEmployee_Speciality.AutoCompleteSource = AutoCompleteSource.ListItems;

            //Settings of Role combobox
            combo_UCEmployeeTCCreate_Role.DataSource = Role;
            combo_UCEmployeeTCCreate_Role.DisplayMember = "Name";
            combo_UCEmployeeTCCreate_Role.ValueMember = "ID";
            combo_UCEmployeeTCCreate_Role.SelectedIndex = -1;
            combo_UCEmployeeTCCreate_Role.AutoCompleteMode = AutoCompleteMode.Suggest;
            combo_UCEmployeeTCCreate_Role.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void button_UCEmployeeTCEdit_EditEmployee_AddSpeciality_Click(object sender, EventArgs e)
        {
            if (!ListBox_UCEmployeeTCEdit_EditEmployee_ShowSpeciality.Items.Contains((Speciality)comboBox_UCEmployeeTCEdit_EditEmployee_Speciality.SelectedItem))
            { 
                ListBox_UCEmployeeTCEdit_EditEmployee_ShowSpeciality.Items.Add((Speciality)comboBox_UCEmployeeTCEdit_EditEmployee_Speciality.SelectedItem);
                comboBox_UCEmployeeTCEdit_EditEmployee_Speciality.SelectedIndex = -1;
            }
        }

        private void button_UCEmployeeTCCreate_CreateEmployee_AddSpeciality_Click(object sender, EventArgs e)
        {
            if (!ListBox_UCEmployeeTCCreate_CreateEmployee_ShowSpeciality.Items.Contains((Speciality)comboBox_UCEmployeeTCCreate_CreateEmployee_Speciality.SelectedItem))
            {
                ListBox_UCEmployeeTCCreate_CreateEmployee_ShowSpeciality.Items.Add((Speciality)comboBox_UCEmployeeTCCreate_CreateEmployee_Speciality.SelectedItem);
                comboBox_UCEmployeeTCCreate_CreateEmployee_Speciality.SelectedIndex = -1;
            }
        }

        private void button_UCEmployeeTCCreate_CreateEmployee_SaveEmployee_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.FirstName = textbox_UCEmployeeTCCreate_firstName.Text;
            employee.LastName = textbox_UCEmployeeTCCreate_lastName.Text;
            employee.Email = textbox_UCEmployeeTCCreate_emailName.Text;
            employee.Phone = textbox_UCEmployeeTCCreate_phone.Text;
            employee.RoleID = (int)combo_UCEmployeeTCCreate_Role.SelectedValue;
                //Create the employee
                gui.EmployeeRepository.Create(employee);


        }
    }
}
