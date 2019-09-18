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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (!this.ShowInTaskbar)
            {
                //notifyIcon1.Visible = false;
                this.ShowInTaskbar = true;
                WindowState = FormWindowState.Normal;
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            bool mousePointerNotOnTaskbar = Screen.GetWorkingArea(this).Contains(Cursor.Position);
            if( this.WindowState == FormWindowState.Minimized && mousePointerNotOnTaskbar)
            {
                notifyIcon1.BalloonTipClicked += new System.EventHandler(notifyIcon2_DoubleClick);
                notifyIcon1.ShowBalloonTip(1000);
                this.ShowInTaskbar = false;
                //Streamate.Visible = true;
            }
        }

        private void notifyIcon2_DoubleClick(object sender, EventArgs e)
        {
            //Yes: Called when ballon is clicked!
            //Bug: Called when right click system tray icon.
        }



        private void facebookToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://facebook.com/BytesCrafterPH");
        }

        private void youTubeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://youtube.com/channel/UCtszwIubJejX-nndEBE-rhw");
        }

        private void websiteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://bytes-crafter.com");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void contextMenuStrip1_Closed(object sender, ToolStripDropDownClosedEventArgs e)
        {
            streamateToolStripMenuItem_Click(this, null);
        }

        private void streamateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                //Instead of exiting when close button on form is clicked!
            }
        }
    }
}
