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
        /// <summary>
        /// Refererer til user controls
        /// </summary>
        UserControlCases userControlCases;
        UserControlEmployees userControlEmployees;
        UserControlClients userControlClients;
        UserControlHelp userControlHelp;
        public GUIForm(ICaseRepository caseRepository, IClientRepository clientRepository, IEmployeeRepository employeeRepository, IServiceRepository serviceRepository, ICaseServiceRepository caseServiceRepository)
        {
            CaseRepository = caseRepository;
            ClientRepository = clientRepository;
            EmployeeRepository = employeeRepository;
            ServiceRepository = serviceRepository;
            userControlCases = new UserControlCases(this);
            userControlEmployees = new UserControlEmployees(this);
            userControlClients = new UserControlClients(this);
            userControlHelp = new UserControlHelp(this);
            InitializeComponent();
            panelWidth = MenuPanel.Width;
            hidden = true;
        }
        /// <summary>
        /// Sørger for at det første der bliver loaded, når Formen loader, er Cases
        /// </summary>
        private void GUI_Load(object sender, EventArgs e)
        {
            CaseBtn.PerformClick();
        }
        /// <summary>
        /// Står for hide/show toggle på menuen
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
        /// Står for at lukke MenuPanel når man trykker på en knap i menuen
        /// </summary>
        public void toggleMenuPanel()
        {
            if (!hidden)
                MenuPictureBtn_Click(this.MenuPictureBtn, null);
        }
        /// <summary>
        /// Står for at lukke programmet ned når man trykker på knappen
        /// </summary>
        private void CloseWindowBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Står for at ændre tekstfarven når musen hover på knappen
        /// </summary>
        private void buttonForeColorHover(Button button)
        {
            button.ForeColor = Color.SteelBlue;
        }
        /// <summary>
        /// Står for at ændre tekstfarven tilbage når musen forlader knappen
        /// </summary>
        private void buttonForeColorLeave(Button button)
        {
            button.ForeColor = Color.Black;
        }
        /// <summary>
        /// Står for at highlighte den sidste knap der er blevet trykket på samt at resette farven når en ny knap trykkes på. 
        /// </summary>
        private Button _lastButtonClicked;
        private void buttonBackColor(Button button)
        {
            if (_lastButtonClicked != null)
                _lastButtonClicked.BackColor = Color.Transparent;

            _lastButtonClicked = button as Button;
            _lastButtonClicked.BackColor = Color.SteelBlue;
        }
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
            userControlClients.Show();
            userControlClients.Dock = DockStyle.Fill;
            UcContainer.Controls.Add(userControlClients);
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
            userControlHelp.Show();
            userControlHelp.Dock = DockStyle.Fill;
            UcContainer.Controls.Add(userControlHelp);
        }

        private void Menu_leave(object sender, EventArgs e)
        {
            toggleMenuPanel();
        }

        #endregion

        //slet den her på et tidspunkt: 
    }
}