using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json.Linq;
using System.ComponentModel;
using System.Drawing;
//using System.Threading;
//using System.Collections.Generic;
//using System.Data;
//using System.Linq;

namespace Battleship_online
{
    public partial class Game : Form
    {
        string[] userInfo = new string[2], rivalInfo;
        JArray online_users = new JArray();
        public int[,] fieldPaper, rivalFieldPaper = new int[10, 10];
        public Panel rivalPanel = new Panel(), waitPanel;
        public PictureBox rivalField = new PictureBox();
        public Label rivalLogin = new Label(), rivalCountOfWins = new Label();
        public Timer gameTimer, waitTimer, generalTimer;
        public int curCountOfCubs = 0, countOfCubs = 20, timer = 60, gameId, stepNumber = 1;
        public bool stepPriority = false;
        public int[] myStep;
        public Game()
        {
            InitializeComponent();

            Initialisator.startInit(myPanel, roolsPanel, complete, onlineUsers, waiters, chat, message, send, password_tb, timerLabel, priority);

            if (File.Exists("cookie.bin"))
            {
                StreamReader reader = new StreamReader("cookie.bin");
                login_tb.Text = reader.ReadLine();
                userInfo[0] = login_tb.Text;
                password_tb.Text = reader.ReadLine();
                userInfo[1] = password_tb.Text;
                reader.Dispose();
            }

            fieldPaper = new int[10, 10];
            /*ContextMenuStrip contextMenuOnlineUsers = new ContextMenuStrip();
            contextMenuOnlineUsers.Opening += contextMenuOnlineUsers_Opening;
            ToolStripMenuItem offerToPlay = new ToolStripMenuItem("Предложить сыграть");
            offerToPlay.Click += offerToPlay_Click;
            offerToPlay.BackColor = Color.Black;
            offerToPlay.ForeColor = Color.White;
            contextMenuOnlineUsers.Items.Add(offerToPlay);
            waiters.ContextMenuStrip = contextMenuOnlineUsers;*/
        }

        void gameTimer_Tick(object sender, EventArgs e)
        {
            if (timer > 0)
            {
                if (!stepPriority)//если мы походили
                {
                    if (myStep != null)//если мы только что походили
                    {
                        int status = Connection.getStepStatus(stepNumber, gameId);//узнаем статус нашего попадания
                        if (status != 0)
                        {
                            rivalFieldPaper[myStep[0], myStep[1]] = status;
                            if (status == 2) //если мы не попали
                            {
                                rivalField.Enabled = false; //даём походить противнику
                            }  
                            int countOfKilledShips = Connection.getCountOfKilledShips(userInfo[0], gameId);
                            if (countOfKilledShips == countOfCubs) // если мы выйграли
                            {
                                Connection.setUserWin(userInfo[0]);
                                MessageBox.Show("Поздравляем! Вы выйграли!", "Победа", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                this.Controls.Remove(rivalPanel);
                                roolsPanel.Visible = true;
                                fieldPaper = new int[10, 10];
                                field.Refresh();
                                userInfo[1] = (int.Parse(userInfo[1]) + 1).ToString();
                                infoCountOfWins.Text = "Побед: " + userInfo[1];
                                gameTimer.Stop();
                                timerLabel.Visible = false;
                                priority.Visible = false;
                            }
                            else
                            {
                                stepPriority = true; //ходим снова
                                Initialisator.priorityLabelInit(priority, stepPriority);
                                stepNumber++;
                                timer = 60;
                                myStep = null;
                                rivalField.Refresh();
                            }
                        }
                    }
                    else // если была не наша очередь и мы ждем хода противника
                    {
                        int[] rivalStep = Connection.getLastStep(stepNumber, gameId);
                        if (rivalStep != null)
                        {
                            if (fieldPaper[rivalStep[0], rivalStep[1]] == 1)//если у нас тут корабль
                            {
                                Connection.setStepStatus(stepNumber, gameId, 3);//сообщить противнику, что он попал
                                fieldPaper[rivalStep[0], rivalStep[1]] = 3;
                            }
                            else
                            {
                                Connection.setStepStatus(stepNumber, gameId, 2);//сообщить противнику, что он промазал
                                fieldPaper[rivalStep[0], rivalStep[1]] = 2;
                                rivalField.Enabled = true;
                                stepPriority = true;
                                Initialisator.priorityLabelInit(priority, stepPriority);
                            }
                            int countOfKilledShips = Connection.getCountOfKilledShips(rivalInfo[0], gameId);
                            if (countOfKilledShips == countOfCubs) // если противник выйграл
                            {
                                Connection.setUserLouse(userInfo[0]);
                                MessageBox.Show("Увы! Вы проиграли!", "Поражение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                this.Controls.Remove(rivalPanel);
                                roolsPanel.Visible = true;
                                fieldPaper = new int[10, 10];
                                field.Refresh();
                                userInfo[1] = (int.Parse(userInfo[1]) - 1).ToString();
                                infoCountOfWins.Text = "Побед: " + userInfo[1];
                                gameTimer.Stop();
                                timerLabel.Visible = false;
                                priority.Visible = false;
                            }
                            else
                            {
                                stepNumber++;
                                timer = 60;
                                field.Refresh();
                            }
                        }
                    }
                }
            }
            else
            {
                if (stepPriority)//если мы не походили
                {
                    Connection.setUserLouse(userInfo[0]);
                    MessageBox.Show("Нужно следить за временем!", "Техническое поражение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else // если не походил противник, тут 2 случая: или противник просто замешкался, либо он отключился....
                {
                    string timediff = Connection.getLastActivity(rivalInfo[0], DateTime.Now.ToString("HH:mm:ss"));
                    string[] timearray = timediff.Split(':');
                    if (int.Parse(timearray[0]) > 0 || int.Parse(timearray[1]) > 0 || int.Parse(timearray[2]) > 30) Connection.setUserLouse(userInfo[0]);
                        //если юзер вылетел, то поражение сам себе он уже не поставит,... делаем это за него
                    Connection.setUserWin(userInfo[0]);
                    MessageBox.Show("Вы выйграли!", "Техническая победа", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Controls.Remove(rivalPanel);
                roolsPanel.Visible = true;
                fieldPaper = new int[10, 10];
                field.Refresh();
                userInfo[1] = (int.Parse(userInfo[1]) - 1).ToString();
                infoCountOfWins.Text = "Побед: " + userInfo[1];
                gameTimer.Stop();
                timerLabel.Visible = false;
                priority.Visible = false;
            }
            timer--;
            timerLabel.Text = "00:" + timer;

        }

        void generalTimer_Tick(object sender, EventArgs e)
        {
            /*долбим сервер каждые 2 секунды для обновления инфы на форме*/
            online_users = Connection.getOnlineUsers(userInfo[0]);
            onlineUsers.Items.Clear();
            foreach (dynamic jobj in online_users) onlineUsers.Items.Add(jobj.login + " / " + jobj.countOfWins);
            bool reload = false;
            string messages = Connection.getMessages(userInfo[0]);
            if (messages != null)
            {
                try
                {
                    foreach (dynamic jobj in JArray.Parse(messages))
                    {
                        reload = false;
                        foreach (string item in chat.Items)
                        {
                            if (item.CompareTo("Приватное от [" + jobj.userFrom + "]: " + jobj.message) == 0 || item.CompareTo("[" + jobj.userFrom + "]: " + jobj.message) == 0)
                            {
                                reload = true;
                                break;
                            }
                        }
                        if (reload) continue;
                        if (("all").CompareTo((string)jobj.userTo) != 0) chat.Items.Add("Приватное от [" + jobj.userFrom + "]: " + jobj.message);
                        else chat.Items.Add("[" + jobj.userFrom + "]: " + jobj.message);
                    }
                }
                catch
                {
                    reload = false;
                    dynamic jobj = JObject.Parse(messages);
                    foreach (string item in chat.Items)
                    {
                        if (item.CompareTo("Приватное от [" + jobj.userFrom + "]: " + jobj.message) == 0 || item.CompareTo("[" + jobj.userFrom + "]: " + jobj.message) == 0)
                        {
                            reload = true;
                            break;
                        }
                    }
                    if (!reload)
                    {
                        if (("all").CompareTo((string)jobj.userTo) != 0) chat.Items.Add("Приватное от [" + jobj.userFrom + "]: " + jobj.message);
                        else chat.Items.Add("[" + jobj.userFrom + "]: " + jobj.message);
                    }
                } 
            }
            Connection.setLastActivity(userInfo[0], DateTime.Now.ToString("HH:mm:ss"));
        }

        /*void offerToPlay_Click(object sender, EventArgs e)
        {
            Connection.sendMessage(result[0], waiters.SelectedItem.ToString(), "offerToPlay");
        }
        private void contextMenuOnlineUsers_Opening(object sender, CancelEventArgs e)
        {
            if (waiters.SelectedItems.Count == 0)
            {
                e.Cancel = true;
            }
        }*/

        private void home_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Connection.exit(userInfo[0]);
                generalTimer.Stop();
                waitTimer.Stop();
                gameTimer.Stop();
            }
            catch
            {
                
            }
        }

        private void field_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i <= ((PictureBox)sender).Width / 30; i++)
            {
                for (int j = 0; j <= ((PictureBox)sender).Height / 30; j++)
                {
                    e.Graphics.DrawLine(new Pen(Brushes.Red, 1), new Point(30 * i, 0), new Point(30 * i, 30 * j));
                    e.Graphics.DrawLine(new Pen(Brushes.Red, 1), new Point(0, 30 * j), new Point(30 * i, 30 * j));
                }
            }

            int[,] thisMass;
            if (((PictureBox)sender).Name.CompareTo("rivalField") == 0) thisMass = rivalFieldPaper;
            else thisMass = fieldPaper;

            for (int i = 0; i < 10; ++i)
            {
                for (int j = 0; j < 10; ++j)
                {
                    switch (thisMass[i, j])
                    {
                        case 1: //корабли
                            {
                                e.Graphics.FillRectangle(Brushes.White, i * 30 + 1, j * 30 + 1, 29, 29);
                            } break;

                        case 2: //снаряд мимо
                            {
                                e.Graphics.FillRectangle(Brushes.Gray, i * 30 + 1, j * 30 + 1, 29, 29);
                            } break;

                        case 3: //снаряд попал
                            {
                                e.Graphics.FillRectangle(Brushes.OrangeRed, i * 30 + 1, j * 30 + 1, 29, 29);
                            } break;
                        default: break;
                    }
                }
            }
        }

        private void play_Click(object sender, EventArgs e)
        {
            UserInformationComparator uifConparator = new UserInformationComparator(login_tb.Text, password_tb.Text);
            try
            {
                uifConparator.compare();
            }
            catch(Exception exp)
            {
                issueLabel.Text = exp.Message;
                issueLabel.Visible = true;
            }

            userInfo = Connection.signup(login_tb.Text, password_tb.Text);
            if (userInfo[0].CompareTo(login_tb.Text) != 0)
            {
                issueLabel.Text = userInfo[0];
                issueLabel.Visible = true;
            }
            else
            {
                if (remember.Checked)
                {
                    StreamWriter writer = new StreamWriter("cookie.bin");
                    writer.WriteLine(login_tb.Text);
                    writer.WriteLine(password_tb.Text);
                    writer.Dispose();
                }
                userLogin.Text = "Пользователь: " + userInfo[0];
                infoCountOfWins.Text = "Побед: " + userInfo[1];
                Initialisator.initAfterEntering(myPanel, roolsPanel, onlineUsers, waiters, chat, message, send);
                this.Controls.Remove(enter_panel);
                generalTimer = new Timer();
                generalTimer.Interval = 2000;
                generalTimer.Tick += generalTimer_Tick;
                generalTimer.Start();
            }
        }

        private void field_MouseClick(object sender, MouseEventArgs e)
        {
            int x = (e.X - e.X % 30) / 30, y = (e.Y - e.Y % 30) / 30;
            if (fieldPaper[x, y] == 0)
            {
                if (curCountOfCubs == countOfCubs) return;
                fieldPaper[x, y] = 1;
                curCountOfCubs++;
            }
            else
            {
                fieldPaper[x, y] = 0;
                curCountOfCubs--;
            }
            if (curCountOfCubs == countOfCubs) complete.Enabled = true;
            else complete.Enabled = false;
            field.Refresh();
        }

        private void complete_Click(object sender, EventArgs e)
        {
            ShipsObserver shipsObserver = new ShipsObserver(fieldPaper);
            try
            {
                shipsObserver.observe();
                roolsPanel.Visible = false;
                field.Enabled = false;
                waitTimer = new Timer();
                waitTimer.Interval = 1000;
                waitTimer.Tick += waitTimer_Tick;
                waitPanel = Initialisator.waitPanelInit();
                this.Controls.Add(waitPanel);
                waitTimer.Start();
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void waitTimer_Tick(object sender, EventArgs e)
        {
            //долбим сервер в ожидании противника
            string response = Connection.setUserWait(userInfo[0]);
            if (response.CompareTo("OK") != 0 && response.CompareTo("AGAIN") != 0 && response.CompareTo("ERROR") != 0)
            {
                rivalInfo = new string[2];
                dynamic jsonObj = JObject.Parse(response);
                if (jsonObj.firstPlayer == null)
                {
                    rivalInfo[0] = jsonObj.secondPlayer;
                    rivalInfo[1] = Initialisator.getCountOfWinsIntoJArray(online_users, (string)jsonObj.secondPlayer);
                    stepPriority = true;
                }
                else
                {
                    rivalInfo[0] = jsonObj.firstPlayer;
                    rivalInfo[1] = rivalCountOfWins.Text += Initialisator.getCountOfWinsIntoJArray(online_users, (string)jsonObj.firstPlayer);
                    stepPriority = false;
                }
                this.Controls.Remove(waitPanel);
                Initialisator.rivalPanelInit(rivalPanel, rivalField, rivalLogin, rivalCountOfWins);
                Initialisator.priorityLabelInit(priority, stepPriority);
                this.Controls.Add(rivalPanel);
                timerLabel.Visible = true;
                rivalField.Paint += field_Paint;
                rivalField.MouseClick += rivalField_MouseClick;
                rivalField.Enabled = stepPriority;
                gameId = jsonObj.id;
                gameTimer = new Timer();
                gameTimer.Interval = 1000;
                gameTimer.Tick += gameTimer_Tick;
                gameTimer.Start();
                waitTimer.Stop();
            }
        }

        private void clearAll_Click(object sender, EventArgs e)
        {
            fieldPaper = new int[10, 10];
            curCountOfCubs = 0;
            field.Refresh();
        }
        private void send_Click(object sender, EventArgs e)
        {
            if (message.Text == "") return;
            string regexp = "^([0-9a-zA-Zа-яА-Я-_]*):(.*)$";
            if (Regex.IsMatch(message.Text, regexp))
            {
                MatchCollection collection = Regex.Matches(message.Text, regexp);
                Connection.sendMessage(userInfo[0], collection[0].Groups[1].Value, collection[0].Groups[2].Value);
            }
            else Connection.sendMessage(userInfo[0], "all", message.Text);
            message.Text = "";
        }
        private void rivalField_MouseClick(object sender, MouseEventArgs e)
        {
            if (rivalFieldPaper[(e.X - e.X % 30) / 30, (e.Y - e.Y % 30) / 30] == 2 || rivalFieldPaper[(e.X - e.X % 30) / 30, (e.Y - e.Y % 30) / 30] == 3) return;
            myStep = new int[2];
            myStep[0] = (e.X - e.X % 30) / 30;
            myStep[1] = (e.Y - e.Y % 30) / 30;
            //долбим сервер
            Connection.step(userInfo[0], stepNumber, gameId, myStep[0], myStep[1]);
            stepPriority = false;
        }
        private void randomShipsArrangement_Click(object sender, EventArgs e)
        {

        }
    }
}