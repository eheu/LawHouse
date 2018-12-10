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
using System.Globalization;

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

            InitializeFindServiceObjectListView();
            InitializeAddServiceCombobox();
        }

        private void InitializeAddServiceCombobox()
        {
            comboBox_UCServicesTCCreate_AddSpeciality.DataSource = gui.SpecialityRepository.GetAll();
            comboBox_UCServicesTCCreate_AddSpeciality.DisplayMember = "Name";
            comboBox_UCServicesTCCreate_AddSpeciality.ValueMember = "ID";
        }

        private void InitializeAddSpecialityCombobox()
        {
            comboBox_UCServicesTCManage_AddSpeciality.DataSource = gui.SpecialityRepository.GetAll();
            comboBox_UCServicesTCManage_AddSpeciality.DisplayMember = "Name";
            comboBox_UCServicesTCManage_AddSpeciality.ValueMember = "ID";
            comboBox_UCServicesTCManage_AddSpeciality.SelectedIndex = -1;
        }

        private void InitializeFindServiceObjectListView()
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
            gui.ClearTextBoxesAndComboBoxesAndListBoxes(TC_UCServiceTC_CreateService.Controls);
            TabControl_UCServices.SelectedTab = TC_UCServiceTC_CreateService;
        }

        private void button_UCServicesTCCreate_FindService_Click(object sender, EventArgs e)
        {
            InitializeFindServiceObjectListView();
            TabControl_UCServices.SelectedTab = TC_UCServiceTC_FindService;
        }

        private void button_UCServicesTCEdit_FindService_Click(object sender, EventArgs e)
        {
            InitializeFindServiceObjectListView();
            TabControl_UCServices.SelectedTab = TC_UCServiceTC_FindService;
        }

        private void button_UCServicesTCEdit_ManageService_Click(object sender, EventArgs e)
        {
            TabControl_UCServices.SelectedTab = TC_UCServiceTC_ManageService;
        }

        private void button_UCServicesTCManage_FindService_Click(object sender, EventArgs e)
        {
            InitializeFindServiceObjectListView();
            TabControl_UCServices.SelectedTab = TC_UCServiceTC_FindService;
        }

        private void button_UCServicesTCManage_EditService_Click(object sender, EventArgs e)
        {
            richTextBox_UCServicesTCEdit_Description.Text = currentService.Description;

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

        private void objectListView_UCServiceTCFind_FindService_MousedoubleClick(object sender, MouseEventArgs e)
        {
            SetCurrentService();

            InitializeAddSpecialityCombobox();

            // Initialize ManageService ObjectListView
            objectListView_UCServicesTCManage_ManageService.SetObjects(gui.SpecialityRepository.GetSpecialitiesFromService(currentService));

            TabControl_UCServices.SelectedTab = TC_UCServiceTC_ManageService;

        }

        private void SetCurrentService()
        {
            Service service = (Service)objectListView_UCServiceTCFind_FindService.SelectedObject;
            label_UCServicesTCManage_ServiceName.Text = service.Name;
            richTextBox_UCServicesTCManage_Description.Text = service.Description;
            currentService = service;
        }

        /// <summary>
        /// creates service
        /// </summary>
        private void bottom_UCServiceTCCreate_Create_Click(object sender, EventArgs e)
        {
            Service service = new Service();
            service.Description = richTextBox_UCServicesTCCreate_Description.Text;
            service.Name = textbox_UCCServiceTCCreate_Name.Text;
            service.Price = Convert.ToDouble(textbox_UCCServiceTCCreate_Price.Text);
            if (radioButton_UCCServiceTCCreate_IsHourlyYes.Checked)
            {
                service.IsHourly = true;
            }
            else if (radioButton_UCCServiceTCCreate_IsHourlyNo.Checked)
            {
                service.IsHourly = false;
            }
            gui.ServiceRepository.Create(service);
            InitializeFindServiceObjectListView();
            TabControl_UCServices.SelectedTab = TC_UCServiceTC_FindService;
        }

        /// <summary>
        /// Saves in Manage service tab
        /// </summary>
        private void button_UCServicesTCManage_Save_Click(object sender, EventArgs e)
        {
            currentService.Description = richTextBox_UCServicesTCManage_Description.Text;
            gui.ServiceRepository.Update(currentService);
        }

        /// <summary>
        /// Saves in edit service tab
        /// </summary>
        private void button_UCServicesTCEdit_SaveChange_Click(object sender, EventArgs e)
        {
            currentService.Description = richTextBox_UCServicesTCEdit_Description.Text;
            currentService.Name = textBox_UCServiceTCEdit_ChangeName.Text;
            // weird thing "stackoverflow.com/a/10209412"
            double d = currentService.Price;
            double.TryParse(textBox_UCServiceTCEdit_ChangePrice.Text, out d);
            currentService.Price = d;
            //
            if (radioButton_UCCServiceTCEdit_IsHourlyYes.Checked)
            {
                currentService.IsHourly = true;
            }
            else if (radioButton_UCCServiceTCEdit_IsHourlyNo.Checked)
            {
                currentService.IsHourly = false;
            }
            gui.ServiceRepository.Update(currentService);
            //Change tab and update
            richTextBox_UCServicesTCManage_Description.Text = currentService.Description;
            label_UCServicesTCManage_ServiceName.Text = currentService.Name;
            gui.ClearTextBoxesAndComboBoxesAndListBoxes(TC_UCServiceTC_EditService.Controls);
            TabControl_UCServices.SelectedTab = TC_UCServiceTC_ManageService;
        }

        private void button_UCServicesTCEdit_DeleteService_Click(object sender, EventArgs e)
        {
            gui.ServiceRepository.Delete(currentService);
            InitializeFindServiceObjectListView();
            TabControl_UCServices.SelectedTab = TC_UCServiceTC_FindService;
        }

        private void button_UCServicesTCManage_AddSpeciality_Click(object sender, EventArgs e)
        {
            if (comboBox_UCServicesTCManage_AddSpeciality.SelectedItem != null)
            {
                List<Speciality> specialitiesInObjectListView = objectListView_UCServicesTCManage_ManageService.Objects.Cast<Speciality>().ToList(); //stackoverflow.com/a/7617784
                Speciality selectedSpeciality = (Speciality)comboBox_UCServicesTCManage_AddSpeciality.SelectedItem;
                bool exists = specialitiesInObjectListView.Any(s => s.ID == selectedSpeciality.ID);
                if (!exists) gui.ServiceSpecialityRepository.Create(new ServiceSpeciality(currentService.ID,selectedSpeciality.ID));
                objectListView_UCServicesTCManage_ManageService.SetObjects(gui.SpecialityRepository.GetSpecialitiesFromService(currentService));
            }
        }

        private void button_UCServicesTCCreate_AddSpeciality_Click(object sender, EventArgs e)
        {
            if (comboBox_UCServicesTCCreate_AddSpeciality.SelectedItem != null)
            {
                List<Speciality> specialitiesInObjectListView = objectListView_UCServicesTCCreate_Speciality.Objects.Cast<Speciality>().ToList();
                Speciality selectedSpeciality = (Speciality)comboBox_UCServicesTCCreate_AddSpeciality.SelectedItem;
                bool exists = specialitiesInObjectListView.Any(s => s.ID == selectedSpeciality.ID);
                if (!exists) objectListView_UCServicesTCCreate_Speciality.AddObject(selectedSpeciality);
            }
        }
}
