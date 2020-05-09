using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
//using System.Windows.Media;

namespace NETFianlHomework
{
    public partial class Main : Form
    {
        enum GameType { People, Computer };
        enum GameTurn { Black, White };

        Game game;
        Forbidden forbidden;
        bool isPlaying = false;
        bool enableProhibitHand = false;
        bool enableLimitTime = false;

        public int Ticks { get; set; }


        static readonly public Brush whiteBrush = new SolidBrush(Color.FromArgb(255, 255, 255));
        static readonly public Brush halfWhiteBrush = new SolidBrush(Color.FromArgb(125, 255, 255, 255));
        static readonly public Brush blackBrush = new SolidBrush(Color.FromArgb(0, 0, 0));
        //static readonly public Brush halfBlackBrush = new SolidBrush(Color.FromArgb(125, 0, 0, 0));
        //static readonly public Brush clarityBrush = new SolidBrush(Color.FromArgb(23, 232, 221, 10));

        Dictionary<GameTurn, GameType> type = new Dictionary<GameTurn, GameType>();//玩家
        Dictionary<GameTurn, AIInterface> ai = new Dictionary<GameTurn, AIInterface>();//AI

        GameTurn gameTurn = GameTurn.Black;
        //bool isEnd = true;


        int lastX = 15, lastY = 15;
        double step = 490 / 14.0;
        double top = 7, left = 7;

        int[,] board = new int[16, 16];//定义棋盘大小
        int[,] _board = new int[16, 16];


        // Pen myPen = new Pen(Color.Black, 3);

        public Main()
        {
            InitializeComponent();
            timer1.Interval = 1000;//每秒执行一次
            type[GameTurn.Black] = GameType.People;
            type[GameTurn.White] = GameType.People;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            game = new Game();
            game.isEnd = true;
            string path = System.Environment.CurrentDirectory;
            path = path.Substring(0, path.Length - 9);
            ChessBoard.Image = Image.FromFile(path + @"source\background.jpg");
        }

        private void startGame()
        {
            //重绘背景
            string path = System.Environment.CurrentDirectory;
            path = path.Substring(0, path.Length - 9);
            ChessBoard.Image = Image.FromFile(path + @"source\background.jpg");

            game = new Game();
            forbidden = new Forbidden();
            game.isEnd = false;
            启用禁手ToolStripMenuItem.Enabled = false;
            设置步时ToolStripMenuItem.Enabled = false;

            timer1.Start();
            black_time_all.Text = "局时: 0秒";
            black_time_this.Text = "步时: 0秒";
            white_time_all.Text = "局时: 0秒";
            white_time_this.Text = "步时: 0秒";

            for (int i = 0; i < 15; i++)
                for (int j = 0; j < 15; j++)
                {
                    board[i, j] = 0;
                    gameTurn = GameTurn.Black;
                }
        }

        // static bool isHere = false;

        private void CopyBoard()
        {
            for (int i = 0; i < 15; i++)
                for (int j = 0; j < 15; j++)
                    _board[i, j] = board[i, j];
        }

        private void gameOver()
        {
            game.isEnd = true;
            isPlaying = false;
            timer1.Enabled = false;
            启用禁手ToolStripMenuItem.Enabled = true;
            设置步时ToolStripMenuItem.Enabled = true;
        }

        private void 玩家VS玩家ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            startGame();
            type[GameTurn.Black] = GameType.People;
            type[GameTurn.White] = GameType.People;
            label_black_type.Text = "玩家";
            label_white_type.Text = "玩家";
        }

        private void 玩家VSAIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("AI先生很厉害的，你要持黑棋吗?", "", MessageBoxButtons.YesNo);
            startGame();
            if (dialogResult == DialogResult.No)//AI  黑
            {
                label_black_type.Text = " AI";
                label_white_type.Text = "玩家";
                ai[GameTurn.Black] = new AI();
                type[GameTurn.Black] = GameType.Computer;
                type[GameTurn.White] = GameType.People;

            }
            else
            {
                label_black_type.Text = "玩家";
                label_white_type.Text = " AI";
                ai[GameTurn.White] = new AI();
                type[GameTurn.White] = GameType.Computer;
                type[GameTurn.Black] = GameType.People;
            }

            if (type[GameTurn.Black] == GameType.Computer)
                UseAI(ai[GameTurn.Black]);
        }

        private void 启用禁手ToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (启用禁手ToolStripMenuItem.Checked)
                enableProhibitHand = true;
            else
                enableProhibitHand = false;
        }

        private void 设置步时ToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (设置步时ToolStripMenuItem.Checked)
                enableLimitTime = true;
            else
                enableLimitTime = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Main time = this;
            if (gameTurn == GameTurn.Black)
            {
                time.game.BlackTime++;
                time.game.BlackTimeThis++;

                time.black_time_all.Text = "局时: " + Convert.ToString(time.game.BlackTime) + "秒";
                time.black_time_this.Text = "步时: " + Convert.ToString(time.game.BlackTimeThis) + "秒";

                if (time.game.BlackTimeThis >= 30 && enableLimitTime)
                {
                    gameOver();
                    MessageBox.Show("黑棋超时，白棋获胜，游戏结束");
                    return;
                }

            }
            else
            {
                time.game.WhiteTime++;
                time.game.WhiteTimeThis++;

                time.white_time_all.Text = "局时: " + Convert.ToString(time.game.WhiteTime) + "秒";
                time.white_time_this.Text = "步时: " + Convert.ToString(time.game.WhiteTimeThis) + "秒";

                if (time.game.WhiteTimeThis >= 30 && enableLimitTime)
                {
                    gameOver();
                    MessageBox.Show("白棋超时，黑棋获胜，游戏结束");
                    return;
                }
            }
            System.Diagnostics.Debug.WriteLine(game.isEnd);
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(".Net期末大作业\n使用c#开发\n时间：2018/24/12\n作者：王邵赟\n学号：2016210405029");
        }

        private void UseAI(AIInterface ai)
        {
            int now = 1;
            if (gameTurn != GameTurn.Black)
                now = 2;
            CopyBoard();
            ai.Running(_board, now);
            int x, y;
            ai.GetNextStep(out x, out y);
            PutPiece(x, y);
        }

        private void ShowVirtualPiece(int x, int y)
        {
            if (game.isEnd && !isPlaying)
                return;
            Image img = ChessBoard.Image;
            Image temp = img;
            Graphics gra = Graphics.FromImage(temp);
            if (board[x, y] != 0)//该位置已经被放置棋子
                return;
            if (gameTurn == GameTurn.Black)
            {
                //gra.FillEllipse(halfBlackBrush, x * 35 + 6, y * 35 + 6, 30, 30);
            }
            else
            {
                gra.FillEllipse(whiteBrush, x * 35 + 6, y * 35 + 6, 30, 30);
            }
            //ChessBoard.Image = temp

            ChessBoard.Image = img;

            //lastX = lastY = 15;
        }

        private void HideLastVirtualPiece()
        {
            if (board[lastX, lastY] != 0)
                return;

        }

        private void ChessBoard_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (type[gameTurn] == GameType.Computer || game.isEnd || isPlaying)
                return;

            double xPos = e.Location.X;
            double yPos = e.Location.Y;
            int x = Convert.ToInt32((xPos - left) / step - 0.5);
            int y = Convert.ToInt32((yPos - top) / step - 0.5);
            lastX = x;
            lastY = y;
            if (x >= 0 && x < 15 && y >= 0 && y < 15)
            {

                //ShowVirtualPiece(x, y);
            }

        }

        private void ChessBoard_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (type[gameTurn] == GameType.Computer || game.isEnd || isPlaying)
                return;
            double xPos = e.Location.X;
            double yPos = e.Location.Y;
            int x = Convert.ToInt32((xPos - left) / step - 0.5);
            int y = Convert.ToInt32((yPos - top) / step - 0.5);
            if (x >= 0 && x < 15 && y >= 0 && y < 15)
                PutPiece(x, y);
        }

        private void PutPiece(int x, int y)
        {
            if (game.isEnd && !game.isPlaying)
                return;
            Image img = ChessBoard.Image;
            Graphics gra = Graphics.FromImage(img);
            if (board[x, y] != 0)//该位置已经被放置棋子
                return;
            if (gameTurn == GameTurn.Black)
            {
                board[x, y] = 1;
                int f = forbidden.forbidden(board, x, y);
                board[x, y] = 0;

                if (f != 0 && enableProhibitHand)//启用禁手
                {
                    DialogResult dialogResult = DialogResult.Yes;
                    switch (f)
                    {
                        case 1:
                            dialogResult = MessageBox.Show("三三禁手!!!是否撤回该步？", "警告", MessageBoxButtons.YesNo);
                            break;
                        case 2:
                            dialogResult = MessageBox.Show("四四禁手!!!是否撤回该步？", "警告", MessageBoxButtons.YesNo);
                            break;
                        case 3:
                            dialogResult = MessageBox.Show("长连禁手!!!是否撤回该步？", "警告", MessageBoxButtons.YesNo);
                            break;
                    }

                    if (dialogResult == DialogResult.Yes)
                    {
                        return;
                    }
                    else
                    {
                        gameOver();
                        MessageBox.Show("白棋胜利，游戏结束");
                        return;
                    }
                }
                game.BlackTimeThis = 0;
                game.WhiteTimeThis = 0;
                black_time_this.Text = "步时: 0秒";
                white_time_this.Text = "步时: 0秒";

                gra.FillEllipse(blackBrush, x * 35 + 6, y * 35 + 6, 30, 30);
                board[x, y] = 1;//放置黑色棋子
                gameTurn = GameTurn.White;
            }
            else
            {
                game.BlackTimeThis = 0;
                game.WhiteTimeThis = 0;
                black_time_this.Text = "步时: 0秒";
                white_time_this.Text = "步时: 0秒";

                gra.FillEllipse(whiteBrush, x * 35 + 6, y * 35 + 6, 30, 30);
                board[x, y] = 2;//放置白色棋子
                gameTurn = GameTurn.Black;
            }
            ChessBoard.Image = img;

            lastX = lastY = 15;
            int result = Util.CheckBoardResult(board, x, y);
            if (result == 1)
            {
                gameOver();
                MessageBox.Show("黑棋获胜，游戏结束");
            }

            if (result == 2)
            {
                gameOver();
                MessageBox.Show("白棋获胜，游戏结束");
            }

            if (!game.isEnd && type[gameTurn] == GameType.Computer)
                UseAI(ai[gameTurn] as AIInterface);
        }
    }
}