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
            this.trackBarVolume = new trackbartest02.PlayerTrackBar();
            this.playerTrackBar1 = new trackbartest02.PlayerTrackBar();
            this.picVolume = new System.Windows.Forms.PictureBox();
            this.picBefore = new System.Windows.Forms.PictureBox();
            this.picSonglist = new System.Windows.Forms.PictureBox();
            this.lblShowTime = new System.Windows.Forms.Label();
            this.lblCurtime = new System.Windows.Forms.Label();
            this.picNextmusic = new System.Windows.Forms.PictureBox();
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
            this.butOffline = new System.Windows.Forms.Button();
            this.butOnline = new System.Windows.Forms.Button();
            this.lblsonglistid = new System.Windows.Forms.Label();
            this.txtSongid = new System.Windows.Forms.TextBox();
            this.pnlControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPlaymode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVolume)).BeginInit();
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
            this.pnlControl.Controls.Add(this.trackBarVolume);
            this.pnlControl.Controls.Add(this.playerTrackBar1);
            this.pnlControl.Controls.Add(this.picVolume);
            this.pnlControl.Controls.Add(this.picBefore);
            this.pnlControl.Controls.Add(this.picSonglist);
            this.pnlControl.Controls.Add(this.lblShowTime);
            this.pnlControl.Controls.Add(this.lblCurtime);
            this.pnlControl.Controls.Add(this.picNextmusic);
            this.pnlControl.Controls.Add(this.picPlay);
            this.pnlControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlControl.Location = new System.Drawing.Point(0, 531);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(960, 69);
            this.pnlControl.TabIndex = 0;
            this.pnlControl.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // picPlaymode
            // 
            this.picPlaymode.BackColor = System.Drawing.Color.Transparent;
            this.picPlaymode.BackgroundImage = global::KuWoMusic.Properties.Resources.repeat;
            this.picPlaymode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPlaymode.Location = new System.Drawing.Point(891, 22);
            this.picPlaymode.Name = "picPlaymode";
            this.picPlaymode.Size = new System.Drawing.Size(30, 30);
            this.picPlaymode.TabIndex = 8;
            this.picPlaymode.TabStop = false;
            this.picPlaymode.Click += new System.EventHandler(this.picPlaymode_Click);
            // 
            // trackBarVolume
            // 
            this.trackBarVolume.BackColor = System.Drawing.Color.White;
            this.trackBarVolume.EmptyColor = System.Drawing.Color.LightGray;
            this.trackBarVolume.FillColor = System.Drawing.Color.Red;
            this.trackBarVolume.Location = new System.Drawing.Point(681, 26);
            this.trackBarVolume.MaxValue = 100;
            this.trackBarVolume.MinValue = 0;
            this.trackBarVolume.Name = "trackBarVolume";
            this.trackBarVolume.Shape = trackbartest02.PlayerTrackBar.TrackShape.Circle;
            this.trackBarVolume.Size = new System.Drawing.Size(208, 23);
            this.trackBarVolume.TabIndex = 4;
            this.trackBarVolume.Text = "playerTrackBar2";
            this.trackBarVolume.Value = 0;
            this.trackBarVolume.Scroll += new System.EventHandler(this.trackBarVolume_Scroll);
            this.trackBarVolume.MouseDown += new System.Windows.Forms.MouseEventHandler(this.trackBarVolume_MouseDown);
            this.trackBarVolume.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBarVolume_MouseUp);
            // 
            // playerTrackBar1
            // 
            this.playerTrackBar1.BackColor = System.Drawing.Color.White;
            this.playerTrackBar1.EmptyColor = System.Drawing.Color.LightGray;
            this.playerTrackBar1.FillColor = System.Drawing.Color.Red;
            this.playerTrackBar1.Location = new System.Drawing.Point(240, 26);
            this.playerTrackBar1.MaxValue = 100;
            this.playerTrackBar1.MinValue = 0;
            this.playerTrackBar1.Name = "playerTrackBar1";
            this.playerTrackBar1.Shape = trackbartest02.PlayerTrackBar.TrackShape.Circle;
            this.playerTrackBar1.Size = new System.Drawing.Size(329, 23);
            this.playerTrackBar1.TabIndex = 4;
            this.playerTrackBar1.Text = "playerTrackBar1";
            this.playerTrackBar1.Value = 0;
            this.playerTrackBar1.Scroll += new System.EventHandler(this.playerTrackBar1_Scroll);
            this.playerTrackBar1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.playerTrackBar1_MouseClick);
            this.playerTrackBar1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.playerTrackBar1_MouseDown);
            this.playerTrackBar1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.playerTrackBar1_MouseUp);
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
            this.picSonglist.Location = new System.Drawing.Point(927, 22);
            this.picSonglist.Name = "picSonglist";
            this.picSonglist.Size = new System.Drawing.Size(30, 30);
            this.picSonglist.TabIndex = 4;
            this.picSonglist.TabStop = false;
            this.picSonglist.Click += new System.EventHandler(this.picSonglist_Click);
            // 
            // lblShowTime
            // 
            this.lblShowTime.BackColor = System.Drawing.Color.Transparent;
            this.lblShowTime.Font = new System.Drawing.Font("宋体", 12F);
            this.lblShowTime.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblShowTime.Location = new System.Drawing.Point(575, 26);
            this.lblShowTime.Name = "lblShowTime";
            this.lblShowTime.Size = new System.Drawing.Size(64, 23);
            this.lblShowTime.TabIndex = 1;
            this.lblShowTime.Text = "00:00";
            this.lblShowTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblShowTime.Click += new System.EventHandler(this.lblShowTime_Click);
            // 
            // lblCurtime
            // 
            this.lblCurtime.BackColor = System.Drawing.Color.Transparent;
            this.lblCurtime.Font = new System.Drawing.Font("宋体", 12F);
            this.lblCurtime.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCurtime.Location = new System.Drawing.Point(177, 29);
            this.lblCurtime.Name = "lblCurtime";
            this.lblCurtime.Size = new System.Drawing.Size(64, 23);
            this.lblCurtime.TabIndex = 1;
            this.lblCurtime.Text = "00:00";
            this.lblCurtime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCurtime.Click += new System.EventHandler(this.lblShowTime_Click);
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
            this.lstMusiclist.BackColor = System.Drawing.SystemColors.Control;
            this.lstMusiclist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstMusiclist.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lstMusiclist.ForeColor = System.Drawing.Color.Red;
            this.lstMusiclist.FormattingEnabled = true;
            this.lstMusiclist.ItemHeight = 24;
            this.lstMusiclist.Location = new System.Drawing.Point(716, 307);
            this.lstMusiclist.Name = "lstMusiclist";
            this.lstMusiclist.Size = new System.Drawing.Size(244, 240);
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
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(256, 61);
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
            this.picMini.Location = new System.Drawing.Point(893, 12);
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
            this.picClose.Location = new System.Drawing.Point(929, 12);
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
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(209, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // butOffline
            // 
            this.butOffline.BackColor = System.Drawing.SystemColors.Control;
            this.butOffline.Location = new System.Drawing.Point(716, 283);
            this.butOffline.Name = "butOffline";
            this.butOffline.Size = new System.Drawing.Size(123, 29);
            this.butOffline.TabIndex = 4;
            this.butOffline.Text = "本地歌曲";
            this.butOffline.UseVisualStyleBackColor = false;
            this.butOffline.Visible = false;
            this.butOffline.Click += new System.EventHandler(this.butOffline_Click);
            // 
            // butOnline
            // 
            this.butOnline.BackColor = System.Drawing.SystemColors.Control;
            this.butOnline.Location = new System.Drawing.Point(839, 283);
            this.butOnline.Name = "butOnline";
            this.butOnline.Size = new System.Drawing.Size(123, 29);
            this.butOnline.TabIndex = 5;
            this.butOnline.Text = "在线听歌";
            this.butOnline.UseVisualStyleBackColor = false;
            this.butOnline.Visible = false;
            this.butOnline.Click += new System.EventHandler(this.butOnline_Click);
            // 
            // lblsonglistid
            // 
            this.lblsonglistid.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblsonglistid.Location = new System.Drawing.Point(713, 261);
            this.lblsonglistid.Name = "lblsonglistid";
            this.lblsonglistid.Size = new System.Drawing.Size(126, 23);
            this.lblsonglistid.TabIndex = 6;
            this.lblsonglistid.Text = "网易云音乐歌单:";
            this.lblsonglistid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblsonglistid.Visible = false;
            // 
            // txtSongid
            // 
            this.txtSongid.Location = new System.Drawing.Point(839, 259);
            this.txtSongid.Name = "txtSongid";
            this.txtSongid.Size = new System.Drawing.Size(121, 25);
            this.txtSongid.TabIndex = 7;
            this.txtSongid.Text = "2455268231";
            this.txtSongid.Visible = false;
            // 
            // MusicPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::KuWoMusic.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(960, 600);
            this.Controls.Add(this.txtSongid);
            this.Controls.Add(this.lblsonglistid);
            this.Controls.Add(this.butOnline);
            this.Controls.Add(this.butOffline);
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
            ((System.ComponentModel.ISupportInitialize)(this.picPlaymode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBefore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSonglist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNextmusic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.cotMenustrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.PictureBox picVolume;
        private System.Windows.Forms.Timer timPlay;
        private System.Windows.Forms.PictureBox picPlaymode;
        private System.Windows.Forms.PictureBox picMini;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.NotifyIcon ntiIcon;
        private System.Windows.Forms.ContextMenuStrip cotMenustrip;
        private System.Windows.Forms.ToolStripMenuItem 打开播放器ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private trackbartest02.PlayerTrackBar playerTrackBar1;
        private trackbartest02.PlayerTrackBar trackBarVolume;
        private System.Windows.Forms.Label lblCurtime;
        private System.Windows.Forms.Button butOffline;
        private System.Windows.Forms.Button butOnline;
        private System.Windows.Forms.Label lblsonglistid;
        private System.Windows.Forms.TextBox txtSongid;
    }
}

