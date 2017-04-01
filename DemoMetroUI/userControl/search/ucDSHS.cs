using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoMetroUI.userControl.search
{
    public partial class ucDSHS : MetroFramework.Controls.MetroUserControl
    {
        public ucDSHS()
        {
            InitializeComponent();
        }

        private void tbTim_TextChanged(object sender, EventArgs e)
        {

        }

        private void ucDSHS_Load(object sender, EventArgs e)
        {

        }

        private void mlBack_Click(object sender, EventArgs e)
        {
            ucSearch uc = new ucSearch();
            frMain.Instance.MetroContainer.Controls.Add(uc);
            frMain.Instance.MetroContainer.Controls["ucSearch"].BringToFront();
        }
    }
}
