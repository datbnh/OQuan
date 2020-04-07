using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OAnQuan
{
    public partial class Form1 : Form
    {
        private int computerIndex = 1; // assign -1 for 2 palyers mode
        public Game Game;

        private readonly Button[] board;
        private readonly Label[] collectedLargeStonesNumericLabels;

        private readonly Label[] collectedLargeStonesSymbolicLabels;

        private readonly Label[] collectedSmallStonesNumericLabels;

        private readonly Label[] collectedSmallStonesSymbolicLabels;

        private readonly Color[] playerColors
                                            = { Color.LightBlue, Color.MistyRose };
        private readonly string[] playerNames;
        private readonly Label[] scoreLabels;

        private int counterFinalCollectTimer;
        private int counterRefillTimer;

        private bool isCollectingImatureMandarinAllowed = false;

        private readonly string win3 = "thắng cực đậm!";
        private readonly string win2 = "thắng đậm!";
        private readonly string win1 = "thắng suýt soát!";


        public Form1()
        {
            InitializeComponent();
            playerNames = new string[2] { "Bên Xanh", "Bên Đỏ" };
            board = new Button[12] {button1, button2, button3, button4, button5, button6,
            button7, button8, button9, button10, button11, button12};
            collectedSmallStonesNumericLabels = new Label[2] { label22, label20 };
            collectedSmallStonesSymbolicLabels = new Label[2] { label3, label12 };
            collectedLargeStonesNumericLabels = new Label[2] { label23, label21 };
            collectedLargeStonesSymbolicLabels = new Label[2] { label5, label13 };
            scoreLabels = new Label[2] { label7, label9 };

            NewGame();



            UpdateAllUIElementsFromGameModel();
            //label17.Text = GameAI.PredictBestMove(Game, 2) + "";
        }




        public void UpdateAllUIElementsFromGameModel()
        {
            if (Game == null)
                return;

            UpdateScore(0);
            UpdateScore(1);
            UpdateBoard();

            UpdateCurrentPlayerState();
            HighlightActiveBoardCell();

            UpdateGameState();
        }

        public void HighlightActiveBoardCell()
        {
            for (int i = 0; i < board.Length; i++)
            {
                if (i == Game.SelectedCellIndex && Game.State != Game.Status.PLAYER_MOVING)
                {
                    board[i].BackColor = playerColors[Game.CurrentPlayer];
                }
                else
                if (i == Game.CurrentCellIndex)
                {
                    board[i].BackColor = playerColors[Game.CurrentPlayer];
                }
                else
                {
                    board[i].BackColor = Color.White;
                }
            }
        }

        public void SetGame(Game game)
        {
            Game = game;
        }

        private void boardCell_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < board.Length; i++)
            {
                if (board[i] == sender && ((i != 0) && (i != 6)))
                {
                    Game.SelectCell(i);
                    break;
                }
            }

            HighlightActiveBoardCell();
        }

        private void buttonGoOrNew_Click(object sender, EventArgs e)
        {
            if (Game.State == Game.Status.OVER)
            {
                NewGame();
                return;
            }

            Game.BeginMove();
            timerScatter.Enabled = true;
            timerScatter.Start();
        }

        private void NewGame()
        {
            Random random = new Random();
            SetGame(new Game(random.Next(0, 2)) { IsCollectingImatureMandarinAllowed = isCollectingImatureMandarinAllowed, });
            if (Game.IsCollectingImatureMandarinAllowed)
                toolStripButton2.Text = "Được Ăn Quan Non";
            else
                toolStripButton2.Text = "Không Được Ăn Quan Non";
            UpdateAllUIElementsFromGameModel();
            if (Game.CurrentPlayer == computerIndex)
                ComputerGo();
        }

        private void buttonRefill_Click_1(object sender, EventArgs e)
        {
            timerRefill.Stop();
            RefillNow();
        }

        private void UpdateCurrentPlayerState()
        {
            if (Game.State == Game.Status.OVER)
            {
                tableLayoutPanelPlayer0.BackColor = this.BackColor;
                tableLayoutPanelPlayer1.BackColor = this.BackColor;
                return;
            }

            labelGameState.Text = playerNames[Game.CurrentPlayer] + " Đi";

            if (Game.CurrentPlayer == 0)
            {
                tableLayoutPanelPlayer0.BackColor = playerColors[Game.CurrentPlayer];
                tableLayoutPanelPlayer1.BackColor = this.BackColor;
            }
            else
            {
                tableLayoutPanelPlayer0.BackColor = this.BackColor;
                tableLayoutPanelPlayer1.BackColor = playerColors[Game.CurrentPlayer];
            }
        }

        private void RefillNow()
        {
            buttonRefill.Visible = false;
            Game.Refill(Game.CurrentPlayer);
            buttonGoOrNew.Enabled = true;
            UpdateAllUIElementsFromGameModel();
        }

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

        private void timerScatter_Tick(object sender, EventArgs e)
        {
            Game.Step();
            UpdateBoard();
            HighlightActiveBoardCell();
            labelStonesInHand.Text = Game.StonesInHand.ToString() + " " + "".PadLeft(Game.StonesInHand, '.');

            if (Game.State != Game.Status.PLAYER_MOVING)
            {
                labelStonesInHand.Text = "-";
                timerScatter.Stop();
                UpdateScore(0);
                UpdateScore(1);
                UpdateCurrentPlayerState();

                UpdateGameState();
            }
        }

        private void ComputerGo()
        {
            labelInstruction.Text = "Máy đang tính kế...";

            Random random = new Random();

            var v = GameAI.PredictBestMove(Game, computerIndex);
            bool valid = Game.SelectCell(v);

            while (!valid)
            {
                v = random.Next(1 + computerIndex * Game.NUMBER_OF_CELL_PER_PLAYER,
                    (computerIndex + 1) * Game.NUMBER_OF_CELL_PER_PLAYER);
                valid = Game.SelectCell(v);
            }

            timerDelayComputerMove.Interval = random.Next(1000, 3000);
            label17.Text = timerDelayComputerMove.Interval.ToString();
            Cursor = Cursors.WaitCursor;
            timerDelayComputerMove.Start();
        }

        private void timerRefill_Tick(object sender, EventArgs e)
        {
            counterRefillTimer++;
            buttonRefill.Text = "Đặt Lại Quân" + Environment.NewLine + "" +
                "(" + (3 - counterRefillTimer) + " s)";
            if (counterRefillTimer >= 3)
            {
                RefillNow();
                timerRefill.Stop();
            }
        }

        private void timerFinalCollect_Tick(object sender, EventArgs e)
        {
            counterFinalCollectTimer++;
            labelInstruction.Text = "(" + (3 - counterFinalCollectTimer) + " s)";
            if (counterFinalCollectTimer >= 3)
            {
                timerFinalCollect.Stop();
                Game.FinalCollect();
                UpdateAllUIElementsFromGameModel();
            }
        }

        private void timerDelayComputerMove_Tick(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            labelInstruction.Text = "Máy đang điều quân...";
            HighlightActiveBoardCell();
            Game.BeginMove();
            timerDelayComputerMove.Stop();
            timerScatter.Start();
        }

        private void UpdateBoard()
        {
            for (int i = 0; i < board.Length; i++)
            {
                board[i].Text = SmallStonesToString(Game.Board[i]);
            }

            board[0].Text = (Game.LargeStones[0] > 0 ? "•" : "") + board[0].Text;
            board[6].Text = (Game.LargeStones[1] > 0 ? "•" : "") + board[6].Text;
        }

        private void UpdateScore(int playerIndex)
        {
            var v = Game.Players[playerIndex].SmallStones;

            collectedSmallStonesSymbolicLabels[playerIndex].Text
                = SmallStonesToString(Math.Abs(v));
            collectedSmallStonesNumericLabels[playerIndex].Text
                = (v < 0 ? "Nợ " : "") + Math.Abs(v).ToString();

            v = Game.Players[playerIndex].LargeStones;
            collectedLargeStonesSymbolicLabels[playerIndex].Text = v > 0 ? ("".PadLeft(v, '•')) : "";
            collectedLargeStonesNumericLabels[playerIndex].Text = v.ToString();

            scoreLabels[playerIndex].Text = Game.Players[playerIndex].Scores.ToString();
        }

        #region Game State

        private void GameOver()
        {
            buttonGoOrNew.Text = "Đánh Trận Mới";
            labelGameState.Text = "Tàn cuộc!";

            string winner =
                (Game.Players[0].Scores > Game.Players[1].Scores) ?
                playerNames[0] : playerNames[1];
            var delta = Math.Abs(Game.Players[0].Scores - Game.Players[1].Scores);
            string score = playerNames[0] + " " + Game.Players[0].Scores + " : " +
                Game.Players[1].Scores + " " + playerNames[1];
            if (delta <= 0)
                labelInstruction.Text = "Đôi bên ngang tài!";
            else if (delta <= 5) // 70 / 2 = 35 -> 32 38
                labelInstruction.Text = winner + " " + win1;
            else if (delta <= 10) // 30 40
                labelInstruction.Text = winner + " " + win2;
            else // 25 45
                labelInstruction.Text = winner + " " + win3;
                        
            MessageBox.Show(labelInstruction.Text + Environment.NewLine + score, "Tàn Cuộc",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UpdateGameState()
        {
            switch (Game.State)
            {
                case Game.Status.NEW:
                    buttonGoOrNew.Text = "Điều Quân";
                    labelGameState.Text = "Khai cuộc!";
                    labelInstruction.Text = playerNames[Game.CurrentPlayer] + " đi trước." + Environment.NewLine +
                        "Chọn một mẫu ruộng để điều quân.";
                    break;

                case Game.Status.PLAYER_SELECTING:
                    labelInstruction.Text
                        = playerNames[Game.CurrentPlayer]
                        + " chọn một mẫu ruộng để điều quân.";
                    if (Game.CurrentPlayer == computerIndex)
                        ComputerGo();
                    break;

                case Game.Status.PLAYER_MOVING:
                    labelInstruction.Text
                        = playerNames[Game.CurrentPlayer]
                        + " đang điều quân...";
                    break;

                case Game.Status.WAITING_FOR_FINAL_COLLECTION:
                    //if (Game.CurrentPlayer == computerIndex)
                    //    RefillNow();
                    //else
                    WaitForFinalCollection();
                    break;

                case Game.Status.OVER:
                    GameOver();
                    break;

                case Game.Status.WAITING_FOR_REFILLING:
                    WaitForRefilling();
                    break;

                default:
                    labelInstruction.Text = "Undefined";
                    break;
            }
        }

        private void WaitForFinalCollection()
        {
            labelGameState.Text = "Hết quan, tàn dân, "
                + Environment.NewLine + "thu quân, bán ruộng!";
            labelInstruction.Text = "(3 s)";
            counterFinalCollectTimer = 0;
            timerFinalCollect.Enabled = true;
            timerFinalCollect.Start();
        }
        private void WaitForRefilling()
        {
            labelInstruction.Text = playerNames[Game.CurrentPlayer] + " đã hết quân."
                + Environment.NewLine + "Đặt lại quân vào ruộng để đi tiếp.";
            buttonRefill.Text = "Đặt Lại Quân" + Environment.NewLine + "(3 s)";
            buttonRefill.Visible = true;
            buttonGoOrNew.Enabled = false;
            counterRefillTimer = 0;
            timerRefill.Enabled = true;
            timerRefill.Start();
        }

        #endregion Game State

        #region ToolStripButtons
        
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Game.IsCollectingImatureMandarinAllowed = !Game.IsCollectingImatureMandarinAllowed;
            isCollectingImatureMandarinAllowed = Game.IsCollectingImatureMandarinAllowed;
            if (Game.IsCollectingImatureMandarinAllowed)
                toolStripButton2.Text = "Được Ăn Quan Non";
            else
                toolStripButton2.Text = "Không Được Ăn Quan Non";
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn đánh trận mới?", "Đánh Trận Mới", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                NewGame();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (computerIndex > -1)
            {
                toolStripButton3.Text = "Hai Người Chơi";
                computerIndex = -1;
            }
            else
            {
                toolStripButton3.Text = "Một Người Chơi";
                computerIndex = 1;
            }
            if (MessageBox.Show("Bạn vừa thay đổi cài đặt. Bạn có muốn đánh trận mới không?", "Đánh Trận Mới", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                NewGame();
        }

        #endregion
    }
}