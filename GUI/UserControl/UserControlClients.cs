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

            SetObjectListViewClients();
        }

        private void UserControlClients_MouseEnter(object sender, EventArgs e)
        {
            gui.toggleMenuPanel();
        }
        private void SetObjectListViewClients()
        {
            List<Client> clientlist = gui.ClientRepository.GetAll();
            objectListView_UCClientTCFind_FindClient.SetObjects(clientlist);
        }
    }
}
