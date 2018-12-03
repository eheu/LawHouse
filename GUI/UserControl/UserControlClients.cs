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
    public partial class UserControlClients : UserControl
    {
        GUIForm gui;
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

            textbox_UCClientTCCreate_firstName.Clear();
            textbox_UCClientTCCreate_lastName.Clear();
            textbox_UCClientTCCreate_phone.Clear();
            textbox_UCClientTCCreate_addresse.Clear();
            textbox_UCClientTCCreate_email.Clear();
        }

        private void objectListView_UCClientTCFind_FindClient_MouseDoubleClick(object sender, EventArgs e)
        {
            // user clicked an item of objectListView control
            if (objectListView_UCClientTCFind_FindClient.SelectedItems.Count == 1)
            {
                TabControl_UCClient.SelectedTab = TC_UCEmployeeTC_EditClient;

                Client client = (Client)objectListView_UCClientTCFind_FindClient.SelectedObject;

                textbox_UCClientTCEdit_firstName.Text = client.FirstName;
                textbox_UCClientTCEdit_lastName.Text = client.LastName;
                textbox_UCClientTCEdit_phone.Text = client.Phone;
                textbox_UCClientTCEdit_addresse.Text = client.Address;
                textbox_UCClientTCEdit_email.Text = client.Email;

                try
                {
                    List<Case> Caselist = gui.CaseRepository.GetCasesFromClient(client.ID);
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
}
