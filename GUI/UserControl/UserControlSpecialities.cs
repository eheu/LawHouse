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
    public partial class UserControlSpecialities : UserControl
    {
        GUIForm gui;
        private Speciality currentSpeciality;
        public UserControlSpecialities(GUIForm guiForm)
        {
            InitializeComponent();
            gui = guiForm;
            // objectlistview 
            SetObjectListViewSpecialities();
            SetAddServiceComboBox();
        }

        private void SetObjectListViewSpecialities()
        {
            List<Speciality> specialitylist = gui.SpecialityRepository.GetAll();
            objectListView_UCSpecialityTCFind_FindSpeciality.SetObjects(specialitylist);
        }

        private void button_UCCSpecialityTCFind_CreateSpeciality_Click(object sender, EventArgs e)
        {
            gui.ClearTextBoxesAndComboBoxesAndListBoxes(TC_UCSpecialityTC_CreateSpeciality.Controls);
            TabControl_UCSpecialities.SelectedTab = TC_UCSpecialityTC_CreateSpeciality;
        }

        private void SetAddServiceComboBox()
        {
            comboBox_UCSpecialityTCCreate_AddService.DataSource = gui.ServiceRepository.GetAll();
            comboBox_UCSpecialityTCCreate_AddService.DisplayMember = "Name";
            comboBox_UCSpecialityTCCreate_AddService.ValueMember = "ID";
        }

        private void button_UCSpecialityTCCreate_FindSpeciality_Click(object sender, EventArgs e)
        {
            SetObjectListViewSpecialities();
            TabControl_UCSpecialities.SelectedTab = TC_UCSpecialityTC_FindSpeciality;
        }

        private void button_UCSpecialityTCEdit_FindSpeciality_Click(object sender, EventArgs e)
        {
            SetObjectListViewSpecialities();
            TabControl_UCSpecialities.SelectedTab = TC_UCSpecialityTC_FindSpeciality;
        }

        private void button_UCSpecialityTCEdit_ManageSpeciality_Click(object sender, EventArgs e)
        {
            TabControl_UCSpecialities.SelectedTab = TC_UCSpecialityTC_ManageSpeciality;
        }

        private void button_UCSpecialityTCManage_FindSpeciality_Click(object sender, EventArgs e)
        {
            SetObjectListViewSpecialities();
            TabControl_UCSpecialities.SelectedTab = TC_UCSpecialityTC_FindSpeciality;
        }

        private void button_UCSpecialityTCManage_EditSpeciality_Click(object sender, EventArgs e)
        {
            TabControl_UCSpecialities.SelectedTab = TC_UCSpecialityTC_EditSpeciality;
            objectListView_UCSpecialityTCEdit_Services.SetObjects(gui.ServiceRepository.GetServicesFromSpeciality(currentSpeciality));
        }

        /// <summary>
        /// Button create speciality
        /// </summary>
        private void bottom_UCSpecialityTCCreate_Create_Click(object sender, EventArgs e)
        {
            Speciality speciality = new Speciality();
            speciality.Name = textbox_UCCServiceTCCreate_Name.Text;
            speciality.Description = richTextBox_UCSpecialityTCCreate_Description.Text;
            gui.SpecialityRepository.Create(speciality);
            SetObjectListViewSpecialities();
            TabControl_UCSpecialities.SelectedTab = TC_UCSpecialityTC_FindSpeciality;
        }
        /// <summary>
        /// Doubleclick event in find speciality
        /// </summary>
        private void objectListView_UCSpecialityTCFind_FindSpeciality_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Speciality speciality = (Speciality)objectListView_UCSpecialityTCFind_FindSpeciality.SelectedObject;
            label_UCSpecialityTCManage_SpecialityName.Text = speciality.Name;
            richTextBox_UCSpecialityTCManage_Description.Text = speciality.Description;
            currentSpeciality = speciality;

            InitializeAddServiceComboBox();
            InitializeServicesOnSpecialityObjectListView();

            TabControl_UCSpecialities.SelectedTab = TC_UCSpecialityTC_ManageSpeciality;
        }

        private void InitializeServicesOnSpecialityObjectListView()
        {
            olvColumn_UCSpecialityTCManage_IsHourly.AspectGetter = delegate (object obj)
            {
                Service service = (Service)obj;
                return service.IsHourly == true ? "Timepris" : "Fastpris";
            };
            objectListView_UCSpecialityTCManage_ServicesOnSpeciality.SetObjects(gui.ServiceRepository.GetServicesFromSpeciality(currentSpeciality));
        }

        private void InitializeAddServiceComboBox()
        {
            comboBox_UCSpecialityTCManage_AddService.DataSource = gui.ServiceRepository.GetAll();
            comboBox_UCSpecialityTCManage_AddService.DisplayMember = "Name";
            comboBox_UCSpecialityTCManage_AddService.ValueMember = "ID";
        }

        /// <summary>
        /// Saves in manage speciality tab
        /// </summary>
        private void button_UCSpecialityTCManage_Save_Click(object sender, EventArgs e)
        {
            currentSpeciality.Description = richTextBox_UCSpecialityTCManage_Description.Text;
            gui.SpecialityRepository.Update(currentSpeciality);
        }
        /// <summary>
        /// Saves in edit speciality tab
        /// </summary>
        private void button_UCSpecialityTCEdit_SaveChange_Click(object sender, EventArgs e)
        {
            currentSpeciality.Description = richTextBox_UCSpecialityTCEdit_Description.Text;
            currentSpeciality.Name = textBox_UCSpecialityTCEdit_ChangeName.Text;
            gui.SpecialityRepository.Update(currentSpeciality);
            //Change tab and update
            label_UCSpecialityTCManage_SpecialityName.Text = currentSpeciality.Name;
            richTextBox_UCSpecialityTCManage_Description.Text = currentSpeciality.Description;

            gui.ClearTextBoxesAndComboBoxesAndListBoxes(TC_UCSpecialityTC_EditSpeciality.Controls);
            TabControl_UCSpecialities.SelectedTab = TC_UCSpecialityTC_ManageSpeciality;
        }

        private void button_UCSpecialityTCEdit_DeleteSpeciality_Click(object sender, EventArgs e)
        {
            gui.SpecialityRepository.Delete(currentSpeciality);
            SetObjectListViewSpecialities();
            TabControl_UCSpecialities.SelectedTab = TC_UCSpecialityTC_FindSpeciality;
        }

        private void button_UCSpecialityTCManage_AddService_Click(object sender, EventArgs e)
        {
            if (comboBox_UCSpecialityTCManage_AddService.SelectedItem != null)
            {
                List<Service> servicesOnSpeciality = objectListView_UCSpecialityTCManage_ServicesOnSpeciality.Objects.Cast<Service>().ToList(); //stackoverflow.com/a/7617784
                Service selectedService = (Service)comboBox_UCSpecialityTCManage_AddService.SelectedItem;
                bool exists = servicesOnSpeciality.Any(s => s.ID == selectedService.ID);
                if (!exists) gui.ServiceSpecialityRepository.Create(new ServiceSpeciality(selectedService.ID,currentSpeciality.ID));
            }
        }

        private void button_UCSpecialityTCCreate_AddService_Click(object sender, EventArgs e)
        {
            if (comboBox_UCSpecialityTCCreate_AddService.SelectedItem != null)
            {
                Service selectedService = (Service)comboBox_UCSpecialityTCCreate_AddService.SelectedItem;
                List<Service> servicesInObjectListView = objectListView_UCSpecialityTCCreate_Service.Objects.Cast<Service>().ToList();
                bool exists = servicesInObjectListView.Any(s => s.ID == selectedService.ID);
                if (!exists) objectListView_UCSpecialityTCCreate_Service.AddObject(selectedService);
            }
        }

        private void button_UCSpecialityTCEdit_RemoveService_Click(object sender, EventArgs e)
        {
            if (objectListView_UCSpecialityTCEdit_Services.SelectedObject != null)
            {
                Service selectedService = (Service)objectListView_UCSpecialityTCEdit_Services.SelectedObject;
                gui.ServiceSpecialityRepository.Delete(new ServiceSpeciality(selectedService.ID,currentSpeciality.ID));
                objectListView_UCSpecialityTCEdit_Services.SetObjects(gui.ServiceRepository.GetServicesFromSpeciality(currentSpeciality));
            }
        }

        private void textBox_UCSpecialityTCFind_Search_TextChanged(object sender, EventArgs e)
        {
            this.objectListView_UCSpecialityTCFind_FindSpeciality.UseFiltering = true;
            this.objectListView_UCSpecialityTCFind_FindSpeciality.ModelFilter = TextMatchFilter.Contains(this.objectListView_UCSpecialityTCFind_FindSpeciality, $"{textBox_UCSpecialityTCFind_Search.Text}");
        }

        private void UserControlSpecialities_MouseEnter(object sender, EventArgs e)
        {
            gui.toggleMenuPanel();
        }
    }
}
