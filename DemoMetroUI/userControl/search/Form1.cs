using DemoMetroUI.DAL;
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
        private string macv { get; set; }
        private string mak { get; set; }
        public DanhSachGV()
        {
            InitializeComponent();
        }
        private void lbdsCV_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            var cv = (lbdsCV.SelectedValue);
        
             macv =cv.ToString() ;
            var k = (lbdsK.SelectedValue);

            k = k.ToString();
            load(macv,mak);
            
        }
        private void lbdsK_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cv = (lbdsCV.SelectedValue);

            macv = cv.ToString();
            var k = (lbdsK.SelectedValue );
           
                mak = k.ToString();
                load(macv, mak);
            
            
        }

        private void Form1_Load(object sender, EventArgs e )
        {
            {
               
                load(null,null);
            }
        }
    
        public void load(string MACV,string MAKHOA)
        {
            using (var db = new QLHOCVUEntities())
            {
                //load listBox
                if(lbdsCV.DataSource==null)
                {
                    var cvdf = new CHUC_VU()
                    {
                        MACV = "",
                        TENCV = "Tất cả"
                    };
                    var chuc_vu = db.CHUC_VU.ToList();
                    chuc_vu.Insert(0, cvdf);
                    lbdsCV.DataSource = chuc_vu;
                   
                    lbdsCV.SelectedItem =cvdf ;
                    lbdsCV.DisplayMember = "TENCV";
                    lbdsCV.ValueMember = "MACV";
                }
                if (lbdsK.DataSource == null)
                {
                    var kdf = new KHOA()
                    {
                        MAKHOA = "",
                        TENKHOA = "Tất cả"
                    };
                    var khoas = db.KHOAs.ToList();
                    khoas.Insert(0, kdf);
                    lbdsK.DataSource = khoas;
                    lbdsK.DisplayMember = "TENKHOA";
                    lbdsK.ValueMember = "MAKHOA";

                
                }
                if (lbdsHV.DataSource == null)
                {
                    lbdsHV.DataSource = db.HOC_VI.ToList();
                    lbdsHV.DisplayMember = "TENHV";
                    lbdsHV.ValueMember = "MAHV";
                }
                //Load DataGridView
                dgvGV.AutoSize = true;
                dgvGV.AutoGenerateColumns = false;
                var GV = db.GIANG_VIEN.AsQueryable();
                if(!string.IsNullOrEmpty(MACV))
                {
                    GV = GV.Where(x => x.MACV == MACV);
                }
                if (!string.IsNullOrEmpty(MAKHOA))
                {
                    GV = GV.Where(x => x.MAKHOA == MAKHOA);
                }
                dgvGV.DataSource =GV.Select(x=>new
                {
                    MAGV =x.MAGV,
                    MACV =x.MACV,
                    TENCV =x.CHUC_VU.TENCV,
                    TENGV =x.TENGV,
                    MAHV =x.MAHV,
                    TENHV =x.HOC_VI.TENHV,
                    Email =x.EMAIL,
                    QueQuan =x.QUEQUAN,
                    DiaChiTamChu =x.DIACHITAMCHU,
                    MAKHOA =x.MAKHOA,
                    TenKhoa =x.KHOA.TENKHOA,
                    TrangThaiGV =x.TRANGTHAIGV=="1"?"Rảnh":"Không Rảnh",
                    
                } ).ToList();
                
                btnThem.Enabled = false;
                btnSua.Enabled = false;
            }
      
        }

        private void dgvGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

