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
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(287, 491);
            this.panel3.TabIndex = 2;
            // 
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
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 672);
            this.Controls.Add(this.panel3);
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
            this.ResumeLayout(false);

        }

        #endregion

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
    }
}

