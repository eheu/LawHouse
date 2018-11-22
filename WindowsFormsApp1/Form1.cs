using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using DataAccess;
using Unity;
using Unity.Injection;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public ICaseRepository caseRepository { get; private set; } 
        public Form1(ICaseRepository caseRepository)
        {
            InitializeComponent();
            objectListView1.AddObject(caseRepository.Get(1));
        }
    }
}
