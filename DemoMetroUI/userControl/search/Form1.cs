using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;





namespace DemoMetroUI.userControl.search
{
    public partial class DanhSachGV : Form
    {
        public DanhSachGV()
        {
            InitializeComponent();
        }
        private void lbdsK_SelectedIndexChanged(object sender, EventArgs e)
        {
        

            string ma= lbdsK.SelectedValue.ToString();
            dgvGV.DataSource = ketnoi.gettable("select * from GIANG_VIEN where GIANG_VIEN.MACV='" + ma + "'");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            {
                load();
            }
        }
    
        public void load()
        {

            ketnoi.openketnoi();
            //load listBox
            lbdsK.DataSource = ketnoi.gettable("select *from CHUC_VU");
            lbdsK.DisplayMember = "TENCV";
            lbdsK.ValueMember = "MACV";
            //Load DataGridView
            dgvGV.DataSource = ketnoi.gettable("select * from GIANG_VIEN");
            btnChapNhan.Enabled = false;
            btnHuy.Enabled = false;
            ketnoi.dongketnoi();
        }

      
        // Khi click vào 1 dòng bất kỳ trong DataGridView hiện lên TextBox
        //private void dtgvpb_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    int t = dtgvpb.CurrentCell.RowIndex;
        //    tbMaNV.Text = dtgvpb.Rows[t].Cells[0].Value.ToString();
        //    tbTenNV.Text = dtgvpb.Rows[t].Cells[1].Value.ToString();
        //    tbNgaySinh.Text = dtgvpb.Rows[t].Cells[2].Value.ToString();
        //    tbDT.Text = dtgvpb.Rows[t].Cells[3].Value.ToString();
        //    tbMaPB.Text = dtgvpb.Rows[t].Cells[4].Value.ToString();
        //}
    }
    }

