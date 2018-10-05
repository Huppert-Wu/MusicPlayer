using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;//网页get请求
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Collections.Generic;
namespace urltest01
{
    class WebSonglist
    {
        //歌曲id列表
        public List<int> SongIds = new List<int>();
        //歌曲字典
        public Dictionary<int, Songs> SongInfo = new Dictionary<int, Songs>();
        /// <summary>
        /// 初始化歌单类
        /// </summary>
        /// <param name="playlisturl"></param>

        public WebSonglist(string playlisturl)
        {
            Playlisturl = playlisturl;
            Parseurl(Playlisturl);
            foreach (int songid in SongIds)
            {
                string songaddr = Parsemp3url(songid);
                string jpgaddr = Parsejpgurl(songid);
                string lyrics = Parselyricurl(songid);
                Songs song = new Songs(songaddr, lyrics, jpgaddr);
                SongInfo.Add(songid, song);
            }
        }

        private string Playlisturl;

        /// <summary>
        /// 获取网页内容，并保存歌曲id为列表
        /// </summary>
        /// <param name="url"></param>
        /// 
        private void Parseurl(string url)
        {
            //保存网页
            string pagehtml;
            try
            {
                pagehtml = Getwebpage(url);
                string songid;

                //string pattern = "[[]([{][\"]id[\"]:([0-9]+),[\"]fee[\"][}]{1},.*?)+[]]{1}";
                string pattern2 = "id\":([0-9]+),\"fee";
                Regex regex = new Regex(pattern2);
                foreach (Match match in regex.Matches(pagehtml))
                {

                    songid = match.Groups[1].Value.ToString();
                    SongIds.Add(int.Parse(songid));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        /// <summary>
        /// 解析出歌曲mps的网络地址
        /// </summary>
        /// <param name="songids"></param>
        private string Parsemp3url(int songid)
        {
            string url = "https://api.imjad.cn/cloudmusic/?type=song&id=" + songid.ToString();
            string pagehtml = Getwebpage(url);
            string pattern = "url\":\"(http.*?mp3)";
            string songaddr;
            Regex regex = new Regex(pattern);
            Match match = regex.Match(pagehtml);
            songaddr = match.Groups[1].ToString();
            return songaddr;
        }

        /// <summary>
        /// 返回歌曲背景图片地址
        /// </summary>
        /// <param name="songid"></param>
        /// <returns></returns>
        private string Parsejpgurl(int songid)
        {
            string url = "https://api.imjad.cn/cloudmusic/?type=detail&id=" + songid.ToString();
            string pagehtml = Getwebpage(url);
            string pattern = "picUrl\":\"(http.*?jpg)";//jpg的正则表达式
            string jpgaddr;
            Regex regex = new Regex(pattern);
            Match match = regex.Match(pagehtml);
            jpgaddr = match.Groups[1].ToString();
            return jpgaddr;
        }

        /// <summary>
        /// 根据歌曲id得到歌词列表
        /// </summary>
        /// <param name="songid"></param>
        /// <returns></returns>
        private string Parselyricurl(int songid)
        {
            string lyrictxt;
            string[] lyrics;
            string url = "https://api.imjad.cn/cloudmusic/?type=lyric&id=" + songid.ToString();
            string pagehtml = Getwebpage(url);
            //unicode解码
            pagehtml = DeUnicode(pagehtml);
            string pattern = "lyric\":\"(.*?)\"}";//jpg的正则表达式
            
            Regex regex = new Regex(pattern);
            Match match = regex.Match(pagehtml);
            lyrictxt = match.Groups[1].ToString();

            return lyrictxt;
        }

        private string Getwebpage(string url)
        {
            WebClient webClient = new WebClient();
            //保存网页
            string pagehtml;
            try
            {
                webClient.Credentials = CredentialCache.DefaultCredentials;//身份验证凭证
                byte[] pagedata = webClient.DownloadData(url);
                pagehtml = Encoding.UTF8.GetString(pagedata);
                return pagehtml;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            return null;
        }

        private static string DeUnicode(string str)
        {
            //最直接的方法Regex.Unescape(str);
            Regex reg = new Regex(@"(?i)\\[uU]([0-9a-f]{4})");
            return reg.Replace(str, delegate (Match m)
            {
                return ((char)Convert.ToInt32(m.Groups[1].Value, 16)).ToString();
            }
            );
            //摘自 https://www.cnblogs.com/iack/p/3664104.html
        }

        
    }

}
