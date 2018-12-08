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
        }

        private void SetObjectListViewSpecialities()
        {
            List<Speciality> specialitylist = gui.SpecialityRepository.GetAll();
            objectListView_UCSpecialityTCFind_FindSpeciality.SetObjects(specialitylist);
        }

        private void button_UCCSpecialityTCFind_CreateSpeciality_Click(object sender, EventArgs e)
        {
            gui.ClearTextboxesAndCompoboxesAndlistboxes(TC_UCSpecialityTC_CreateSpeciality.Controls);
            TabControl_UCSpecialities.SelectedTab = TC_UCSpecialityTC_CreateSpeciality;
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
            TabControl_UCSpecialities.SelectedTab = TC_UCSpecialityTC_ManageSpeciality;
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
            gui.ClearTextboxesAndCompoboxesAndlistboxes(TC_UCSpecialityTC_EditSpeciality.Controls);
            TabControl_UCSpecialities.SelectedTab = TC_UCSpecialityTC_ManageSpeciality;
        }

        private void button_UCSpecialityTCEdit_DeleteSpeciality_Click(object sender, EventArgs e)
        {
            gui.SpecialityRepository.Delete(currentSpeciality);
            SetObjectListViewSpecialities();
            TabControl_UCSpecialities.SelectedTab = TC_UCSpecialityTC_FindSpeciality;
        }
    }
}
