using System;
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
using BrightIdeasSoftware;

namespace GUI
{
    public partial class UserControlServices : UserControl
    {
        GUIForm gui;
        private Service currentService;
        public UserControlServices(GUIForm guiForm)
        {
            InitializeComponent();
            gui = guiForm;
            SetObjectListViewServices();
        }

        private void SetObjectListViewServices()
        {
            List<Service> servicelist = gui.ServiceRepository.GetAll();
            objectListView_UCServiceTCFind_FindService.SetObjects(servicelist);
        }

        private void button_UCCServicesTCFind_CreateService_Click(object sender, EventArgs e)
        {
            TabControl_UCServices.SelectedTab = TC_UCServiceTC_CreateService;
        }

        private void button_UCServicesTCCreate_FindService_Click(object sender, EventArgs e)
        {
            TabControl_UCServices.SelectedTab = TC_UCServiceTC_FindService;
        }

        private void button_UCServicesTCEdit_FindService_Click(object sender, EventArgs e)
        {
            TabControl_UCServices.SelectedTab = TC_UCServiceTC_FindService;
        }

        private void button_UCServicesTCEdit_ManageService_Click(object sender, EventArgs e)
        {
            TabControl_UCServices.SelectedTab = TC_UCServiceTC_ManageService;
        }

        private void button_UCServicesTCManage_FindService_Click(object sender, EventArgs e)
        {
            TabControl_UCServices.SelectedTab = TC_UCServiceTC_FindService;
        }

        private void button_UCServicesTCManage_EditService_Click(object sender, EventArgs e)
        {
            TabControl_UCServices.SelectedTab = TC_UCServiceTC_EditService;
        }

        private void objectListView_UCServiceTCFind_FindService_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Service service = (Service)objectListView_UCServiceTCFind_FindService.SelectedObject;
            label_UCServicesTCManage_ServiceName.Text = service.Name;
            //richTextBox_UCServicesTCManage_Description.Text = service.Description;
        }
    }
}
