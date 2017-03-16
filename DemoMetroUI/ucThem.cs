using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using DemoMetroUI;
using DemoMetroUI.userControl.giangVien;
using DemoMetroUI.userControl.monHoc;


namespace DemoMetroUI
{
    public partial class ucThem : MetroFramework.Controls.MetroUserControl
    {
        public ucThem()
        {
            InitializeComponent();
        }

        private void ucThem_Load(object sender, EventArgs e)
        {

        }

        private void mtThemgv_Click(object sender, EventArgs e)
        {
            ucCreategv uc = new ucCreategv();
            frMain.Instance.MetroContainer.Controls.Add(uc);
            frMain.Instance.MetroContainer.Controls["ucCreategv"].BringToFront();
        }

        private void mtThemlop_Click(object sender, EventArgs e)
        {

        }

        private void mtThemphong_Click(object sender, EventArgs e)
        {

        }

        private void mtThemmh_Click(object sender, EventArgs e)
        {
            ucCreatemh uc = new ucCreatemh();
            frMain.Instance.MetroContainer.Controls.Add(uc);
            frMain.Instance.MetroContainer.Controls["ucCreatemh"].BringToFront();
        }

        private void mlBack_Click(object sender, EventArgs e)
        {
            ucDashboard uc = new ucDashboard();
            frMain.Instance.MetroContainer.Controls.Add(uc);
            frMain.Instance.MetroContainer.Controls["ucDashboard"].BringToFront();
        }
    }
}
