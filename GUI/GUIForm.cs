using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    // OBS !!!  Alle kommentare refererer til nedenstående kode.
    public partial class GUIForm : Form
    {
        public GUIForm()
        {
            InitializeComponent();
            panelWidth = MenuPanel.Width;
            hidden = true;
        }
        //Sørger for at det første der bliver loaded, når Formen loader, er Cases
        private void GUI_Load(object sender, EventArgs e)
        {
            CaseBtn.PerformClick();
        }
        //Står for hide/show toggle på menuen
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
        //Står for at lukke programmet ned når man trykker på knappen
        private void CloseWindowBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Står for at ændre tekstfarven når musen hover på knappen
        private void buttonForeColorHover(Button button)
        {
            button.ForeColor = Color.SteelBlue;
        }
        //Står for at ændre tekstfarven tilbage når musen forlader knappen
        private void buttonForeColorLeave(Button button)
        {
            button.ForeColor = Color.Black;
        }
        //Står for at highlighte den sidste knap der er blevet trykket på samt at resette farven når en ny knap trykkes på. 
        private Button _lastButtonClicked;
        private void buttonBackColor(Button button)
        {
            if (_lastButtonClicked != null)
                _lastButtonClicked.BackColor = Color.Transparent;

            _lastButtonClicked = button as Button;
            _lastButtonClicked.BackColor = Color.SteelBlue;
        }
        //Events for CaseBtn
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
        }
        //Events for EmployeeBtn
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
        }
        //Events for ClientBtn
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
        }
        //Events for HelpBtn
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
        }
    }
}
