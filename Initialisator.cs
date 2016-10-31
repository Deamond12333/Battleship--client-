using System;
using System.Drawing;
using System.Windows.Forms;
using Battleship_online.Properties;
//using System.ComponentModel;
//using System.IO;
//using System.Collections.Generic;
//using System.Text;
//using System.Net;
using Newtonsoft.Json.Linq;
//using System.Data;
//using System.Linq;
//using System.Threading;

namespace Battleship_online
{
    static class Initialisator
    {
        public static void rivalPanelInit(Panel rivalPanel, PictureBox rivalField, Label rivalLogin, Label rivalCountOfWins)
        {
            // 
            // rivalLogin
            // 
            rivalLogin.AutoSize = true;
            rivalLogin.BackColor = System.Drawing.Color.Transparent;
            rivalLogin.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            rivalLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            rivalLogin.Location = new System.Drawing.Point(29, 13);
            rivalLogin.Name = "rivalLogin";
            rivalLogin.Size = new System.Drawing.Size(146, 23);
            rivalLogin.TabIndex = 5;
            rivalLogin.Text = "Противник: ";
            // 
            // rivalCountOfWins
            // 
            rivalCountOfWins.AutoSize = true;
            rivalCountOfWins.BackColor = System.Drawing.Color.Transparent;
            rivalCountOfWins.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            rivalCountOfWins.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            rivalCountOfWins.Location = new System.Drawing.Point(29, 44);
            rivalCountOfWins.Name = "rivalCountOfWins";
            rivalCountOfWins.Size = new System.Drawing.Size(76, 23);
            rivalCountOfWins.TabIndex = 6;
            rivalCountOfWins.Text = "Побед: ";
            // 
            // rivalField
            // 
            rivalField.BackColor = System.Drawing.Color.Transparent;
            rivalField.Location = new System.Drawing.Point(23, 88);
            rivalField.Name = "rivalField";
            rivalField.Size = new System.Drawing.Size(301, 301);
            rivalField.TabIndex = 24;
            rivalField.TabStop = false;
            // 
            // rivalPanel
            // 
            rivalPanel.BackColor = System.Drawing.Color.Transparent;
            rivalPanel.Controls.Add(rivalField);
            rivalPanel.Controls.Add(rivalCountOfWins);
            rivalPanel.Controls.Add(rivalLogin);
            rivalPanel.Location = new System.Drawing.Point(400, 0);
            rivalPanel.Name = "rivalPanel";
            rivalPanel.Size = new System.Drawing.Size(350, 406);
            rivalPanel.TabIndex = 25;

            rivalPanel.Visible = true;
            rivalPanel.Enabled = true;
        }
        public static Panel waitPanelInit()
        {
            // 
            // animation
            // 
            PictureBox animation = new PictureBox();
            animation.Image = Resources.download;
            animation.Location = new System.Drawing.Point(23, 88);
            animation.Name = "animation";
            animation.Size = new System.Drawing.Size(301, 301);
            animation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            animation.TabIndex = 0;
            animation.TabStop = false;
            // 
            // waitLabel
            // 
            Label waitLabel = new Label();
            waitLabel.AutoSize = true;
            waitLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            waitLabel.ForeColor = System.Drawing.Color.White;
            waitLabel.Location = new System.Drawing.Point(58, 35);
            waitLabel.Name = "waitLabel";
            waitLabel.Size = new System.Drawing.Size(236, 23);
            waitLabel.TabIndex = 1;
            waitLabel.Text = "Ожидаем противника...";
            // 
            // waitPanel
            // 
            Panel waitPanel = new Panel();
            waitPanel.BackColor = System.Drawing.Color.Transparent;
            waitPanel.Controls.Add(animation);
            waitPanel.Controls.Add(waitLabel);
            waitPanel.Location = new System.Drawing.Point(400, 0);
            waitPanel.Name = "waitPanel";
            waitPanel.Size = new System.Drawing.Size(350, 406);
            waitPanel.TabIndex = 1;

            return waitPanel;
        }
        public static void startInit(Panel myPanel, Panel roolsPanel, Button complete, ListBox onlineUsers, ListBox waiters, ListBox chat, TextBox message, Button send, TextBox password_tb, Label timerLabel, Label priority)
        {
            myPanel.Enabled = false;
            roolsPanel.Visible = false;
            complete.Enabled = false;
            onlineUsers.Enabled = false;
            onlineUsers.Items.Clear();
            waiters.Enabled = false;
            waiters.Items.Clear();
            chat.Enabled = false;
            message.Enabled = false;
            send.Enabled = false;
            timerLabel.Visible = false;
            password_tb.PasswordChar = '*';
            priority.Visible = false;
        }
        public static void initAfterEntering(Panel myPanel, Panel roolsPanel, ListBox onlineUsers, ListBox waiters, ListBox chat, TextBox message, Button send)
        {
            myPanel.Enabled = true;
            roolsPanel.Visible = true;
            onlineUsers.Enabled = true;
            waiters.Enabled = true;
            chat.Enabled = true;
            message.Enabled = true;
            send.Enabled = true;
        }
        public static string getCountOfWinsIntoJArray(JArray jar, string pattern)
        {
            foreach(dynamic jobj in jar)
            {
                if (pattern.CompareTo((string)jobj.login) == 0) return (string)jobj.countOfWins;
            }
            return null;
        }
        public static void priorityLabelInit(Label priorityLabel, bool stepPriority)
        {
            priorityLabel.Visible = true;
            if (stepPriority)
            {
                priorityLabel.ForeColor = Color.Green;
                priorityLabel.Text = "<=";
            }
            else
            {
                priorityLabel.ForeColor = Color.Yellow;
                priorityLabel.Text = "=>";
            }
        }
    }
}
