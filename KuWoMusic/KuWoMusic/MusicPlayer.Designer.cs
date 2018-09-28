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
            this.trkVolume = new System.Windows.Forms.TrackBar();
            this.picVolume = new System.Windows.Forms.PictureBox();
            this.trkLyrictime = new System.Windows.Forms.TrackBar();
            this.picBefore = new System.Windows.Forms.PictureBox();
            this.picSonglist = new System.Windows.Forms.PictureBox();
            this.picNextmusic = new System.Windows.Forms.PictureBox();
            this.lblShowTime = new System.Windows.Forms.Label();
            this.picPlay = new System.Windows.Forms.PictureBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.timProcess = new System.Windows.Forms.Timer(this.components);
            this.lstMusiclist = new System.Windows.Forms.ListBox();
            this.timLyric = new System.Windows.Forms.Timer(this.components);
            this.lblLyric = new System.Windows.Forms.Label();
            this.pnlControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkLyrictime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBefore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSonglist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNextmusic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlControl
            // 
            this.pnlControl.BackColor = System.Drawing.SystemColors.Control;
            this.pnlControl.Controls.Add(this.trkVolume);
            this.pnlControl.Controls.Add(this.picVolume);
            this.pnlControl.Controls.Add(this.trkLyrictime);
            this.pnlControl.Controls.Add(this.picBefore);
            this.pnlControl.Controls.Add(this.picSonglist);
            this.pnlControl.Controls.Add(this.picNextmusic);
            this.pnlControl.Controls.Add(this.lblShowTime);
            this.pnlControl.Controls.Add(this.picPlay);
            this.pnlControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlControl.Location = new System.Drawing.Point(0, 484);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(969, 69);
            this.pnlControl.TabIndex = 0;
            this.pnlControl.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // trkVolume
            // 
            this.trkVolume.Location = new System.Drawing.Point(715, 7);
            this.trkVolume.Maximum = 100;
            this.trkVolume.Name = "trkVolume";
            this.trkVolume.Size = new System.Drawing.Size(211, 56);
            this.trkVolume.TabIndex = 5;
            this.trkVolume.TickFrequency = 5;
            this.trkVolume.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // picVolume
            // 
            this.picVolume.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picVolume.BackgroundImage")));
            this.picVolume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picVolume.Location = new System.Drawing.Point(680, 16);
            this.picVolume.Name = "picVolume";
            this.picVolume.Size = new System.Drawing.Size(29, 32);
            this.picVolume.TabIndex = 7;
            this.picVolume.TabStop = false;
            this.picVolume.Click += new System.EventHandler(this.picVolume_Click);
            // 
            // trkLyrictime
            // 
            this.trkLyrictime.Location = new System.Drawing.Point(207, 13);
            this.trkLyrictime.Maximum = 100;
            this.trkLyrictime.Name = "trkLyrictime";
            this.trkLyrictime.Size = new System.Drawing.Size(329, 56);
            this.trkLyrictime.TabIndex = 6;
            this.trkLyrictime.Scroll += new System.EventHandler(this.trkLyrictime_Scroll);
            // 
            // picBefore
            // 
            this.picBefore.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBefore.BackgroundImage")));
            this.picBefore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBefore.Location = new System.Drawing.Point(12, 16);
            this.picBefore.Name = "picBefore";
            this.picBefore.Size = new System.Drawing.Size(56, 50);
            this.picBefore.TabIndex = 5;
            this.picBefore.TabStop = false;
            this.picBefore.Click += new System.EventHandler(this.picBefore_Click);
            // 
            // picSonglist
            // 
            this.picSonglist.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picSonglist.BackgroundImage")));
            this.picSonglist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picSonglist.Location = new System.Drawing.Point(932, 16);
            this.picSonglist.Name = "picSonglist";
            this.picSonglist.Size = new System.Drawing.Size(34, 32);
            this.picSonglist.TabIndex = 4;
            this.picSonglist.TabStop = false;
            this.picSonglist.Click += new System.EventHandler(this.picSonglist_Click);
            // 
            // picNextmusic
            // 
            this.picNextmusic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picNextmusic.BackgroundImage")));
            this.picNextmusic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picNextmusic.Location = new System.Drawing.Point(146, 16);
            this.picNextmusic.Name = "picNextmusic";
            this.picNextmusic.Size = new System.Drawing.Size(55, 50);
            this.picNextmusic.TabIndex = 3;
            this.picNextmusic.TabStop = false;
            this.picNextmusic.Click += new System.EventHandler(this.picNextmusic_Click);
            // 
            // lblShowTime
            // 
            this.lblShowTime.Font = new System.Drawing.Font("宋体", 12F);
            this.lblShowTime.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblShowTime.Location = new System.Drawing.Point(533, 25);
            this.lblShowTime.Name = "lblShowTime";
            this.lblShowTime.Size = new System.Drawing.Size(141, 23);
            this.lblShowTime.TabIndex = 1;
            this.lblShowTime.Text = "00:00/00:00";
            this.lblShowTime.Click += new System.EventHandler(this.lblShowTime_Click);
            // 
            // picPlay
            // 
            this.picPlay.BackColor = System.Drawing.Color.Transparent;
            this.picPlay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picPlay.BackgroundImage")));
            this.picPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picPlay.Location = new System.Drawing.Point(75, 7);
            this.picPlay.Name = "picPlay";
            this.picPlay.Size = new System.Drawing.Size(74, 59);
            this.picPlay.TabIndex = 0;
            this.picPlay.TabStop = false;
            this.picPlay.Click += new System.EventHandler(this.picPlay_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(537, 36);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(171, 99);
            this.axWindowsMediaPlayer1.TabIndex = 1;
            this.axWindowsMediaPlayer1.Visible = false;
            this.axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayer1_PlayStateChange);
            this.axWindowsMediaPlayer1.EndOfStream += new AxWMPLib._WMPOCXEvents_EndOfStreamEventHandler(this.axWindowsMediaPlayer1_EndOfStream);
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // timProcess
            // 
            this.timProcess.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lstMusiclist
            // 
            this.lstMusiclist.FormattingEnabled = true;
            this.lstMusiclist.ItemHeight = 15;
            this.lstMusiclist.Location = new System.Drawing.Point(767, 229);
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
            // lblLyric
            // 
            this.lblLyric.BackColor = System.Drawing.Color.Transparent;
            this.lblLyric.Font = new System.Drawing.Font("宋体", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLyric.ForeColor = System.Drawing.Color.Lime;
            this.lblLyric.Location = new System.Drawing.Point(85, 242);
            this.lblLyric.Name = "lblLyric";
            this.lblLyric.Size = new System.Drawing.Size(507, 43);
            this.lblLyric.TabIndex = 4;
            this.lblLyric.Text = "label1";
            this.lblLyric.Click += new System.EventHandler(this.lblLyric_Click);
            // 
            // MusicPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(969, 553);
            this.Controls.Add(this.lblLyric);
            this.Controls.Add(this.lstMusiclist);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.pnlControl);
            this.DoubleBuffered = true;
            this.Name = "MusicPlayer";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlControl.ResumeLayout(false);
            this.pnlControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkLyrictime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBefore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSonglist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNextmusic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
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
        private System.Windows.Forms.Label lblLyric;
        private System.Windows.Forms.TrackBar trkLyrictime;
        private System.Windows.Forms.TrackBar trkVolume;
        private System.Windows.Forms.PictureBox picVolume;
    }
}

