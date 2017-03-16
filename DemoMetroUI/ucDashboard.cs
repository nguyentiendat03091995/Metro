using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoMetroUI
{
    public partial class ucDashboard : MetroFramework.Controls.MetroUserControl
    {
        public ucDashboard()
        {
            InitializeComponent();
        }

        private void ucDashboard_Load(object sender, EventArgs e)
        {

        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            ucThem uc = new ucThem();
            frMain.Instance.MetroContainer.Controls.Add(uc);
            frMain.Instance.MetroContainer.Controls["ucThem"].BringToFront();
        }
    }
}
