﻿namespace DemoMetroUI.userControl.nganh
{
    partial class ucNganh
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
            this.txtCode = new MetroFramework.Controls.MetroTextBox();
            this.txtTenkhoa = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mtLuu = new MetroFramework.Controls.MetroTile();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // mlBack
            // 
            this.mlBack.Image = global::DemoMetroUI.Properties.Resources._1489502099_Previous_2;
            this.mlBack.ImageSize = 32;
            this.mlBack.Location = new System.Drawing.Point(0, 0);
            this.mlBack.Name = "mlBack";
            this.mlBack.Size = new System.Drawing.Size(75, 39);
            this.mlBack.TabIndex = 81;
            this.mlBack.UseSelectable = true;
            this.mlBack.Click += new System.EventHandler(this.mlBack_Click);
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
            this.txtCode.Location = new System.Drawing.Point(297, 137);
            this.txtCode.MaxLength = 32767;
            this.txtCode.Name = "txtCode";
            this.txtCode.PasswordChar = '\0';
            this.txtCode.PromptText = "Mã ngành (bỏ trống sẽ tự sinh)";
            this.txtCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCode.SelectedText = "";
            this.txtCode.SelectionLength = 0;
            this.txtCode.SelectionStart = 0;
            this.txtCode.ShortcutsEnabled = true;
            this.txtCode.Size = new System.Drawing.Size(197, 23);
            this.txtCode.TabIndex = 79;
            this.txtCode.UseSelectable = true;
            this.txtCode.WaterMark = "Mã ngành (bỏ trống sẽ tự sinh)";
            this.txtCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtTenkhoa
            // 
            // 
            // 
            // 
            this.txtTenkhoa.CustomButton.Image = null;
            this.txtTenkhoa.CustomButton.Location = new System.Drawing.Point(175, 1);
            this.txtTenkhoa.CustomButton.Name = "";
            this.txtTenkhoa.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTenkhoa.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTenkhoa.CustomButton.TabIndex = 1;
            this.txtTenkhoa.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTenkhoa.CustomButton.UseSelectable = true;
            this.txtTenkhoa.CustomButton.Visible = false;
            this.txtTenkhoa.Lines = new string[0];
            this.txtTenkhoa.Location = new System.Drawing.Point(297, 92);
            this.txtTenkhoa.MaxLength = 32767;
            this.txtTenkhoa.Name = "txtTenkhoa";
            this.txtTenkhoa.PasswordChar = '\0';
            this.txtTenkhoa.PromptText = "Tên ngành...";
            this.txtTenkhoa.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTenkhoa.SelectedText = "";
            this.txtTenkhoa.SelectionLength = 0;
            this.txtTenkhoa.SelectionStart = 0;
            this.txtTenkhoa.ShortcutsEnabled = true;
            this.txtTenkhoa.Size = new System.Drawing.Size(197, 23);
            this.txtTenkhoa.TabIndex = 80;
            this.txtTenkhoa.UseSelectable = true;
            this.txtTenkhoa.WaterMark = "Tên ngành...";
            this.txtTenkhoa.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTenkhoa.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(200, 137);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(74, 19);
            this.metroLabel3.TabIndex = 77;
            this.metroLabel3.Text = "Mã Ngành:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(200, 92);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(74, 19);
            this.metroLabel2.TabIndex = 78;
            this.metroLabel2.Text = "Tên Ngành:";
            // 
            // mtLuu
            // 
            this.mtLuu.ActiveControl = null;
            this.mtLuu.Location = new System.Drawing.Point(484, 318);
            this.mtLuu.Name = "mtLuu";
            this.mtLuu.Size = new System.Drawing.Size(215, 83);
            this.mtLuu.TabIndex = 76;
            this.mtLuu.Text = "Lưu";
            this.mtLuu.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(275, 18);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(112, 19);
            this.metroLabel1.TabIndex = 75;
            this.metroLabel1.Text = "Thêm Mới Ngành";
            // 
            // ucNganh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mlBack);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.txtTenkhoa);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.mtLuu);
            this.Controls.Add(this.metroLabel1);
            this.Name = "ucNganh";
            this.Size = new System.Drawing.Size(702, 404);
            this.Load += new System.EventHandler(this.ucNganh_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLink mlBack;
        private MetroFramework.Controls.MetroTextBox txtCode;
        private MetroFramework.Controls.MetroTextBox txtTenkhoa;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTile mtLuu;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}
