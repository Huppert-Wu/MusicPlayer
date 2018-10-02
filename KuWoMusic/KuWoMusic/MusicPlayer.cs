using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;
using System.Timers;
using System.Threading;
using System.Drawing;

namespace KuWoMusic
{
    public partial class MusicPlayer : Form
    {
        public MusicPlayer()
        {
            InitializeComponent();
        }
        List<string> Songlists = new List<string>();//存储音乐文件的路径
        List<Label> Lablelists = new List<Label>();
        private Point mousepoint;//捕捉鼠标，移动form
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        LyricFIles lyricf;

        private void Form1_Load(object sender, EventArgs e)
        {
            //画画
            this.DoubleBuffered = true;
            this.Paint += new PaintEventHandler(Form1_Paint);

            //初始化歌曲列表
            DirectoryInfo dirinfo = new DirectoryInfo("./song/");
            FileInfo[] filelist = dirinfo.GetFiles();
            string filefullname;
            //新建播放列表
            //WMPLib.IWMPPlaylist playlist = axWindowsMediaPlayer1.playlistCollection.newPlaylist("musicplaylist");
            //WMPLib.IWMPMedia media;
            for (int i = 0; i < filelist.Length; i++)
            {
                if (!lstMusiclist.Items.Contains(Path.GetFileName(filelist[i].FullName)))
                {
                    filefullname = filelist[i].FullName;
                    lstMusiclist.Items.Add(Path.GetFileName(filefullname));
                    Songlists.Add(filefullname);

                    //media = axWindowsMediaPlayer1.newMedia(filefullname);
                    //playlist.appendItem(media);
                }
            }
            for (int i = 0; i < 7; i++)
            {
                Label label = new Label();
                label.Location = new Point(30, 55 + i * 45);
                label.Size = new Size(900, 50);
                label.BackColor = Color.Transparent;
                label.ForeColor = Color.White;
                label.Font = new Font("微软雅黑", 15);

                Lablelists.Add(label);
                this.Controls.Add(label);
            }
            //axWindowsMediaPlayer1.currentPlaylist = playlist;

            //默认播放列表第一首歌
            if (lstMusiclist.Items != null)
            {
                //初始化Songlist,使默认歌曲为index==0
                lstMusiclist.SelectedIndex = 0;
            }
            else
            {
                //error
                ;
            }
            //循环模式为列表循环
            playmode = 0;

            MusicPlay(Songlists[lstMusiclist.SelectedIndex]);

            isPlay = true;
            axWindowsMediaPlayer1.Ctlcontrols.stop();//等待播放
            picPlay.BackgroundImage = Properties.Resources.play_button;
            isPlay = false;
            //初始化track volume
            trkVolume.Value = axWindowsMediaPlayer1.settings.volume;
            //初始化，准备工作
            pnlControl.BackColor = Color.FromArgb(127, 200, 200, 200);
            //隐藏音量调节条
            isMute = false;
        }

        bool isPlay;
        private void picPlay_Click(object sender, EventArgs e)
        {

            //播放暂停
            isPlay = !isPlay;
            if (isPlay)
            {
                //播放歌曲
                axWindowsMediaPlayer1.Ctlcontrols.play();
                //MusicPlay(Songlists[lstMusiclist.SelectedIndex]);
                //播放歌词
                timLyric.Enabled = true;
                timProcess.Enabled = true;
                picPlay.BackgroundImage = Properties.Resources.pause;
            }
            else//暂停歌曲
            {
                axWindowsMediaPlayer1.Ctlcontrols.pause();
                timProcess.Enabled = false;
                timLyric.Enabled = false;
                //暂停播放歌词

                picPlay.BackgroundImage = Properties.Resources.play_button;
            }
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
        //歌曲已播放时长
        string timeLeft;
        private void timer1_Tick(object sender, EventArgs e)
        {

            TimePlay();
            TrackPlay();
        }
        private void lstMusiclist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void lstMusiclist_DoubleClick(object sender, EventArgs e)
        {
            MusicPlay(Songlists[lstMusiclist.SelectedIndex]);
        }
        //歌曲播放时元素控制

        //全局歌词文件类

        public void MusicPlay(string songpath)
        {
            //各计时器状态设置
            isPlay = true;
            timProcess.Enabled = true;
            timLyric.Enabled = true;
            //音乐播放
            //axWindowsMediaPlayer1.URL = Songlists[lstMusiclist.SelectedIndex];
            axWindowsMediaPlayer1.URL = songpath;
            axWindowsMediaPlayer1.Ctlcontrols.play();
            //设置播放/暂停的图片
            picPlay.BackgroundImage = Properties.Resources.pause;
            //从文件路径获取歌词名称
            string[] lyricpaths = songpath.Split('\\', '.');
            string lyricname = lyricpaths[lyricpaths.Length - 2];

            //初始化歌词类
            lyricf = new LyricFIles();
            lyricf.LoadLyric(lyricname);
            //初始化歌词显示label

            //改背景图片
            Loadbgimage(lyricname);
        }
        public void Loadbgimage(string musicname)
        {
            string filename = "./bg/" + musicname + ".jpg";
            this.BackgroundImage = Image.FromFile(filename);
        }
        //播放下一曲
        public void TimePlay()
        {

            //将小时，分钟，秒分割并显示
            int mintime = 0, sectime = 0, hourtime = 0;
            //将player的计时器强制转化成整数秒，再赋值给lable显示
            string strCurpos = axWindowsMediaPlayer1.Ctlcontrols.currentPosition.ToString();
            string[] nums = strCurpos.Split('.');
            int intSec = int.Parse(nums[0]);
            sectime = intSec % 60;
            mintime = intSec / 60;
            hourtime = intSec / 3600;

            //构造一个年月日小时分钟秒的日期
            DateTime curTime = new DateTime(2000, 1, 1, hourtime, mintime, sectime);
            //取日期的两位分钟和秒
            timeLeft = curTime.ToString("mm:ss");
            string timeRight = axWindowsMediaPlayer1.currentMedia.durationString;
            lblShowTime.Text = timeLeft + "/" + timeRight;
        }
        public void TrackPlay()
        {
            double curvalue = axWindowsMediaPlayer1.Ctlcontrols.currentPosition * 100 / axWindowsMediaPlayer1.currentMedia.duration;
            if (curvalue > 0)
                trkLyrictime.Value = (int)Math.Round(curvalue, MidpointRounding.ToEven);
        }
        public void LyricPlay()
        {
            //以当下时间获取此时间的歌词
            string[] lyric = lyricf.Firstlyrics(axWindowsMediaPlayer1.Ctlcontrols.currentPosition);
            if (lyric == null)
                return;
            //显示歌词
            for (int i = 0; i < 7; i++)
            {
                Lablelists[i].Text = lyric[i];
                Lablelists[i].ForeColor = Color.White;
                if (Convert.ToInt32(lyric[7])==i+1)
                {
                    Lablelists[i].ForeColor = Color.Red;
                }

            }


            //lblLyric.Text = lyric[3];

        }
        private void picNextmusic_Click(object sender, EventArgs e)
        {

            int index = lstMusiclist.SelectedIndex;
            //根据播放模式播放
            if (playmode == 0)
            {//循环播放下一曲

                index++;
                if (index == lstMusiclist.Items.Count)
                {
                    index = 0;
                }
            }
            else if (playmode == 1)
            {//随机播放下一曲
                Random random = new Random();
                random.Next();
                index = random.Next() % lstMusiclist.Items.Count;
                //随机的下一首不能与当前一样
                if (index == lstMusiclist.SelectedIndex)
                    index++;

            }
            lstMusiclist.SelectedIndex = index;
            MusicPlay(Songlists[lstMusiclist.SelectedIndex]);

        }
        bool isShow = false;
        //歌曲列表显示与隐藏
        private void picSonglist_Click(object sender, EventArgs e)
        {

            if (!isShow)
            {
                lstMusiclist.Show();
                isShow = true;
            }
            else
            {
                lstMusiclist.Hide();
                isShow = false;
            }
        }
        //播放上一曲
        private void picBefore_Click(object sender, EventArgs e)
        {

            int index = lstMusiclist.SelectedIndex;
            //根据播放模式播放
            if (playmode == 0)
            {//循环播放下一曲

                index--;
                if (index < 0)
                {
                    index = lstMusiclist.Items.Count - 1;
                }
            }
            else if (playmode == 1)
            {//随机播放下一曲
                Random random = new Random();
                random.Next();
                index = random.Next() % lstMusiclist.Items.Count;
                //随机的下一首不能与当前一样
                if (index == lstMusiclist.SelectedIndex)
                    index++;

            }
            lstMusiclist.SelectedIndex = index;
            MusicPlay(Songlists[lstMusiclist.SelectedIndex]);

        }

        private void rihLyricshow_TextChanged(object sender, EventArgs e)
        {

        }


        private void timLyric_Tick(object sender, EventArgs e)
        {

            LyricPlay();
        }

        private void lblLyric_Click(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {

            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                //下一曲播放
                //不能在事件里mediaplayer.play ？？？
                //this.axWindowsMediaPlayer1.currentPlaylist.clear();
                //this.axWindowsMediaPlayer1.currentPlaylist.appendItem(this.axWindowsMediaPlayer1.newMedia(Songlists[lstMusiclist.SelectedIndex]));
                //axWindowsMediaPlayer1.settings.setMode("loop", true);
                timPlay.Enabled = true;

            }

        }

        private void trkLyrictime_Scroll(object sender, EventArgs e)
        {
            //先停止播放
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            //改变player进度
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = trkLyrictime.Value * axWindowsMediaPlayer1.currentMedia.duration / 100;
            //重新开始

            axWindowsMediaPlayer1.Ctlcontrols.play();
            picPlay.BackgroundImage = Properties.Resources.pause;
        }

        private void axWindowsMediaPlayer1_EndOfStream(object sender, AxWMPLib._WMPOCXEvents_EndOfStreamEvent e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = trkVolume.Value;
            VolumeImage(axWindowsMediaPlayer1.settings.volume);
            isMute = false;
        }
        //是否静音
        bool isMute;
        //静音前音量
        int MuteBefore;
        private void picVolume_Click(object sender, EventArgs e)
        {
            isMute = !isMute;
            if (isMute)
            {
                //保持静音前音量
                MuteBefore = axWindowsMediaPlayer1.settings.volume;
                //音量变0
                trkVolume.Value = 0;
                axWindowsMediaPlayer1.settings.volume = trkVolume.Value;
                //设置背景图片
                picVolume.BackgroundImage = Properties.Resources.mute;
            }
            else
            {
                axWindowsMediaPlayer1.settings.volume = MuteBefore;
                trkVolume.Value = axWindowsMediaPlayer1.settings.volume;
                VolumeImage(trkVolume.Value);
            }
        }

        private void lblShowTime_Click(object sender, EventArgs e)
        {

        }
        public void VolumeImage(int volume)
        {
            if (trkVolume.Value > 0)
                picVolume.BackgroundImage = Properties.Resources.volume;

            else
            {
                picVolume.BackgroundImage = Properties.Resources.mute;
            }
        }

        private void timPlay_Tick(object sender, EventArgs e)
        {
            timPlay.Enabled = false;
            int index = lstMusiclist.SelectedIndex;
            //根据播放模式播放
            if (playmode == 0)
            {//循环播放下一曲

                index++;
                if (index == lstMusiclist.Items.Count)
                {
                    index = 0;
                }
                lstMusiclist.SelectedIndex = index;
            }
            else if (playmode == 1)
            {//随机播放下一曲
                Random random = new Random();
                random.Next();
                lstMusiclist.SelectedIndex = random.Next() % lstMusiclist.Items.Count;
            }

            MusicPlay(Songlists[lstMusiclist.SelectedIndex]);

        }
        int playmode;
        private void picPlaymode_Click(object sender, EventArgs e)
        {
            playmode = (playmode + 1) % 2;
            if (playmode == 0)
            {
                picPlaymode.BackgroundImage = Properties.Resources.repeat;
            }
            else if (playmode == 1)
            {
                picPlaymode.BackgroundImage = Properties.Resources.shuffle;
            }
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //添加timer 不断刷新 interval=10


        }

        private void MusicPlayer_Paint(object sender, PaintEventArgs e)
        {
        }

        private void MusicPlayer_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)//按下左键
            {
                mousepoint.X = e.X;
                mousepoint.Y = e.Y;
            }
        }

        private void MusicPlayer_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Top = MousePosition.Y - mousepoint.Y;
                Left = MousePosition.X - mousepoint.X;
            }
        }

        private void picMini_MouseEnter(object sender, EventArgs e)
        {
            picMini.BackColor = Color.FromArgb(50, 200, 255, 255);
        }

        private void picMini_MouseLeave(object sender, EventArgs e)
        {
            picMini.BackColor = Color.FromArgb(0, 255, 255, 255);
        }

        private void picClose_MouseEnter(object sender, EventArgs e)
        {
            picClose.BackColor = Color.Red;
        }

        private void picClose_MouseLeave(object sender, EventArgs e)
        {
            picClose.BackColor = Color.Transparent;
        }

        private void 打开播放器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
            this.Show();
        }

        private void MusicPlayer_Resize(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Minimized)
            { //最小化窗口时
                this.Visible = false;
                this.ntiIcon.Visible = true;
            }
        }

        private void picMini_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ntiIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
            this.Show();
        }

        private void MusicPlayer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 32)
            {//捕获空格键，播放暂停
                if (isPlay)
                {
                    axWindowsMediaPlayer1.Ctlcontrols.pause();
                    isPlay = !isPlay;
                    picPlay.BackgroundImage = Properties.Resources.play_button;
                }
                else
                {
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    isPlay = !isPlay;
                    picPlay.BackgroundImage = Properties.Resources.pause;

                }
            }
        }
    }
}
