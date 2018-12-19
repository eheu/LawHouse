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

        public void ResetSearchBox(object sender, EventArgs e)
        {
            textBox_UCSpecialityTCFind_Search.Text = null;
        }

        private void SetObjectListViewSpecialities()
        {
            List<Speciality> specialitylist = gui.SpecialityRepository.GetAll();
            objectListView_UCSpecialityTCFind_FindSpeciality.SetObjects(specialitylist);
        }

        private void button_UCCSpecialityTCFind_CreateSpeciality_Click(object sender, EventArgs e)
        {
            gui.ClearControlCollection(TC_UCSpecialityTC_CreateSpeciality.Controls);
            TabControl_UCSpecialities.SelectedTab = TC_UCSpecialityTC_CreateSpeciality;
            //GUINavigationLabel
            gui.setGUINavigationLabel("Opret Efteruddannelse");
        }

        private void SetAddServiceComboBox()
        {
            comboBox_UCSpecialityTCCreate_AddService.DataSource = gui.ServiceRepository.GetAll();
            comboBox_UCSpecialityTCCreate_AddService.DisplayMember = "Name";
            comboBox_UCSpecialityTCCreate_AddService.ValueMember = "ID";
            comboBox_UCSpecialityTCCreate_AddService.SelectedIndex = -1;
            comboBox_UCSpecialityTCCreate_AddService.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBox_UCSpecialityTCCreate_AddService.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void button_UCSpecialityTCCreate_FindSpeciality_Click(object sender, EventArgs e)
        {
            SetObjectListViewSpecialities();
            TabControl_UCSpecialities.SelectedTab = TC_UCSpecialityTC_FindSpeciality;
            //GUINavigationLabel
            gui.setGUINavigationLabel("Find Efteruddannelse");
        }

        private void button_UCSpecialityTCEdit_FindSpeciality_Click(object sender, EventArgs e)
        {
            SetObjectListViewSpecialities();
            TabControl_UCSpecialities.SelectedTab = TC_UCSpecialityTC_FindSpeciality;
            //GUINavigationLabel
            gui.setGUINavigationLabel("Find Efteruddannelse");
        }

        private void button_UCSpecialityTCEdit_ManageSpeciality_Click(object sender, EventArgs e)
        {
            TabControl_UCSpecialities.SelectedTab = TC_UCSpecialityTC_ManageSpeciality;
            //GUINavigationLabel
            gui.setGUINavigationLabel("Administrer Efteruddannelse");
        }

        private void button_UCSpecialityTCManage_FindSpeciality_Click(object sender, EventArgs e)
        {
            SetObjectListViewSpecialities();
            TabControl_UCSpecialities.SelectedTab = TC_UCSpecialityTC_FindSpeciality;
            //GUINavigationLabel
            gui.setGUINavigationLabel("Find Efteruddannelse");
        }

        private void button_UCSpecialityTCManage_EditSpeciality_Click(object sender, EventArgs e)
        {
            textBox_UCSpecialityTCEdit_ChangeName.Text = currentSpeciality.Name;
            richTextBox_UCSpecialityTCEdit_Description.Text = currentSpeciality.Description;
            TabControl_UCSpecialities.SelectedTab = TC_UCSpecialityTC_EditSpeciality;
            objectListView_UCSpecialityTCEdit_Services.SetObjects(gui.ServiceRepository.GetServicesFromSpeciality(currentSpeciality));
            //GUINavigationLabel
            gui.setGUINavigationLabel("Rediger Efteruddannelse");
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
            //GUINavigationLabel
            gui.setGUINavigationLabel("Find Efteruddannelse");
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
            //GUINavigationLabel
            gui.setGUINavigationLabel("Administrer Efteruddannelse");
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
            comboBox_UCSpecialityTCManage_AddService.SelectedIndex = -1;
            comboBox_UCSpecialityTCManage_AddService.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBox_UCSpecialityTCManage_AddService.AutoCompleteSource = AutoCompleteSource.ListItems;
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

            gui.ClearControlCollection(TC_UCSpecialityTC_EditSpeciality.Controls);
            TabControl_UCSpecialities.SelectedTab = TC_UCSpecialityTC_ManageSpeciality;
            //GUINavigationLabel
            gui.setGUINavigationLabel("Administrer Efteruddannelse");
        }

        private void button_UCSpecialityTCEdit_DeleteSpeciality_Click(object sender, EventArgs e)
        {
            try
            {
                gui.SpecialityRepository.Delete(currentSpeciality);
            }
            catch (DataException)
            {
                MessageBox.Show("Kan ikke slette efteruddannelsen! Måske er den i brug?");
            }
            SetObjectListViewSpecialities();
            TabControl_UCSpecialities.SelectedTab = TC_UCSpecialityTC_FindSpeciality;
            //GUINavigationLabel
            gui.setGUINavigationLabel("Find Efteruddannelse");
        }

        private void button_UCSpecialityTCManage_AddService_Click(object sender, EventArgs e)
        {
            if (comboBox_UCSpecialityTCManage_AddService.SelectedItem != null)
            {
                List<Service> servicesOnSpeciality = objectListView_UCSpecialityTCManage_ServicesOnSpeciality.Objects.Cast<Service>().ToList(); //stackoverflow.com/a/7617784
                Service selectedService = (Service)comboBox_UCSpecialityTCManage_AddService.SelectedItem;
                bool exists = servicesOnSpeciality.Any(s => s.ID == selectedService.ID);
                if (!exists)
                {
                    gui.ServiceSpecialityRepository.Create(new ServiceSpeciality(selectedService.ID, currentSpeciality.ID));
                    objectListView_UCSpecialityTCManage_ServicesOnSpeciality.AddObject(selectedService);
                }
            }
            comboBox_UCSpecialityTCManage_AddService.SelectedIndex = -1;
        }

        private void button_UCSpecialityTCCreate_AddService_Click(object sender, EventArgs e)
        {
            if (comboBox_UCSpecialityTCCreate_AddService.SelectedItem != null)
            {
                Service selectedService = (Service)comboBox_UCSpecialityTCCreate_AddService.SelectedItem;
                if (objectListView_UCSpecialityTCCreate_Service.Objects == null)
                    objectListView_UCSpecialityTCCreate_Service.AddObject(selectedService);
                else
                {
                    List<Service> servicesInObjectListView = objectListView_UCSpecialityTCCreate_Service.Objects.Cast<Service>().ToList();
                    bool exists = servicesInObjectListView.Any(s => s.ID == selectedService.ID);
                    if (!exists)
                        objectListView_UCSpecialityTCCreate_Service.AddObject(selectedService);
                }
            }
            comboBox_UCSpecialityTCCreate_AddService.SelectedIndex = -1;
        }

        private void button_UCSpecialityTCEdit_RemoveService_Click(object sender, EventArgs e)
        {
            if (objectListView_UCSpecialityTCEdit_Services.SelectedObject != null)
            {
                Service selectedService = (Service)objectListView_UCSpecialityTCEdit_Services.SelectedObject;
                gui.ServiceSpecialityRepository.Delete(new ServiceSpeciality(selectedService.ID,currentSpeciality.ID));
                objectListView_UCSpecialityTCEdit_Services.SetObjects(gui.ServiceRepository.GetServicesFromSpeciality(currentSpeciality));
                objectListView_UCSpecialityTCManage_ServicesOnSpeciality.SetObjects(gui.ServiceRepository.GetServicesFromSpeciality(currentSpeciality));
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
