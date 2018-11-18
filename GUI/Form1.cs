using System.Windows.Forms;
using BusinessLogic;

namespace GUI
{
    public partial class Form1 : Form
    {
        private LawHouse _lawHouse = new LawHouse();
        public Form1()
        {
            InitializeComponent();
            objectListView1.SetObjects(_lawHouse.Employees.FindAll());
        }
    }
}
