using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoMetroUI.userControl.lich.add
{
    public partial class ucThemlich : MetroFramework.Controls.MetroUserControl
    {
        public ucThemlich()
        {
            InitializeComponent();
        }

        private void ucViewlich_Load(object sender, EventArgs e)
        {
            
            
        }

        private void mlBack_Click(object sender, EventArgs e)
        {
            ucThem uc = new ucThem();
            frMain.Instance.MetroContainer.Controls.Add(uc);
            frMain.Instance.MetroContainer.Controls["ucThem"].BringToFront();
        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
