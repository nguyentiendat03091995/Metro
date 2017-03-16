using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DemoMetroUI;

namespace DemoMetroUI.userControl.giangVien
{
    public partial class ucCreategv : MetroFramework.Controls.MetroUserControl
    {
        public ucCreategv()
        {
            InitializeComponent();
        }

        private void ucCreategv_Load(object sender, EventArgs e)
        {

        }

        private void mlBack_Click(object sender, EventArgs e)
        {
            ucThem uc = new ucThem();
            frMain.Instance.MetroContainer.Controls.Add(uc);
            frMain.Instance.MetroContainer.Controls["ucThem"].BringToFront();
        }
    }
}
