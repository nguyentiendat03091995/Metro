using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DemoMetroUI;
using MetroFramework;
using MetroFramework.Forms;

namespace DemoMetroUI.userControl
{
    public partial class ucDangnhap : MetroFramework.Controls.MetroUserControl
    {
        public ucDangnhap()
        {
            InitializeComponent();
        }
        

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text == "admin" && txtPassword.Text == "789789")
            {
                ucDashboard uc = new ucDashboard();
                frMain.Instance.MetroContainer.Controls.Add(uc);
                frMain.Instance.MetroContainer.Controls["ucDashboard"].BringToFront();
            }
            else
            {
                //hế lu
                MetroFramework.MetroMessageBox.Show(this, "User Name or Password was wron't !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            ucDangky uc = new ucDangky();
            frMain.Instance.MetroContainer.Controls.Add(uc);
            frMain.Instance.MetroContainer.Controls["ucDangky"].BringToFront();
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (txtUsername.Text == "admin" && txtPassword.Text == "789789")
                {
                    ucDashboard uc = new ucDashboard();
                    frMain.Instance.MetroContainer.Controls.Add(uc);
                    frMain.Instance.MetroContainer.Controls["ucDashboard"].BringToFront();
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "User Name or Password was wron't !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }

        
    }
}
