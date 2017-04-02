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
using DemoMetroUI.userControl.lop;
using DemoMetroUI.userControl.khoa;
using DemoMetroUI.userControl.caHoc;
using DemoMetroUI.userControl.phong;
using DemoMetroUI.userControl.chucVu;
using DemoMetroUI.userControl.nganh;
using DemoMetroUI.userControl.lich.add;


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
        //cmit
        private void mtThemlop_Click(object sender, EventArgs e)
        {
            //MetroFramework.MetroMessageBox.Show(this, "Mục đang được nâng cấp !, vui lòng chọn mục khác !!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            ucLop uc = new ucLop();
            frMain.Instance.MetroContainer.Controls.Add(uc);
            frMain.Instance.MetroContainer.Controls["ucLop"].BringToFront();
        }

        private void mtThemphong_Click(object sender, EventArgs e)
        {
            //MetroFramework.MetroMessageBox.Show(this, "Mục đang được nâng cấp !, vui lòng chọn mục khác !!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            ucPhong uc = new ucPhong();
            frMain.Instance.MetroContainer.Controls.Add(uc);
            frMain.Instance.MetroContainer.Controls["ucPhong"].BringToFront();
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

        private void mtThemkhoa_Click(object sender, EventArgs e)
        {
            ucKhoa uc = new ucKhoa();
            frMain.Instance.MetroContainer.Controls.Add(uc);
            frMain.Instance.MetroContainer.Controls["ucKhoa"].BringToFront();
        }

        private void mtThemca_Click(object sender, EventArgs e)
        {
            ucCa uc = new ucCa();
            frMain.Instance.MetroContainer.Controls.Add(uc);
            frMain.Instance.MetroContainer.Controls["ucCa"].BringToFront();
        }

        private void mtThemcv_Click(object sender, EventArgs e)
        {
            ucChucvu uc = new ucChucvu();
            frMain.Instance.MetroContainer.Controls.Add(uc);
            frMain.Instance.MetroContainer.Controls["ucChucvu"].BringToFront();
        }

        private void mtThemnganh_Click(object sender, EventArgs e)
        {
            ucNganh uc = new ucNganh();
            frMain.Instance.MetroContainer.Controls.Add(uc);
            frMain.Instance.MetroContainer.Controls["ucNganh"].BringToFront();
        }

        private void mtThemlich_Click(object sender, EventArgs e)
        {
            ucThemlich uc = new ucThemlich();
            frMain.Instance.MetroContainer.Controls.Add(uc);
            frMain.Instance.MetroContainer.Controls["ucViewlich"].BringToFront();
        }
    }
}
