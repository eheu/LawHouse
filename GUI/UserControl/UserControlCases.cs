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

namespace GUI
{
    public partial class UserControlCases : UserControl
    {

        GUIForm gui;
        public UserControlCases(GUIForm guiForm)
        {
            gui = guiForm;
            InitializeComponent();
            //vælg klient
            SetComboBowClint();
            //vælg advokat
            SetComboBoxLawyer();
            //vælg ydelse
            SetComboboxService();
            //object list view
            SetObjectListViewCases();
            // liste af valgte ydelser, opret sag
            List<Service> servicelist = new List<Service>();
            listBox_UCCaseTCCreate_Service.DisplayMember = "Name";
            listBox_UCCaseTCCreate_Service.ValueMember = "ID";
        }

        private void SetComboBowClint()
        {
            List<Client> clientlist = gui.ClientRepository.GetAll();
            comboBox_UCCaseTCCreate_ChooseClient.DataSource = clientlist;
            comboBox_UCCaseTCCreate_ChooseClient.DisplayMember = "FullName";
            comboBox_UCCaseTCCreate_ChooseClient.ValueMember = "ID";
            comboBox_UCCaseTCCreate_ChooseClient.SelectedIndex = -1;
            comboBox_UCCaseTCCreate_ChooseClient.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBox_UCCaseTCCreate_ChooseClient.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void SetComboBoxLawyer()
        {
            List<Employee> lawyerlist = gui.EmployeeRepository.GetAllLawyers();
            comboBox_UCCaseTCCreate_ChooseLawyer.DataSource = lawyerlist;
            comboBox_UCCaseTCCreate_ChooseLawyer.DisplayMember = "FullName";
            comboBox_UCCaseTCCreate_ChooseLawyer.ValueMember = "ID";
            comboBox_UCCaseTCCreate_ChooseLawyer.SelectedIndex = -1;
            comboBox_UCCaseTCCreate_ChooseLawyer.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBox_UCCaseTCCreate_ChooseLawyer.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void SetComboboxService()
        {
            List<Service> servicelist = gui.ServiceRepository.GetAll();
            comboBox_UCCaseTCCreate_ChooseService.DataSource = servicelist;
            comboBox_UCCaseTCCreate_ChooseService.DisplayMember = "Name";
            comboBox_UCCaseTCCreate_ChooseService.ValueMember = "ID";
            comboBox_UCCaseTCCreate_ChooseService.SelectedIndex = -1;
            comboBox_UCCaseTCCreate_ChooseService.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBox_UCCaseTCCreate_ChooseService.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void SetObjectListViewCases()
        {
            List<Case> caselist = gui.CaseRepository.GetAll();
            objectListView_UCCaseTCFind_FindCase.SetObjects(caselist);
        }

        private void FindCase_MouseEnter(object sender, EventArgs e)
        {
            gui.toggleMenuPanel();
        }



        private void button_UCCaseTCFind_CreateCase_Click(object sender, EventArgs e)
        {
            TabControl_UCCases.SelectedTab = TC_UCCaseTC_CreateCase;
        }

        private void button_UCCaseTCEdit_FindCase_Click(object sender, EventArgs e)
        {
            TabControl_UCCases.SelectedTab = TC_UCCaseTC_FindCase;
        }

        private void button_UCCaseTCEdit_ManageCase_Click(object sender, EventArgs e)
        {
            TabControl_UCCases.SelectedTab = TC_UCCaseTC_ManageCase;
        }

        private void button_UCCaseTCCreate_FindCase_Click(object sender, EventArgs e)
        {
            TabControl_UCCases.SelectedTab = TC_UCCaseTC_FindCase;
        }

        private void button_UCCaseTCManage_FindCase_Click(object sender, EventArgs e)
        {
            TabControl_UCCases.SelectedTab = TC_UCCaseTC_FindCase;
        }

        private void button_UCCaseTCManage_EditCase_Click(object sender, EventArgs e)
        {
            TabControl_UCCases.SelectedTab = TC_UCCaseTC_EditCase;
        }

        private void button_UCCaseTCCreate_CreateCase_Click(object sender, EventArgs e)
        {
            Case @case = new Case();
            @case.Description = richTextBox_UCCaseTCCreate_Description.Text;
            @case.Title = textBox_UCCaseTCCreate_Title.Text;
            @case.ClientID = (int)comboBox_UCCaseTCCreate_ChooseClient.SelectedValue;
            @case.EmployeeID = (int)comboBox_UCCaseTCCreate_ChooseLawyer.SelectedValue;
            gui.CaseRepository.Create(@case);
            SetObjectListViewCases();

            foreach(Service service in listBox_UCCaseTCCreate_Service.Items)
            {
                gui.CaseRepository.AddServiceToCase(service, @case);
            }

            MessageBox.Show("virkede");
        }

        private void objectListView_UCCaseTCFind_FindCase_DoubleClick(object sender, EventArgs e)
        {
            Case @case = (Case)objectListView_UCCaseTCFind_FindCase.SelectedObject;
            label_UCCaseTCManage_CaseName.Text = @case.Title;
            richTextBox_UCCaseTCManage_Description.Text = @case.Description;
            TabControl_UCCases.SelectedTab = TC_UCCaseTC_ManageCase;
            
        }

        private void button_UCCaseTCCreate_AddService_Click(object sender, EventArgs e)
        {
            if (!listBox_UCCaseTCCreate_Service.Items.Contains((Service)comboBox_UCCaseTCCreate_ChooseService.SelectedItem))
                listBox_UCCaseTCCreate_Service.Items.Add((Service)comboBox_UCCaseTCCreate_ChooseService.SelectedItem);
        }
    }
}
