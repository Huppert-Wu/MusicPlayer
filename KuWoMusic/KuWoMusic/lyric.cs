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
        
        public string  Firstlyrics(double Curtime)
        {
            double time;
            string lyrics=null;

            //当前时间，以double表示
            foreach(Lyric lyric in lstLyric)
            {
                //全部化成double计算
                //如果大于等于就返回歌词
                time = lyric.Minute*60 + lyric.Second + lyric.Mmsec*0.01;
                if (time <= Curtime)
                {
                    //返回上一条歌词
                    lyrics = lyric.Strlyric;
                    //lstLyric.Remove(lyric);


                }
                else
                    return lyrics;
            }
            return null;
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
            while ((line = sr.ReadLine()) != null)
            {
                //将歌词信息，时间片段加入list
                if (line == "")
                    continue;
                string []lyrictime = LyricParse(line);
                
                Lyric lyric = new Lyric(int.Parse(lyrictime[1]), int.Parse(lyrictime[2]), int.Parse(lyrictime[3]), lyrictime[4]); //可能自动属性的锅
                lstLyric.Add(lyric);

            }
            sr.Close();
            fs.Close();
            

        }
        public string[] LyricParse(string lyricLine)
        {
            string[] lyrics =  lyricLine.Split('[', ':', '.', ']');
            return lyrics;
        }

        //public string[] 

    }
    class Lyric
    {
        //分钟 秒 毫秒
        int mmsecs=0, minutes=0, seconds=0;
        string strlyrics=null;
        public Lyric(int minute, int second,int mmsecs, string strlyric)
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
