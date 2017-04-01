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
    public partial class ucSearch : MetroFramework.Controls.MetroUserControl
    {
        public ucSearch()
        {
            InitializeComponent();
        }

        private void mlBack_Click(object sender, EventArgs e)
        {
            ucDashboard uc = new ucDashboard();
            frMain.Instance.MetroContainer.Controls.Add(uc);
            frMain.Instance.MetroContainer.Controls["ucDashboard"].BringToFront();
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //if (txtUsername.Text == "admin" && txtPassword.Text == "789789")
                //{
                //    ucDashboard uc = new ucDashboard();
                //    frMain.Instance.MetroContainer.Controls.Add(uc);
                //    frMain.Instance.MetroContainer.Controls["ucDashboard"].BringToFront();
                //}
                //else
                //{
                MetroFramework.MetroMessageBox.Show(this, "Mục này chưa được hoàn thiện !!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                //}
            }
        }

        private void mtGv_Click(object sender, EventArgs e)
        {
            ucDSGV uc = new ucDSGV();
            frMain.Instance.MetroContainer.Controls.Add(uc);
            frMain.Instance.MetroContainer.Controls["ucDSGV"].BringToFront();
        }

        private void mtHs_Click(object sender, EventArgs e)
        {
            ucDSHS uc = new ucDSHS();
            frMain.Instance.MetroContainer.Controls.Add(uc);
            frMain.Instance.MetroContainer.Controls["ucDSHS"].BringToFront();
        }
    }
}
