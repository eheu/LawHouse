using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BusinessLogic.Models;
using BrightIdeasSoftware;

namespace GUI
{
    public partial class UserControlClients : UserControl
    {
        GUIForm gui;
        private Client currentClient;
        public UserControlClients(GUIForm guiForm)
        {
            gui = guiForm;
            InitializeComponent();
            //Load of clients into the objectlistview
            SetObjectListViewClients();
        }

        void SetCaseAndEmployeeObjectListViews(ObjectListView ObjectListViewName)
        {
            List<Case> Caselist = gui.CaseRepository.GetCasesFromClient(currentClient.ID);
            var CaseAndEmployeeDictionary = new Dictionary<Case, Employee>();
            foreach (Case item in Caselist)
            {
                Employee caseEmployee = gui.EmployeeRepository.Get(item.EmployeeID);
                CaseAndEmployeeDictionary.Add(item, caseEmployee);
            }
            ObjectListViewName.SetObjects(CaseAndEmployeeDictionary);
        }

        private void UserControlClients_MouseEnter(object sender, EventArgs e)
        {
            gui.toggleMenuPanel();
        }
        private void button_UCClientTCFind_CreateClient_Click(object sender, EventArgs e)
        {
            TabControl_UCClient.SelectedTab = TC_UCClientTC_CreateClient;
            //GUINavigationLabel
            gui.setGUINavigationLabel("Opret Klient");
        }

        private void bottom_UCClientTCEdit_FindCase_Click(object sender, EventArgs e)
        {
            TabControl_UCClient.SelectedTab = TC_UCClientTC_FindClient;
            //GUINavigationLabel
            gui.setGUINavigationLabel("Find Klient");
        }

        private void SetObjectListViewClients()
        {
            List<Client> clientlist = gui.ClientRepository.GetAll();
            objectListView_UCClientTCFind_FindClient.SetObjects(clientlist);
        }

        private void bottom_UCClientTCCreate_Save_Click(object sender, EventArgs e)
        {
            try
            {
                Client NewClient = new Client
                {
                    FirstName = textbox_UCClientTCCreate_firstName.Text,
                    LastName = textbox_UCClientTCCreate_lastName.Text,
                    Phone = textbox_UCClientTCCreate_phone.Text,
                    Address = textbox_UCClientTCCreate_addresse.Text,
                    Email = textbox_UCClientTCCreate_email.Text
                };
                //Send to DB.
                gui.ClientRepository.Create(NewClient);
                label_UCClientTCCreate_Save.Text = "Klienten er nu gemt";
            }
            catch (Exception)
            {
                label_UCClientTCCreate_Save.Text = "Der er sket en fejl";
            }

            //Clear textBoxes
            gui.ClearTextBoxesAndComboBoxesAndListBoxes(TC_UCEmployeeTC_CreateClient.Controls);

            //Refreash olv
            SetObjectListViewClients();

            //User send back to Find_Client
            TabControl_UCClient.SelectedTab = TC_UCEmployeeTC_FindClient;
        }

        /// <summary>
        /// Send Client object to Manage Client tab
        /// </summary>
        private void objectListView_UCClientTCFind_FindClient_MouseDoubleClick(object sender, EventArgs e)
        {
            // user clicked an item of objectListView control
            if (objectListView_UCClientTCFind_FindClient.SelectedItems.Count == 1)
            {
                currentClient = (Client)objectListView_UCClientTCFind_FindClient.SelectedObject;

                label_UCClientTCManage_firstName_Show.Text = currentClient.FirstName;
                label_UCClientTCManage_lastName_Show.Text = currentClient.LastName;
                label_UCClientTCManage_phone_Show.Text = currentClient.Phone;
                label_UCClientTCManage_addresse_Show.Text = currentClient.Address;
                label_UCClientTCManage_email_Show.Text = currentClient.Email;

                //Load Cases and Laywers
                SetCaseAndEmployeeObjectListViews(objectListView_UCClientTCManage);

                TabControl_UCClient.SelectedTab = TC_UCClientTC_ManageClient;
                //GUINavigationLabel
                gui.setGUINavigationLabel("Administrer Klient");
            }
        }
        /// <summary>
        /// Makes the search field sort the list view
        /// </summary>
        private void textBox_UCCaseTCFind_Search_TextChanged(object sender, EventArgs e)
        {
            this.objectListView_UCClientTCFind_FindClient.UseFiltering = true;
            this.objectListView_UCClientTCFind_FindClient.ModelFilter = TextMatchFilter.Contains(this.objectListView_UCClientTCFind_FindClient, $"{textBox_UCClientTCFind_Search.Text}");
        }

        private void bottom_UCClientTCManage_Edit_Click(object sender, EventArgs e)
        {
            textbox_UCClientTCEdit_firstName.Text = currentClient.FirstName;
            textbox_UCClientTCEdit_lastName.Text = currentClient.LastName;
            textbox_UCClientTCEdit_phone.Text = currentClient.Phone;
            textbox_UCClientTCEdit_addresse.Text = currentClient.Address;
            textbox_UCClientTCEdit_email.Text = currentClient.Email;

            //Load Cases and Laywers
            SetCaseAndEmployeeObjectListViews(objectListView_UCClientTCEdit);

            TabControl_UCClient.SelectedTab = TC_UCClientTC_EditClient;
            //GUINavigationLabel
            gui.setGUINavigationLabel("Rediger Klient");

        }

        private void button_UCClientTCCreate_FindClient_Click(object sender, EventArgs e)
        {
            TabControl_UCClient.SelectedTab = TC_UCClientTC_FindClient;
            //GUINavigationLabel
            gui.setGUINavigationLabel("Find Klient");
        }

        private void button_UCClientTCEdit_ManageClient_Click(object sender, EventArgs e)
        {
            TabControl_UCClient.SelectedTab = TC_UCClientTC_ManageClient;
            //GUINavigationLabel
            gui.setGUINavigationLabel("Administrer Klient");
        }
    }
}
