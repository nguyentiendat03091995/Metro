﻿namespace DemoMetroUI
{
    partial class ucThem
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
            this.mtThemgv = new MetroFramework.Controls.MetroTile();
            this.mtThemmh = new MetroFramework.Controls.MetroTile();
            this.mtThemlop = new MetroFramework.Controls.MetroTile();
            this.mtThemphong = new MetroFramework.Controls.MetroTile();
            this.mlBack = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // mtThemgv
            // 
            this.mtThemgv.ActiveControl = null;
            this.mtThemgv.Location = new System.Drawing.Point(43, 39);
            this.mtThemgv.Name = "mtThemgv";
            this.mtThemgv.Size = new System.Drawing.Size(214, 90);
            this.mtThemgv.TabIndex = 1;
            this.mtThemgv.Text = "Thêm Giảng Viên";
            this.mtThemgv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtThemgv.UseSelectable = true;
            this.mtThemgv.Click += new System.EventHandler(this.mtThemgv_Click);
            // 
            // mtThemmh
            // 
            this.mtThemmh.ActiveControl = null;
            this.mtThemmh.Location = new System.Drawing.Point(449, 279);
            this.mtThemmh.Name = "mtThemmh";
            this.mtThemmh.Size = new System.Drawing.Size(214, 90);
            this.mtThemmh.TabIndex = 1;
            this.mtThemmh.Text = "Thêm Môn Học";
            this.mtThemmh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtThemmh.UseSelectable = true;
            this.mtThemmh.Click += new System.EventHandler(this.mtThemmh_Click);
            // 
            // mtThemlop
            // 
            this.mtThemlop.ActiveControl = null;
            this.mtThemlop.Location = new System.Drawing.Point(449, 39);
            this.mtThemlop.Name = "mtThemlop";
            this.mtThemlop.Size = new System.Drawing.Size(214, 90);
            this.mtThemlop.TabIndex = 1;
            this.mtThemlop.Text = "Thêm Lớp";
            this.mtThemlop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtThemlop.UseSelectable = true;
            this.mtThemlop.Click += new System.EventHandler(this.mtThemlop_Click);
            // 
            // mtThemphong
            // 
            this.mtThemphong.ActiveControl = null;
            this.mtThemphong.Location = new System.Drawing.Point(43, 279);
            this.mtThemphong.Name = "mtThemphong";
            this.mtThemphong.Size = new System.Drawing.Size(214, 90);
            this.mtThemphong.TabIndex = 1;
            this.mtThemphong.Text = "Thêm Phòng";
            this.mtThemphong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtThemphong.UseSelectable = true;
            this.mtThemphong.Click += new System.EventHandler(this.mtThemphong_Click);
            // 
            // mlBack
            // 
            this.mlBack.Image = global::DemoMetroUI.Properties.Resources._1489502099_Previous_2;
            this.mlBack.ImageSize = 32;
            this.mlBack.Location = new System.Drawing.Point(0, 0);
            this.mlBack.Name = "mlBack";
            this.mlBack.Size = new System.Drawing.Size(75, 39);
            this.mlBack.TabIndex = 2;
            this.mlBack.UseSelectable = true;
            this.mlBack.Click += new System.EventHandler(this.mlBack_Click);
            // 
            // ucThem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mlBack);
            this.Controls.Add(this.mtThemphong);
            this.Controls.Add(this.mtThemlop);
            this.Controls.Add(this.mtThemmh);
            this.Controls.Add(this.mtThemgv);
            this.Name = "ucThem";
            this.Size = new System.Drawing.Size(702, 404);
            this.Load += new System.EventHandler(this.ucThem_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile mtThemgv;
        private MetroFramework.Controls.MetroTile mtThemmh;
        private MetroFramework.Controls.MetroTile mtThemlop;
        private MetroFramework.Controls.MetroTile mtThemphong;
        private MetroFramework.Controls.MetroLink mlBack;
    }
}