using System;
using System.Drawing;
using System.Windows.Forms;
using BusinessLogic.Interfaces;

namespace GUI
{
    public partial class GUIForm : Form
    {
        public ICaseRepository CaseRepository { get; set; }
        public IClientRepository ClientRepository { get; set; }
        public IEmployeeRepository EmployeeRepository { get; set; }
        public IServiceRepository ServiceRepository { get; set; }
        public ICaseServiceRepository CaseServiceRepository { get; set; }
        public ISpecialityRepository SpecialityRepository { get; set; }
        public IRoleRepository RoleRepository { get; set; }
        public IEmployeeSpecialityRepository EmployeeSpecialityRepository { get; set; }
        /// <summary>
        /// Refererer til user controls
        /// </summary>
        UserControlCases userControlCases;
        UserControlEmployees userControlEmployees;
        UserControlClients userControlClients;
        UserControlSpecialities userControlSpecialities;
        UserControlServices userControlServices;
        UserControlHelp userControlHelp;
        public GUIForm(ICaseRepository caseRepository, IClientRepository clientRepository, IEmployeeRepository employeeRepository, IServiceRepository serviceRepository, ICaseServiceRepository caseServiceRepository, ISpecialityRepository specialityRepository, IRoleRepository roleRepository, IEmployeeSpecialityRepository employeeSpecialityRepository)
        {
            CaseRepository = caseRepository;
            ClientRepository = clientRepository;
            EmployeeRepository = employeeRepository;
            ServiceRepository = serviceRepository;
            CaseServiceRepository = caseServiceRepository;
            SpecialityRepository = specialityRepository;
            RoleRepository = roleRepository;
            EmployeeSpecialityRepository = employeeSpecialityRepository;
            userControlCases = new UserControlCases(this);
            userControlEmployees = new UserControlEmployees(this);
            userControlClients = new UserControlClients(this);
            userControlSpecialities = new UserControlSpecialities(this);
            userControlServices = new UserControlServices(this);
            userControlHelp = new UserControlHelp(this);
            InitializeComponent();
            panelWidth = MenuPanel.Width;
            hidden = true;
        }
        #region GUI events. Primarily menubar events and application close/minimize events
        /// <summary>
        ///     Performs a click on CaseBtn when GUIform is loaded. 
        /// </summary>
        private void GUI_Load(object sender, EventArgs e)
        {
            CaseBtn.PerformClick();
        }
        /// <summary>
        ///     Makes the menu bar slide when menubutton is clicked.
        /// </summary>
        private int panelWidth;
        private bool hidden;
        private void MenuPictureBtn_Click(object sender, EventArgs e)
        {
            if (hidden)
                MenuSlideTimer.Start();
            else
                MenuSlideTimer.Start();
        }
        /// <summary>
        ///     Makes the menu bar slide out or in depending on the state in which it is when the event is raised.
        /// </summary>
        private void MenuSlideTimer_Tick(object sender, EventArgs e)
        {
            if (hidden)
            {
                MenuPanel.Width = MenuPanel.Width + 20;
                if (MenuPanel.Width >= 310)
                {
                    MenuSlideTimer.Stop();
                    hidden = false;
                    this.Refresh();
                }
            }
            else
            {
                MenuPanel.Width = MenuPanel.Width - 20;
                if (MenuPanel.Width <= panelWidth)
                {
                    MenuSlideTimer.Stop();
                    hidden = true;
                    this.Refresh();
                }
            }
        }
        /// <summary>
        ///     Makes the menu bar slide in if it is not hidden. Used for when the user leaves the menubar, so it slides in automaticly. 
        /// </summary>
        public void toggleMenuPanel()
        {
            if (!hidden)
                MenuPictureBtn_Click(this.MenuPictureBtn, null);
        }
        /// <summary>
        ///     Closes the program.
        /// </summary>
        private void CloseWindowBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        ///     Minimizes the window
        /// </summary>
        private void minimizeWindowBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        /// <summary>
        ///     Changes the text color on the buttons when hovered
        /// </summary>
        private void buttonForeColorHover(Button button)
        {
            button.ForeColor = Color.SteelBlue;
        }
        /// <summary>
        ///     Changes the text color back when mouse leaves the buttons.
        /// </summary>
        private void buttonForeColorLeave(Button button)
        {
            button.ForeColor = Color.Black;
        }
        /// <summary>
        ///     Highlights the last button clicked, so that the user can always see which menu point they are on.  
        /// </summary>
        private Button _lastButtonClicked;
        private void buttonBackColor(Button button)
        {
            if (_lastButtonClicked != null)
                _lastButtonClicked.BackColor = Color.Transparent;

            _lastButtonClicked = button as Button;
            _lastButtonClicked.BackColor = Color.SteelBlue;
        }
#endregion
        #region Events for CaseBtn
        private void CaseBtn_MouseEnter(object sender, EventArgs e)
        {
            buttonForeColorHover(CaseBtn);
        }
        private void CaseBtn_MouseLeave(object sender, EventArgs e)
        {
            buttonForeColorLeave(CaseBtn);     
        }
        private void CaseBtn_Click(object sender, EventArgs e)
        {
            buttonBackColor(CaseBtn);
            userControlEmployees.Hide();
            userControlClients.Hide();
            userControlHelp.Hide();
            userControlSpecialities.Hide();
            userControlServices.Hide();
            userControlCases.Show();
            userControlCases.Dock = DockStyle.Fill;
            UcContainer.Controls.Add(userControlCases);
            
        }
        #endregion
        #region Events for EmployeeBtn
        private void EmployeeBtn_MouseEnter(object sender, EventArgs e)
        {
            buttonForeColorHover(EmployeeBtn);
        }
        private void EmployeeBtn_MouseLeave(object sender, EventArgs e)
        {
            buttonForeColorLeave(EmployeeBtn);
        }
        private void EmployeeBtn_Click(object sender, EventArgs e)
        {
            buttonBackColor(EmployeeBtn);
            userControlCases.Hide();
            userControlClients.Hide();
            userControlHelp.Hide();
            userControlSpecialities.Hide();
            userControlServices.Hide();
            userControlEmployees.Show();
            userControlEmployees.Dock = DockStyle.Fill;
            UcContainer.Controls.Add(userControlEmployees);
        }
        #endregion  
        #region Events for ClientBtn
        private void ClientBtn_MouseEnter(object sender, EventArgs e)
        {
            buttonForeColorHover(ClientBtn);
        }
        private void ClientBtn_MouseLeave(object sender, EventArgs e)
        {
            buttonForeColorLeave(ClientBtn);
        }
        private void ClientBtn_Click(object sender, EventArgs e)
        {
            buttonBackColor(ClientBtn);
            userControlCases.Hide();
            userControlEmployees.Hide();
            userControlHelp.Hide();
            userControlSpecialities.Hide();
            userControlServices.Hide();
            userControlClients.Show();
            userControlClients.Dock = DockStyle.Fill;
            UcContainer.Controls.Add(userControlClients);
        }
        #endregion
        #region Events for SpecialitiesBtn
        private void SpecialitiesBtn_MouseEnter(object sender, EventArgs e)
        {
            buttonForeColorHover(SpecialitiesBtn);
        }
        private void SpecialitiesBtn_MouseLeave(object sender, EventArgs e)
        {
            buttonForeColorLeave(SpecialitiesBtn);
        }
        private void SpecialitiesBtn_Click(object sender, EventArgs e)
        {
            buttonBackColor(SpecialitiesBtn);
            userControlEmployees.Hide();
            userControlClients.Hide();
            userControlHelp.Hide();
            userControlServices.Hide();
            userControlCases.Hide();
            userControlSpecialities.Show();
            userControlSpecialities.Dock = DockStyle.Fill;
            UcContainer.Controls.Add(userControlSpecialities);
        }
        #endregion
        #region Events for ServicesBtn
        private void servicesBtn_MouseEnter(object sender, EventArgs e)
        {
            buttonForeColorHover(servicesBtn);
        }
        private void servicesBtn_MouseLeave(object sender, EventArgs e)
        {
            buttonForeColorLeave(servicesBtn);
        }
        private void servicesBtn_Click(object sender, EventArgs e)
        {
            buttonBackColor(servicesBtn);
            userControlEmployees.Hide();
            userControlClients.Hide();
            userControlHelp.Hide();
            userControlCases.Hide();
            userControlSpecialities.Hide();
            userControlServices.Show();
            userControlServices.Dock = DockStyle.Fill;
            UcContainer.Controls.Add(userControlServices);
        }
        #endregion
        #region  Events for HelpBtn
        private void HelpBtn_MouseEnter(object sender, EventArgs e)
        {
            buttonForeColorHover(HelpBtn);
        }
        private void HelpBtn_MouseLeave(object sender, EventArgs e)
        {
            buttonForeColorLeave(HelpBtn);
        }
        private void HelpBtn_Click(object sender, EventArgs e)
        {
            buttonBackColor(HelpBtn);
            userControlCases.Hide();
            userControlEmployees.Hide();
            userControlClients.Hide();
            userControlSpecialities.Hide();
            userControlServices.Hide();
            userControlHelp.Show();
            userControlHelp.Dock = DockStyle.Fill;
            UcContainer.Controls.Add(userControlHelp);
        }

        private void Menu_leave(object sender, EventArgs e)
        {
            toggleMenuPanel();
        }

        #endregion

        /// <summary>
        /// Clear all Controls in the given ControlCollection
        /// Ex call: gui.ClearTextboxesAndCompoboxesAndlistboxes(TC_UCEmployeeTC_CreateEmployee.Controls);
        /// </summary>
        public void ClearTextboxesAndCompoboxesAndlistboxes(System.Windows.Forms.Control.ControlCollection ctrls)
        {
            foreach (Control ctrl in ctrls)
            {
                if (ctrl is TextBox)
                    ((TextBox)ctrl).Text = string.Empty;
                if (ctrl is ComboBox)
                    ((ComboBox)ctrl).SelectedItem = -1;
                if (ctrl is ListBox) {
                    ((ListBox)ctrl).DataSource = null;
                    ((ListBox)ctrl).Items.Clear();
                }
                if(ctrl is RichTextBox)
                    ((RichTextBox)ctrl).Text = string.Empty;
                if(ctrl is RadioButton)
                    ((RadioButton)ctrl).Checked = false;
                ClearTextboxesAndCompoboxesAndlistboxes(ctrl.Controls);
            }
        }
    }
}