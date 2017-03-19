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

namespace DemoMetroUI.userControl.giangVien
{
    public partial class ucCreategv : MetroFramework.Controls.MetroUserControl
    {
        public ucCreategv()
        {
            InitializeComponent();
        }

        private void ucCreategv_Load(object sender, EventArgs e)
        {

        }

        private void mlBack_Click(object sender, EventArgs e)
        {
            ucThem uc = new ucThem();
            frMain.Instance.MetroContainer.Controls.Add(uc);
            frMain.Instance.MetroContainer.Controls["ucThem"].BringToFront();
        }

        private void mtLuu_Click(object sender, EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this,"Lưu thành công !!", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
                
        }

        private void txtCmnd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtLuongcb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtLuongcb_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtLuongcb.Text.Equals("0"))
                    return;
                double temp = Convert.ToDouble(txtLuongcb.Text);
                txtLuongcb.Text = temp.ToString("#,###");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi:" + ex);
            }
        }

        private void txtLuongcb_TabIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
