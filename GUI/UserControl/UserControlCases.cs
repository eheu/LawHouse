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
using BusinessLogic.Models;

namespace GUI
{
    public partial class UserControlCases : UserControl
    {
        private Case currentCase;
        GUIForm gui;
        public UserControlCases(GUIForm guiForm)
        {
            gui = guiForm;
            InitializeComponent();
            //vælg klient
            SetComboBowClint(comboBox_UCCaseTCCreate_ChooseClient);
            SetComboBowClint(comboBox_UCCaseTCEdit_ChangeClient);
            //vælg advokat
            SetComboBoxLawyer(comboBox_UCCaseTCCreate_ChooseLawyer);
            SetComboBoxLawyer(comboBox_UCCaseTCEdit_ChangeLawyer);
            //vælg ydelse
            SetComboboxService(comboBox_UCCaseTCCreate_ChooseService);
            SetComboboxService(comboBox_UCCaseTCManage_AddService);
            //object list view
            SetObjectListViewCases();
            // liste af valgte ydelser, opret sag
            List<Service> serviceList = new List<Service>();
            listBox_UCCaseTCCreate_Service.DisplayMember = "Name";
            listBox_UCCaseTCCreate_Service.ValueMember = "ID";
            
        }

        private void SetComboBowClint(ComboBox comboBox)
        {
            List<Client> clientList = gui.ClientRepository.GetAll();
            comboBox.DataSource = clientList;
            comboBox.DisplayMember = "FullName";
            comboBox.ValueMember = "ID";
            comboBox.SelectedIndex = -1;
            comboBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

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

        private void SetObjectListViewCases()
        {
            List<Case> caselist = gui.CaseRepository.GetAll();
            objectListView_UCCaseTCFind_FindCase.SetObjects(caselist);
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
            //her skal indlæses sager
            LoadCaseservicesTObjectListView(currentCase);
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
            richTextBox_UCCaseTCEdit_Description.Text = currentCase.Description;
            // objectlistview 
            Dictionary<CaseService, Service> servicesByCaseService = gui.CaseServiceRepository.GetServicesByCaseServiceFromCase(currentCase);
            objectListView_UCCaseTCEdit_Services.SetObjects(servicesByCaseService);
            //labels
            Client client = gui.ClientRepository.Get(currentCase.ClientID);
            Employee employee = gui.EmployeeRepository.Get(currentCase.EmployeeID);
            label_UCCaseTCEdit_CurrentName.Text = currentCase.Title;
            label_UCCaseTCEdit_CurrentClient.Text = client.FullName;
            label_UCCaseTCEdit_CurrentLawyer.Text = employee.FullName;

            TabControl_UCCases.SelectedTab = TC_UCCaseTC_EditCase;
        }

        private void button_UCCaseTCCreate_CreateCase_Click(object sender, EventArgs e)
        {
            Case @case = new Case();
            @case.Description = richTextBox_UCCaseTCCreate_Description.Text;
            @case.Title = textBox_UCCaseTCCreate_Title.Text;
            @case.ClientID = (int)comboBox_UCCaseTCCreate_ChooseClient.SelectedValue;
            @case.EmployeeID = (int)comboBox_UCCaseTCCreate_ChooseLawyer.SelectedValue;
            gui.CaseRepository.Create(@case);
            SetObjectListViewCases();

            foreach(Service service in listBox_UCCaseTCCreate_Service.Items)
            {
                gui.CaseServiceRepository.AddServiceToCase(service, @case);
            }

            MessageBox.Show("virkede");
        }

        private void objectListView_UCCaseTCFind_FindCase_DoubleClick(object sender, EventArgs e)
        {
            Case @case = (Case)objectListView_UCCaseTCFind_FindCase.SelectedObject;
            label_UCCaseTCManage_CaseName.Text = @case.Title;
            richTextBox_UCCaseTCManage_Description.Text = @case.Description;
            //her skal indlæses sager
            LoadCaseservicesTObjectListView(@case);

            currentCase = @case;
            TabControl_UCCases.SelectedTab = TC_UCCaseTC_ManageCase;
        }

        
        private void LoadCaseservicesTObjectListView(Case @case)
        {
            Dictionary<CaseService, Service> caseNameDictionary = gui.CaseServiceRepository.GetServicesByCaseServiceFromCase(@case);
            objectListView_UCCaseTCManage_ManageService.SetObjects(caseNameDictionary);
        }

        private void button_UCCaseTCCreate_AddService_Click(object sender, EventArgs e)
        {
            if (!listBox_UCCaseTCCreate_Service.Items.Contains((Service)comboBox_UCCaseTCCreate_ChooseService.SelectedItem))
                listBox_UCCaseTCCreate_Service.Items.Add((Service)comboBox_UCCaseTCCreate_ChooseService.SelectedItem);
        }

        private void button_UCCaseTCManage_AddService_Click(object sender, EventArgs e)
        {
            gui.CaseServiceRepository.AddServiceToCase((Service)comboBox_UCCaseTCManage_AddService.SelectedItem, currentCase);
            LoadCaseservicesTObjectListView(currentCase);
        }

        private void button_UCCaseTCManage_Save_Click(object sender, EventArgs e)
        {
            currentCase.Description = richTextBox_UCCaseTCManage_Description.Text;
            gui.CaseRepository.Update(currentCase);
            MessageBox.Show("Det virkede!");
        }

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
            TabControl_UCCases.SelectedTab = TC_UCCaseTC_ManageCase;
            // clear tab
            textBox_UCCaseTCEdit_ChangeName.Clear();
            comboBox_UCCaseTCEdit_ChangeClient.SelectedIndex = -1;
            comboBox_UCCaseTCEdit_ChangeLawyer.SelectedIndex = -1;
        }

        private void button_UCCaseTCEdit_DeleteCase_Click(object sender, EventArgs e)
        {
            gui.CaseServiceRepository.DeleteAllServicesOnACase(currentCase);
            gui.CaseRepository.Delete(currentCase);
            //Refresh Find case object list view
            SetObjectListViewCases();
            TabControl_UCCases.SelectedTab = TC_UCCaseTC_FindCase;
        }

        private void button_UCCaseTCEdit_RemoveService_Click(object sender, EventArgs e)
        {
            KeyValuePair<CaseService, Service> caseServiceServiceKeyValuePair = (KeyValuePair<CaseService, Service>)objectListView_UCCaseTCEdit_Services.SelectedObject;
            CaseService caseService = caseServiceServiceKeyValuePair.Key;
            gui.CaseServiceRepository.Delete(caseService);
            // refresh objectlistview 
            Dictionary<CaseService, Service> caseNameDictionary = gui.CaseServiceRepository.GetServicesByCaseServiceFromCase(currentCase);
            objectListView_UCCaseTCEdit_Services.SetObjects(caseNameDictionary);
        }
    }
}
