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

namespace GUI
{
    public partial class UserControlEmployees : UserControl
    {
        GUIForm gui;
        private Employee currentEmployee;
        public UserControlEmployees(GUIForm guiForm)
        {
            InitializeComponent();
            gui = guiForm;
            //Load of clients into the objectlistview
            List<Employee> Employeelist = gui.EmployeeRepository.GetAll();
            objectListView_UCEmployeeTCFind_FindEmployee.SetObjects(Employeelist);
            //Load of Speciality into Combobox
            SetComboBoxSpeciality();
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

        private void button_UCEmployeeTCEdit_Back_ManageEmployee_Click(object sender, EventArgs e)
        {
            //her mangler vi at reloade UCEmployeeTCManage controlsne
            TabControl_UCEmployee.SelectedTab = TC_UCEmployeeTC_ManageEmployee;
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
            comboBox_UCEmployeeTCManage_ManageEmployee_Speciality.DataSource = SpecialityList;
            comboBox_UCEmployeeTCManage_ManageEmployee_Speciality.DisplayMember = "Name";
            comboBox_UCEmployeeTCManage_ManageEmployee_Speciality.ValueMember = "ID";
            comboBox_UCEmployeeTCManage_ManageEmployee_Speciality.SelectedIndex = -1;
            comboBox_UCEmployeeTCManage_ManageEmployee_Speciality.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBox_UCEmployeeTCManage_ManageEmployee_Speciality.AutoCompleteSource = AutoCompleteSource.ListItems;

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
        /// Inserts Speciality's in Edit Employee's SpecialityListbox and checks if the Employee already have them
        /// </summary>
        /// ListBox_UCEmployeeTCManage_ManageEmployee_ShowSpeciality
        private void button_UCEmployeeTCManage_ManageEmployee_AddSpeciality_Click(object sender, EventArgs e)
        {
            if (comboBox_UCEmployeeTCManage_ManageEmployee_Speciality.SelectedItem != null)
            {
                Speciality selectedSpeciality = (Speciality)comboBox_UCEmployeeTCManage_ManageEmployee_Speciality.SelectedItem;
                List<Speciality> specialitiesInListBox = objectListView__UCEmployeeTCManage_Specialities.Objects.Cast<Speciality>().ToList();
                bool exists = specialitiesInListBox.Any(s => s.ID == selectedSpeciality.ID);
                if (!exists) gui.EmployeeSpecialityRepository.Create(new EmployeeSpeciality(currentEmployee.ID,selectedSpeciality.ID));
                objectListView__UCEmployeeTCManage_Specialities.SetObjects(gui.SpecialityRepository.GetSpecialitiesFromLawyer(currentEmployee));
                objectListView__UCEmployeeTCManage_Services.SetObjects(gui.ServiceRepository.GetServicesFromEmployee(currentEmployee));
            }
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
            gui.ClearTextBoxesAndComboBoxesAndListBoxes(TC_UCEmployeeTC_EditEmployee.Controls);

            //Refresh Employee Olv
            List<Employee> Employeelist = gui.EmployeeRepository.GetAll();
            objectListView_UCEmployeeTCFind_FindEmployee.SetObjects(Employeelist);

            //Go back to Find Employee
            TabControl_UCEmployee.SelectedTab = TC_UCEmployeeTC_FindEmployee;
        }


        /// <summary>
        /// Fills data in the ManageEmployee tap and loads the Specialitys listbox
        /// </summary>
        private void objectListView_UCEmployeeTCFind_FindEmployee_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // user clicked an item of objectListView control
            if (objectListView_UCEmployeeTCFind_FindEmployee.SelectedItems.Count == 1)
            {
                Employee selectedEmployee = (Employee)objectListView_UCEmployeeTCFind_FindEmployee.SelectedObject;

                //Set the globel Employee object
                currentEmployee = selectedEmployee;

                label_UCEmployeeTCManage_firstName_Show.Text = selectedEmployee.FirstName;
                label_UCEmployeeTCManage_lastName_Show.Text = selectedEmployee.LastName;
                label_UCEmployeeTCManage_email_Show.Text = selectedEmployee.Email;
                label_UCEmployeeTCManage_phone_Show.Text = selectedEmployee.Phone;

                //Get Role
                Role RoleInfo = gui.RoleRepository.Get(selectedEmployee.RoleID);
                label_UCEmployeeTCManage_role_Show.Text = RoleInfo.Name;

                //Load List of employee Specialitys showed in listbox on Manage Employee
                objectListView__UCEmployeeTCManage_Specialities.SetObjects(gui.SpecialityRepository.GetSpecialitiesFromLawyer(selectedEmployee));

                //Load datalstview with employees cases
                List<Case> Caselist = gui.CaseRepository.GetCasesFromLawyer(selectedEmployee.ID);
                objectListView_UCEmployeeTCManage_ManageEmployee_ShowCases.SetObjects(Caselist);

                objectListView__UCEmployeeTCManage_Specialities.SetObjects(gui.SpecialityRepository.GetSpecialitiesFromLawyer(currentEmployee));

                objectListView__UCEmployeeTCManage_Services.SetObjects(gui.ServiceRepository.GetServicesFromEmployee(currentEmployee));

                TabControl_UCEmployee.SelectedTab = TC_UCEmployeeTC_ManageEmployee;
            }
        }
        #endregion
        #region Create Employee
        /// <summary>
        /// Inserts Speciality's in Create Employee's SpecialityListbox
        /// </summary>
        private void button_UCEmployeeTCCreate_CreateEmployee_AddSpeciality_Click(object sender, EventArgs e)
        {
            Speciality selectedSpeciality = (Speciality)comboBox_UCEmployeeTCCreate_CreateEmployee_Speciality.SelectedItem;
            bool exists = false;
            if (objectListView_UCEmployeeTCCreate_ShowSpeciality.Objects != null)
            {
                List<Speciality> specialitiesInObjectListView = objectListView_UCEmployeeTCCreate_ShowSpeciality.Objects.Cast<Speciality>().ToList();
                exists = specialitiesInObjectListView.Any(s => s.ID == selectedSpeciality.ID);
            }
            if (!exists)
            {
                objectListView_UCEmployeeTCCreate_ShowSpeciality.AddObject(selectedSpeciality);
                comboBox_UCEmployeeTCCreate_CreateEmployee_Speciality.SelectedIndex = -1;
            }
        }

        /// <summary>
        /// Saves the Employee and the Employee's Specialities
        /// </summary>
        private void button_UCEmployeeTCCreate_CreateEmployee_SaveEmployee_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee(
                textbox_UCEmployeeTCCreate_firstName.Text,
                 textbox_UCEmployeeTCCreate_lastName.Text,
                 (int)combo_UCEmployeeTCCreate_Role.SelectedValue,
                  textbox_UCEmployeeTCCreate_emailName.Text,
                  textbox_UCEmployeeTCCreate_phone.Text);
            //Create the employee
            gui.EmployeeRepository.Create(employee);

            //Set the Employee's Specialities
            List<Speciality> specialities = objectListView_UCEmployeeTCCreate_ShowSpeciality.Objects.Cast<Speciality>().ToList();

            //Check if specialities-List is not empty
            if ((specialities != null) && (specialities.Count != 0))
            {
                gui.SpecialityRepository.AddSpecialitiesToLawyer(employee, specialities);
            }
            
            gui.ClearTextBoxesAndComboBoxesAndListBoxes(TC_UCEmployeeTC_CreateEmployee.Controls);

            //Refresh OlvEmployee
            List<Employee> Employeelist = gui.EmployeeRepository.GetAll();
            objectListView_UCEmployeeTCFind_FindEmployee.SetObjects(Employeelist);
        }
        #endregion

        /// <summary>
        /// Makes the search field sort the list view
        /// </summary>
        private void textBox_UCEmployeeTCFind_Search_TextChanged(object sender, EventArgs e)
        {
            this.objectListView_UCEmployeeTCFind_FindEmployee.UseFiltering = true; 
            this.objectListView_UCEmployeeTCFind_FindEmployee.ModelFilter = TextMatchFilter.Contains(this.objectListView_UCEmployeeTCFind_FindEmployee, $"{textBox_UCEmployeeTCFind_Search.Text}");
        }

        private void button_UCEmployeeTCEdit_DeleteEmployee_Click(object sender, EventArgs e)
        {
            Console.WriteLine(gui.CaseRepository.CheckIflawyerHasCases(currentEmployee.ID));

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
            gui.ClearTextBoxesAndComboBoxesAndListBoxes(TC_UCEmployeeTC_EditEmployee.Controls);

            //Refresh Employee Olv
            List<Employee> Employeelist = gui.EmployeeRepository.GetAll();
            objectListView_UCEmployeeTCFind_FindEmployee.SetObjects(Employeelist);
            //Go back to Find Employee
            TabControl_UCEmployee.SelectedTab = TC_UCEmployeeTC_FindEmployee;
        }

        private void button_UCEmployeeTCEdit_EditEmployee_DeleteSpeciality_Click(object sender, EventArgs e)
        {
            Speciality selectedSpeciality = (Speciality)objectListView_UCEmployeeTCEdit_EditEmployee_Speciality.SelectedObject;
            EmployeeSpeciality employeeSpeciality = new EmployeeSpeciality(currentEmployee.ID, selectedSpeciality.ID);
            gui.EmployeeSpecialityRepository.Delete(employeeSpeciality);

            objectListView_UCEmployeeTCEdit_EditEmployee_Speciality.SetObjects(gui.SpecialityRepository.GetSpecialitiesFromLawyer(currentEmployee));
        }

        private void button_UCEmployeeTCManage_EditEmployee_Click(object sender, EventArgs e)
        {
            textbox_UCEmployeeTCEdit_firstName.Text = currentEmployee.FirstName;
            textbox_UCEmployeeTCEdit_lastName.Text = currentEmployee.LastName;
            textbox_UCEmployeeTCEdit_email.Text = currentEmployee.Email;
            textbox_UCEmployeeTCEdit_phone.Text = currentEmployee.Phone;
            combo_UCEmployeeTCEdit_Role.SelectedValue = currentEmployee.RoleID;

            objectListView_UCEmployeeTCEdit_EditEmployee_Speciality.SetObjects(gui.SpecialityRepository.GetSpecialitiesFromLawyer(currentEmployee));

            //Load objectListView with employees cases
            List<Case> Caselist = gui.CaseRepository.GetCasesFromLawyer(currentEmployee.ID);
            objectListView_UCEmployeeTCEdit_EditEmployee_ShowCases.SetObjects(Caselist);

            TabControl_UCEmployee.SelectedTab = TC_UCEmployeeTC_EditEmployee;
        }

        private void checkBox_UCEmployeeTCManage_IsFinished_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox_UCEmployeeTCManage_IsFinished.Checked)
            {
                checkBox_UCEmployeeTCManage_IsFinished.Text = "Se alle færdige sager";
                //caselist = gui.CaseRepository.GetAllOpenCases();
                //objectListView_UCCaseTCFind_FindCase.SetObjects(caselist);
            }
            if (checkBox_UCEmployeeTCManage_IsFinished.Checked)
            {
                checkBox_UCEmployeeTCManage_IsFinished.Text = "Se alle igangværende sager";
                //caselist = gui.CaseRepository.GetAllDoneCases();
                //objectListView_UCCaseTCFind_FindCase.SetObjects(caselist);
            }
        }
    }
}
