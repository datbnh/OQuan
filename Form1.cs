using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OAnQuan
{
    public partial class Form1 : Form
    {
        public Game Game;

        Button[] Board;

        public Form1()
        {
            InitializeComponent();
            Board = new Button[12] {button1, button2, button3, button4, button5, button6,
            button7, button8, button9, button10, button11, button12};
            //for (int i = 0; i < Board.Length; i++)
            //{
            //    Board[i].Font.FontFamily = new FontFamily(Board[i].Font.FontFamily.Name, )
            //}
            SetGame(new Game());
            GameModelToUI();
        }

        public void SetGame(Game game)
        {
            Game = game;
        }

        public void GameModelToUI()
        {
            if (Game == null)
                return;

            label3.Text = Game.Players[0].SmallStones.ToString();
            label5.Text = Game.Players[0].LargeStones.ToString();
            label7.Text = Game.Players[0].Scores.ToString();

            label12.Text = Game.Players[1].SmallStones.ToString();
            label13.Text = Game.Players[1].LargeStones.ToString();
            label9.Text = Game.Players[1].Scores.ToString();

            label18.Text = Game.CurrentPlayer + 1 + "";
            label16.Text = "".PadLeft(Game.StonesInHand, 'o');


            for (int i = 0; i < Board.Length; i++)
            {
                Board[i].Text = "".PadLeft(Game.Board[i], '•');
            }

            Board[0].Text = "".PadLeft(Game.LargeStones[0], '❿') + Board[0].Text;
            Board[6].Text = "".PadLeft(Game.LargeStones[1], '❿') + Board[6].Text;

            UpdateHighlightedCell();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Game.BeginMove();
            GameModelToUI();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            //Game.Step();
            //GameModelToUI();
            timer1.Start();
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

        public void UpdateHighlightedCell()
        {
            for (int i = 0; i < Board.Length; i++)
            {
                if (i == Game.SelectedCellIndex && !Game.IsPlayerMoving)
                {
                    //Board[i].FlatAppearance.BorderColor = Color.DarkRed;
                    //Board[i].FlatAppearance.BorderSize = 2;
                    if (Game.CurrentPlayer == 0)
                        Board[i].BackColor = Color.LightBlue;
                    else
                        Board[i].BackColor = Color.LightCoral;
                }
                else
                if (i == Game.CurrentCellIndex)
                {
                    //Board[i].FlatAppearance.BorderColor = Color.DarkRed;
                    //Board[i].FlatAppearance.BorderSize = 1;
                    if (Game.CurrentPlayer == 0)
                        Board[i].BackColor = Color.LightBlue;
                    else
                        Board[i].BackColor = Color.LightCoral;
                }
                else
                {
                    //Board[i].FlatAppearance.BorderColor = Color.Black;
                    //Board[i].FlatAppearance.BorderSize = 0;
                    Board[i].BackColor = Color.White;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Game.Step();
            GameModelToUI();
            if (!Game.IsPlayerMoving)
                timer1.Stop();
        }
    }
}
