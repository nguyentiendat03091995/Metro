using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DemoMetroUI.userControl;
using MetroFramework;
using MetroFramework.Forms;

namespace DemoMetroUI
{
    public partial class frMain : MetroFramework.Forms.MetroForm
    {
        static frMain _instance;
        public static frMain Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new frMain();
                return _instance;
            }
        }
        //ê sao rồi
        public MetroFramework.Controls.MetroPanel MetroContainer
        {
            get
            {
                return mPanel;
            }
            set { mPanel = value; }
        }
        public MetroFramework.Controls.MetroLink MetroBack
        {
            get { return mlBack; }
            set { mlBack = value; }
        }
        public frMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mlBack.Visible = false;
            _instance = this;
            //ucDashboard uc = new ucDashboard();
            //uc.Dock = DockStyle.Fill;

            ucDangnhap uc = new ucDangnhap();
            uc.Dock = DockStyle.Fill;
            mPanel.Controls.Add(uc);
        }

        private void mlBack_Click(object sender, EventArgs e)
        {

            //mlBack.Visible = true;
        }
    }
}
