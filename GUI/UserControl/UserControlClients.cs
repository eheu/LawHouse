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
        private void SetObjectListViewClients()
        {
            List<Client> clientlist = gui.ClientRepository.GetAll();
            objectListView_UCClientTCFind_FindClient.SetObjects(clientlist);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Client NewClient = new Client();
            NewClient.FirstName = textBox1.Text;
            gui.ClientRepository.Create(NewClient);
        }
    }
}
