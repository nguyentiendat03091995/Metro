namespace DemoMetroUI.userControl.lich.add
{
    partial class ucThemlich
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
            this.mlBack = new MetroFramework.Controls.MetroLink();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtPhong = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtLop = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtMon = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox4 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.mtLuu = new MetroFramework.Controls.MetroTile();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.cboGiangvien = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // mlBack
            // 
            this.mlBack.Image = global::DemoMetroUI.Properties.Resources._1489502099_Previous_2;
            this.mlBack.ImageSize = 32;
            this.mlBack.Location = new System.Drawing.Point(0, 0);
            this.mlBack.Name = "mlBack";
            this.mlBack.Size = new System.Drawing.Size(75, 39);
            this.mlBack.TabIndex = 6;
            this.mlBack.UseSelectable = true;
            this.mlBack.Click += new System.EventHandler(this.mlBack_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendar1.Location = new System.Drawing.Point(0, 78);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendar2.Location = new System.Drawing.Point(475, 78);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 1;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 50);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(93, 19);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Ngày Bắt Đầu:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(247, 133);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(50, 19);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Phòng:";
            this.metroLabel2.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // txtPhong
            // 
            // 
            // 
            // 
            this.txtPhong.CustomButton.Image = null;
            this.txtPhong.CustomButton.Location = new System.Drawing.Point(106, 1);
            this.txtPhong.CustomButton.Name = "";
            this.txtPhong.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPhong.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPhong.CustomButton.TabIndex = 1;
            this.txtPhong.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPhong.CustomButton.UseSelectable = true;
            this.txtPhong.CustomButton.Visible = false;
            this.txtPhong.Lines = new string[0];
            this.txtPhong.Location = new System.Drawing.Point(328, 133);
            this.txtPhong.MaxLength = 32767;
            this.txtPhong.Name = "txtPhong";
            this.txtPhong.PasswordChar = '\0';
            this.txtPhong.PromptText = "Tên phòng.....";
            this.txtPhong.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPhong.SelectedText = "";
            this.txtPhong.SelectionLength = 0;
            this.txtPhong.SelectionStart = 0;
            this.txtPhong.ShortcutsEnabled = true;
            this.txtPhong.Size = new System.Drawing.Size(128, 23);
            this.txtPhong.TabIndex = 8;
            this.txtPhong.UseSelectable = true;
            this.txtPhong.WaterMark = "Tên phòng.....";
            this.txtPhong.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPhong.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(247, 162);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(34, 19);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "Lớp:";
            this.metroLabel3.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // txtLop
            // 
            // 
            // 
            // 
            this.txtLop.CustomButton.Image = null;
            this.txtLop.CustomButton.Location = new System.Drawing.Point(106, 1);
            this.txtLop.CustomButton.Name = "";
            this.txtLop.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtLop.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLop.CustomButton.TabIndex = 1;
            this.txtLop.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLop.CustomButton.UseSelectable = true;
            this.txtLop.CustomButton.Visible = false;
            this.txtLop.Lines = new string[0];
            this.txtLop.Location = new System.Drawing.Point(328, 162);
            this.txtLop.MaxLength = 32767;
            this.txtLop.Name = "txtLop";
            this.txtLop.PasswordChar = '\0';
            this.txtLop.PromptText = "Tên lớp.....";
            this.txtLop.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLop.SelectedText = "";
            this.txtLop.SelectionLength = 0;
            this.txtLop.SelectionStart = 0;
            this.txtLop.ShortcutsEnabled = true;
            this.txtLop.Size = new System.Drawing.Size(128, 23);
            this.txtLop.TabIndex = 8;
            this.txtLop.UseSelectable = true;
            this.txtLop.WaterMark = "Tên lớp.....";
            this.txtLop.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLop.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtLop.Click += new System.EventHandler(this.metroTextBox2_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(247, 191);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(39, 19);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "Môn:";
            this.metroLabel4.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // txtMon
            // 
            // 
            // 
            // 
            this.txtMon.CustomButton.Image = null;
            this.txtMon.CustomButton.Location = new System.Drawing.Point(106, 1);
            this.txtMon.CustomButton.Name = "";
            this.txtMon.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMon.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMon.CustomButton.TabIndex = 1;
            this.txtMon.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMon.CustomButton.UseSelectable = true;
            this.txtMon.CustomButton.Visible = false;
            this.txtMon.Lines = new string[0];
            this.txtMon.Location = new System.Drawing.Point(328, 191);
            this.txtMon.MaxLength = 32767;
            this.txtMon.Name = "txtMon";
            this.txtMon.PasswordChar = '\0';
            this.txtMon.PromptText = "Tên môn học....";
            this.txtMon.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMon.SelectedText = "";
            this.txtMon.SelectionLength = 0;
            this.txtMon.SelectionStart = 0;
            this.txtMon.ShortcutsEnabled = true;
            this.txtMon.Size = new System.Drawing.Size(128, 23);
            this.txtMon.TabIndex = 8;
            this.txtMon.UseSelectable = true;
            this.txtMon.WaterMark = "Tên môn học....";
            this.txtMon.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMon.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox4
            // 
            // 
            // 
            // 
            this.metroTextBox4.CustomButton.Image = null;
            this.metroTextBox4.CustomButton.Location = new System.Drawing.Point(614, 2);
            this.metroTextBox4.CustomButton.Name = "";
            this.metroTextBox4.CustomButton.Size = new System.Drawing.Size(85, 85);
            this.metroTextBox4.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox4.CustomButton.TabIndex = 1;
            this.metroTextBox4.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox4.CustomButton.UseSelectable = true;
            this.metroTextBox4.CustomButton.Visible = false;
            this.metroTextBox4.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTextBox4.Lines = new string[0];
            this.metroTextBox4.Location = new System.Drawing.Point(0, 271);
            this.metroTextBox4.MaxLength = 32767;
            this.metroTextBox4.Name = "metroTextBox4";
            this.metroTextBox4.PasswordChar = '\0';
            this.metroTextBox4.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox4.SelectedText = "";
            this.metroTextBox4.SelectionLength = 0;
            this.metroTextBox4.SelectionStart = 0;
            this.metroTextBox4.ShortcutsEnabled = true;
            this.metroTextBox4.Size = new System.Drawing.Size(702, 90);
            this.metroTextBox4.TabIndex = 9;
            this.metroTextBox4.UseSelectable = true;
            this.metroTextBox4.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox4.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(61, 249);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(112, 19);
            this.metroLabel5.TabIndex = 7;
            this.metroLabel5.Text = "Thông Tin Mô Tả:";
            // 
            // mtLuu
            // 
            this.mtLuu.ActiveControl = null;
            this.mtLuu.Location = new System.Drawing.Point(614, 367);
            this.mtLuu.Name = "mtLuu";
            this.mtLuu.Size = new System.Drawing.Size(88, 34);
            this.mtLuu.TabIndex = 10;
            this.mtLuu.Text = "Lưu";
            this.mtLuu.UseSelectable = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(475, 50);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(96, 19);
            this.metroLabel6.TabIndex = 7;
            this.metroLabel6.Text = "Ngày Kết Thúc:";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(247, 78);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(75, 19);
            this.metroLabel7.TabIndex = 7;
            this.metroLabel7.Text = "Giảng Viên:";
            this.metroLabel7.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // cboGiangvien
            // 
            this.cboGiangvien.FormattingEnabled = true;
            this.cboGiangvien.ItemHeight = 23;
            this.cboGiangvien.Location = new System.Drawing.Point(329, 75);
            this.cboGiangvien.Name = "cboGiangvien";
            this.cboGiangvien.Size = new System.Drawing.Size(127, 29);
            this.cboGiangvien.TabIndex = 11;
            this.cboGiangvien.UseSelectable = true;
            // 
            // ucViewlich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cboGiangvien);
            this.Controls.Add(this.mtLuu);
            this.Controls.Add(this.metroTextBox4);
            this.Controls.Add(this.txtMon);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtLop);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.txtPhong);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.monthCalendar2);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.mlBack);
            this.Name = "ucViewlich";
            this.Size = new System.Drawing.Size(702, 404);
            this.Load += new System.EventHandler(this.ucViewlich_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLink mlBack;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtPhong;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtLop;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtMon;
        private MetroFramework.Controls.MetroTextBox metroTextBox4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTile mtLuu;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroComboBox cboGiangvien;
    }
}
