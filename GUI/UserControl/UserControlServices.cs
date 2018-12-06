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
            gui = guiForm;
            InitializeComponent();

            // objectlistview 
            SetObjectListViewServices();
            

        }

        private void SetObjectListViewServices()
        {
            olvColumn_UCServiceTCFind_IsHourly.AspectGetter = delegate (object obj)
            {
                Service service = (Service)obj;
                return service.IsHourly == true ? "Timepris" : "Fastpris";
            };
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
            //richTextBox_UCServiceTCEdit_Description.Text = currentService.Description;

            TabControl_UCServices.SelectedTab = TC_UCServiceTC_EditService;

            //labels
            label_UCServicesTCEdit_CurrentName.Text = currentService.Name;
            label_UCServicesTCEdit_CurrentPrice.Text = Convert.ToString(currentService.Price);
            if (currentService.IsHourly == true)
            {
                label_UCServicesTCEdit_CurrentIsHourly.Text = "Timepris";
            }
            else
            {
                label_UCServicesTCEdit_CurrentIsHourly.Text = "Fastpris";
            }


        }

        private void objectListView_UCServiceTCFind_FindService_MousefloatClick(object sender, MouseEventArgs e)
        {
            Service service = (Service)objectListView_UCServiceTCFind_FindService.SelectedObject;
            label_UCServicesTCManage_ServiceName.Text = service.Name;
            richTextBox_UCServicesTCManage_Description.Text = service.Description;
            currentService = service;

            TabControl_UCServices.SelectedTab = TC_UCServiceTC_ManageService;
        }

        private void bottom_UCServiceTCCreate_Create_Click(object sender, EventArgs e)
        {
            Service service = new Service();
            service.Description = richTextBox_UCServicesTCCreate_Description.Text;
            service.Name = textbox_UCCServiceTCCreate_Name.Text;
            service.Price = Convert.ToSingle(textbox_UCCServiceTCCreate_Price.Text);
            if (radioButton_UCCServiceTCCreate_IsHourlyYes.Checked)
            {
                service.IsHourly = true;
            }
            else if (radioButton_UCCServiceTCCreate_IsHourlyNo.Checked)
            {
                service.IsHourly = false;
            }
            gui.ServiceRepository.Create(service);
            SetObjectListViewServices();
            TabControl_UCServices.SelectedTab = TC_UCServiceTC_FindService;
        }
    }
}
