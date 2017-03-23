namespace DemoMetroUI.userControl.monHoc
{
    partial class ucCreatemh
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mlBack = new MetroFramework.Controls.MetroLink();
            this.mtLuu = new MetroFramework.Controls.MetroTile();
            this.txtYeucau = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtCode = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtTenmh = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtDes = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(283, 21);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(127, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Thêm Mới Môn Học";
            // 
            // mlBack
            // 
            this.mlBack.Image = global::DemoMetroUI.Properties.Resources._1489502099_Previous_2;
            this.mlBack.ImageSize = 32;
            this.mlBack.Location = new System.Drawing.Point(0, 0);
            this.mlBack.Name = "mlBack";
            this.mlBack.Size = new System.Drawing.Size(75, 39);
            this.mlBack.TabIndex = 3;
            this.mlBack.UseSelectable = true;
            this.mlBack.Click += new System.EventHandler(this.mlBack_Click);
            // 
            // mtLuu
            // 
            this.mtLuu.ActiveControl = null;
            this.mtLuu.Location = new System.Drawing.Point(484, 318);
            this.mtLuu.Name = "mtLuu";
            this.mtLuu.Size = new System.Drawing.Size(215, 83);
            this.mtLuu.TabIndex = 18;
            this.mtLuu.Text = "Lưu";
            this.mtLuu.UseSelectable = true;
            // 
            // txtYeucau
            // 
            // 
            // 
            // 
            this.txtYeucau.CustomButton.Image = null;
            this.txtYeucau.CustomButton.Location = new System.Drawing.Point(175, 1);
            this.txtYeucau.CustomButton.Name = "";
            this.txtYeucau.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtYeucau.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtYeucau.CustomButton.TabIndex = 1;
            this.txtYeucau.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtYeucau.CustomButton.UseSelectable = true;
            this.txtYeucau.CustomButton.Visible = false;
            this.txtYeucau.Lines = new string[0];
            this.txtYeucau.Location = new System.Drawing.Point(305, 235);
            this.txtYeucau.MaxLength = 32767;
            this.txtYeucau.Name = "txtYeucau";
            this.txtYeucau.PasswordChar = '\0';
            this.txtYeucau.PromptText = "Yêu cầu môn học....";
            this.txtYeucau.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtYeucau.SelectedText = "";
            this.txtYeucau.SelectionLength = 0;
            this.txtYeucau.SelectionStart = 0;
            this.txtYeucau.ShortcutsEnabled = true;
            this.txtYeucau.Size = new System.Drawing.Size(197, 23);
            this.txtYeucau.TabIndex = 27;
            this.txtYeucau.UseSelectable = true;
            this.txtYeucau.WaterMark = "Yêu cầu môn học....";
            this.txtYeucau.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtYeucau.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(208, 235);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(61, 19);
            this.metroLabel5.TabIndex = 21;
            this.metroLabel5.Text = "Yêu Cầu:";
            // 
            // txtCode
            // 
            // 
            // 
            // 
            this.txtCode.CustomButton.Image = null;
            this.txtCode.CustomButton.Location = new System.Drawing.Point(175, 1);
            this.txtCode.CustomButton.Name = "";
            this.txtCode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCode.CustomButton.TabIndex = 1;
            this.txtCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCode.CustomButton.UseSelectable = true;
            this.txtCode.CustomButton.Visible = false;
            this.txtCode.Lines = new string[0];
            this.txtCode.Location = new System.Drawing.Point(305, 140);
            this.txtCode.MaxLength = 32767;
            this.txtCode.Name = "txtCode";
            this.txtCode.PasswordChar = '\0';
            this.txtCode.PromptText = "Mã môn học (bỏ trống sẽ tự sinh)";
            this.txtCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCode.SelectedText = "";
            this.txtCode.SelectionLength = 0;
            this.txtCode.SelectionStart = 0;
            this.txtCode.ShortcutsEnabled = true;
            this.txtCode.Size = new System.Drawing.Size(197, 23);
            this.txtCode.TabIndex = 28;
            this.txtCode.UseSelectable = true;
            this.txtCode.WaterMark = "Mã môn học (bỏ trống sẽ tự sinh)";
            this.txtCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(208, 186);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(77, 19);
            this.metroLabel4.TabIndex = 22;
            this.metroLabel4.Text = "Description:";
            // 
            // txtTenmh
            // 
            // 
            // 
            // 
            this.txtTenmh.CustomButton.Image = null;
            this.txtTenmh.CustomButton.Location = new System.Drawing.Point(175, 1);
            this.txtTenmh.CustomButton.Name = "";
            this.txtTenmh.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTenmh.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTenmh.CustomButton.TabIndex = 1;
            this.txtTenmh.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTenmh.CustomButton.UseSelectable = true;
            this.txtTenmh.CustomButton.Visible = false;
            this.txtTenmh.Lines = new string[0];
            this.txtTenmh.Location = new System.Drawing.Point(305, 95);
            this.txtTenmh.MaxLength = 32767;
            this.txtTenmh.Name = "txtTenmh";
            this.txtTenmh.PasswordChar = '\0';
            this.txtTenmh.PromptText = "Tên môn học...";
            this.txtTenmh.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTenmh.SelectedText = "";
            this.txtTenmh.SelectionLength = 0;
            this.txtTenmh.SelectionStart = 0;
            this.txtTenmh.ShortcutsEnabled = true;
            this.txtTenmh.Size = new System.Drawing.Size(197, 23);
            this.txtTenmh.TabIndex = 29;
            this.txtTenmh.UseSelectable = true;
            this.txtTenmh.WaterMark = "Tên môn học...";
            this.txtTenmh.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTenmh.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(208, 140);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(89, 19);
            this.metroLabel3.TabIndex = 23;
            this.metroLabel3.Text = "Mã Môn Học:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(208, 95);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(89, 19);
            this.metroLabel2.TabIndex = 24;
            this.metroLabel2.Text = "Tên Môn Học:";
            // 
            // txtDes
            // 
            // 
            // 
            // 
            this.txtDes.CustomButton.Image = null;
            this.txtDes.CustomButton.Location = new System.Drawing.Point(175, 1);
            this.txtDes.CustomButton.Name = "";
            this.txtDes.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDes.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDes.CustomButton.TabIndex = 1;
            this.txtDes.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDes.CustomButton.UseSelectable = true;
            this.txtDes.CustomButton.Visible = false;
            this.txtDes.Lines = new string[0];
            this.txtDes.Location = new System.Drawing.Point(305, 186);
            this.txtDes.MaxLength = 32767;
            this.txtDes.Name = "txtDes";
            this.txtDes.PasswordChar = '\0';
            this.txtDes.PromptText = "Mô tả...";
            this.txtDes.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDes.SelectedText = "";
            this.txtDes.SelectionLength = 0;
            this.txtDes.SelectionStart = 0;
            this.txtDes.ShortcutsEnabled = true;
            this.txtDes.Size = new System.Drawing.Size(197, 23);
            this.txtDes.TabIndex = 27;
            this.txtDes.UseSelectable = true;
            this.txtDes.WaterMark = "Mô tả...";
            this.txtDes.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDes.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ucCreatemh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtDes);
            this.Controls.Add(this.txtYeucau);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtTenmh);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.mtLuu);
            this.Controls.Add(this.mlBack);
            this.Controls.Add(this.metroLabel1);
            this.Name = "ucCreatemh";
            this.Size = new System.Drawing.Size(702, 404);
            this.Load += new System.EventHandler(this.ucCreatemh_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLink mlBack;
        private MetroFramework.Controls.MetroTile mtLuu;
        private MetroFramework.Controls.MetroTextBox txtYeucau;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtCode;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtTenmh;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtDes;
    }
}
