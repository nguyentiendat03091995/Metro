namespace DemoMetroUI.userControl.search
{
    partial class DanhSachGV
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbdsK = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvGV = new System.Windows.Forms.DataGridView();
            this.dgvSearch = new MetroFramework.Controls.MetroGrid();
            this.btnXoa = new System.Windows.Forms.Button();
            this.TrangThaiGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENHV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChiTamChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QueQuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbdsCV = new System.Windows.Forms.ListBox();
            this.lbdsHV = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(189, 203);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 21;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(69, 203);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 20;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Danh Sách Chức Vụ";
            // 
            // lbdsK
            // 
            this.lbdsK.FormattingEnabled = true;
            this.lbdsK.Location = new System.Drawing.Point(349, 80);
            this.lbdsK.Name = "lbdsK";
            this.lbdsK.Size = new System.Drawing.Size(218, 95);
            this.lbdsK.TabIndex = 18;
            this.lbdsK.SelectedIndexChanged += new System.EventHandler(this.lbdsK_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 17;
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
            this.dgvGV.Location = new System.Drawing.Point(12, 297);
            this.dgvGV.Name = "dgvGV";
            this.dgvGV.Size = new System.Drawing.Size(928, 158);
            this.dgvGV.TabIndex = 16;
            this.dgvGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGV_CellContentClick);
            // 
            // dgvSearch
            // 
            this.dgvSearch.AllowUserToResizeRows = false;
            this.dgvSearch.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSearch.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvSearch.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSearch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSearch.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvSearch.EnableHeadersVisualStyles = false;
            this.dgvSearch.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvSearch.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvSearch.Location = new System.Drawing.Point(40, 156);
            this.dgvSearch.Name = "dgvSearch";
            this.dgvSearch.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSearch.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvSearch.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSearch.Size = new System.Drawing.Size(900, 255);
            this.dgvSearch.TabIndex = 15;
            this.dgvSearch.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSearch_CellContentClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(324, 203);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 22;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
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
            // lbdsCV
            // 
            this.lbdsCV.FormattingEnabled = true;
            this.lbdsCV.Location = new System.Drawing.Point(46, 80);
            this.lbdsCV.Name = "lbdsCV";
            this.lbdsCV.Size = new System.Drawing.Size(218, 95);
            this.lbdsCV.TabIndex = 23;
            this.lbdsCV.SelectedIndexChanged += new System.EventHandler(this.lbdsCV_SelectedIndexChanged);
            // 
            // lbdsHV
            // 
            this.lbdsHV.FormattingEnabled = true;
            this.lbdsHV.Location = new System.Drawing.Point(661, 80);
            this.lbdsHV.Name = "lbdsHV";
            this.lbdsHV.Size = new System.Drawing.Size(218, 95);
            this.lbdsHV.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(349, 44);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Danh Sách Khoa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(658, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Danh Sách Học Vị";
            // 
            // DanhSachGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 498);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbdsHV);
            this.Controls.Add(this.lbdsCV);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbdsK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvGV);
            this.Controls.Add(this.dgvSearch);
            this.Name = "DanhSachGV";
            this.Text = "Danh Sách GV";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbdsK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvGV;
        private MetroFramework.Controls.MetroGrid dgvSearch;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThaiGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENCV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENHV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChiTamChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn QueQuan;
        private System.Windows.Forms.ListBox lbdsCV;
        private System.Windows.Forms.ListBox lbdsHV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}