using System;
using System.Collections.Generic;
using System.Text;

namespace OAnQuan
{
    public class Game
    {
        public const int LARGE_STONE_VALUE = 10;
        public const int NUMBER_OF_CELL_PER_PLAYER = 6;
        public const int QUAN_NON_THRESHOLD = 5;
        public const int SMALL_STONE_VALUE = 1;
        public bool IsCollectingImatureMandarinAllowed = false;

        /// <summary>
        /// <para>Is flagged as true when BeginMove() is called with a CurrentCellIndex set,
        /// and false when SetCurrentPlayer() is called.
        /// </para>
        /// SetCurrentPlayer() is called privately and automatically 
        /// within Step() method.
        /// 
        /// </summary>
        private bool isPlayerMoving = false;

        public Game(int firstPlayer = 0)
        {
            PlayerNumber = 2;
            Players = new Player[2] { new Player(), new Player() };
            Board = new int[12] { 0,  5, 5, 5, 5, 5,
                                  0,  5, 5, 5, 5, 5 };
            LargeStones = new int[2] { 1, 1 };
            SetCurrentPlayer(firstPlayer);
            State = Status.NEW;
            IsCollectingImatureMandarinAllowed = true;
        }

        public enum Status
        {
            NEW = 0,
            PLAYER_SELECTING = 1,
            PLAYER_MOVING = 2,
            WAITING_FOR_REFILLING = 3,
            WAITING_FOR_FINAL_COLLECTION = 4,
            OVER = 5,
        }

        /// <summary>
        /// Stores the number of small stones on each cell of the board. 
        /// Large stones are stored separately in LargeStones array.
        /// </summary>
        public int[] Board { get; private set; }
        public int CurrentCellIndex { get; private set; }
        public int CurrentPlayer { get; private set; }
        public int[] LargeStones { get; private set; }
        public int PlayerNumber { get; private set; }
        public Player[] Players { get; private set; }
        public int SelectedCellIndex { get; private set; }
        public Status State { get; private set; }
        /// <summary>
        /// Stones to be scatted in one picking-up - scattering sequence.
        /// </summary>
        public int StonesInHand { get; private set; }
        public void BeginMove()
        {
            if (isPlayerMoving)
                return;

            if (SelectedCellIndex < 0)
                return; // player need to pickup a cell first

            CurrentCellIndex = SelectedCellIndex;
            PickUp(CurrentCellIndex);
            State = Status.PLAYER_MOVING;
            isPlayerMoving = true;
        }

        public Game Clone()
        {
            var clonedGame = new Game()
            {
                PlayerNumber = PlayerNumber,
                Board = (int[])Board.Clone(),
                LargeStones = (int[])LargeStones.Clone(),
                CurrentCellIndex = CurrentCellIndex,
                SelectedCellIndex = SelectedCellIndex,
                CurrentPlayer = CurrentPlayer,
                IsCollectingImatureMandarinAllowed = IsCollectingImatureMandarinAllowed,
                isPlayerMoving = isPlayerMoving,
                StonesInHand = StonesInHand,
            };

            clonedGame.Players = new Player[clonedGame.PlayerNumber];
            for (int i = 0; i < clonedGame.PlayerNumber; i++)
            {
                clonedGame.Players[i] = Players[i].Clone();
            }
            return clonedGame;
        }

        /// <summary>
        /// Performs final collect when "Hết quan, tàn dân, 
        /// thu quân, bán ruộng" condition is met.
        /// </summary>
        public void FinalCollect()
        {
            for (int i = 0; i < PlayerNumber; i++)
            {
                for (int j = 1; j < NUMBER_OF_CELL_PER_PLAYER; j++)
                // starting from 1, skipping "quan" cell
                {
                    Players[i].SmallStones += Board[(i * NUMBER_OF_CELL_PER_PLAYER) + j];
                    Board[(i * NUMBER_OF_CELL_PER_PLAYER) + j] = 0;
                }
            }

            State = Status.OVER;
        }

        [System.Diagnostics.Conditional("DEBUG")]
        public void PrintBoard()
        {
            System.Diagnostics.Debug.WriteLine("---------------------------");
            System.Diagnostics.Debug.Write("    ");
            for (int i = 1; i < NUMBER_OF_CELL_PER_PLAYER; i++)
            {
                System.Diagnostics.Debug.Write(Board[i].ToString("0 ").PadLeft(4, ' '));
            }
            System.Diagnostics.Debug.WriteLine("");
            System.Diagnostics.Debug.Write(LargeStones[0] + "+");
            System.Diagnostics.Debug.Write(Board[NUMBER_OF_CELL_PER_PLAYER].ToString("0 ").PadLeft(2, ' '));
            for (int i = 1; i < NUMBER_OF_CELL_PER_PLAYER; i++)
            {
                System.Diagnostics.Debug.Write("    ");
            }
            System.Diagnostics.Debug.Write(LargeStones[0] + "+");
            System.Diagnostics.Debug.WriteLine(Board[NUMBER_OF_CELL_PER_PLAYER * 2 - 1]);
            System.Diagnostics.Debug.Write("    ");
            for (int i = 1; i < NUMBER_OF_CELL_PER_PLAYER; i++)
            {
                System.Diagnostics.Debug.Write(Board[i + NUMBER_OF_CELL_PER_PLAYER].ToString("0 ").PadLeft(4, ' '));
            }
            System.Diagnostics.Debug.WriteLine("");
            System.Diagnostics.Debug.WriteLine("---------------------------");
            System.Diagnostics.Debug.WriteLine("Current Player: " + CurrentPlayer);
            System.Diagnostics.Debug.WriteLine("Player 0: " + Players[0].SmallStones + "-" + Players[0].LargeStones + " | " + Players[0].Scores);
            System.Diagnostics.Debug.WriteLine("Player 1: " + Players[1].SmallStones + "-" + Players[1].LargeStones + " | " + Players[1].Scores);
        }

        public void Refill(int playerIndex)
        {
            for (int j = 1; j < NUMBER_OF_CELL_PER_PLAYER; j++)
            // starting from 1, skipping "quan" cell
            {
                Players[playerIndex].SmallStones--;
                Board[playerIndex * NUMBER_OF_CELL_PER_PLAYER + j]++;
            }
            State = Status.PLAYER_SELECTING;
        }

        /// <summary>
        /// Try selecting a cell preparing for a move. If specified index is invalid,
        /// retunrs false and changes SelectedCellIndex to -1, 
        /// otherwise returns true and set SelectedCellIndex to specified value.
        /// </summary>
        /// <param name="cellIndex"></param>
        /// <returns></returns>
        public bool SelectCell(int cellIndex)
        {
            if (isPlayerMoving)
                return false;

            // player 0: 1 -> 5
            // player 1: 7 -> 11 etc
            var offset = CurrentPlayer * NUMBER_OF_CELL_PER_PLAYER;
            if (cellIndex > offset && cellIndex < (offset + NUMBER_OF_CELL_PER_PLAYER))
            {
                if (Board[cellIndex] > 0)
                {
                    SelectedCellIndex = cellIndex;
                    return true;
                }
            }

            SelectedCellIndex = -1;
            return false;
        }

        /// <summary>
        /// <para>If StonesInHand > 0, scatters one stone.</para>
        /// <para>If scattering the last stone in hand, check if next cell is not empty
        /// or is a "quan" cell then pick it</para>
        /// <para>If no stones left in hand, performs Collect() for the current turn,
        /// then changes current player and updates game state.</para>
        /// </summary>
        public void Step()
        {
            if (!isPlayerMoving)
                return;

            var nextCellIndex = GetNextCellIndex(CurrentCellIndex);

            if (StonesInHand > 0) // not finish scattering stones yet
            { // continue to scatter stones
                Board[nextCellIndex]++;
                StonesInHand--;
                CurrentCellIndex = nextCellIndex;
            }
            else if (nextCellIndex % NUMBER_OF_CELL_PER_PLAYER != 0
              && Board[nextCellIndex] > 0)
            // all stones have been scattered,
            // next cell is not mandarin cell and has stones in it
            {
                PickUp(nextCellIndex);
            }
            else // begin collecting stones
            {
                Collect();
                SetCurrentPlayer((CurrentPlayer + 1) % PlayerNumber);
                UpdateGameStatus();
            }
        }

        private int CellIndexToLargeStoneIndex(int cellIndex)
        {
            return cellIndex / NUMBER_OF_CELL_PER_PLAYER;
        }

        private void Collect()
        {
            var nextCellIndex = GetNextCellIndex(CurrentCellIndex);
            var secondNextCellIndex = GetNextCellIndex(nextCellIndex);

            if (Board[nextCellIndex] == 0 && Board[secondNextCellIndex] > 0)
            {
                if (secondNextCellIndex % NUMBER_OF_CELL_PER_PLAYER == 0)
                // the 2nd-next cell is "quan" cell
                {
                    if (IsCollectingImatureMandarinAllowed // "ăn quan non"
                        ||
                       (GetQuanCellValue(CellIndexToLargeStoneIndex(secondNextCellIndex)) >= QUAN_NON_THRESHOLD))
                    {
                        Players[CurrentPlayer].LargeStones +=
                            LargeStones[CellIndexToLargeStoneIndex(secondNextCellIndex)];
                        LargeStones[CellIndexToLargeStoneIndex(secondNextCellIndex)] = 0;

                        Players[CurrentPlayer].SmallStones += Board[secondNextCellIndex];
                        Board[secondNextCellIndex] = 0;
                        CurrentCellIndex = secondNextCellIndex;
                        Collect(); // keep collecting until condition is not met
                    }
                }
                else // the 2nd-next cell is "dân" cell
                {
                    Players[CurrentPlayer].SmallStones += Board[secondNextCellIndex];
                    Board[secondNextCellIndex] = 0;
                    CurrentCellIndex = secondNextCellIndex;
                    Collect(); // keep collecting until condition is not met
                }

                return;
            }
            return;
        }

        private int GetNextCellIndex(int currentCellIndex)
        {
            if (currentCellIndex >= PlayerNumber * NUMBER_OF_CELL_PER_PLAYER - 1)
                return 0;
            else return currentCellIndex + 1;
        }

        private int GetQuanCellValue(int playerIndex)
        {
            return LargeStones[playerIndex] * LARGE_STONE_VALUE +
                Board[playerIndex * NUMBER_OF_CELL_PER_PLAYER] * SMALL_STONE_VALUE;
        }
        private void PickUp(int cellIndex)
        {
            StonesInHand = Board[cellIndex];
            Board[cellIndex] = 0;
            CurrentCellIndex = cellIndex;
        }
        private void SetCurrentPlayer(int playerIndex)
        {
            CurrentPlayer = playerIndex;
            StonesInHand = 0;
            CurrentCellIndex = -1;
            SelectedCellIndex = -1;
            isPlayerMoving = false;
        }

        private void UpdateGameStatus()
        {
            if (State == Status.OVER)
                return;

            var isAllQuanCellEmpty = true;
            for (int i = 0; i < PlayerNumber; i++)
            {
                if (GetQuanCellValue(i) > 0)
                {
                    isAllQuanCellEmpty = false;
                    break;
                }
            }

            if (isAllQuanCellEmpty)
            {
                State = Status.WAITING_FOR_FINAL_COLLECTION;
                return;
            }

            if (isPlayerMoving)
            {
                State = Status.PLAYER_MOVING;
            }
            else
            {
                var isCurrentPlayerHavingAllEmptyCell = true;
                for (int i = 1; i < NUMBER_OF_CELL_PER_PLAYER; i++)
                {
                    if (Board[CurrentPlayer * NUMBER_OF_CELL_PER_PLAYER + i] > 0)
                    {
                        isCurrentPlayerHavingAllEmptyCell = false;
                        break;
                    }
                }

                if (isCurrentPlayerHavingAllEmptyCell)
                    State = Status.WAITING_FOR_REFILLING;
                else
                    State = Status.PLAYER_SELECTING;
            }
        }
    }
}
