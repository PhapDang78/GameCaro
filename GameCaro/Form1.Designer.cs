namespace GameCaro
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
<<<<<<< HEAD
            this.components = new System.ComponentModel.Container();
            this.pnlChessBoard = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbIP = new System.Windows.Forms.TextBox();
            this.btnLAN = new System.Windows.Forms.Button();
            this.pctbMark = new System.Windows.Forms.PictureBox();
            this.prcbCoolDown = new System.Windows.Forms.ProgressBar();
            this.txbPlayerName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pctbLoGo = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmCoolDown = new System.Windows.Forms.Timer(this.components);
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbMark)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbLoGo)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlChessBoard
            // 
            this.pnlChessBoard.Location = new System.Drawing.Point(0, 29);
            this.pnlChessBoard.Name = "pnlChessBoard";
            this.pnlChessBoard.Size = new System.Drawing.Size(808, 556);
            this.pnlChessBoard.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txbIP);
            this.panel3.Controls.Add(this.btnLAN);
            this.panel3.Controls.Add(this.pctbMark);
            this.panel3.Controls.Add(this.prcbCoolDown);
            this.panel3.Controls.Add(this.txbPlayerName);
            this.panel3.Location = new System.Drawing.Point(814, 235);
=======
            this.chessboard = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLAN = new System.Windows.Forms.Button();
            this.tbIP = new System.Windows.Forms.TextBox();
            this.playerName = new System.Windows.Forms.TextBox();
            this.picMark = new System.Windows.Forms.PictureBox();
            this.coolDown = new System.Windows.Forms.ProgressBar();
            this.logouth = new System.Windows.Forms.Panel();
            this.picturelogouth = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMark)).BeginInit();
            this.logouth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturelogouth)).BeginInit();
            this.SuspendLayout();
            // 
            // chessboard
            // 
            this.chessboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chessboard.Location = new System.Drawing.Point(12, 12);
            this.chessboard.Name = "chessboard";
            this.chessboard.Size = new System.Drawing.Size(759, 648);
            this.chessboard.TabIndex = 0;
            this.chessboard.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btnLAN);
            this.panel3.Controls.Add(this.tbIP);
            this.panel3.Controls.Add(this.playerName);
            this.panel3.Controls.Add(this.picMark);
            this.panel3.Controls.Add(this.coolDown);
            this.panel3.Location = new System.Drawing.Point(777, 158);
>>>>>>> 8713793272f8aa5ea872973e7f0c26d73427e4e7
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(287, 491);
            this.panel3.TabIndex = 2;
            // 
<<<<<<< HEAD
            // txbIP
            // 
            this.txbIP.Location = new System.Drawing.Point(3, 57);
            this.txbIP.Name = "txbIP";
            this.txbIP.Size = new System.Drawing.Size(103, 22);
            this.txbIP.TabIndex = 5;
            // 
            // btnLAN
            // 
            this.btnLAN.Location = new System.Drawing.Point(4, 82);
            this.btnLAN.Name = "btnLAN";
            this.btnLAN.Size = new System.Drawing.Size(99, 23);
            this.btnLAN.TabIndex = 4;
            this.btnLAN.Text = "CONNECT";
            this.btnLAN.UseVisualStyleBackColor = true;
            // 
            // pctbMark
            // 
            this.pctbMark.Location = new System.Drawing.Point(126, 3);
            this.pctbMark.Name = "pctbMark";
            this.pctbMark.Size = new System.Drawing.Size(121, 102);
            this.pctbMark.TabIndex = 3;
            this.pctbMark.TabStop = false;
            // 
            // prcbCoolDown
            // 
            this.prcbCoolDown.Location = new System.Drawing.Point(3, 28);
            this.prcbCoolDown.Name = "prcbCoolDown";
            this.prcbCoolDown.Size = new System.Drawing.Size(100, 23);
            this.prcbCoolDown.TabIndex = 1;
            // 
            // txbPlayerName
            // 
            this.txbPlayerName.Location = new System.Drawing.Point(3, 0);
            this.txbPlayerName.Name = "txbPlayerName";
            this.txbPlayerName.Size = new System.Drawing.Size(103, 22);
            this.txbPlayerName.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pctbLoGo);
            this.panel2.Location = new System.Drawing.Point(814, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 200);
            this.panel2.TabIndex = 1;
            // 
            // pctbLoGo
            // 
            this.pctbLoGo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctbLoGo.Image = global::GameCaro.Properties.Resources.LogoGTVT;
            this.pctbLoGo.Location = new System.Drawing.Point(0, 3);
            this.pctbLoGo.Name = "pctbLoGo";
            this.pctbLoGo.Size = new System.Drawing.Size(244, 194);
            this.pctbLoGo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbLoGo.TabIndex = 0;
            this.pctbLoGo.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1076, 30);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.undoToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 26);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.newGameToolStripMenuItem.Text = "New game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click_1);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.undoToolStripMenuItem.Text = "Undo";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.quitToolStripMenuItem.Text = "Quit";
=======
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // btnLAN
            // 
            this.btnLAN.Location = new System.Drawing.Point(36, 150);
            this.btnLAN.Name = "btnLAN";
            this.btnLAN.Size = new System.Drawing.Size(75, 23);
            this.btnLAN.TabIndex = 4;
            this.btnLAN.Text = "LAN";
            this.btnLAN.UseVisualStyleBackColor = true;
            // 
            // tbIP
            // 
            this.tbIP.Location = new System.Drawing.Point(20, 103);
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(100, 22);
            this.tbIP.TabIndex = 3;
            this.tbIP.Text = "127.0.0.1";
            this.tbIP.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // playerName
            // 
            this.playerName.Location = new System.Drawing.Point(20, 39);
            this.playerName.Name = "playerName";
            this.playerName.ReadOnly = true;
            this.playerName.Size = new System.Drawing.Size(100, 22);
            this.playerName.TabIndex = 0;
            this.playerName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // picMark
            // 
            this.picMark.Location = new System.Drawing.Point(136, 26);
            this.picMark.Name = "picMark";
            this.picMark.Size = new System.Drawing.Size(100, 99);
            this.picMark.TabIndex = 2;
            this.picMark.TabStop = false;
            // 
            // coolDown
            // 
            this.coolDown.Location = new System.Drawing.Point(20, 67);
            this.coolDown.Name = "coolDown";
            this.coolDown.Size = new System.Drawing.Size(100, 23);
            this.coolDown.TabIndex = 1;
            // 
            // logouth
            // 
            this.logouth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logouth.Controls.Add(this.picturelogouth);
            this.logouth.Location = new System.Drawing.Point(777, 12);
            this.logouth.Name = "logouth";
            this.logouth.Size = new System.Drawing.Size(287, 140);
            this.logouth.TabIndex = 1;
            // 
            // picturelogouth
            // 
            this.picturelogouth.BackgroundImage = global::GameCaro.Properties.Resources.LogoGTVT;
            this.picturelogouth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picturelogouth.Location = new System.Drawing.Point(0, 3);
            this.picturelogouth.Name = "picturelogouth";
            this.picturelogouth.Size = new System.Drawing.Size(284, 137);
            this.picturelogouth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturelogouth.TabIndex = 0;
            this.picturelogouth.TabStop = false;
            this.picturelogouth.Click += new System.EventHandler(this.picturelogouth_Click);
>>>>>>> 8713793272f8aa5ea872973e7f0c26d73427e4e7
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 672);
            this.Controls.Add(this.panel3);
<<<<<<< HEAD
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlChessBoard);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbMark)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctbLoGo)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
=======
            this.Controls.Add(this.logouth);
            this.Controls.Add(this.chessboard);
            this.Name = "Form1";
            this.Text = "Game Caro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMark)).EndInit();
            this.logouth.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picturelogouth)).EndInit();
>>>>>>> 8713793272f8aa5ea872973e7f0c26d73427e4e7
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

<<<<<<< HEAD
        private System.Windows.Forms.Panel pnlChessBoard;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ProgressBar prcbCoolDown;
        private System.Windows.Forms.TextBox txbPlayerName;
        private System.Windows.Forms.PictureBox pctbMark;
        private System.Windows.Forms.PictureBox pctbLoGo;
        private System.Windows.Forms.Button btnLAN;
        private System.Windows.Forms.TextBox txbIP;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.Timer tmCoolDown;
=======
        private System.Windows.Forms.Panel chessboard;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel logouth;
        private System.Windows.Forms.ProgressBar coolDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLAN;
        private System.Windows.Forms.TextBox tbIP;
        private System.Windows.Forms.TextBox playerName;
        private System.Windows.Forms.PictureBox picMark;
        private System.Windows.Forms.PictureBox picturelogouth;
>>>>>>> 8713793272f8aa5ea872973e7f0c26d73427e4e7
    }
}

