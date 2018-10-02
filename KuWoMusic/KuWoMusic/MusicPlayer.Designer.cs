namespace KuWoMusic
{
    partial class MusicPlayer
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicPlayer));
            this.pnlControl = new System.Windows.Forms.Panel();
            this.picPlaymode = new System.Windows.Forms.PictureBox();
            this.trkVolume = new System.Windows.Forms.TrackBar();
            this.picVolume = new System.Windows.Forms.PictureBox();
            this.trkLyrictime = new System.Windows.Forms.TrackBar();
            this.picBefore = new System.Windows.Forms.PictureBox();
            this.picSonglist = new System.Windows.Forms.PictureBox();
            this.picNextmusic = new System.Windows.Forms.PictureBox();
            this.lblShowTime = new System.Windows.Forms.Label();
            this.picPlay = new System.Windows.Forms.PictureBox();
            this.timProcess = new System.Windows.Forms.Timer(this.components);
            this.lstMusiclist = new System.Windows.Forms.ListBox();
            this.timLyric = new System.Windows.Forms.Timer(this.components);
            this.timPlay = new System.Windows.Forms.Timer(this.components);
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.picMini = new System.Windows.Forms.PictureBox();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.ntiIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.cotMenustrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.打开播放器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPlaymode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkLyrictime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBefore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSonglist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNextmusic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.cotMenustrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlControl
            // 
            this.pnlControl.BackColor = System.Drawing.SystemColors.Control;
            this.pnlControl.Controls.Add(this.picPlaymode);
            this.pnlControl.Controls.Add(this.trkVolume);
            this.pnlControl.Controls.Add(this.picVolume);
            this.pnlControl.Controls.Add(this.trkLyrictime);
            this.pnlControl.Controls.Add(this.picBefore);
            this.pnlControl.Controls.Add(this.picSonglist);
            this.pnlControl.Controls.Add(this.picNextmusic);
            this.pnlControl.Controls.Add(this.lblShowTime);
            this.pnlControl.Controls.Add(this.picPlay);
            this.pnlControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlControl.Location = new System.Drawing.Point(0, 513);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(969, 69);
            this.pnlControl.TabIndex = 0;
            this.pnlControl.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // picPlaymode
            // 
            this.picPlaymode.BackColor = System.Drawing.Color.Transparent;
            this.picPlaymode.BackgroundImage = global::KuWoMusic.Properties.Resources.repeat;
            this.picPlaymode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPlaymode.Location = new System.Drawing.Point(896, 22);
            this.picPlaymode.Name = "picPlaymode";
            this.picPlaymode.Size = new System.Drawing.Size(30, 30);
            this.picPlaymode.TabIndex = 8;
            this.picPlaymode.TabStop = false;
            this.picPlaymode.Click += new System.EventHandler(this.picPlaymode_Click);
            // 
            // trkVolume
            // 
            this.trkVolume.Location = new System.Drawing.Point(681, 13);
            this.trkVolume.Maximum = 100;
            this.trkVolume.Name = "trkVolume";
            this.trkVolume.Size = new System.Drawing.Size(211, 56);
            this.trkVolume.TabIndex = 5;
            this.trkVolume.TickFrequency = 5;
            this.trkVolume.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // picVolume
            // 
            this.picVolume.BackColor = System.Drawing.Color.Transparent;
            this.picVolume.BackgroundImage = global::KuWoMusic.Properties.Resources.volume;
            this.picVolume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picVolume.Location = new System.Drawing.Point(645, 22);
            this.picVolume.Name = "picVolume";
            this.picVolume.Size = new System.Drawing.Size(30, 30);
            this.picVolume.TabIndex = 7;
            this.picVolume.TabStop = false;
            this.picVolume.Click += new System.EventHandler(this.picVolume_Click);
            // 
            // trkLyrictime
            // 
            this.trkLyrictime.Location = new System.Drawing.Point(177, 13);
            this.trkLyrictime.Maximum = 100;
            this.trkLyrictime.Name = "trkLyrictime";
            this.trkLyrictime.Size = new System.Drawing.Size(329, 56);
            this.trkLyrictime.TabIndex = 6;
            this.trkLyrictime.Scroll += new System.EventHandler(this.trkLyrictime_Scroll);
            // 
            // picBefore
            // 
            this.picBefore.BackColor = System.Drawing.Color.Transparent;
            this.picBefore.BackgroundImage = global::KuWoMusic.Properties.Resources.previous;
            this.picBefore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBefore.Location = new System.Drawing.Point(3, 15);
            this.picBefore.Name = "picBefore";
            this.picBefore.Size = new System.Drawing.Size(45, 45);
            this.picBefore.TabIndex = 5;
            this.picBefore.TabStop = false;
            this.picBefore.Click += new System.EventHandler(this.picBefore_Click);
            // 
            // picSonglist
            // 
            this.picSonglist.BackColor = System.Drawing.Color.Transparent;
            this.picSonglist.BackgroundImage = global::KuWoMusic.Properties.Resources.menu;
            this.picSonglist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picSonglist.Location = new System.Drawing.Point(932, 22);
            this.picSonglist.Name = "picSonglist";
            this.picSonglist.Size = new System.Drawing.Size(30, 30);
            this.picSonglist.TabIndex = 4;
            this.picSonglist.TabStop = false;
            this.picSonglist.Click += new System.EventHandler(this.picSonglist_Click);
            // 
            // picNextmusic
            // 
            this.picNextmusic.BackColor = System.Drawing.Color.Transparent;
            this.picNextmusic.BackgroundImage = global::KuWoMusic.Properties.Resources.next;
            this.picNextmusic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picNextmusic.Location = new System.Drawing.Point(126, 15);
            this.picNextmusic.Name = "picNextmusic";
            this.picNextmusic.Size = new System.Drawing.Size(45, 45);
            this.picNextmusic.TabIndex = 3;
            this.picNextmusic.TabStop = false;
            this.picNextmusic.Click += new System.EventHandler(this.picNextmusic_Click);
            // 
            // lblShowTime
            // 
            this.lblShowTime.BackColor = System.Drawing.Color.Transparent;
            this.lblShowTime.Font = new System.Drawing.Font("宋体", 12F);
            this.lblShowTime.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblShowTime.Location = new System.Drawing.Point(498, 26);
            this.lblShowTime.Name = "lblShowTime";
            this.lblShowTime.Size = new System.Drawing.Size(141, 23);
            this.lblShowTime.TabIndex = 1;
            this.lblShowTime.Text = "00:00/00:00";
            this.lblShowTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblShowTime.Click += new System.EventHandler(this.lblShowTime_Click);
            // 
            // picPlay
            // 
            this.picPlay.BackColor = System.Drawing.Color.Transparent;
            this.picPlay.BackgroundImage = global::KuWoMusic.Properties.Resources.play_button;
            this.picPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPlay.Location = new System.Drawing.Point(62, 12);
            this.picPlay.Name = "picPlay";
            this.picPlay.Size = new System.Drawing.Size(50, 50);
            this.picPlay.TabIndex = 0;
            this.picPlay.TabStop = false;
            this.picPlay.Click += new System.EventHandler(this.picPlay_Click);
            // 
            // timProcess
            // 
            this.timProcess.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lstMusiclist
            // 
            this.lstMusiclist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lstMusiclist.ForeColor = System.Drawing.Color.Red;
            this.lstMusiclist.FormattingEnabled = true;
            this.lstMusiclist.ItemHeight = 15;
            this.lstMusiclist.Location = new System.Drawing.Point(767, 261);
            this.lstMusiclist.Name = "lstMusiclist";
            this.lstMusiclist.Size = new System.Drawing.Size(202, 259);
            this.lstMusiclist.TabIndex = 2;
            this.lstMusiclist.Visible = false;
            this.lstMusiclist.SelectedIndexChanged += new System.EventHandler(this.lstMusiclist_SelectedIndexChanged);
            this.lstMusiclist.DoubleClick += new System.EventHandler(this.lstMusiclist_DoubleClick);
            // 
            // timLyric
            // 
            this.timLyric.Tick += new System.EventHandler(this.timLyric_Tick);
            // 
            // timPlay
            // 
            this.timPlay.Tick += new System.EventHandler(this.timPlay_Tick);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(767, 133);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(171, 99);
            this.axWindowsMediaPlayer1.TabIndex = 1;
            this.axWindowsMediaPlayer1.Visible = false;
            this.axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayer1_PlayStateChange);
            this.axWindowsMediaPlayer1.EndOfStream += new AxWMPLib._WMPOCXEvents_EndOfStreamEventHandler(this.axWindowsMediaPlayer1_EndOfStream);
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // picMini
            // 
            this.picMini.BackColor = System.Drawing.Color.Transparent;
            this.picMini.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picMini.BackgroundImage")));
            this.picMini.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picMini.Location = new System.Drawing.Point(901, 12);
            this.picMini.Name = "picMini";
            this.picMini.Size = new System.Drawing.Size(25, 25);
            this.picMini.TabIndex = 3;
            this.picMini.TabStop = false;
            this.picMini.Click += new System.EventHandler(this.picMini_Click);
            this.picMini.MouseEnter += new System.EventHandler(this.picMini_MouseEnter);
            this.picMini.MouseLeave += new System.EventHandler(this.picMini_MouseLeave);
            // 
            // picClose
            // 
            this.picClose.BackColor = System.Drawing.Color.Transparent;
            this.picClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picClose.BackgroundImage")));
            this.picClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picClose.Location = new System.Drawing.Point(937, 12);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(25, 25);
            this.picClose.TabIndex = 3;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            this.picClose.MouseEnter += new System.EventHandler(this.picClose_MouseEnter);
            this.picClose.MouseLeave += new System.EventHandler(this.picClose_MouseLeave);
            // 
            // ntiIcon
            // 
            this.ntiIcon.ContextMenuStrip = this.cotMenustrip;
            this.ntiIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("ntiIcon.Icon")));
            this.ntiIcon.Text = "notifyIcon1";
            this.ntiIcon.Visible = true;
            this.ntiIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ntiIcon_MouseDoubleClick);
            // 
            // cotMenustrip
            // 
            this.cotMenustrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cotMenustrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开播放器ToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.cotMenustrip.Name = "cotMenustrip";
            this.cotMenustrip.Size = new System.Drawing.Size(210, 52);
            // 
            // 打开播放器ToolStripMenuItem
            // 
            this.打开播放器ToolStripMenuItem.Name = "打开播放器ToolStripMenuItem";
            this.打开播放器ToolStripMenuItem.Size = new System.Drawing.Size(209, 24);
            this.打开播放器ToolStripMenuItem.Text = "Open MusicPlayer";
            this.打开播放器ToolStripMenuItem.Click += new System.EventHandler(this.打开播放器ToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // MusicPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KuWoMusic.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(969, 582);
            this.Controls.Add(this.picClose);
            this.Controls.Add(this.picMini);
            this.Controls.Add(this.lstMusiclist);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.pnlControl);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "MusicPlayer";
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MusicPlayer_Paint);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MusicPlayer_KeyPress);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MusicPlayer_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MusicPlayer_MouseMove);
            this.Resize += new System.EventHandler(this.MusicPlayer_Resize);
            this.pnlControl.ResumeLayout(false);
            this.pnlControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPlaymode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkLyrictime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBefore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSonglist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNextmusic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.cotMenustrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.PictureBox picPlay;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Label lblShowTime;
        private System.Windows.Forms.Timer timProcess;
        private System.Windows.Forms.ListBox lstMusiclist;
        private System.Windows.Forms.PictureBox picNextmusic;
        private System.Windows.Forms.PictureBox picSonglist;
        private System.Windows.Forms.PictureBox picBefore;
        private System.Windows.Forms.Timer timLyric;
        private System.Windows.Forms.TrackBar trkLyrictime;
        private System.Windows.Forms.TrackBar trkVolume;
        private System.Windows.Forms.PictureBox picVolume;
        private System.Windows.Forms.Timer timPlay;
        private System.Windows.Forms.PictureBox picPlaymode;
        private System.Windows.Forms.PictureBox picMini;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.NotifyIcon ntiIcon;
        private System.Windows.Forms.ContextMenuStrip cotMenustrip;
        private System.Windows.Forms.ToolStripMenuItem 打开播放器ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

