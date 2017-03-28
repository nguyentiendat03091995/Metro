namespace DemoMetroUI.userControl.search
{
    partial class HOC_SINH
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
            this.btnTT = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.tbTim = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbdsCV = new System.Windows.Forms.ListBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvGV)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTT
            // 
            this.btnTT.Location = new System.Drawing.Point(34, 252);
            this.btnTT.Name = "btnTT";
            this.btnTT.Size = new System.Drawing.Size(93, 23);
            this.btnTT.TabIndex = 44;
            this.btnTT.Text = "Đổi Trạng Thái";
            this.btnTT.UseVisualStyleBackColor = true;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(800, 187);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 43;
            this.btnTim.Text = "TÌM";
            this.btnTim.UseVisualStyleBackColor = true;
            // 
            // tbTim
            // 
            this.tbTim.Location = new System.Drawing.Point(602, 190);
            this.tbTim.Name = "tbTim";
            this.tbTim.Size = new System.Drawing.Size(192, 20);
            this.tbTim.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(328, 28);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Danh Sách Khoa";
            // 
            // lbdsCV
            // 
            this.lbdsCV.FormattingEnabled = true;
            this.lbdsCV.Location = new System.Drawing.Point(25, 64);
            this.lbdsCV.Name = "lbdsCV";
            this.lbdsCV.Size = new System.Drawing.Size(218, 95);
            this.lbdsCV.TabIndex = 38;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(303, 187);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 37;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(168, 187);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 36;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(48, 187);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 35;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Danh Sách Lớp";
            // 
            // lbdsK
            // 
            this.lbdsK.FormattingEnabled = true;
            this.lbdsK.Location = new System.Drawing.Point(328, 64);
            this.lbdsK.Name = "lbdsK";
            this.lbdsK.Size = new System.Drawing.Size(218, 95);
            this.lbdsK.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(376, 257);
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
            this.dgvGV.Location = new System.Drawing.Point(-9, 281);
            this.dgvGV.Name = "dgvGV";
            this.dgvGV.Size = new System.Drawing.Size(928, 158);
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
            // HOC_SINH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 467);
            this.Controls.Add(this.btnTT);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.tbTim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbdsCV);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbdsK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvGV);
            this.Name = "HOC_SINH";
            this.Text = "Học Sinh";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTT;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox tbTim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbdsCV;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
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
    }
}