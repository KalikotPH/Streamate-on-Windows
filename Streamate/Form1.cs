using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Streamate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            notifyIcon1.Visible = false;
            this.ShowInTaskbar = true;
            WindowState = FormWindowState.Normal;
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            bool mousePointerNotOnTaskbar = Screen.GetWorkingArea(this).Contains(Cursor.Position);
            if( this.WindowState == FormWindowState.Minimized && mousePointerNotOnTaskbar)
            {
                notifyIcon1.Icon = SystemIcons.Application;
                //notifyIcon1.Icon = ;
                notifyIcon1.BalloonTipClicked += new System.EventHandler(NotifyIcon1_Click);
                notifyIcon1.BalloonTipTitle = "Streamate";
                notifyIcon1.BalloonTipText = "Im just here!";
                notifyIcon1.ShowBalloonTip(1000);
                this.ShowInTaskbar = false;
                notifyIcon1.Visible = true;
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void NotifyIcon1_Click(object sender, System.EventArgs e)
        {
            notifyIcon1.Visible = false;
            this.ShowInTaskbar = true;
            WindowState = FormWindowState.Normal;
        }
    }
}
