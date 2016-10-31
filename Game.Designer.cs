namespace Battleship_online
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.field = new System.Windows.Forms.PictureBox();
            this.enter_panel = new System.Windows.Forms.Panel();
            this.issueLabel = new System.Windows.Forms.Label();
            this.play = new System.Windows.Forms.Button();
            this.remember = new System.Windows.Forms.CheckBox();
            this.password_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.login_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.userLogin = new System.Windows.Forms.Label();
            this.infoCountOfWins = new System.Windows.Forms.Label();
            this.myPanel = new System.Windows.Forms.Panel();
            this.roolsPanel = new System.Windows.Forms.Panel();
            this.clearAll = new System.Windows.Forms.Button();
            this.complete = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.onlineUsers = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chat = new System.Windows.Forms.ListBox();
            this.message = new System.Windows.Forms.TextBox();
            this.send = new System.Windows.Forms.Button();
            this.waiters = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.timerLabel = new System.Windows.Forms.Label();
            this.priority = new System.Windows.Forms.Label();
            this.randomShipsArrangement = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.field)).BeginInit();
            this.enter_panel.SuspendLayout();
            this.myPanel.SuspendLayout();
            this.roolsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // field
            // 
            this.field.BackColor = System.Drawing.Color.Transparent;
            this.field.Location = new System.Drawing.Point(23, 88);
            this.field.Name = "field";
            this.field.Size = new System.Drawing.Size(301, 301);
            this.field.TabIndex = 0;
            this.field.TabStop = false;
            this.field.Paint += new System.Windows.Forms.PaintEventHandler(this.field_Paint);
            this.field.MouseClick += new System.Windows.Forms.MouseEventHandler(this.field_MouseClick);
            // 
            // enter_panel
            // 
            this.enter_panel.BackColor = System.Drawing.Color.Transparent;
            this.enter_panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("enter_panel.BackgroundImage")));
            this.enter_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.enter_panel.Controls.Add(this.issueLabel);
            this.enter_panel.Controls.Add(this.play);
            this.enter_panel.Controls.Add(this.remember);
            this.enter_panel.Controls.Add(this.password_tb);
            this.enter_panel.Controls.Add(this.label2);
            this.enter_panel.Controls.Add(this.login_tb);
            this.enter_panel.Controls.Add(this.label1);
            this.enter_panel.Location = new System.Drawing.Point(384, 104);
            this.enter_panel.Name = "enter_panel";
            this.enter_panel.Size = new System.Drawing.Size(334, 191);
            this.enter_panel.TabIndex = 2;
            // 
            // issueLabel
            // 
            this.issueLabel.AutoSize = true;
            this.issueLabel.BackColor = System.Drawing.Color.Red;
            this.issueLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.issueLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.issueLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.issueLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.issueLabel.Location = new System.Drawing.Point(0, 0);
            this.issueLabel.MaximumSize = new System.Drawing.Size(340, 0);
            this.issueLabel.MinimumSize = new System.Drawing.Size(334, 0);
            this.issueLabel.Name = "issueLabel";
            this.issueLabel.Size = new System.Drawing.Size(334, 42);
            this.issueLabel.TabIndex = 6;
            this.issueLabel.Text = "Здесь будут располагаться исключения, и мне по**й, какая там длина";
            this.issueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.issueLabel.Visible = false;
            // 
            // play
            // 
            this.play.BackColor = System.Drawing.Color.DarkOrange;
            this.play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.play.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.play.Location = new System.Drawing.Point(16, 137);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(304, 38);
            this.play.TabIndex = 5;
            this.play.Text = "Играть!";
            this.play.UseVisualStyleBackColor = false;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // remember
            // 
            this.remember.AutoSize = true;
            this.remember.BackColor = System.Drawing.Color.Black;
            this.remember.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("remember.BackgroundImage")));
            this.remember.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.remember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.remember.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.remember.ForeColor = System.Drawing.Color.Yellow;
            this.remember.Location = new System.Drawing.Point(85, 105);
            this.remember.Name = "remember";
            this.remember.Size = new System.Drawing.Size(235, 23);
            this.remember.TabIndex = 4;
            this.remember.Text = "Запомнить и не выходить";
            this.remember.UseVisualStyleBackColor = false;
            // 
            // password_tb
            // 
            this.password_tb.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password_tb.Location = new System.Drawing.Point(166, 77);
            this.password_tb.Name = "password_tb";
            this.password_tb.Size = new System.Drawing.Size(124, 23);
            this.password_tb.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(42, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пароль:";
            // 
            // login_tb
            // 
            this.login_tb.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_tb.Location = new System.Drawing.Point(166, 48);
            this.login_tb.Name = "login_tb";
            this.login_tb.Size = new System.Drawing.Size(124, 23);
            this.login_tb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(57, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин:";
            // 
            // userLogin
            // 
            this.userLogin.AutoSize = true;
            this.userLogin.BackColor = System.Drawing.Color.Transparent;
            this.userLogin.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userLogin.Location = new System.Drawing.Point(29, 13);
            this.userLogin.Name = "userLogin";
            this.userLogin.Size = new System.Drawing.Size(146, 23);
            this.userLogin.TabIndex = 5;
            this.userLogin.Text = "Пользователь:";
            // 
            // infoCountOfWins
            // 
            this.infoCountOfWins.AutoSize = true;
            this.infoCountOfWins.BackColor = System.Drawing.Color.Transparent;
            this.infoCountOfWins.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoCountOfWins.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.infoCountOfWins.Location = new System.Drawing.Point(29, 44);
            this.infoCountOfWins.Name = "infoCountOfWins";
            this.infoCountOfWins.Size = new System.Drawing.Size(76, 23);
            this.infoCountOfWins.TabIndex = 6;
            this.infoCountOfWins.Text = "Побед:";
            // 
            // myPanel
            // 
            this.myPanel.BackColor = System.Drawing.Color.Transparent;
            this.myPanel.Controls.Add(this.field);
            this.myPanel.Controls.Add(this.infoCountOfWins);
            this.myPanel.Controls.Add(this.userLogin);
            this.myPanel.Location = new System.Drawing.Point(0, 0);
            this.myPanel.Name = "myPanel";
            this.myPanel.Size = new System.Drawing.Size(350, 406);
            this.myPanel.TabIndex = 7;
            // 
            // roolsPanel
            // 
            this.roolsPanel.BackColor = System.Drawing.Color.Transparent;
            this.roolsPanel.Controls.Add(this.randomShipsArrangement);
            this.roolsPanel.Controls.Add(this.clearAll);
            this.roolsPanel.Controls.Add(this.complete);
            this.roolsPanel.Controls.Add(this.label5);
            this.roolsPanel.Location = new System.Drawing.Point(431, 13);
            this.roolsPanel.Name = "roolsPanel";
            this.roolsPanel.Size = new System.Drawing.Size(259, 384);
            this.roolsPanel.TabIndex = 9;
            // 
            // clearAll
            // 
            this.clearAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.clearAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearAll.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearAll.Location = new System.Drawing.Point(43, 324);
            this.clearAll.Name = "clearAll";
            this.clearAll.Size = new System.Drawing.Size(160, 30);
            this.clearAll.TabIndex = 11;
            this.clearAll.Text = "Очистить поле";
            this.clearAll.UseVisualStyleBackColor = false;
            this.clearAll.Click += new System.EventHandler(this.clearAll_Click);
            // 
            // complete
            // 
            this.complete.BackColor = System.Drawing.Color.Lime;
            this.complete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.complete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.complete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.complete.Location = new System.Drawing.Point(122, 288);
            this.complete.Name = "complete";
            this.complete.Size = new System.Drawing.Size(81, 30);
            this.complete.TabIndex = 10;
            this.complete.Text = "Готово";
            this.complete.UseVisualStyleBackColor = false;
            this.complete.Click += new System.EventHandler(this.complete_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(14, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(242, 266);
            this.label5.TabIndex = 0;
            this.label5.Text = resources.GetString("label5.Text");
            // 
            // onlineUsers
            // 
            this.onlineUsers.BackColor = System.Drawing.SystemColors.WindowText;
            this.onlineUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.onlineUsers.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.onlineUsers.ForeColor = System.Drawing.SystemColors.Window;
            this.onlineUsers.FormattingEnabled = true;
            this.onlineUsers.ItemHeight = 16;
            this.onlineUsers.Items.AddRange(new object[] {
            "Vasya",
            "kometa",
            "pizduke"});
            this.onlineUsers.Location = new System.Drawing.Point(757, 35);
            this.onlineUsers.Name = "onlineUsers";
            this.onlineUsers.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.onlineUsers.Size = new System.Drawing.Size(192, 240);
            this.onlineUsers.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(816, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "В сети";
            // 
            // chat
            // 
            this.chat.BackColor = System.Drawing.SystemColors.InfoText;
            this.chat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chat.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chat.ForeColor = System.Drawing.SystemColors.Window;
            this.chat.FormattingEnabled = true;
            this.chat.ItemHeight = 16;
            this.chat.Location = new System.Drawing.Point(12, 412);
            this.chat.Name = "chat";
            this.chat.Size = new System.Drawing.Size(738, 96);
            this.chat.TabIndex = 12;
            // 
            // message
            // 
            this.message.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.message.Location = new System.Drawing.Point(12, 513);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(622, 27);
            this.message.TabIndex = 13;
            // 
            // send
            // 
            this.send.BackColor = System.Drawing.SystemColors.HotTrack;
            this.send.Cursor = System.Windows.Forms.Cursors.Hand;
            this.send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.send.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.send.ForeColor = System.Drawing.SystemColors.ControlText;
            this.send.Location = new System.Drawing.Point(640, 513);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(110, 27);
            this.send.TabIndex = 14;
            this.send.Text = "Отправить";
            this.send.UseVisualStyleBackColor = false;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // waiters
            // 
            this.waiters.BackColor = System.Drawing.SystemColors.WindowText;
            this.waiters.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.waiters.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.waiters.ForeColor = System.Drawing.SystemColors.Window;
            this.waiters.FormattingEnabled = true;
            this.waiters.ItemHeight = 16;
            this.waiters.Items.AddRange(new object[] {
            "Vasya",
            "kometa",
            "pizduke"});
            this.waiters.Location = new System.Drawing.Point(757, 301);
            this.waiters.Name = "waiters";
            this.waiters.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.waiters.Size = new System.Drawing.Size(192, 240);
            this.waiters.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(754, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "Ожидают начала игры";
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.BackColor = System.Drawing.Color.Transparent;
            this.timerLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timerLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.timerLabel.Location = new System.Drawing.Point(351, 13);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(49, 19);
            this.timerLabel.TabIndex = 17;
            this.timerLabel.Text = "00:59";
            // 
            // priority
            // 
            this.priority.AutoSize = true;
            this.priority.BackColor = System.Drawing.Color.Transparent;
            this.priority.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priority.ForeColor = System.Drawing.Color.White;
            this.priority.Location = new System.Drawing.Point(351, 33);
            this.priority.MaximumSize = new System.Drawing.Size(50, 0);
            this.priority.MinimumSize = new System.Drawing.Size(50, 0);
            this.priority.Name = "priority";
            this.priority.Size = new System.Drawing.Size(50, 36);
            this.priority.TabIndex = 18;
            this.priority.Text = "=>";
            // 
            // randomShipsArrangement
            // 
            this.randomShipsArrangement.BackColor = System.Drawing.Color.DodgerBlue;
            this.randomShipsArrangement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.randomShipsArrangement.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.randomShipsArrangement.Location = new System.Drawing.Point(43, 288);
            this.randomShipsArrangement.Name = "randomShipsArrangement";
            this.randomShipsArrangement.Size = new System.Drawing.Size(73, 30);
            this.randomShipsArrangement.TabIndex = 12;
            this.randomShipsArrangement.Text = "Рандом";
            this.randomShipsArrangement.UseVisualStyleBackColor = false;
            this.randomShipsArrangement.Click += new System.EventHandler(this.randomShipsArrangement_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(960, 544);
            this.Controls.Add(this.priority);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.enter_panel);
            this.Controls.Add(this.waiters);
            this.Controls.Add(this.send);
            this.Controls.Add(this.message);
            this.Controls.Add(this.chat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.onlineUsers);
            this.Controls.Add(this.myPanel);
            this.Controls.Add(this.roolsPanel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Battleship Online by Deamond";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.home_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.field)).EndInit();
            this.enter_panel.ResumeLayout(false);
            this.enter_panel.PerformLayout();
            this.myPanel.ResumeLayout(false);
            this.myPanel.PerformLayout();
            this.roolsPanel.ResumeLayout(false);
            this.roolsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox field;
        private System.Windows.Forms.Panel enter_panel;
        private System.Windows.Forms.Label issueLabel;
        private System.Windows.Forms.Button play;
        private System.Windows.Forms.CheckBox remember;
        private System.Windows.Forms.TextBox password_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox login_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label userLogin;
        private System.Windows.Forms.Label infoCountOfWins;
        private System.Windows.Forms.Panel myPanel;
        private System.Windows.Forms.Panel roolsPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button complete;
        private System.Windows.Forms.Button clearAll;
        private System.Windows.Forms.ListBox onlineUsers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox chat;
        private System.Windows.Forms.TextBox message;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.ListBox waiters;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Label priority;
        private System.Windows.Forms.Button randomShipsArrangement;

    }
}