using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoMetroUI
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        static Form1 _instance;
        public static Form1 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Form1();
                return _instance;
            }
        }

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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mlBack.Visible = false;
            _instance = this;
            //ucDashboard uc = new ucDashboard();
            //uc.Dock = DockStyle.Fill;
            
            
            //mPanel.Controls.Add(uc);
        }

        private void mlBack_Click(object sender, EventArgs e)
        {
            mPanel.Controls["ucDashboard"].BringToFront();
            mlBack.Visible = false;

        }
    }
}
