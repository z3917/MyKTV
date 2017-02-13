using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyKTV
{
    class song
    {
        /// <summary>
        /// 枚举：歌曲播放状态
        /// </summary>
        public enum SongPlayState
        {
            unplayed, played, again, cut
        }
        public class Song
        {
            //歌曲名称字段
            private string songname;

            //歌曲名称属性
            public string SongName
            {
                get { return songname; }
                set { songname = value; }
            }

            //歌曲存放路径字段
            private string songURL;

            //歌曲存放路径属性
            public string SongURL
            {
                get { return songURL; }
                set { songURL = value; }
            }

            //歌曲播放状态字段
            private SongPlayState playstate = SongPlayState.unplayed;

            //歌曲播放状态属性
            public SongPlayState PlayState
            {
                get { return playstate; }
                set { playstate = value; }
            }

        }
    }
}
