﻿using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OAnQuan
{
    public partial class Form1 : Form
    {
        public Game Game;

        private Button[] Board;
        private int distributeTimerCounter;
        private int finalCollecTimerCounter;
        private Color player1Color = Color.LightBlue;
        private Color player2Color = Color.MistyRose;

        private string[] playerNames;
        public Form1()
        {
            InitializeComponent();
            playerNames = new string[2] { "Bên Xanh", "Bên Đỏ" };
            Board = new Button[12] {button1, button2, button3, button4, button5, button6,
            button7, button8, button9, button10, button11, button12};
            SetGame(new Game() { CurrentPlayer = 1 });
            GameModelToUI();

            //label17.Text = GameAI.PredictBestMove(Game, 2) + "";
        }

        public void GameModelToUI()
        {
            if (Game == null)
                return;


            var v = Game.Players[0].SmallStones;
            label3.Text = SmallStonesToString(Math.Abs(v));
            label22.Text = (v < 0 ? "Nợ " : "") + Math.Abs(v).ToString();

            v = Game.Players[0].LargeStones;
            label5.Text = v > 0 ? "•" : "";
            label23.Text = v.ToString();
            label7.Text = Game.Players[0].Scores.ToString();

            v = Game.Players[1].SmallStones;
            label12.Text = SmallStonesToString(Math.Abs(v));
            label20.Text = (v < 0 ? "Nợ " : "") + Math.Abs(v).ToString();

            v = Game.Players[1].LargeStones;
            label13.Text = v > 0 ? "•" : "";
            label21.Text = v.ToString();
            label9.Text = Game.Players[1].Scores.ToString();

            v = Game.StonesInHand;
            label16.Text = SmallStonesToString(v) + " " + v.ToString();

            for (int i = 0; i < Board.Length; i++)
            {
                Board[i].Text = SmallStonesToString(Game.Board[i]);// StonesToString(Game.Board[i], '•');
            }

            Board[0].Text = Game.LargeStones[0] > 0 ? "•" : "" + Board[0].Text;
            Board[6].Text = Game.LargeStones[1] > 0 ? "•" : "" + Board[6].Text;

            if (Game.CurrentPlayer == 0)
            {
                tableLayoutPanel1.BackColor = player1Color;
                tableLayoutPanel2.BackColor = this.BackColor;
            }
            else
            {
                tableLayoutPanel1.BackColor = this.BackColor;
                tableLayoutPanel2.BackColor = player2Color;
            }

            label18.Text = playerNames[Game.CurrentPlayer] + " Đi";
            UpdateGameState();
            UpdateHighlightedCell();
        }

        public void SetGame(Game game)
        {
            Game = game;
        }

        public void UpdateHighlightedCell()
        {
            for (int i = 0; i < Board.Length; i++)
            {
                if (i == Game.SelectedCellIndex && !Game.IsPlayerMoving)
                {
                    if (Game.CurrentPlayer == 0)
                        Board[i].BackColor = player1Color;
                    else
                        Board[i].BackColor = player2Color;
                }
                else
                if (i == Game.CurrentCellIndex)
                {
                    if (Game.CurrentPlayer == 0)
                        Board[i].BackColor = player1Color;
                    else
                        Board[i].BackColor = player2Color;
                }
                else
                {
                    Board[i].BackColor = Color.White;
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Game.SelectCell(9);
            UpdateHighlightedCell();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Game.SelectCell(10);
            UpdateHighlightedCell();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Game.SelectCell(11);
            UpdateHighlightedCell();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (Game.State == Game.Status.OVER)
            {
                Game = new Game();
                GameModelToUI();
                return;
            }

            Game.BeginMove();
            timer1.Enabled = true;
            timer1.Start();
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            RefillNow();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Game.SelectCell(1);
            UpdateHighlightedCell();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Game.SelectCell(2);
            UpdateHighlightedCell();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Game.SelectCell(3);
            UpdateHighlightedCell();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Game.SelectCell(4);
            UpdateHighlightedCell();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Game.SelectCell(5);
            UpdateHighlightedCell();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Game.SelectCell(7);
            UpdateHighlightedCell();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Game.SelectCell(8);
            UpdateHighlightedCell();
        }

        private void RefillNow()
        {
            button14.Visible = false;
            Game.Refill(Game.CurrentPlayer);
            button13.Enabled = true;
            GameModelToUI();
        }

        //private string StonesToString(int numberOfStones, char symbol, bool addSpace = false, bool addNumericValue = false)
        //{
        //    var output = "".PadRight(Math.Abs(numberOfStones), symbol);
        //    output = (addNumericValue ? "(" + Math.Abs(numberOfStones) + ") " : "") + output;
        //    output = (numberOfStones < 0 ? "Nợ " : "") + output;
        //    if (addSpace)
        //        return output.Replace(symbol + "", symbol + " ");
        //    return output;
        //}

        private string SmallStonesToString(int numberOfStones)
        {
            StringBuilder sb = new StringBuilder();

            var d = numberOfStones / 5;
            var r = numberOfStones % 5;

            if (d > 0)
                sb.Append("".PadLeft(d, '⁙'));
            if (r > 0)
                switch (r)
                {
                    case 1:
                        sb.Append("‧");
                        break;
                    case 2:
                        sb.Append("᛬");
                        break;
                    case 3:
                        sb.Append("⁖");
                        break;
                    case 4:
                        sb.Append("⁘");
                        break;
                    default:
                        break;
                }

            return sb.ToString();
        }

        #region Game State

        private void GameOver()
        {
            button13.Text = "Đánh Trận Mới";
            label18.Text = "Tàn cuộc!";
            label19.Text = (Game.Players[0].Scores > Game.Players[1].Scores)
                ? playerNames[0] + " thắng!"
                : (Game.Players[0].Scores == Game.Players[1].Scores)
                ? "Hòa" : playerNames[1] + " thắng!";
            MessageBox.Show(label19.Text, "Tàn Cuộc",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void NewGame()
        {
            button13.Text = "Điều Quân";
            label18.Text = "Khai cuộc!";
            label19.Text = playerNames[Game.CurrentPlayer] + " đi trước." + Environment.NewLine +
                "Chọn một mẫu ruộng để điều quân.";
        }

        private void UpdateGameState()
        {
            switch (Game.State)
            {
                case Game.Status.NEW:
                    NewGame();
                    break;

                case Game.Status.PLAYER_SELECTING:
                    label19.Text = playerNames[Game.CurrentPlayer] + " chọn một mẫu ruộng để điều quân.";
                    break;

                case Game.Status.PLAYER_MOVING:
                    label19.Text = playerNames[Game.CurrentPlayer] + " đang điều quân...";
                    break;

                case Game.Status.WAITING_FOR_FINAL_COLLECTION:
                    WaitForFinalCollection();
                    break;

                case Game.Status.OVER:
                    GameOver();
                    break;

                case Game.Status.WAITING_FOR_REFILLING:
                    WaitForRefilling();
                    break;

                default:
                    label19.Text = "Undefined";
                    break;
            }
        }

        private void WaitForFinalCollection()
        {
            label18.Text = "Hết quan, tàn dân, " + Environment.NewLine + "thu quân, bán ruộng!";
            label19.Text = "(3 s)";
            finalCollecTimerCounter = 0;
            timer3.Enabled = true;
            timer3.Start();
        }
        private void WaitForRefilling()
        {
            label19.Text = playerNames[Game.CurrentPlayer] + " đã hết quân." + Environment.NewLine + "Đặt lại quân vào ruộng để đi tiếp.";
            button14.Text = "Đặt Lại Quân" + Environment.NewLine + "(3 s)";
            button14.Visible = true;
            button13.Enabled = false;
            distributeTimerCounter = 0;
            timer2.Enabled = true;
            timer2.Start();
        }

        #endregion Game State
        private void timer1_Tick(object sender, EventArgs e)
        {
            Game.Step();
            GameModelToUI();
            if (!Game.IsPlayerMoving)
            {
                timer1.Stop();
                //label17.Text = GameAI.PredictBestMove(Game, 2) + "";
            }

        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            distributeTimerCounter++;
            button14.Text = "Đặt Lại Quân" + Environment.NewLine + "" +
                "(" + (3 - distributeTimerCounter) + " s)";
            if (distributeTimerCounter >= 3)
            {
                RefillNow();
                timer2.Stop();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            finalCollecTimerCounter++;
            label19.Text = "(" + (3 - finalCollecTimerCounter) + " s)";
            if (finalCollecTimerCounter >= 3)
            {
                timer3.Stop();
                Game.FinalCollect();
                GameModelToUI();
            }
        }
    }
}