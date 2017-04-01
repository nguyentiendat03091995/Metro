namespace DemoMetroUI.userControl.search
{
    partial class ucSearch
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
            this.mtGv = new MetroFramework.Controls.MetroTile();
            this.mtHs = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(263, 9);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(77, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Tìm Kiếm ...";
            // 
            // mlBack
            // 
            this.mlBack.Image = global::DemoMetroUI.Properties.Resources._1489502099_Previous_2;
            this.mlBack.ImageSize = 32;
            this.mlBack.Location = new System.Drawing.Point(0, 0);
            this.mlBack.Name = "mlBack";
            this.mlBack.Size = new System.Drawing.Size(75, 39);
            this.mlBack.TabIndex = 8;
            this.mlBack.UseSelectable = true;
            this.mlBack.Click += new System.EventHandler(this.mlBack_Click);
            // 
            // mtGv
            // 
            this.mtGv.ActiveControl = null;
            this.mtGv.Location = new System.Drawing.Point(86, 156);
            this.mtGv.Name = "mtGv";
            this.mtGv.Size = new System.Drawing.Size(176, 89);
            this.mtGv.TabIndex = 9;
            this.mtGv.Text = "Giảng Viên";
            this.mtGv.UseSelectable = true;
            this.mtGv.Click += new System.EventHandler(this.mtGv_Click);
            // 
            // mtHs
            // 
            this.mtHs.ActiveControl = null;
            this.mtHs.Location = new System.Drawing.Point(452, 156);
            this.mtHs.Name = "mtHs";
            this.mtHs.Size = new System.Drawing.Size(176, 89);
            this.mtHs.TabIndex = 9;
            this.mtHs.Text = "Học Sinh";
            this.mtHs.UseSelectable = true;
            this.mtHs.Click += new System.EventHandler(this.mtHs_Click);
            // 
            // ucSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mtHs);
            this.Controls.Add(this.mtGv);
            this.Controls.Add(this.mlBack);
            this.Controls.Add(this.metroLabel1);
            this.Name = "ucSearch";
            this.Size = new System.Drawing.Size(702, 404);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLink mlBack;
        private MetroFramework.Controls.MetroTile mtGv;
        private MetroFramework.Controls.MetroTile mtHs;
    }
}
