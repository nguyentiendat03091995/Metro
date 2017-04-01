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

                load(macv, mak, mahv);
            }
        }

        private void mlBack_Click(object sender, EventArgs e)
        {
            ucSearch uc = new ucSearch();
            frMain.Instance.MetroContainer.Controls.Add(uc);
            frMain.Instance.MetroContainer.Controls["ucSearch"].BringToFront();
        }

        private void lbdsCV_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cv = (lbdsCV.SelectedValue);
            macv = cv.ToString();
            load(macv, mak, mahv);
        }

        private void lbdsK_SelectedIndexChanged(object sender, EventArgs e)
        {
            var k = (lbdsK.SelectedValue);

            mak = k.ToString();
            load(macv, mak, mahv);
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
                    TrangThaiGV = x.TRANGTHAIGV == "1" ? "Rảnh" : "Không Rảnh",

                }).ToList();

                btnThem.Enabled = false;
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
            load(macv, mak, mahv);
            ketnoi.dongketnoi();
        }

        private void lbdsHV_SelectedIndexChanged(object sender, EventArgs e)
        {
            var hv = (lbdsHV.SelectedValue);

            mahv = hv.ToString();
            load(macv, mak, mahv);
        }
    }
}
