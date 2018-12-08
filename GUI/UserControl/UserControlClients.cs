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

        private void UserControlClients_MouseEnter(object sender, EventArgs e)
        {
            gui.toggleMenuPanel();
        }
        private void button_UCClientTCFind_CreateClient_Click(object sender, EventArgs e)
        {
            TabControl_UCClient.SelectedTab = TC_UCEmployeeTC_CreateClient;
        }

        private void bottom_UCClientTCEdit_Back_Click(object sender, EventArgs e)
        {
            TabControl_UCClient.SelectedTab = TC_UCEmployeeTC_FindClient;
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
            gui.ClearTextboxesAndCompoboxesAndlistboxes(TC_UCEmployeeTC_CreateClient.Controls);
        }

        /// <summary>
        /// Send Client object to Manage Client tab
        /// </summary>
        private void objectListView_UCClientTCFind_FindClient_MouseDoubleClick(object sender, EventArgs e)
        {
            // user clicked an item of objectListView control
            if (objectListView_UCClientTCFind_FindClient.SelectedItems.Count == 1)
            {
                TabControl_UCClient.SelectedTab = TC_UCEmployeeTC_ManageClient;

                currentClient = (Client)objectListView_UCClientTCFind_FindClient.SelectedObject;

                label_UCClientTCManage_firstName_Show.Text = currentClient.FirstName;
                label_UCClientTCManage_lastName_Show.Text = currentClient.LastName;
                label_UCClientTCManage_phone_Show.Text = currentClient.Phone;
                label_UCClientTCManage_addresse_Show.Text = currentClient.Address;
                label_UCClientTCManage_email_Show.Text = currentClient.Email;

                try
                {
                    List<Case> Caselist = gui.CaseRepository.GetCasesFromClient(currentClient.ID);
                    dataListView_UCClientTCManage.SetObjects(Caselist);

                    olvColumn_UCClient_TCManage_laywer_name.AspectGetter = delegate (object obj)
                    {
                        Case clientCase = (Case)obj;
                        Employee caseEmployee = gui.EmployeeRepository.Get(clientCase.EmployeeID);
                        return caseEmployee.FullName;
                    };
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {

                }
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
            TabControl_UCClient.SelectedTab = TC_UCEmployeeTC_EditClient;

            textbox_UCClientTCEdit_firstName.Text = currentClient.FirstName;
            textbox_UCClientTCEdit_lastName.Text = currentClient.LastName;
            textbox_UCClientTCEdit_phone.Text = currentClient.Phone;
            textbox_UCClientTCEdit_addresse.Text = currentClient.Address;
            textbox_UCClientTCEdit_email.Text = currentClient.Email;

            try
            {
                List<Case> Caselist = gui.CaseRepository.GetCasesFromClient(currentClient.ID);
                dataListView_UCClientTCEdit.SetObjects(Caselist);

                olvColumn_UCClient_TCEdit_laywer_name.AspectGetter = delegate (object obj)
                {
                    Case clientCase = (Case)obj;
                    Employee caseEmployee = gui.EmployeeRepository.Get(clientCase.EmployeeID);
                    return caseEmployee.FullName;
                };
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {

            }
        }
    }
}
