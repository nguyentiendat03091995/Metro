﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoMetroUI.userControl.lich
{
    public partial class ucLichcanhan : MetroFramework.Controls.MetroUserControl
    {
        public ucLichcanhan()
        {
            InitializeComponent();
        }

        private void ucLichcanhan_Load(object sender, EventArgs e)
        {

        }

        private void mlBack_Click(object sender, EventArgs e)
        {
            ucDashboard uc = new ucDashboard();
            frMain.Instance.MetroContainer.Controls.Add(uc);
            frMain.Instance.MetroContainer.Controls["ucDashboard"].BringToFront();
        }
    }
}
