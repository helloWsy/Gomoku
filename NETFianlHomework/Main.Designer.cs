namespace NETFianlHomework
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private object source;

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
            this.panel_chessBoard = new System.Windows.Forms.Panel();
            this.ChessBoard = new System.Windows.Forms.PictureBox();
            this.label_black = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.black_time_all = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.新游戏ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.玩家VS玩家ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.玩家VSAIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.启用禁手ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置步时ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.black_time_this = new System.Windows.Forms.Label();
            this.white_time_this = new System.Windows.Forms.Label();
            this.white_time_all = new System.Windows.Forms.Label();
            this.label_black_type = new System.Windows.Forms.Label();
            this.label_white_type = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel_chessBoard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChessBoard)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_chessBoard
            // 
            this.panel_chessBoard.BackgroundImage = global::NETFianlHomework.Properties.Resources.background;
            this.panel_chessBoard.Controls.Add(this.ChessBoard);
            this.panel_chessBoard.Location = new System.Drawing.Point(0, 25);
            this.panel_chessBoard.Name = "panel_chessBoard";
            this.panel_chessBoard.Size = new System.Drawing.Size(532, 532);
            this.panel_chessBoard.TabIndex = 0;
            // 
            // ChessBoard
            // 
            this.ChessBoard.Image = global::NETFianlHomework.Properties.Resources.background;
            this.ChessBoard.Location = new System.Drawing.Point(0, 0);
            this.ChessBoard.Name = "ChessBoard";
            this.ChessBoard.Size = new System.Drawing.Size(532, 532);
            this.ChessBoard.TabIndex = 0;
            this.ChessBoard.TabStop = false;
            this.ChessBoard.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ChessBoard_MouseDown);
            this.ChessBoard.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChessBoard_MouseMove);
            // 
            // label_black
            // 
            this.label_black.AutoSize = true;
            this.label_black.Font = new System.Drawing.Font("仿宋", 33F, System.Drawing.FontStyle.Bold);
            this.label_black.Location = new System.Drawing.Point(567, 84);
            this.label_black.Name = "label_black";
            this.label_black.Size = new System.Drawing.Size(315, 44);
            this.label_black.TabIndex = 1;
            this.label_black.Text = "黑棋（     ）";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("仿宋", 33F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(567, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 44);
            this.label1.TabIndex = 10;
            this.label1.Text = "白棋（     ）";
            // 
            // black_time_all
            // 
            this.black_time_all.AutoSize = true;
            this.black_time_all.Font = new System.Drawing.Font("宋体", 22F);
            this.black_time_all.Location = new System.Drawing.Point(645, 164);
            this.black_time_all.Name = "black_time_all";
            this.black_time_all.Size = new System.Drawing.Size(148, 30);
            this.black_time_all.TabIndex = 11;
            this.black_time_all.Text = "局时: 0秒";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新游戏ToolStripMenuItem,
            this.配置ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(882, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 新游戏ToolStripMenuItem
            // 
            this.新游戏ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.玩家VS玩家ToolStripMenuItem,
            this.玩家VSAIToolStripMenuItem});
            this.新游戏ToolStripMenuItem.Name = "新游戏ToolStripMenuItem";
            this.新游戏ToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.新游戏ToolStripMenuItem.Text = "新游戏";
            // 
            // 玩家VS玩家ToolStripMenuItem
            // 
            this.玩家VS玩家ToolStripMenuItem.Name = "玩家VS玩家ToolStripMenuItem";
            this.玩家VS玩家ToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.玩家VS玩家ToolStripMenuItem.Text = "玩家VS玩家";
            this.玩家VS玩家ToolStripMenuItem.Click += new System.EventHandler(this.玩家VS玩家ToolStripMenuItem_Click);
            // 
            // 玩家VSAIToolStripMenuItem
            // 
            this.玩家VSAIToolStripMenuItem.Name = "玩家VSAIToolStripMenuItem";
            this.玩家VSAIToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.玩家VSAIToolStripMenuItem.Text = "玩家VSAI";
            this.玩家VSAIToolStripMenuItem.Click += new System.EventHandler(this.玩家VSAIToolStripMenuItem_Click);
            // 
            // 配置ToolStripMenuItem
            // 
            this.配置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.启用禁手ToolStripMenuItem,
            this.设置步时ToolStripMenuItem});
            this.配置ToolStripMenuItem.Name = "配置ToolStripMenuItem";
            this.配置ToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.配置ToolStripMenuItem.Text = "配置";
            // 
            // 启用禁手ToolStripMenuItem
            // 
            this.启用禁手ToolStripMenuItem.CheckOnClick = true;
            this.启用禁手ToolStripMenuItem.Name = "启用禁手ToolStripMenuItem";
            this.启用禁手ToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.启用禁手ToolStripMenuItem.Text = "启用禁手";
            this.启用禁手ToolStripMenuItem.CheckedChanged += new System.EventHandler(this.启用禁手ToolStripMenuItem_CheckedChanged);
            // 
            // 设置步时ToolStripMenuItem
            // 
            this.设置步时ToolStripMenuItem.CheckOnClick = true;
            this.设置步时ToolStripMenuItem.Name = "设置步时ToolStripMenuItem";
            this.设置步时ToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.设置步时ToolStripMenuItem.Text = "限制步时30S";
            this.设置步时ToolStripMenuItem.CheckedChanged += new System.EventHandler(this.设置步时ToolStripMenuItem_CheckedChanged);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // black_time_this
            // 
            this.black_time_this.AutoSize = true;
            this.black_time_this.Font = new System.Drawing.Font("宋体", 22F);
            this.black_time_this.Location = new System.Drawing.Point(645, 211);
            this.black_time_this.Name = "black_time_this";
            this.black_time_this.Size = new System.Drawing.Size(148, 30);
            this.black_time_this.TabIndex = 13;
            this.black_time_this.Text = "步时: 0秒";
            // 
            // white_time_this
            // 
            this.white_time_this.AutoSize = true;
            this.white_time_this.Font = new System.Drawing.Font("宋体", 22F);
            this.white_time_this.Location = new System.Drawing.Point(645, 477);
            this.white_time_this.Name = "white_time_this";
            this.white_time_this.Size = new System.Drawing.Size(148, 30);
            this.white_time_this.TabIndex = 15;
            this.white_time_this.Text = "步时: 0秒";
            // 
            // white_time_all
            // 
            this.white_time_all.AutoSize = true;
            this.white_time_all.Font = new System.Drawing.Font("宋体", 22F);
            this.white_time_all.Location = new System.Drawing.Point(645, 420);
            this.white_time_all.Name = "white_time_all";
            this.white_time_all.Size = new System.Drawing.Size(148, 30);
            this.white_time_all.TabIndex = 14;
            this.white_time_all.Text = "局时: 0秒";
            // 
            // label_black_type
            // 
            this.label_black_type.AutoSize = true;
            this.label_black_type.Font = new System.Drawing.Font("仿宋", 33F, System.Drawing.FontStyle.Bold);
            this.label_black_type.Location = new System.Drawing.Point(713, 84);
            this.label_black_type.Name = "label_black_type";
            this.label_black_type.Size = new System.Drawing.Size(110, 44);
            this.label_black_type.TabIndex = 16;
            this.label_black_type.Text = "玩家";
            // 
            // label_white_type
            // 
            this.label_white_type.AutoSize = true;
            this.label_white_type.Font = new System.Drawing.Font("仿宋", 33F, System.Drawing.FontStyle.Bold);
            this.label_white_type.Location = new System.Drawing.Point(713, 330);
            this.label_white_type.Name = "label_white_type";
            this.label_white_type.Size = new System.Drawing.Size(110, 44);
            this.label_white_type.TabIndex = 17;
            this.label_white_type.Text = "玩家";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(882, 556);
            this.Controls.Add(this.label_white_type);
            this.Controls.Add(this.label_black_type);
            this.Controls.Add(this.white_time_this);
            this.Controls.Add(this.white_time_all);
            this.Controls.Add(this.black_time_this);
            this.Controls.Add(this.black_time_all);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_black);
            this.Controls.Add(this.panel_chessBoard);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Main";
            this.Text = "  五子棋";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel_chessBoard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ChessBoard)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_chessBoard;
        private System.Windows.Forms.Label label_black;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label black_time_all;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 新游戏ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 玩家VS玩家ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 玩家VSAIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 配置ToolStripMenuItem;
        private System.Windows.Forms.Label black_time_this;
        private System.Windows.Forms.Label white_time_this;
        private System.Windows.Forms.Label white_time_all;
        private System.Windows.Forms.Label label_black_type;
        private System.Windows.Forms.Label label_white_type;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox ChessBoard;
        private System.Windows.Forms.ToolStripMenuItem 启用禁手ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置步时ToolStripMenuItem;
    }
}

