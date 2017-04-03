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
using System.Data.SqlClient;
using DemoMetroUI.userControl.search;

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
        //public void load()
        //{
        //    ketnoi.openketnoi();
        //    //load listBox
        //    lbdspb.DataSource = ketnoi.gettable("select *from phongban");
        //    lbdspb.DisplayMember = "tenpb";
        //    lbdspb.ValueMember = "mapb";

        //    //Load DataGridView
        //    dtgvpb.DataSource = ketnoi.gettable("select *from nhanvien");

        //    bntChapNhan.Enabled = false;
        //    bntHuy.Enabled = false;
        //    ketnoi.dongketnoi();
        //}
        private void mlBack_Click(object sender, EventArgs e)
        {
            ucThem uc = new ucThem();
            frMain.Instance.MetroContainer.Controls.Add(uc);
            frMain.Instance.MetroContainer.Controls["ucThem"].BringToFront();
        }

        private void mtLuu_Click(object sender, EventArgs e)
        {
            int sex;            
            MetroFramework.MetroMessageBox.Show(this,"Lưu thành công !!", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            if(cboSex.Text == "Nam")
            {
                sex = 1;
            }
            else
            {
                sex = 0;
            }
            ketnoi.openketnoi();
            ketnoi.executeQuery("insert into GIANG_VIEN values('" + txtCode.Text + "','" + txtHoten.Text + "','ThS','GVBT','" + DateTime.Parse(dtNgaysinh.Text) + "','" + txtQuequan.Text + "','" + txtDiachi.Text + "','" + txtEmail.Text + "','" + sex + "','" + txtPhone.Text + "','" + txtCmnd.Text + "','" + txtDk.Text + "','CDDT')");
            

            
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
