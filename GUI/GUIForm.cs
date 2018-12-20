using System;
using System.Drawing;
using System.Windows.Forms;
using BusinessLogic.Interfaces;

namespace GUI
{
    public partial class GUIForm : Form
    {
        public ICaseRepository CaseRepository { get; private set; }
        public IClientRepository ClientRepository { get; private set; }
        public IEmployeeRepository EmployeeRepository { get; private set; }
        public IServiceRepository ServiceRepository { get; private set; }
        public ICaseServiceRepository CaseServiceRepository { get; private set; }
        public ISpecialityRepository SpecialityRepository { get; private set; }
        public IRoleRepository RoleRepository { get; private set; }
        public IEmployeeSpecialityRepository EmployeeSpecialityRepository { get; private set; }

        public IServiceSpecialityRepository ServiceSpecialityRepository { get; private set; }

        UserControlCases userControlCases;
        UserControlEmployees userControlEmployees;
        UserControlClients userControlClients;
        UserControlSpecialities userControlSpecialities;
        UserControlServices userControlServices;

        public GUIForm(ICaseRepository caseRepository, IClientRepository clientRepository, IEmployeeRepository employeeRepository, IServiceRepository serviceRepository, ICaseServiceRepository caseServiceRepository, ISpecialityRepository specialityRepository, IRoleRepository roleRepository, IEmployeeSpecialityRepository employeeSpecialityRepository, IServiceSpecialityRepository serviceSpecialityRepository)
        {
            CaseRepository = caseRepository;
            ClientRepository = clientRepository;
            EmployeeRepository = employeeRepository;
            ServiceRepository = serviceRepository;
            CaseServiceRepository = caseServiceRepository;
            SpecialityRepository = specialityRepository;
            RoleRepository = roleRepository;
            EmployeeSpecialityRepository = employeeSpecialityRepository;
            ServiceSpecialityRepository = serviceSpecialityRepository;
            userControlCases = new UserControlCases(this);
            userControlEmployees = new UserControlEmployees(this);
            userControlClients = new UserControlClients(this);
            userControlSpecialities = new UserControlSpecialities(this);
            userControlServices = new UserControlServices(this);
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
            userControlSpecialities.Hide();
            userControlServices.Hide();
            userControlCases.Show();
            userControlCases.Dock = DockStyle.Fill;
            UcContainer.Controls.Add(userControlCases);

            TabControl tabControl = (TabControl)userControlCases.Controls["TabControl_UCCases"];
            tabControl.SelectedTab = tabControl.TabPages["TC_UCCaseTC_FindCase"];

            //Reset the Searchbox
            userControlCases.ResetSearchBox(sender, e);

            //GUINavigationLabel
            setGUINavigationLabel("Find Sag");
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
            userControlSpecialities.Hide();
            userControlServices.Hide();
            userControlEmployees.Show();
            userControlEmployees.Dock = DockStyle.Fill;
            UcContainer.Controls.Add(userControlEmployees);

            TabControl tabControl = (TabControl)userControlEmployees.Controls["TabControl_UCEmployee"];
            tabControl.SelectedTab = tabControl.TabPages["TC_UCEmployeeTC_FindEmployee"];

            //Reset the Searchbox
            userControlEmployees.ResetSearchBox(sender, e);

            //GUINavigationLabel
            setGUINavigationLabel("Find Ansat");
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
            userControlSpecialities.Hide();
            userControlServices.Hide();
            userControlClients.Show();
            userControlClients.Dock = DockStyle.Fill;
            UcContainer.Controls.Add(userControlClients);

            TabControl tabControl = (TabControl)userControlClients.Controls["TabControl_UCClient"];
            tabControl.SelectedTab = tabControl.TabPages["TC_UCClientTC_FindClient"];

            //Reset the Searchbox
            userControlClients.ResetSearchBox(sender, e);

            //GUINavigationLabel
            setGUINavigationLabel("Find Klient");
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
            userControlServices.Hide();
            userControlCases.Hide();
            userControlSpecialities.Show();
            userControlSpecialities.Dock = DockStyle.Fill;
            UcContainer.Controls.Add(userControlSpecialities);

            TabControl tabControl = (TabControl)userControlSpecialities.Controls["TabControl_UCSpecialities"];
            tabControl.SelectedTab = tabControl.TabPages["TC_UCSpecialityTC_FindSpeciality"];

            //Reset the Searchbox
            userControlSpecialities.ResetSearchBox(sender, e);

            //GUINavigationLabel
            setGUINavigationLabel("Find Efteruddannelse");
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
            userControlCases.Hide();
            userControlSpecialities.Hide();
            userControlServices.Show();
            userControlServices.Dock = DockStyle.Fill;
            UcContainer.Controls.Add(userControlServices);

            TabControl tabControl = (TabControl)userControlServices.Controls["TabControl_UCServices"];
            tabControl.SelectedTab = tabControl.TabPages["TC_UCServiceTC_FindService"];

            //Reset the Searchbox
            userControlServices.ResetSearchBox(sender, e);

            //GUINavigationLabel
            setGUINavigationLabel("Find Ydelse");
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

        /// <summary>
        /// Starts helpform or Brings it To Front
        /// </summary>
        public HelpForm helpForm = null;
        private void HelpBtn_Click(object sender, EventArgs e)
        {
            if (helpForm != null)
            {
                helpForm.BringToFront();
            }
            else
            {
                helpForm = new HelpForm(this);
                helpForm.Show();
            }
        }

        private void Menu_leave(object sender, EventArgs e)
        {
            toggleMenuPanel();
        }

        #endregion

        public void setGUINavigationLabel(string text)
        {
            GUINavigationLabel.Text = text;
        }


        /// <summary>
        /// Clear all Controls in the given ControlCollection
        /// Ex call: gui.ClearControlCollection(TC_UCEmployeeTC_CreateEmployee.Controls);
        /// </summary>
        public void ClearControlCollection(System.Windows.Forms.Control.ControlCollection ctrls)
        {
            foreach (Control ctrl in ctrls)
            {
                if (ctrl is TextBox)
                    ((TextBox)ctrl).Text = string.Empty;
                else if (ctrl is ComboBox)
                    ((ComboBox)ctrl).SelectedIndex = -1;
                else if (ctrl is ListBox)
                {
                    ((ListBox)ctrl).DataSource = null;
                    ((ListBox)ctrl).Items.Clear();
                }
                else if (ctrl is RichTextBox)
                    ((RichTextBox)ctrl).Text = string.Empty;
                else if (ctrl is RadioButton)
                    ((RadioButton)ctrl).Checked = false;
                else if (ctrl is BrightIdeasSoftware.ObjectListView) 
                    ((BrightIdeasSoftware.ObjectListView)ctrl).ClearObjects();

                ClearControlCollection(ctrl.Controls);
            }
        }
    }
}