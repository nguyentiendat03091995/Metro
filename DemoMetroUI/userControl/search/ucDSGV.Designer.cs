namespace DemoMetroUI.userControl.search
{
    partial class ucDSGV
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbTim = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbdsHV = new System.Windows.Forms.ListBox();
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
            this.dgvSearch = new MetroFramework.Controls.MetroGrid();
            this.label5 = new System.Windows.Forms.Label();
            this.btnThem = new MetroFramework.Controls.MetroTile();
            this.btnSua = new MetroFramework.Controls.MetroTile();
            this.btnXoa = new MetroFramework.Controls.MetroTile();
            this.btnTim = new MetroFramework.Controls.MetroTile();
            this.btnTT = new MetroFramework.Controls.MetroTile();
            this.mlBack = new MetroFramework.Controls.MetroLink();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // tbTim
            // 
            this.tbTim.Location = new System.Drawing.Point(331, 245);
            this.tbTim.Name = "tbTim";
            this.tbTim.Size = new System.Drawing.Size(192, 20);
            this.tbTim.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(475, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Danh Sách Học Vị";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 47);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Danh Sách Khoa";
            // 
            // lbdsHV
            // 
            this.lbdsHV.FormattingEnabled = true;
            this.lbdsHV.Location = new System.Drawing.Point(466, 63);
            this.lbdsHV.Name = "lbdsHV";
            this.lbdsHV.Size = new System.Drawing.Size(218, 95);
            this.lbdsHV.TabIndex = 39;
            this.lbdsHV.SelectedIndexChanged += new System.EventHandler(this.lbdsHV_SelectedIndexChanged);
            // 
            // lbdsCV
            // 
            this.lbdsCV.FormattingEnabled = true;
            this.lbdsCV.Location = new System.Drawing.Point(14, 63);
            this.lbdsCV.Name = "lbdsCV";
            this.lbdsCV.Size = new System.Drawing.Size(172, 95);
            this.lbdsCV.TabIndex = 38;
            this.lbdsCV.SelectedIndexChanged += new System.EventHandler(this.lbdsCV_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Danh Sách Chức Vụ";
            // 
            // lbdsK
            // 
            this.lbdsK.FormattingEnabled = true;
            this.lbdsK.Location = new System.Drawing.Point(217, 63);
            this.lbdsK.Name = "lbdsK";
            this.lbdsK.Size = new System.Drawing.Size(218, 95);
            this.lbdsK.TabIndex = 33;
            this.lbdsK.SelectedIndexChanged += new System.EventHandler(this.lbdsK_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(394, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Danh Sách Giảng Viên";
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
            this.dgvGV.Location = new System.Drawing.Point(9, 337);
            this.dgvGV.Name = "dgvGV";
            this.dgvGV.Size = new System.Drawing.Size(675, 158);
            this.dgvGV.TabIndex = 31;
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
            // dgvSearch
            // 
            this.dgvSearch.AllowUserToResizeRows = false;
            this.dgvSearch.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSearch.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvSearch.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSearch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSearch.DefaultCellStyle = dataGridViewCellStyle20;
            this.dgvSearch.EnableHeadersVisualStyles = false;
            this.dgvSearch.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvSearch.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvSearch.Location = new System.Drawing.Point(9, 242);
            this.dgvSearch.Name = "dgvSearch";
            this.dgvSearch.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSearch.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvSearch.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSearch.Size = new System.Drawing.Size(686, 255);
            this.dgvSearch.TabIndex = 30;
            this.dgvSearch.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSearch_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(217, 0);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(237, 29);
            this.label5.TabIndex = 40;
            this.label5.Text = "Tìm kiếm Giảng Viên";
            // 
            // btnThem
            // 
            this.btnThem.ActiveControl = null;
            this.btnThem.Location = new System.Drawing.Point(36, 185);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(105, 42);
            this.btnThem.TabIndex = 45;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseSelectable = true;
            // 
            // btnSua
            // 
            this.btnSua.ActiveControl = null;
            this.btnSua.Location = new System.Drawing.Point(182, 185);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(105, 42);
            this.btnSua.TabIndex = 45;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseSelectable = true;
            // 
            // btnXoa
            // 
            this.btnXoa.ActiveControl = null;
            this.btnXoa.Location = new System.Drawing.Point(344, 185);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(105, 42);
            this.btnXoa.TabIndex = 45;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseSelectable = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTim
            // 
            this.btnTim.ActiveControl = null;
            this.btnTim.Location = new System.Drawing.Point(562, 245);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(105, 42);
            this.btnTim.TabIndex = 45;
            this.btnTim.Text = "TÌM";
            this.btnTim.UseSelectable = true;
            // 
            // btnTT
            // 
            this.btnTT.ActiveControl = null;
            this.btnTT.Location = new System.Drawing.Point(36, 289);
            this.btnTT.Name = "btnTT";
            this.btnTT.Size = new System.Drawing.Size(105, 42);
            this.btnTT.TabIndex = 45;
            this.btnTT.Text = "Đổi Trạng Thái";
            this.btnTT.UseSelectable = true;
            this.btnTT.Click += new System.EventHandler(this.btnTT_Click);
            // 
            // mlBack
            // 
            this.mlBack.Image = global::DemoMetroUI.Properties.Resources._1489502099_Previous_2;
            this.mlBack.ImageSize = 32;
            this.mlBack.Location = new System.Drawing.Point(0, 0);
            this.mlBack.Name = "mlBack";
            this.mlBack.Size = new System.Drawing.Size(75, 39);
            this.mlBack.TabIndex = 46;
            this.mlBack.UseSelectable = true;
            this.mlBack.Click += new System.EventHandler(this.mlBack_Click);
            // 
            // ucDSGV
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
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbdsHV);
            this.Controls.Add(this.lbdsCV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbdsK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvGV);
            this.Controls.Add(this.dgvSearch);
            this.Name = "ucDSGV";
            this.Size = new System.Drawing.Size(702, 404);
            this.Load += new System.EventHandler(this.ucDSGV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbTim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbdsHV;
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
        private MetroFramework.Controls.MetroGrid dgvSearch;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroTile btnThem;
        private MetroFramework.Controls.MetroTile btnSua;
        private MetroFramework.Controls.MetroTile btnXoa;
        private MetroFramework.Controls.MetroTile btnTim;
        private MetroFramework.Controls.MetroTile btnTT;
        private MetroFramework.Controls.MetroLink mlBack;
    }
}
