using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoMetroUI.userControl.lich
{
    public partial class ucLichtong : MetroFramework.Controls.MetroUserControl
    {
        public ucLichtong()
        {
            InitializeComponent();
        }

        private void ucLichtong_Load(object sender, EventArgs e)
        {

        }

        private void mlBack_Click(object sender, EventArgs e)
        {
            ucDashboard uc = new ucDashboard();
            frMain.Instance.MetroContainer.Controls.Add(uc);
            frMain.Instance.MetroContainer.Controls["ucDashboard"].BringToFront();
        }
    }
}
