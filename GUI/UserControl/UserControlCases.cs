using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using BusinessLogic.Models;
using BrightIdeasSoftware;
using System.Diagnostics;

namespace GUI
{
    public partial class UserControlCases : UserControl
    {
        private Case currentCase;
        private List<Case> caselist;
        GUIForm gui;
        public UserControlCases(GUIForm guiForm)
        {
            gui = guiForm;
            InitializeComponent();
            //vælg klient
            SetComboBoxClient(comboBox_UCCaseTCCreate_ChooseClient);
            SetComboBoxClient(comboBox_UCCaseTCEdit_ChangeClient);
            //vælg advokat
            SetComboBoxLawyer(comboBox_UCCaseTCCreate_ChooseLawyer);
            SetComboBoxLawyer(comboBox_UCCaseTCEdit_ChangeLawyer);
            //vælg ydelse
            SetComboboxService(comboBox_UCCaseTCCreate_ChooseService);
            SetComboboxService(comboBox_UCCaseTCManage_AddService);
            //object list view
            SetObjectListViewCases();            
        }

        /// <summary>
        /// Load Clients into the Combobox
        /// </summary>
        private void SetComboBoxClient(ComboBox comboBox)
        {
            List<Client> clientList = gui.ClientRepository.GetAll();
            comboBox.DataSource = clientList;
            comboBox.DisplayMember = "FullName";
            comboBox.ValueMember = "ID";
            comboBox.SelectedIndex = -1;
            comboBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
        /// <summary>
        /// Load Laywers into the Combobox
        /// </summary>
        private void SetComboBoxLawyer(ComboBox comboBox)
        {
            List<Employee> lawyerList = gui.EmployeeRepository.GetAllLawyers();
            comboBox.DataSource = lawyerList;
            comboBox.DisplayMember = "FullName";
            comboBox.ValueMember = "ID";
            comboBox.SelectedIndex = -1;
            comboBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
        /// <summary>
        /// Load Services into the Combobox
        /// </summary>
        private void SetComboboxService(ComboBox comboBox)
        {
            List<Service> serviceList = gui.ServiceRepository.GetAll();
            comboBox.DataSource = serviceList;
            comboBox.DisplayMember = "Name";
            comboBox.ValueMember = "ID";
            comboBox.SelectedIndex = -1;
            comboBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
        /// <summary>
        /// Load ObjectListView with open cases
        /// </summary>
        private void SetObjectListViewCases()
        {
            caselist = gui.CaseRepository.GetAllOpenCases();
            objectListView_UCCaseTCFind_FindCase.SetObjects(caselist);
        }
        /// <summary>
        /// Resets the search textbox
        /// </summary>
        public void ResetSearchBox(object sender, EventArgs e)
        {
            textBox_UCCaseTCFind_Search.Text = null;
        }

        /// <summary>
        ///     Menubar toggle event. This event gets called multiple times by objects on same usercontrol. 
        /// </summary>
        private void objectListView_UCCaseTCFind_FindCase_MouseEnter(object sender, EventArgs e)
        {
            gui.toggleMenuPanel();
        }
        /// <summary>
        /// Switch to the Create case tab and load all comboboxes
        /// </summary>
        private void button_UCCaseTCFind_CreateCase_Click(object sender, EventArgs e)
        {

            //vælg klient
            SetComboBoxClient(comboBox_UCCaseTCCreate_ChooseClient);
            //vælg advokat
            SetComboBoxLawyer(comboBox_UCCaseTCCreate_ChooseLawyer);
            //vælg ydelse
            SetComboboxService(comboBox_UCCaseTCCreate_ChooseService);

            TabControl_UCCases.SelectedTab = TC_UCCaseTC_CreateCase;
            //GUINavigationLabel
            gui.setGUINavigationLabel("Opret Sag");
        }
        /// <summary>
        /// Switch to the Find case tab
        /// </summary>
        private void button_UCCaseTCEdit_FindCase_Click(object sender, EventArgs e)
        {
            TabControl_UCCases.SelectedTab = TC_UCCaseTC_FindCase;
            //GUINavigationLabel
            gui.setGUINavigationLabel("Find Sag");
        }
        /// <summary>
        /// Switch to the Manage case and load all comboboxes
        /// </summary>
        private void button_UCCaseTCEdit_ManageCase_Click(object sender, EventArgs e)
        {
            //her skal indlæses sager
            LoadCaseservicesTObjectListView(currentCase);

            //vælg ydelse
            SetComboboxService(comboBox_UCCaseTCManage_AddService);

            TabControl_UCCases.SelectedTab = TC_UCCaseTC_ManageCase;
            //GUINavigationLabel
            gui.setGUINavigationLabel("Administrer Sag");
        }
        /// <summary>
        /// Switch to the Find case and reset all controls on CreateCase
        /// </summary>
        private void button_UCCaseTCCreate_FindCase_Click(object sender, EventArgs e)
        {
            gui.ClearControlCollection(TC_UCCaseTC_CreateCase.Controls);
            TabControl_UCCases.SelectedTab = TC_UCCaseTC_FindCase;
            //GUINavigationLabel
            gui.setGUINavigationLabel("Find Sag");
        }
        /// <summary>
        /// Switch to the Find case tab
        /// </summary>
        private void button_UCCaseTCManage_FindCase_Click(object sender, EventArgs e)
        {
            TabControl_UCCases.SelectedTab = TC_UCCaseTC_FindCase;
            //GUINavigationLabel
            gui.setGUINavigationLabel("Find Sag");
        }
        /// <summary>
        /// Switch to the Manage case tab and load all comboboxes
        /// </summary>
        private void button_UCCaseTCManage_EditCase_Click(object sender, EventArgs e)
        {
            //klient
            SetComboBoxClient(comboBox_UCCaseTCEdit_ChangeClient);
            //advokat
            SetComboBoxLawyer(comboBox_UCCaseTCEdit_ChangeLawyer);

            richTextBox_UCCaseTCEdit_Description.Text = currentCase.Description;
            // objectlistview 
            Dictionary<CaseService, Service> servicesByCaseService = gui.CaseServiceRepository.GetServicesByCaseServiceFromCase(currentCase);
            objectListView_UCCaseTCEdit_Services.SetObjects(servicesByCaseService);
            //import current values
            Client client = gui.ClientRepository.Get(currentCase.ClientID);
            Employee employee = gui.EmployeeRepository.Get(currentCase.EmployeeID);

            label_UCCaseTCEdit_CaseID_Show.Text = Convert.ToString(currentCase.ID);
            textBox_UCCaseTCEdit_ChangeName.Text = currentCase.Title;
            comboBox_UCCaseTCEdit_ChangeClient.SelectedValue = client.ID;
            comboBox_UCCaseTCEdit_ChangeLawyer.SelectedValue = employee.ID;

            TabControl_UCCases.SelectedTab = TC_UCCaseTC_EditCase;
            //GUINavigationLabel
            gui.setGUINavigationLabel("Rediger Sag");
        }
        /// <summary>
        /// Create case - Sends the data to DataAccess layer
        /// </summary>
        private void button_UCCaseTCCreate_CreateCase_Click(object sender, EventArgs e)
        {
            Case @case = null;
            try
            {
                @case = new Case
                    (
                    textBox_UCCaseTCCreate_Title.Text,
                    richTextBox_UCCaseTCCreate_Description.Text,
                    DateTime.Now,
                    (int)comboBox_UCCaseTCCreate_ChooseClient.SelectedValue,
                    (int)comboBox_UCCaseTCCreate_ChooseLawyer.SelectedValue
                    );
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Kunne ikke oprette sagen! Advokat og klient må ikke være tomme.");
            }
            gui.CaseRepository.Create(@case);
            SetObjectListViewCases();

            foreach(Service service in objectListView_UCCaseTCCreate_Service.Objects)
            {
                gui.CaseServiceRepository.AddServiceToCase(service, @case);
            }

            gui.ClearControlCollection(TC_UCCaseTC_CreateCase.Controls);
        }
        /// <summary>
        /// Switch to the Manage case tab after the user has doubleclicked a obeject in the olv
        /// </summary>
        private void objectListView_UCCaseTCFind_FindCase_DoubleClick(object sender, EventArgs e)
        {
            Case @case = (Case)objectListView_UCCaseTCFind_FindCase.SelectedObject;
            label_UCCaseTCManage_CaseID_Show.Text = Convert.ToString(@case.ID);
            label_UCCaseTCManage_CaseName_Show.Text = @case.Title;
            richTextBox_UCCaseTCManage_Description.Text = @case.Description;
            //her skal indlæses sager
            LoadCaseservicesTObjectListView(@case);

            //ydelse
            SetComboboxService(comboBox_UCCaseTCManage_AddService);

            currentCase = @case;
            TabControl_UCCases.SelectedTab = TC_UCCaseTC_ManageCase;
            //GUINavigationLabel
            gui.setGUINavigationLabel("Administrer Sag");
        }
        /// <summary>
        /// Load CaseServices into olv
        /// </summary>
        private void LoadCaseservicesTObjectListView(Case @case)
        {
            Dictionary<CaseService, Service> servicesByCaseService = gui.CaseServiceRepository.GetServicesByCaseServiceFromCase(@case);
            objectListView_UCCaseTCManage_ManageService.SetObjects(servicesByCaseService);
        }
        /// <summary>
        /// Adds a Service to a new Case
        /// </summary>
        private void button_UCCaseTCCreate_AddService_Click(object sender, EventArgs e)
        {
            List<Service> servicesInObjectListView = new List<Service>();
            if (objectListView_UCCaseTCCreate_Service.Objects != null)
                servicesInObjectListView = objectListView_UCCaseTCCreate_Service.Objects.Cast<Service>().ToList();
            Service selectedService = (Service)comboBox_UCCaseTCCreate_ChooseService.SelectedItem;
            bool exists = servicesInObjectListView.Any(s => s.ID == selectedService.ID);
            if (!exists)
                objectListView_UCCaseTCCreate_Service.AddObject(selectedService);
        }
        /// <summary>
        /// Adds a Service to a Case
        /// </summary>
        private void button_UCCaseTCManage_AddService_Click(object sender, EventArgs e)
        {
            if (objectListView_UCCaseTCManage_ManageService != null)
            {
                Service selectedService = (Service)comboBox_UCCaseTCManage_AddService.SelectedItem;
                List<Service> servicesInObjectListView = new List<Service>();
                foreach (var item in objectListView_UCCaseTCManage_ManageService.Objects)
                {
                    KeyValuePair<CaseService, Service> keyValue = (KeyValuePair<CaseService, Service>)item;
                    Service service = keyValue.Value;
                    servicesInObjectListView.Add(service); 
                }
                bool exists = servicesInObjectListView.Any(s => s.ID == selectedService.ID);
                if (!exists)
                {
                    gui.CaseServiceRepository.AddServiceToCase((Service)comboBox_UCCaseTCManage_AddService.SelectedItem, currentCase);
                    LoadCaseservicesTObjectListView(currentCase);
                    comboBox_UCCaseTCManage_AddService.SelectedIndex = -1;
                }
                else
                {
                    comboBox_UCCaseTCManage_AddService.SelectedIndex = -1;
                }
            }
            else
            {
                gui.CaseServiceRepository.AddServiceToCase((Service)comboBox_UCCaseTCManage_AddService.SelectedItem, currentCase);
                LoadCaseservicesTObjectListView(currentCase);
                comboBox_UCCaseTCManage_AddService.SelectedIndex = -1;
            }
        }
        /// <summary>
        /// Saves the content off the richtextbox on Manage Client
        /// </summary>
        private void button_UCCaseTCManage_Save_Click(object sender, EventArgs e)
        {
            currentCase.Description = richTextBox_UCCaseTCManage_Description.Text;
            gui.CaseRepository.Update(currentCase);
            MessageBox.Show("Det virkede!");
        }
        /// <summary>
        /// Saves the chances after the user has edited the client
        /// </summary>
        private void button_UCCaseTCEdit_SaveChange_Click(object sender, EventArgs e)
        {
            currentCase.Description = richTextBox_UCCaseTCEdit_Description.Text;
            if(!string.IsNullOrEmpty(comboBox_UCCaseTCEdit_ChangeClient.Text))
            {
                currentCase.ClientID = (int)comboBox_UCCaseTCEdit_ChangeClient.SelectedValue;
            }
            if(!string.IsNullOrEmpty(comboBox_UCCaseTCEdit_ChangeLawyer.Text))
            {
                currentCase.EmployeeID = (int)comboBox_UCCaseTCEdit_ChangeLawyer.SelectedValue;
            }
            if (!string.IsNullOrEmpty(textBox_UCCaseTCEdit_ChangeName.Text))
            {
                currentCase.Title = textBox_UCCaseTCEdit_ChangeName.Text;
            }
            gui.CaseRepository.Update(currentCase);
            // clear tab
            textBox_UCCaseTCEdit_ChangeName.Clear();
            comboBox_UCCaseTCEdit_ChangeClient.SelectedIndex = -1;
            comboBox_UCCaseTCEdit_ChangeLawyer.SelectedIndex = -1;

            TabControl_UCCases.SelectedTab = TC_UCCaseTC_ManageCase;
            //GUINavigationLabel
            gui.setGUINavigationLabel("Administrer Sag");

        }
        /// <summary>
        /// Deletes a Case
        /// </summary>
        private void button_UCCaseTCEdit_DeleteCase_Click(object sender, EventArgs e)
        {
            gui.CaseServiceRepository.DeleteAllServicesOnACase(currentCase);
            gui.CaseRepository.Delete(currentCase);
            //Refresh Find case object list view
            SetObjectListViewCases();
            TabControl_UCCases.SelectedTab = TC_UCCaseTC_FindCase;
            //GUINavigationLabel
            gui.setGUINavigationLabel("Find Sag");
        }
        /// <summary>
        /// Removes a Service from a Case
        /// </summary>
        private void button_UCCaseTCEdit_RemoveService_Click(object sender, EventArgs e)
        {
            KeyValuePair<CaseService, Service> caseServiceServiceKeyValuePair = (KeyValuePair<CaseService, Service>)objectListView_UCCaseTCEdit_Services.SelectedObject;
            CaseService caseService = caseServiceServiceKeyValuePair.Key;
            gui.CaseServiceRepository.Delete(caseService);
            // refresh objectlistview 
            Dictionary<CaseService, Service> servicesByCaseService = gui.CaseServiceRepository.GetServicesByCaseServiceFromCase(currentCase);
            objectListView_UCCaseTCEdit_Services.SetObjects(servicesByCaseService);
        }
        /// <summary>
        /// Checks after Qualified laywers
        /// </summary>
        private void radioButton_UCCaseTCCreate_Qualified_CheckedChanged(object sender, EventArgs e)
        {
                List<Service> services = objectListView_UCCaseTCCreate_Service.Objects.Cast<Service>().ToList();
            comboBox_UCCaseTCCreate_ChooseLawyer.DataSource = gui.EmployeeRepository.GetAllFullyQualifiedLawyersFromServices(services);
            comboBox_UCCaseTCCreate_ChooseLawyer.SelectedIndex = -1;
        }

        private void radioButton_UCCaseTCCreate_All_CheckedChanged(object sender, EventArgs e)
        {
            comboBox_UCCaseTCCreate_ChooseLawyer.DataSource = gui.EmployeeRepository.GetAllLawyers();
            comboBox_UCCaseTCCreate_ChooseLawyer.SelectedIndex = -1;
        }
        /// <summary>
        /// Makes the search field sort the list view
        /// </summary>
        private void textBox_UCCaseTCFind_Search_TextChanged(object sender, EventArgs e)
        {
            this.objectListView_UCCaseTCFind_FindCase.UseFiltering = true;
            this.objectListView_UCCaseTCFind_FindCase.ModelFilter = TextMatchFilter.Contains(this.objectListView_UCCaseTCFind_FindCase, $"{textBox_UCCaseTCFind_Search.Text}");
        }
        /// <summary>
        ///      Since ObjectListView cannot handle updating a KeyValuePair object correctly, we do it manually here
        /// </summary>
        private void objectListView_UCCaseTCManage_ManageService_CellEditFinishing(object sender, CellEditEventArgs e)
        {
            KeyValuePair<CaseService, Service> keyValue = (KeyValuePair<CaseService, Service>)e.RowObject;

            string c = e.Column.AspectName;
            switch (c)
            {
                case "Key.Hours":
                    keyValue.Key.Hours = (double)e.NewValue;
                    Debug.WriteLine("object value: " + keyValue.Key.Hours);
                    break;
                case "Key.EstimatedHours":
                    keyValue.Key.EstimatedHours = (double)e.NewValue;
                    Debug.WriteLine("object value: " + keyValue.Key.EstimatedHours);
                    break;
                default:
                    break;
            }
        }
        /// <summary>
        ///     We take the newly updatet object in the ObjectListView and save it to the database. 
        /// </summary>
        private void objectListView_UCCaseTCManage_ManageService_CellEditFinished(object sender, CellEditEventArgs e)
        {
            KeyValuePair<CaseService, Service> keyValue = (KeyValuePair<CaseService, Service>)e.RowObject;
            var caseService = keyValue.Key;
                      
            gui.CaseServiceRepository.UpdateCaseService(caseService);
        }
        /// <summary>
        ///     CheckBox switch the content in olv from done to Not done cases 
        /// </summary>
        private void checkBox_UCCaseTCFind_IsFinished_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox_UCCaseTCFind_IsFinished.Checked)
            {
                caselist = gui.CaseRepository.GetAllOpenCases();
                objectListView_UCCaseTCFind_FindCase.SetObjects(caselist);
            }
            if (checkBox_UCCaseTCFind_IsFinished.Checked)
            {
                caselist = gui.CaseRepository.GetAllDoneCases();
                objectListView_UCCaseTCFind_FindCase.SetObjects(caselist);
            }
        }
        /// <summary>
        ///    Close/End a Case and insert end date on the case obejct in the DB
        /// </summary>
        private void button_UCCaseTCManage_CloseCase_Click(object sender, EventArgs e)
        {
            if (currentCase.Status)
            {
                currentCase.Status = false;
                gui.CaseRepository.Update(currentCase);
                button_UCCaseTCManage_CloseCase.Text = "Afslut sag";
                //Refresh Find case object list view
                SetObjectListViewCases();
                TabControl_UCCases.SelectedTab = TC_UCCaseTC_FindCase;
                if (checkBox_UCCaseTCFind_IsFinished.Checked)
                    checkBox_UCCaseTCFind_IsFinished.Checked = false;
                //GUINavigationLabel
                gui.setGUINavigationLabel("Find Sag");
            }
            else if (!currentCase.Status)
            {
                currentCase.Status = true;
                currentCase.EndDate = DateTime.Now;
                gui.CaseRepository.Update(currentCase);
                button_UCCaseTCManage_CloseCase.Text = "Genåben sag";
                //Refresh Find case object list view
                SetObjectListViewCases();
                TabControl_UCCases.SelectedTab = TC_UCCaseTC_FindCase;
                //GUINavigationLabel
                gui.setGUINavigationLabel("Find Sag");

            }
            
        }
    }
}
