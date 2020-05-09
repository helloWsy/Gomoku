using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace NETFianlHomework
{
    [Serializable]
    public class Game
    {
        static readonly DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1));
        readonly long gameStartTime = (long)(DateTime.Now - startTime).TotalMilliseconds;


        //是否开始
        public bool Start { get; set; }
        public int Steps { get; set; }
        public bool isEnd { get; set; }

        public bool isPlaying { get;set; }
        public bool HumanVShuman { get; set; }
        public bool HumanVSai { get; set; }

        public int BlackTime { get; set; }
        public int WhiteTime { get; set; }
        public int BlackTimeThis { get; set; }
        public int WhiteTimeThis { get; set; }

        public int[,] Chess = new int[15, 15];
        public int[,] Moves = new int[230, 6];

        public Game()
        {

            Start = false;
            isEnd = false;
            isPlaying = false;
            //HumanVShuman = false;
            //HumanVSai = false;

            BlackTime = 0;
            WhiteTime = 0;
            BlackTimeThis = 0;
            WhiteTimeThis = 0;
        }
    }
}
