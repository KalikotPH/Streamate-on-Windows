using System;
using System.Windows.Forms;
using Quobject.SocketIoClientDotNet.Client;

namespace Streamate
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            ConnectToSocketIO();

            //MessageBox.Show("Streamate is on ACTIVE DEVELOPMENT!");
        }

        private void ConnectToSocketIO()
        {
            var socket = IO.Socket("http://localhost:8080");
            socket.On(Socket.EVENT_CONNECT, () =>
            {
                //checkBox1.Text = "ONLINE";
                //Console.WriteLine("Default 'Connect' event called!");

                //ConnectInfo conInfo = new ConnectInfo("input", "123");
                //string dataToServer = JsonConvert.SerializeObject(conInfo);
                //socket.Emit("session", dataToServer);
            });

            socket.On("welcome", (data) =>
            {
                Console.WriteLine("Welcome! Token: " + data.ToString() );
            });

            socket.On("play", (data) =>
            {
                Console.WriteLine("Welcome! Token: " + data.ToString());
            });

            socket.On(Socket.EVENT_RECONNECT, () =>
            {
                Console.WriteLine("Default 'Reconnect' event called!");
            });

            socket.On(Socket.EVENT_DISCONNECT, () =>
            {
                Console.WriteLine("Default 'Disconnect' event called!");
            });
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
