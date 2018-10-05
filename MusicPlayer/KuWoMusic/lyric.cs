using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace KuWoMusic
{
    class LyricFIles
    {
        public List<Lyric> lstLyric = new List<Lyric>();
        public string[] Firstlyrics(double Curtime)
        {
            int index = 0;
            int sentinel = 4;
            double time;
            //保存7行代码返回
            string[] lyrics = new string[8];
            string[] newlyric = new string[8];
            newlyric[0] = newlyric[1] = newlyric[2] = newlyric[3] = null;
            for (int count = 0; count < 7; count++)
            {
                lyrics[count] = lstLyric[count].Strlyric;
            }

            foreach (Lyric lyric in lstLyric)
            {
                //全部化成double计算
                //如果大于等于就返回歌词
                time = lyric.Minute * 60 + lyric.Second + lyric.Mmsec * 0.01;
                if (lyric != null)
                {
                    if (time <= Curtime)
                    {
                        newlyric[0] = newlyric[1];
                        newlyric[1] = newlyric[2];
                        newlyric[2] = newlyric[3];
                        newlyric[3] = lyric.Strlyric;
                        index++;
                    }
                    else
                    {
                        if(index <= 4)
                        {
                            //返回最初7行歌词
                            lyrics[7] = index.ToString();
                            return lyrics;
                        }
                        else
                        {
                            newlyric[sentinel++] = lyric.Strlyric;
                            if(sentinel == 7)
                            {
                                newlyric[7] = "4";
                                return newlyric;
                            }
                        }
                    }
                }

            }
            if (newlyric[0] != null)
            {
                newlyric[7] = "4";
                return newlyric;
            }
            else
                return lyrics;
        }
        public void LoadLyric(string lyricname)
        {
            //编码
            //encode utf-8
            Encoding encode = Encoding.GetEncoding("GB2312");
            //打开歌词文件夹，获取歌词
            FileStream fs = new FileStream("./Lyric/" + lyricname + ".lrc", FileMode.Open);
            StreamReader sr = new StreamReader(fs, encode);


            //解析歌词文件
            string line;
            int lyriccount = 0;
            while ((line = sr.ReadLine()) != null)
            {
                //将歌词信息，时间片段加入list
                if (line == "")
                    continue;
                string[] lyrictime = LyricParse(line);

                Lyric lyric = new Lyric(int.Parse(lyrictime[1]), int.Parse(lyrictime[2]), int.Parse(lyrictime[3]), lyrictime[4]);
                lstLyric.Add(lyric);
                lyriccount++;
            }
            sr.Close();
            fs.Close();


        }
        public string[] LyricParse(string lyricLine)
        {
            string[] lyrics = lyricLine.Split('[', ':', '.', ']');
            return lyrics;
        }


    }
    class Lyric
    {
        //分钟 秒 毫秒
        int mmsecs = 0, minutes = 0, seconds = 0;
        string strlyrics = null;
        //记录歌词条数

        public Lyric(int minute, int second, int mmsecs, string strlyric)
        {

            this.mmsecs = mmsecs;
            this.minutes = minute;
            this.seconds = second;
            this.strlyrics = strlyric;
        }

        public int Mmsec
        {
            get { return this.mmsecs; }
            set { value = this.mmsecs; }
        }
        public int Minute
        {
            get { return this.minutes; }
            set { value = this.minutes; }
        }
        public int Second
        {
            get { return this.seconds; }
            set { value = this.seconds; }
        }
        public string Strlyric
        {
            get { return this.strlyrics; }
            set { value = this.strlyrics; }
        }

    }

}
