using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DemoMetroUI.DAL;
using DemoMetroUI.userControl.lich.add;
using DemoMetroUI.userControl;
using MetroFramework;
using DemoMetroUI;
using System.Data.SqlClient;

namespace DemoMetroUI.userControl.search
{
    public partial class ucDSGV : MetroFramework.Controls.MetroUserControl
    {
        private string macv { get; set; }
        private string mak { get; set; }
        private string mahv { get; set; }
        public ucDSGV()
        {
            InitializeComponent();
        }
        
        private void dgvSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ucDSGV_Load(object sender, EventArgs e)
        {
            {
                //load(macv, mak, mahv);
            }
            
            loadList();
            var cv = (lbdsCV.SelectedValue);
            macv = cv.ToString();

            var hv = (lbdsHV.SelectedValue);
            mahv = hv.ToString();

            var khoa = (lbdsK.SelectedValue);
            mak = khoa.ToString();
            if(ktServer() == true)
            {
                loadServer(macv, mak, mahv);
            }
            else
            {
                load(macv, mak, mahv);
            }
        }
        bool ktServer()
        {
            var ab = 0;
            string connecStr = "workstation id = QLGIAOVU.mssql.somee.com; packet size = 4096; user id = nhoxliaryeuem1_SQLLogin_1; pwd=8l5ab41xg8;data source = QLGIAOVU.mssql.somee.com; persist security info=False;initial catalog = QLGIAOVU";
            SqlConnection conn = new SqlConnection(connecStr);
            string cautruyvan = "select MAGV,TENCV,TENGV,TENHV,Email,QueQuan,DiaChiTamChu,TenKhoa,TrangThaiGV from GIANG_VIEN g, KHOA k, CHUC_VU c, HOC_VI h where g.MAKHOA = K.MAKHOA and g.MACV = C.MACV and g.MAHV = H.MAHV ";
            SqlDataAdapter adt = new SqlDataAdapter(cautruyvan, conn);
            DataTable dt = new DataTable();
            try
            {
                adt.Fill(dt);
                ab = 1;
            }
            catch (SqlException)
            {
                ab = 0;
                //hien loi 
            }
            if (ab == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public void loadServer(string MACV, string MAKHOA, string MAHV)
        {
            string connecStr = "workstation id = QLGIAOVU.mssql.somee.com; packet size = 4096; user id = nhoxliaryeuem1_SQLLogin_1; pwd=8l5ab41xg8;data source = QLGIAOVU.mssql.somee.com; persist security info=False;initial catalog = QLGIAOVU";
            SqlConnection conn = new SqlConnection(connecStr);
            string cautruyvan = "select MAGV,TENCV,TENGV,TENHV,Email,QueQuan,DiaChiTamChu,TenKhoa,TrangThaiGV from GIANG_VIEN g, KHOA k, CHUC_VU c, HOC_VI h where g.MAKHOA = K.MAKHOA and g.MACV = C.MACV and g.MAHV = H.MAHV and g.MACV = '" + MACV + "' and g.MAKHOA = '"+ MAKHOA +"' and g.MAHV = '"+ MAHV +"'";
            //string cautruyvan = "select MAGV,TENCV,TENGV,TENHV,Email,QueQuan,DiaChiTamChu,TenKhoa,TrangThaiGV from GIANG_VIEN g, KHOA k, CHUC_VU c, HOC_VI h where g.MAKHOA = K.MAKHOA and g.MACV = C.MACV and g.MAHV = H.MAHV";
            if(MACV == "" && MAKHOA == "" && MAHV == "")
            {
                cautruyvan = "select MAGV,TENCV,TENGV,TENHV,Email,QueQuan,DiaChiTamChu,TenKhoa,TrangThaiGV from GIANG_VIEN g, KHOA k, CHUC_VU c, HOC_VI h where g.MAKHOA = K.MAKHOA and g.MACV = C.MACV and g.MAHV = H.MAHV";
            }
            SqlDataAdapter adt = new SqlDataAdapter(cautruyvan, conn);
            DataTable dt = new DataTable();
            try
            {
                adt.Fill(dt);
                dgvGV.DataSource = dt;
                dgvGV.AutoResizeColumns();
            }
            catch (SqlException)
            {
                if (MessageBox.Show("Error", "Thong Bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    load(macv, mak, mahv);
                }
                ;
                //hien loi 
            }

            
        }
        public void loadList()
        {
            string connecStr = "workstation id = QLGIAOVU.mssql.somee.com; packet size = 4096; user id = nhoxliaryeuem1_SQLLogin_1; pwd=8l5ab41xg8;data source = QLGIAOVU.mssql.somee.com; persist security info=False;initial catalog = QLGIAOVU";
            SqlConnection conn = new SqlConnection(connecStr);

            using (var db = new QLHOCVUEntities())
            {
                //load listBox
                if (lbdsCV.DataSource == null)
                {
                    var cvdf = new CHUC_VU()
                    {
                        MACV = "",
                        TENCV = "Tất cả"
                    };

                    var chuc_vu = db.CHUC_VU.ToList();
                    chuc_vu.Insert(0, cvdf);
                    lbdsCV.DataSource = chuc_vu;
                }
                lbdsCV.DisplayMember = "TENCV";
                lbdsCV.ValueMember = "MACV";


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
                }
                lbdsK.DisplayMember = "TENKHOA";
                lbdsK.ValueMember = "MAKHOA";


                if (lbdsHV.DataSource == null)
                {

                    var hvdf = new HOC_VI()
                    {
                        MAHV = "",
                        TENHV = "Tất cả"
                    };

                    var hoc_vi = db.HOC_VI.ToList();
                    hoc_vi.Insert(0, hvdf);
                    lbdsHV.DataSource = hoc_vi;
                }
                lbdsHV.DisplayMember = "TENHV";
                lbdsHV.ValueMember = "MAHV";
            }

                //try
                //{
                //    string cautruyvan = "select * from CHUC_VU";
                //    SqlDataAdapter adt = new SqlDataAdapter(cautruyvan, conn);
                //    DataTable dt = new DataTable();
                //    adt.Fill(dt);

                //    ///////////////////////////////////////////////////////
                //    if (lbdsCV.DataSource == null)
                //    {
                //        var cvdf = new CHUC_VU()
                //        {
                //            MACV = "",
                //            TENCV = "Tất cả"
                //        };



                //        var chuc_vu = db.CHUC_VU.ToList();
                //        chuc_vu.Insert(0, cvdf);
                //        lbdsCV.DataSource = chuc_vu;
                //    }


                //    lbdsCV.DataSource = dt;
                //    lbdsCV.DisplayMember = "TENCV";
                //    lbdsCV.ValueMember = "MACV";
                //}
                //catch (SqlException)
                //{
                //    MessageBox.Show("Error CHUC_VU");
                //    //hien loi 
                //}
                //try
                //{
                //    string cautruyvan = "select * from KHOA";
                //    SqlDataAdapter adt = new SqlDataAdapter(cautruyvan, conn);
                //    DataTable dt = new DataTable();
                //    adt.Fill(dt);
                //    lbdsK.DataSource = dt;
                //    lbdsK.DisplayMember = "TENKHOA";
                //    lbdsK.ValueMember = "MAKHOA";
                //}
                //catch (SqlException)
                //{
                //    MessageBox.Show("Error KHOA");
                //    //hien loi 
                //}
                //try
                //{
                //    string cautruyvan = "select * from HOC_VI";
                //    SqlDataAdapter adt = new SqlDataAdapter(cautruyvan, conn);
                //    DataTable dt = new DataTable();
                //    adt.Fill(dt);
                //    lbdsHV.DataSource = dt;
                //    lbdsHV.DisplayMember = "TENHV";
                //    lbdsHV.ValueMember = "MAHV";
                //}
                //catch (SqlException)
                //{
                //    MessageBox.Show("Error HOC_VI");
                //    //hien loi 
                //}
            }
        private void mlBack_Click(object sender, EventArgs e)
        {
            ucSearch uc = new ucSearch();
            frMain.Instance.MetroContainer.Controls.Add(uc);
            frMain.Instance.MetroContainer.Controls["ucSearch"].BringToFront();
        }

        private void lbdsCV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cautruyvan = "select MAGV,TENCV,TENGV,TENHV,Email,QueQuan,DiaChiTamChu,TenKhoa,TrangThaiGV from GIANG_VIEN g, KHOA k, CHUC_VU c, HOC_VI h where g.MAKHOA = K.MAKHOA and g.MACV = C.MACV and g.MAHV = H.MAHV and g.MACV = '" + macv + "'";
            var cv = (lbdsCV.SelectedValue);
            macv = cv.ToString();

            //var hv = (lbdsHV.SelectedValue);
            //mahv = hv.ToString();

            //var khoa = (lbdsK.SelectedValue);
            //mak = khoa.ToString();

            //load(macv, mak, mahv);
            string connecStr = "workstation id = QLGIAOVU.mssql.somee.com; packet size = 4096; user id = nhoxliaryeuem1_SQLLogin_1; pwd=8l5ab41xg8;data source = QLGIAOVU.mssql.somee.com; persist security info=False;initial catalog = QLGIAOVU";
            SqlConnection conn = new SqlConnection(connecStr);

            //string cautruyvan = "select MAGV,TENCV,TENGV,TENHV,Email,QueQuan,DiaChiTamChu,TenKhoa,TrangThaiGV from GIANG_VIEN g, KHOA k, CHUC_VU c, HOC_VI h where g.MAKHOA = K.MAKHOA and g.MACV = C.MACV and g.MAHV = H.MAHV";

            SqlDataAdapter adt = new SqlDataAdapter(cautruyvan, conn);
            DataTable dt = new DataTable();
            dgvGV.DataSource = dt;
            if (ktServer() == true)
            {
                loadServer(macv, mak, mahv);
            }
            else
            {
                load(macv, mak, mahv);
            }
        }

        private void lbdsK_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var k = (lbdsK.SelectedValue);

            //mak = k.ToString();
            ////load(macv, mak, mahv);
            //dgvGV.DataSource = ketnoi.gettable("select MAGV,TENCV,TENGV,TENHV,Email,QueQuan,DiaChiTamChu,TenKhoa,TrangThaiGV from GIANG_VIEN g, KHOA k, CHUC_VU c, HOC_VI h where g.MAKHOA = " + mak + " and g.MACV = " + macv + " and g.MAHV = " + mahv + "");
            //loadServer(macv, mak, mahv);
            string cautruyvan = "select MAGV,TENCV,TENGV,TENHV,Email,QueQuan,DiaChiTamChu,TenKhoa,TrangThaiGV from GIANG_VIEN g, KHOA k, CHUC_VU c, HOC_VI h where g.MAKHOA = K.MAKHOA and g.MACV = C.MACV and g.MAHV = H.MAHV and g.MAKHOA = '" + mak + "'";
            //var cv = (lbdsCV.SelectedValue);
            //macv = cv.ToString();

            //var hv = (lbdsHV.SelectedValue);
            //mahv = hv.ToString();

            var khoa = (lbdsK.SelectedValue);
            mak = khoa.ToString();

            //load(macv, mak, mahv);

            string connecStr = "workstation id = QLGIAOVU.mssql.somee.com; packet size = 4096; user id = nhoxliaryeuem1_SQLLogin_1; pwd=8l5ab41xg8;data source = QLGIAOVU.mssql.somee.com; persist security info=False;initial catalog = QLGIAOVU";
            SqlConnection conn = new SqlConnection(connecStr);

            //string cautruyvan = "select MAGV,TENCV,TENGV,TENHV,Email,QueQuan,DiaChiTamChu,TenKhoa,TrangThaiGV from GIANG_VIEN g, KHOA k, CHUC_VU c, HOC_VI h where g.MAKHOA = K.MAKHOA and g.MACV = C.MACV and g.MAHV = H.MAHV";

            SqlDataAdapter adt = new SqlDataAdapter(cautruyvan, conn);
            DataTable dt = new DataTable();
            dgvGV.DataSource = dt;
            if (ktServer() == true)
            {
                loadServer(macv, mak, mahv);
            }
            else
            {
                load(macv, mak, mahv);
            }
        }
        public void load(string MACV, string MAKHOA, string MAHV)
        {
            using (var db = new QLHOCVUEntities())
            {
                //load listBox
                if (lbdsCV.DataSource == null)
                {
                    var cvdf = new CHUC_VU()
                    {
                        MACV = "",
                        TENCV = "Tất cả"
                    };

                    var chuc_vu = db.CHUC_VU.ToList();
                    chuc_vu.Insert(0, cvdf);
                    lbdsCV.DataSource = chuc_vu;
                }
                lbdsCV.DisplayMember = "TENCV";
                lbdsCV.ValueMember = "MACV";


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
                }
                lbdsK.DisplayMember = "TENKHOA";
                lbdsK.ValueMember = "MAKHOA";


                if (lbdsHV.DataSource == null)
                {

                    var hvdf = new HOC_VI()
                    {
                        MAHV = "",
                        TENHV = "Tất cả"
                    };

                    var hoc_vi = db.HOC_VI.ToList();
                    hoc_vi.Insert(0, hvdf);
                    lbdsHV.DataSource = hoc_vi;
                }
                lbdsHV.DisplayMember = "TENHV";
                lbdsHV.ValueMember = "MAHV";



                dgvGV.AutoSize = true;
                dgvGV.AutoGenerateColumns = false;
                var GV = db.GIANG_VIEN.AsQueryable();
                if (!string.IsNullOrEmpty(MACV))
                {
                    GV = GV.Where(x => x.MACV == MACV);
                }
                if (!string.IsNullOrEmpty(MAKHOA))
                {
                    GV = GV.Where(x => x.MAKHOA == MAKHOA);
                }
                if (!string.IsNullOrEmpty(MAHV))
                {
                    GV = GV.Where(x => x.MAHV == MAHV);
                }

                dgvGV.DataSource = GV.Select(x => new
                {
                    MAGV = x.MAGV,
                    MACV = x.MACV,
                    TENCV = x.CHUC_VU.TENCV,
                    TENGV = x.TENGV,
                    MAHV = x.MAHV,
                    TENHV = x.HOC_VI.TENHV,
                    Email = x.EMAIL,
                    QueQuan = x.QUEQUAN,
                    DiaChiTamChu = x.DIACHITAMCHU,
                    MAKHOA = x.MAKHOA,
                    TenKhoa = x.KHOA.TENKHOA,
                    TrangThaiGV = x.TRANGTHAIGV,
                    //== "1" ? "Rảnh" : "Không Rảnh"
                }).ToList();
                btnSua.Enabled = false;
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
             
            if ((MetroFramework.MetroMessageBox.Show(this, "Bạn có chắc muốn xóa!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)) == DialogResult.OK)
            {
                ketnoi.openketnoi();
                ketnoi.executeQuery("delete from GIANG_VIEN where MAGV='" + dgvGV.Rows[dgvGV.CurrentCell.RowIndex].Cells[1].Value.ToString() + "' ");
                load(null, null, null);
                ketnoi.dongketnoi();
            }
        }

        private void btnTT_Click(object sender, EventArgs e)
        {
            ketnoi.openketnoi();
            if (dgvGV.Rows[dgvGV.CurrentCell.RowIndex].Cells[0].Value.ToString() == "Rảnh")
            {
                ketnoi.executeQuery("update GIANG_VIEN set TRANGTHAIGV=2 where MAGV='" + dgvGV.Rows[dgvGV.CurrentCell.RowIndex].Cells[1].Value.ToString() + "'");
            }
            if (dgvGV.Rows[dgvGV.CurrentCell.RowIndex].Cells[0].Value.ToString() == "Không Rảnh")
            {
                ketnoi.executeQuery("update GIANG_VIEN set TRANGTHAIGV=1 where MAGV='" + dgvGV.Rows[dgvGV.CurrentCell.RowIndex].Cells[1].Value.ToString() + "'");
            }
            //load(macv, mak, mahv);
            ketnoi.dongketnoi();
        }

        private void lbdsHV_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var hv = (lbdsHV.SelectedValue);

            //mahv = hv.ToString();
            ////load(macv, mak, mahv);
            //dgvGV.DataSource = ketnoi.gettable("select MAGV,TENCV,TENGV,TENHV,Email,QueQuan,DiaChiTamChu,TenKhoa,TrangThaiGV from GIANG_VIEN g, KHOA k, CHUC_VU c, HOC_VI h where g.MAKHOA = " + mak + " and g.MACV = " + macv + " and g.MAHV = " + mahv + "");
            //loadServer(macv, mak, mahv);

            string cautruyvan = "select MAGV,TENCV,TENGV,TENHV,Email,QueQuan,DiaChiTamChu,TenKhoa,TrangThaiGV from GIANG_VIEN g, KHOA k, CHUC_VU c, HOC_VI h where g.MAKHOA = K.MAKHOA and g.MACV = C.MACV and g.MAHV = H.MAHV and g.MAHV = '" + mahv + "'";
            //var cv = (lbdsCV.SelectedValue);
            //macv = cv.ToString();

            var hv = (lbdsHV.SelectedValue);
            mahv = hv.ToString();

            //var khoa = (lbdsK.SelectedValue);
            //mak = khoa.ToString();

            //load(macv, mak, mahv);
            
            string connecStr = "workstation id = QLGIAOVU.mssql.somee.com; packet size = 4096; user id = nhoxliaryeuem1_SQLLogin_1; pwd=8l5ab41xg8;data source = QLGIAOVU.mssql.somee.com; persist security info=False;initial catalog = QLGIAOVU";
            SqlConnection conn = new SqlConnection(connecStr);

            //string cautruyvan = "select MAGV,TENCV,TENGV,TENHV,Email,QueQuan,DiaChiTamChu,TenKhoa,TrangThaiGV from GIANG_VIEN g, KHOA k, CHUC_VU c, HOC_VI h where g.MAKHOA = K.MAKHOA and g.MACV = C.MACV and g.MAHV = H.MAHV";

            SqlDataAdapter adt = new SqlDataAdapter(cautruyvan, conn);
            DataTable dt = new DataTable();
            dgvGV.DataSource = dt;
            if (ktServer() == true)
            {
                loadServer(macv, mak, mahv);
            }
            else
            {
                load(macv, mak, mahv);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ucThemlich uc = new ucThemlich();
            frMain.Instance.MetroContainer.Controls.Add(uc);
            frMain.Instance.MetroContainer.Controls["ucThemlich"].BringToFront();
        }
    }
}
