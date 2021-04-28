namespace Streamate
{
    partial class Menu
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.streamateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facebookToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.youTubeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.websiteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facebookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.youTubeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.websiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.urlLists = new System.Windows.Forms.RichTextBox();
            this.intervals = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "If you need me, you can find me here on your system tray.";
            this.notifyIcon1.BalloonTipTitle = "Streamate";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Streamate";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.streamateToolStripMenuItem,
            this.optionToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(134, 98);
            this.contextMenuStrip1.Closed += new System.Windows.Forms.ToolStripDropDownClosedEventHandler(this.contextMenuStrip1_Closed);
            // 
            // streamateToolStripMenuItem
            // 
            this.streamateToolStripMenuItem.Enabled = false;
            this.streamateToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.streamateToolStripMenuItem.Name = "streamateToolStripMenuItem";
            this.streamateToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.streamateToolStripMenuItem.Text = "Streamate";
            this.streamateToolStripMenuItem.ToolTipText = "Thank You!";
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.optionToolStripMenuItem.Text = "Option";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facebookToolStripMenuItem1,
            this.youTubeToolStripMenuItem1,
            this.websiteToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // facebookToolStripMenuItem1
            // 
            this.facebookToolStripMenuItem1.Name = "facebookToolStripMenuItem1";
            this.facebookToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.facebookToolStripMenuItem1.Text = "Facebook";
            this.facebookToolStripMenuItem1.Click += new System.EventHandler(this.facebookToolStripMenuItem1_Click);
            // 
            // youTubeToolStripMenuItem1
            // 
            this.youTubeToolStripMenuItem1.Name = "youTubeToolStripMenuItem1";
            this.youTubeToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.youTubeToolStripMenuItem1.Text = "YouTube";
            this.youTubeToolStripMenuItem1.Click += new System.EventHandler(this.youTubeToolStripMenuItem1_Click);
            // 
            // websiteToolStripMenuItem1
            // 
            this.websiteToolStripMenuItem1.Name = "websiteToolStripMenuItem1";
            this.websiteToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.websiteToolStripMenuItem1.Text = "Website";
            this.websiteToolStripMenuItem1.Click += new System.EventHandler(this.websiteToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(130, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // facebookToolStripMenuItem
            // 
            this.facebookToolStripMenuItem.Name = "facebookToolStripMenuItem";
            this.facebookToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // youTubeToolStripMenuItem
            // 
            this.youTubeToolStripMenuItem.Name = "youTubeToolStripMenuItem";
            this.youTubeToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // websiteToolStripMenuItem
            // 
            this.websiteToolStripMenuItem.Name = "websiteToolStripMenuItem";
            this.websiteToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(12, 12);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(91, 28);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Online";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // urlLists
            // 
            this.urlLists.Location = new System.Drawing.Point(243, 12);
            this.urlLists.Name = "urlLists";
            this.urlLists.Size = new System.Drawing.Size(278, 360);
            this.urlLists.TabIndex = 2;
            this.urlLists.Text = "sadsad";
            // 
            // intervals
            // 
            this.intervals.Location = new System.Drawing.Point(62, 169);
            this.intervals.Name = "intervals";
            this.intervals.Size = new System.Drawing.Size(100, 20);
            this.intervals.TabIndex = 3;
            this.intervals.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(59, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Seconds";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(533, 384);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.intervals);
            this.Controls.Add(this.urlLists);
            this.Controls.Add(this.checkBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cron App by BytesCrafter";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facebookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem youTubeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem websiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facebookToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem youTubeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem websiteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem streamateToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RichTextBox urlLists;
        private System.Windows.Forms.TextBox intervals;
        private System.Windows.Forms.Label label1;
    }
}

