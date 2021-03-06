﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
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

            InitializeFindServiceObjectListView();
        }
        /// <summary>
        /// Reset the SearchBo
        /// </summary>
        public void ResetSearchBox(object sender, EventArgs e)
        {
            textBox_UCServicesTCFind_Search.Text = null;
        }
        /// <summary>
        /// Set Specialitycombobox on Create Services
        /// </summary>
        private void Set_ComboBox_UCServicesTCCreate_AddSpeciality()
        {
            comboBox_UCServicesTCCreate_AddSpeciality.DataSource = gui.SpecialityRepository.GetAll();
            comboBox_UCServicesTCCreate_AddSpeciality.DisplayMember = "Name";
            comboBox_UCServicesTCCreate_AddSpeciality.ValueMember = "ID";
            comboBox_UCServicesTCCreate_AddSpeciality.SelectedIndex = -1;
        }
        /// <summary>
        /// Set Specialitycombobox on Manage Services
        /// </summary>
        private void Set_ComboBox_UCServicesTCManage_AddSpeciality()
        {
            comboBox_UCServicesTCManage_AddSpeciality.DataSource = gui.SpecialityRepository.GetAll();
            comboBox_UCServicesTCManage_AddSpeciality.DisplayMember = "Name";
            comboBox_UCServicesTCManage_AddSpeciality.ValueMember = "ID";
            comboBox_UCServicesTCManage_AddSpeciality.SelectedIndex = -1;
        }
        /// <summary>
        /// Initialize Find Service ObjectListView
        /// </summary>
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
        /// <summary>
        /// Switch to Create Service tab
        /// </summary>
        private void button_UCCServicesTCFind_CreateService_Click(object sender, EventArgs e)
        {
            gui.ClearControlCollection(TC_UCServiceTC_CreateService.Controls);
            Set_ComboBox_UCServicesTCCreate_AddSpeciality();
            TabControl_UCServices.SelectedTab = TC_UCServiceTC_CreateService;
            //GUINavigationLabel
            gui.setGUINavigationLabel("Opret Ydelse");
        }
        /// <summary>
        /// Switch to Find Service tab
        /// </summary>
        private void button_UCServicesTCCreate_FindService_Click(object sender, EventArgs e)
        {
            InitializeFindServiceObjectListView();
            TabControl_UCServices.SelectedTab = TC_UCServiceTC_FindService;
            //GUINavigationLabel
            gui.setGUINavigationLabel("Find Ydelse");
        }
        /// <summary>
        /// Switch to Find Service tab
        /// </summary>
        private void button_UCServicesTCEdit_FindService_Click(object sender, EventArgs e)
        {
            InitializeFindServiceObjectListView();
            TabControl_UCServices.SelectedTab = TC_UCServiceTC_FindService;
            //GUINavigationLabel
            gui.setGUINavigationLabel("Find Ydelse");
        }
        /// <summary>
        /// Switch to Manage Service tab
        /// </summary>
        private void button_UCServicesTCEdit_ManageService_Click(object sender, EventArgs e)
        {
            TabControl_UCServices.SelectedTab = TC_UCServiceTC_ManageService;
            //GUINavigationLabel
            gui.setGUINavigationLabel("Administrer Ydelse");
        }
        /// <summary>
        /// Switch to Find Service tab
        /// </summary>
        private void button_UCServicesTCManage_FindService_Click(object sender, EventArgs e)
        {
            InitializeFindServiceObjectListView();
            TabControl_UCServices.SelectedTab = TC_UCServiceTC_FindService;
            //GUINavigationLabel
            gui.setGUINavigationLabel("Find Ydelse");
        }
        /// <summary>
        /// Switch to Edit Service tab
        /// </summary>
        private void button_UCServicesTCManage_EditService_Click(object sender, EventArgs e)
        {
            richTextBox_UCServicesTCEdit_Description.Text = currentService.Description;
            //labels
            textBox_UCServiceTCEdit_ChangeName.Text = currentService.Name;
            textBox_UCServiceTCEdit_ChangePrice.Text = Convert.ToString(currentService.Price);
            if (currentService.IsHourly == true)
            {
                radioButton_UCCServiceTCEdit_IsHourlyYes.Checked = true;
            }
            else
            {
                radioButton_UCCServiceTCEdit_IsHourlyNo.Checked = true;
            }

            //Load of olv
            objectListView_UCServicesTCEdit_Speciality.SetObjects(gui.SpecialityRepository.GetSpecialitiesFromService(currentService));

            TabControl_UCServices.SelectedTab = TC_UCServiceTC_EditService;
            //GUINavigationLabel
            gui.setGUINavigationLabel("Rediger Ydelse");
        }
        /// <summary>
        /// Switch to Manage Service tab and load olv
        /// </summary>
        private void objectListView_UCServiceTCFind_FindService_MousedoubleClick(object sender, MouseEventArgs e)
        {
            SetCurrentService();

            Set_ComboBox_UCServicesTCManage_AddSpeciality();

            // Initialize ManageService ObjectListView
            objectListView_UCServicesTCManage_ManageService.SetObjects(gui.SpecialityRepository.GetSpecialitiesFromService(currentService));

            TabControl_UCServices.SelectedTab = TC_UCServiceTC_ManageService;
            //GUINavigationLabel
            gui.setGUINavigationLabel("Administrer Ydelse");
        }
        /// <summary>
        /// Set Current Service 
        /// </summary>
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
            //GUINavigationLabel
            gui.setGUINavigationLabel("Find Ydelse");
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
            gui.ClearControlCollection(TC_UCServiceTC_EditService.Controls);
            TabControl_UCServices.SelectedTab = TC_UCServiceTC_ManageService;
            //GUINavigationLabel
            gui.setGUINavigationLabel("Administrer Ydelse");
        }
        /// <summary>
        /// Delete service
        /// </summary>
        private void button_UCServicesTCEdit_DeleteService_Click(object sender, EventArgs e)
        {
            gui.ServiceRepository.Delete(currentService);
            InitializeFindServiceObjectListView();
            TabControl_UCServices.SelectedTab = TC_UCServiceTC_FindService;
            //GUINavigationLabel
            gui.setGUINavigationLabel("Find Ydelse");
        }
        /// <summary>
        /// Manage service - AddSpeciality
        /// </summary>
        private void button_UCServicesTCManage_AddSpeciality_Click(object sender, EventArgs e)
        {
            if (comboBox_UCServicesTCManage_AddSpeciality.SelectedItem != null)
            {
                List<Speciality> specialitiesInObjectListView = objectListView_UCServicesTCManage_ManageService.Objects.Cast<Speciality>().ToList(); //stackoverflow.com/a/7617784
                Speciality selectedSpeciality = (Speciality)comboBox_UCServicesTCManage_AddSpeciality.SelectedItem;
                bool exists = specialitiesInObjectListView.Any(s => s.ID == selectedSpeciality.ID);
                if (!exists) gui.ServiceSpecialityRepository.Create(new ServiceSpeciality(currentService.ID, selectedSpeciality.ID));
                objectListView_UCServicesTCManage_ManageService.SetObjects(gui.SpecialityRepository.GetSpecialitiesFromService(currentService));
            }
        }
        /// <summary>
        /// Create service - AddSpeciality
        /// </summary>
        private void button_UCServicesTCCreate_AddSpeciality_Click(object sender, EventArgs e)
        {
            if (comboBox_UCServicesTCCreate_AddSpeciality.SelectedItem != null)
            {
                Speciality selectedSpeciality = (Speciality)comboBox_UCServicesTCCreate_AddSpeciality.SelectedItem;
                if (objectListView_UCServicesTCCreate_Speciality.Objects == null)
                    objectListView_UCServicesTCCreate_Speciality.AddObject(selectedSpeciality);
                else
                {
                    List<Speciality> specialitiesInObjectListView = objectListView_UCServicesTCCreate_Speciality.Objects.Cast<Speciality>().ToList();
                    bool exists = specialitiesInObjectListView.Any(s => s.ID == selectedSpeciality.ID);
                    if (!exists)
                        objectListView_UCServicesTCCreate_Speciality.AddObject(selectedSpeciality);
                }
            }
        }
        /// <summary>
        /// Filter the Search text
        /// </summary>
        private void textBox_UCServicesTCFind_Search_TextChanged(object sender, EventArgs e)
        {
            this.objectListView_UCServiceTCFind_FindService.UseFiltering = true;
            this.objectListView_UCServiceTCFind_FindService.ModelFilter = TextMatchFilter.Contains(this.objectListView_UCServiceTCFind_FindService, $"{textBox_UCServicesTCFind_Search.Text}");
        }
        /// <summary>
        /// toggle Menu Panel
        /// </summary>
        private void UserControlServices_MouseEnter(object sender, EventArgs e)
        {
            gui.toggleMenuPanel();
        }
        /// <summary>
        /// Remove Speciality from Service edit
        /// </summary>
        private void button_UCServicesTCEdit_RemoveSpeciality_Click(object sender, EventArgs e)
        {
            if (objectListView_UCServicesTCEdit_Speciality.SelectedObject != null)
            {
                Speciality selectedSpeciality = (Speciality)objectListView_UCServicesTCEdit_Speciality.SelectedObject;
                gui.ServiceSpecialityRepository.Delete(new ServiceSpeciality(selectedSpeciality.ID, currentService.ID));
                objectListView_UCServicesTCEdit_Speciality.SetObjects(gui.SpecialityRepository.GetSpecialitiesFromService(currentService));
                objectListView_UCServicesTCManage_ManageService.SetObjects(gui.SpecialityRepository.GetSpecialitiesFromService(currentService));
            }
        }
    }
}