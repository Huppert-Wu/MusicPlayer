using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace urltest01
{
    class Songs
    {
        List<Lyric> lstLyric = new List<Lyric>();
        public string Song { get; set; }
        public string Lyrics { get; set; }
        public string Backimg { get; set; }
        public string Name { get; set; }
        public Songs(string song, string lyric, string backimg,string name)
        {
            this.Song = song;
            this.Lyrics = lyric;
            this.Backimg = backimg;
            this.Name = name;
        }

        public void Loadlyric()
        {
            string lyrictxt = this.Lyrics;
            Lyric curlyric;
            string[] lyrics = lyrictxt.Split(new string[] { "\\n" }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string lyric in lyrics)
            {
                string[] foo = lyric.Split('[',']');//先把时间与歌词分割
                string lyricpartial = foo[2];
                string[] bar = foo[1].Split(':', '.');//再分割时间

                if (bar.Length == 3)
                {
                    curlyric = new Lyric(int.Parse(bar[0]), int.Parse(bar[1]), bar[2], foo[2]);
                    lstLyric.Add(curlyric);
                }
                else
                {
                    curlyric = new Lyric(0, 0, "0", foo[1]);
                    lstLyric.Add(curlyric);
                }
            }
        }
        /// <summary>
        /// 据当前播放时间返回相应歌词
        /// </summary>
        /// <param name="Curtime"></param>
        /// <returns></returns>
        public string[] Curlyrics(double Curtime)
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
                if (lyric.Mmsec.Length > 2)//歌词时间轴毫秒数区分
                    time = lyric.Minute * 60 + lyric.Second + int.Parse(lyric.Mmsec) * 0.001;
                else
                    time = lyric.Minute * 60 + lyric.Second + int.Parse(lyric.Mmsec) * 0.01;
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
                        if (index <= 4)
                        {
                            //返回最初7行歌词
                            lyrics[7] = index.ToString();
                            return lyrics;
                        }
                        else
                        {
                            newlyric[sentinel++] = lyric.Strlyric;
                            if (sentinel == 7)
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
    }
    class Lyric
    {
        public Lyric(int minute, int second, string mmsecs, string strlyric)
        {

            this.Mmsec = mmsecs;
            this.Minute = minute;
            this.Second = second;
            this.Strlyric = strlyric;
        }
        public string Mmsec { get; set; }
        public int Minute { get; set; }
        public int Second { get; set; }
        public string Strlyric { get; set; }
    }
}
