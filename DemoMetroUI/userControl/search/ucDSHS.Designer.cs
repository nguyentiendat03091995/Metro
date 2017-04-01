namespace DemoMetroUI.userControl.search
{
    partial class ucDSHS
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.lbdsCV = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbdsK = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvGV = new System.Windows.Forms.DataGridView();
            this.TrangThaiGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENHV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChiTamChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QueQuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTT = new MetroFramework.Controls.MetroTile();
            this.btnTim = new MetroFramework.Controls.MetroTile();
            this.btnXoa = new MetroFramework.Controls.MetroTile();
            this.btnSua = new MetroFramework.Controls.MetroTile();
            this.btnThem = new MetroFramework.Controls.MetroTile();
            this.tbTim = new System.Windows.Forms.TextBox();
            this.mlBack = new MetroFramework.Controls.MetroLink();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(440, 53);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "Danh Sách Khoa";
            // 
            // lbdsCV
            // 
            this.lbdsCV.FormattingEnabled = true;
            this.lbdsCV.Location = new System.Drawing.Point(46, 69);
            this.lbdsCV.Name = "lbdsCV";
            this.lbdsCV.Size = new System.Drawing.Size(218, 95);
            this.lbdsCV.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Danh Sách Lớp";
            // 
            // lbdsK
            // 
            this.lbdsK.FormattingEnabled = true;
            this.lbdsK.Location = new System.Drawing.Point(440, 69);
            this.lbdsK.Name = "lbdsK";
            this.lbdsK.Size = new System.Drawing.Size(218, 95);
            this.lbdsK.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(381, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Danh Sách Học Sinh";
            // 
            // dgvGV
            // 
            this.dgvGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TrangThaiGV,
            this.MAGV,
            this.TENGV,
            this.TenKhoa,
            this.TENCV,
            this.TENHV,
            this.Email,
            this.DiaChiTamChu,
            this.QueQuan});
            this.dgvGV.Location = new System.Drawing.Point(3, 303);
            this.dgvGV.Name = "dgvGV";
            this.dgvGV.Size = new System.Drawing.Size(696, 158);
            this.dgvGV.TabIndex = 45;
            // 
            // TrangThaiGV
            // 
            this.TrangThaiGV.DataPropertyName = "TRANGTHAIGV";
            this.TrangThaiGV.HeaderText = "Trạng Thái";
            this.TrangThaiGV.Name = "TrangThaiGV";
            // 
            // MAGV
            // 
            this.MAGV.DataPropertyName = "MAGV";
            this.MAGV.HeaderText = "Mã GV";
            this.MAGV.Name = "MAGV";
            // 
            // TENGV
            // 
            this.TENGV.DataPropertyName = "TENGV";
            this.TENGV.HeaderText = "Tên GV";
            this.TENGV.Name = "TENGV";
            // 
            // TenKhoa
            // 
            this.TenKhoa.DataPropertyName = "TENKHOA";
            this.TenKhoa.HeaderText = "Khoa";
            this.TenKhoa.Name = "TenKhoa";
            // 
            // TENCV
            // 
            this.TENCV.DataPropertyName = "TENCV";
            this.TENCV.HeaderText = "Chức Vụ";
            this.TENCV.Name = "TENCV";
            // 
            // TENHV
            // 
            this.TENHV.DataPropertyName = "TENHV";
            this.TENHV.HeaderText = "Học Vị";
            this.TENHV.Name = "TENHV";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // DiaChiTamChu
            // 
            this.DiaChiTamChu.DataPropertyName = "DIACHITAMCHU";
            this.DiaChiTamChu.HeaderText = "Địa Chỉ";
            this.DiaChiTamChu.Name = "DiaChiTamChu";
            // 
            // QueQuan
            // 
            this.QueQuan.DataPropertyName = "QUEQUAN";
            this.QueQuan.HeaderText = "Quê Quán";
            this.QueQuan.Name = "QueQuan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(227, 0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(208, 29);
            this.label4.TabIndex = 53;
            this.label4.Text = "Tìm kiếm học sinh";
            // 
            // btnTT
            // 
            this.btnTT.ActiveControl = null;
            this.btnTT.Location = new System.Drawing.Point(20, 255);
            this.btnTT.Name = "btnTT";
            this.btnTT.Size = new System.Drawing.Size(105, 42);
            this.btnTT.TabIndex = 55;
            this.btnTT.Text = "Đổi Trạng Thái";
            this.btnTT.UseSelectable = true;
            // 
            // btnTim
            // 
            this.btnTim.ActiveControl = null;
            this.btnTim.Location = new System.Drawing.Point(583, 223);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(105, 42);
            this.btnTim.TabIndex = 56;
            this.btnTim.Text = "TÌM";
            this.btnTim.UseSelectable = true;
            // 
            // btnXoa
            // 
            this.btnXoa.ActiveControl = null;
            this.btnXoa.Location = new System.Drawing.Point(421, 170);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(105, 42);
            this.btnXoa.TabIndex = 57;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseSelectable = true;
            // 
            // btnSua
            // 
            this.btnSua.ActiveControl = null;
            this.btnSua.Location = new System.Drawing.Point(261, 170);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(105, 42);
            this.btnSua.TabIndex = 58;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseSelectable = true;
            // 
            // btnThem
            // 
            this.btnThem.ActiveControl = null;
            this.btnThem.Location = new System.Drawing.Point(96, 170);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(105, 42);
            this.btnThem.TabIndex = 59;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseSelectable = true;
            // 
            // tbTim
            // 
            this.tbTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTim.Location = new System.Drawing.Point(384, 236);
            this.tbTim.Name = "tbTim";
            this.tbTim.Size = new System.Drawing.Size(192, 29);
            this.tbTim.TabIndex = 54;
            this.tbTim.TextChanged += new System.EventHandler(this.tbTim_TextChanged);
            // 
            // mlBack
            // 
            this.mlBack.Image = global::DemoMetroUI.Properties.Resources._1489502099_Previous_2;
            this.mlBack.ImageSize = 32;
            this.mlBack.Location = new System.Drawing.Point(0, 0);
            this.mlBack.Name = "mlBack";
            this.mlBack.Size = new System.Drawing.Size(75, 39);
            this.mlBack.TabIndex = 60;
            this.mlBack.UseSelectable = true;
            this.mlBack.Click += new System.EventHandler(this.mlBack_Click);
            // 
            // ucDSHS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mlBack);
            this.Controls.Add(this.btnTT);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.tbTim);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbdsCV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbdsK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvGV);
            this.Name = "ucDSHS";
            this.Size = new System.Drawing.Size(702, 404);
            this.Load += new System.EventHandler(this.ucDSHS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbdsCV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbdsK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThaiGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENCV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENHV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChiTamChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn QueQuan;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroTile btnTT;
        private MetroFramework.Controls.MetroTile btnTim;
        private MetroFramework.Controls.MetroTile btnXoa;
        private MetroFramework.Controls.MetroTile btnSua;
        private MetroFramework.Controls.MetroTile btnThem;
        private System.Windows.Forms.TextBox tbTim;
        private MetroFramework.Controls.MetroLink mlBack;
    }
}
