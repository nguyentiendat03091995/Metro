using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DemoMetroUI.userControl.lich;
using DemoMetroUI.userControl.search;

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

        private void mtLich_Click(object sender, EventArgs e)
        {
            ucLichtong uc = new ucLichtong();
            frMain.Instance.MetroContainer.Controls.Add(uc);
            frMain.Instance.MetroContainer.Controls["ucLichtong"].BringToFront();
        }

        private void mtOffline_Click(object sender, EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this, "Mục đang được nâng cấp !, vui lòng chọn mục khác !!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void mtTheodoi_Click(object sender, EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this, "Mục đang được nâng cấp !, vui lòng chọn mục khác !!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void mtYkien_Click(object sender, EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this, "Mục đang được nâng cấp !, vui lòng chọn mục khác !!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void mtTimkiem_Click(object sender, EventArgs e)
        {
            //MetroFramework.MetroMessageBox.Show(this, "Mục đang được nâng cấp !, vui lòng chọn mục khác !!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            ucSearch uc = new ucSearch();
            frMain.Instance.MetroContainer.Controls.Add(uc);
            frMain.Instance.MetroContainer.Controls["ucSearch"].BringToFront();
        }

        private void mtLapphieudiem_Click(object sender, EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this, "Mục đang được nâng cấp !, vui lòng chọn mục khác !!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void mtBaocao_Click(object sender, EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this, "Mục đang được nâng cấp !, vui lòng chọn mục khác !!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void mtImport_Click(object sender, EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this, "Mục đang được nâng cấp !, vui lòng chọn mục khác !!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void mtDanhgia_Click(object sender, EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this, "Mục đang được nâng cấp !, vui lòng chọn mục khác !!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
