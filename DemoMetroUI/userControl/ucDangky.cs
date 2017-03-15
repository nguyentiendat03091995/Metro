using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoMetroUI.userControl
{
    public partial class ucDangky : MetroFramework.Controls.MetroUserControl
    {
        public ucDangky()
        {
            InitializeComponent();
        }

        private void ucDangky_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ucDangnhap uc = new ucDangnhap();
            frMain.Instance.MetroContainer.Controls.Add(uc);
            frMain.Instance.MetroContainer.Controls["ucDangnhap"].BringToFront();
        }
    }
}
