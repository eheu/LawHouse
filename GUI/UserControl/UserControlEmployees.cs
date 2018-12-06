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
using BrightIdeasSoftware;
using System.Linq;

namespace GUI
{
    public partial class UserControlEmployees : UserControl
    {
        GUIForm gui;
        private Employee currentEmployee;
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
            ListBox_UCEmployeeTCCreate_CreateEmployee_ShowSpeciality.DisplayMember = "Name";
            ListBox_UCEmployeeTCCreate_CreateEmployee_ShowSpeciality.ValueMember = "ID";
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


        /// <summary>
        /// Sets the All comboboxes on startup
        /// </summary>
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

            //Settings of Role comboboxes
            combo_UCEmployeeTCCreate_Role.DataSource = Role;
            combo_UCEmployeeTCCreate_Role.DisplayMember = "Name";
            combo_UCEmployeeTCCreate_Role.ValueMember = "ID";
            combo_UCEmployeeTCCreate_Role.SelectedIndex = -1;
            combo_UCEmployeeTCCreate_Role.AutoCompleteMode = AutoCompleteMode.Suggest;
            combo_UCEmployeeTCCreate_Role.AutoCompleteSource = AutoCompleteSource.ListItems;

            combo_UCEmployeeTCEdit_Role.DataSource = Role;
            combo_UCEmployeeTCEdit_Role.DisplayMember = "Name";
            combo_UCEmployeeTCEdit_Role.ValueMember = "ID";
            combo_UCEmployeeTCEdit_Role.SelectedIndex = -1;
            combo_UCEmployeeTCEdit_Role.AutoCompleteMode = AutoCompleteMode.Suggest;
            combo_UCEmployeeTCEdit_Role.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        #region Edit Employee
        /// <summary>
        /// Sets the EditEmployee Listbox
        /// </summary>
        private void SetEditEmployeeListbox(int employee_ID)
        {
            //List of employee Specialitys showed in listbox on Edit Employee
            List<Speciality> Specialitylist = gui.SpecialityRepository.GetAllSpecialityesFromOnelaywer(employee_ID);
            ListBox_UCEmployeeTCEdit_EditEmployee_ShowSpeciality.DataSource = Specialitylist;
            ListBox_UCEmployeeTCEdit_EditEmployee_ShowSpeciality.DisplayMember = "Name";
            ListBox_UCEmployeeTCEdit_EditEmployee_ShowSpeciality.ValueMember = "ID";
        }

        /// <summary>
        /// Inserts Speciality's in Edit Employee's SpecialityListbox and checks if the Employee already have them
        /// </summary>
        private void button_UCEmployeeTCEdit_EditEmployee_AddSpeciality_Click(object sender, EventArgs e)
        {
            Speciality inCombobox = (Speciality)comboBox_UCEmployeeTCEdit_EditEmployee_Speciality.SelectedItem;
            var inListBox = ListBox_UCEmployeeTCEdit_EditEmployee_ShowSpeciality.Items;
            foreach (Speciality item in ListBox_UCEmployeeTCEdit_EditEmployee_ShowSpeciality.Items)
            {
                if (item.ID == inCombobox.ID) {
                    comboBox_UCEmployeeTCEdit_EditEmployee_Speciality.SelectedIndex = -1;
                    return;
                }
            }

            Employee employee = (Employee)objectListView_UCEmployeeTCFind_FindEmployee.SelectedObject;
            gui.SpecialityRepository.AddOneSpecialityOnLaywer(employee.ID, (Speciality)comboBox_UCEmployeeTCEdit_EditEmployee_Speciality.SelectedItem);
            comboBox_UCEmployeeTCEdit_EditEmployee_Speciality.SelectedIndex = -1;
            SetEditEmployeeListbox(employee.ID);
        }

        ///<summary>
        ///Saves the Employees edited data
        /// </summary>
        private void button_UCEmployeeTCEdit_EditEmployee_SaveEmployee_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();

            employee.ID = currentEmployee.ID;
            employee.FirstName = textbox_UCEmployeeTCEdit_firstName.Text;
            employee.LastName = textbox_UCEmployeeTCEdit_lastName.Text;
            employee.Email = textbox_UCEmployeeTCEdit_email.Text;
            employee.Phone = textbox_UCEmployeeTCEdit_phone.Text;
            employee.RoleID = Convert.ToInt32(combo_UCEmployeeTCEdit_Role.SelectedValue);

            //Create the employee
            gui.EmployeeRepository.Update(employee);

            //Clear text/Compoboxes
            gui.ClearTextboxesAndCompoboxesAndlistboxes(TC_UCEmployeeTC_EditEmployee.Controls);

            //Refresh Employee Olv
            SetObjectListViewEmployee();

            //Go back to Find Employee
            TabControl_UCEmployee.SelectedTab = TC_UCEmployeeTC_FindEmployee;
        }


        /// <summary>
        /// Fills data in the EditEmployee tap and loads the Specialitys listbox
        /// </summary>
        private void objectListView_UCEmployeeTCFind_FindEmployee_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // user clicked an item of objectListView control
            if (objectListView_UCEmployeeTCFind_FindEmployee.SelectedItems.Count == 1)
            {
                TabControl_UCEmployee.SelectedTab = TC_UCEmployeeTC_EditEmployee;

                Employee employee = (Employee)objectListView_UCEmployeeTCFind_FindEmployee.SelectedObject;

                //Set the globel Employee object
                currentEmployee = employee;

                textbox_UCEmployeeTCEdit_firstName.Text = employee.FirstName;
                textbox_UCEmployeeTCEdit_lastName.Text = employee.LastName;
                textbox_UCEmployeeTCEdit_email.Text = employee.Email;
                textbox_UCEmployeeTCEdit_phone.Text = employee.Phone;
                combo_UCEmployeeTCEdit_Role.SelectedValue = employee.RoleID;

                //Load List of employee Specialitys showed in listbox on Edit Employee
                SetEditEmployeeListbox(employee.ID);
            }
        }
        #endregion
        #region Save Employee
        /// <summary>
        /// Inserts Speciality's in Create Employee's SpecialityListbox
        /// </summary>
        private void button_UCEmployeeTCCreate_CreateEmployee_AddSpeciality_Click(object sender, EventArgs e)
        {
            if (!ListBox_UCEmployeeTCCreate_CreateEmployee_ShowSpeciality.Items.Contains((Speciality)comboBox_UCEmployeeTCCreate_CreateEmployee_Speciality.SelectedItem))
            {
                ListBox_UCEmployeeTCCreate_CreateEmployee_ShowSpeciality.Items.Add((Speciality)comboBox_UCEmployeeTCCreate_CreateEmployee_Speciality.SelectedItem);
                comboBox_UCEmployeeTCCreate_CreateEmployee_Speciality.SelectedIndex = -1;
            }
        }

        /// <summary>
        /// Saves the Employee and the Employee's Speciality's
        /// </summary>
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

            //Set the Employee's Specialityes
            List<Speciality> Specialitylist = new List<Speciality>();
            foreach (Speciality item in ListBox_UCEmployeeTCCreate_CreateEmployee_ShowSpeciality.Items)
            {
                Specialitylist.Add(item);
            }
            gui.SpecialityRepository.SetAllSpecialityesOnOnelaywer(employee.ID, Specialitylist);

            gui.ClearTextboxesAndCompoboxesAndlistboxes(TC_UCEmployeeTC_CreateEmployee.Controls);
        }
        #endregion






        /// <summary>
        /// Makes the search field sort the list view
        /// </summary>
        private void textBox_UCCaseTCFind_Search_TextChanged(object sender, EventArgs e)
        {
            this.objectListView_UCEmployeeTCFind_FindEmployee.UseFiltering = true; 
            this.objectListView_UCEmployeeTCFind_FindEmployee.ModelFilter = TextMatchFilter.Contains(this.objectListView_UCEmployeeTCFind_FindEmployee, $"{textBox_UCCaseTCFind_Search.Text}");
        }

        private void button_UCEmployeeTCEdit_DeleteEmployee_Click(object sender, EventArgs e)
        {
            if (gui.CaseRepository.CheckIflawyerHasCases(currentEmployee.ID) == 0)
            {
                gui.EmployeeRepository.Delete(currentEmployee);
            }
            else
            {
                label_UCEmployeeTCEdit_DeleteEmployee.Text = "Medarbejderen er på en sag og kan ikke slettes";
                return;
            }
            
            //label_UCEmployeeTCEdit_DeleteEmployee
            gui.ClearTextboxesAndCompoboxesAndlistboxes(TC_UCEmployeeTC_EditEmployee.Controls);

            //Refresh Employee Olv
            SetObjectListViewEmployee();

            //Go back to Find Employee
            TabControl_UCEmployee.SelectedTab = TC_UCEmployeeTC_FindEmployee;
        }
    }
}
