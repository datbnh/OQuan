using System;
using System.Collections.Generic;
using System.Text;

namespace OAnQuan
{
    public class Game
    {
        public const int NUMBER_OF_CELL_PER_PLAYER = 6;
        public const int LARGE_STONE_VALUE = 10;
        public const int SMALL_STONE_VALUE = 1;
        public const int QUAN_NON_THRESHOLD = 5;
        /// <summary>
        /// Stores the number of small stones on each cell of the board. 
        /// Large stones are stored separately in LargeStones array.
        /// </summary>
        public int[] Board;

        public int CurrentCellIndex;
        public int CurrentPlayer;
        public bool IsCollectingImatureMandarinAllowed = false;
        public bool IsPlayerMoving = false;
        public int[] LargeStones;
        public int PlayerNumber;
        public Player[] Players;
        public int SelectedCellIndex;
        /// <summary>
        /// Stones to be scatted in one picking-up - scattering sequence.
        /// </summary>
        public int StonesInHand;

        public Status State { get; private set; }
        public Game()
        {
            PlayerNumber = 2;
            Players = new Player[2] { new Player(), new Player() };
            Board = new int[12] { 0,  5, 5, 5, 5, 5,
                                  0,  5, 5, 5, 5, 5 };
            LargeStones = new int[2] { 1, 1 };
            SetCurrentPlayer(0);
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


        public void BeginMove()
        {
            if (IsPlayerMoving)
                return;

            if (SelectedCellIndex < 0)
                return; // player need to pickup a cell first

            CurrentCellIndex = SelectedCellIndex;
            PickUp(CurrentCellIndex);
            State = Status.PLAYER_MOVING;
            IsPlayerMoving = true;
        }

        public int CellIndexToLargeStoneIndex(int cellIndex)
        {
            return cellIndex / NUMBER_OF_CELL_PER_PLAYER;
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
                IsPlayerMoving = IsPlayerMoving,
                StonesInHand = StonesInHand,
            };

            clonedGame.Players = new Player[clonedGame.PlayerNumber];
            for (int i = 0; i < clonedGame.PlayerNumber; i++)
            {
                clonedGame.Players[i] = Players[i].Clone();
            }
            return clonedGame;
        }

        public void Collect()
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
                       (GetQuanCellValue(secondNextCellIndex) >= QUAN_NON_THRESHOLD))
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

        public int GetNextCellIndex(int currentCellIndex)
        {
            if (currentCellIndex >= PlayerNumber * NUMBER_OF_CELL_PER_PLAYER - 1)
                return 0;
            else return currentCellIndex + 1;
        }

        public void PickUp(int cellIndex)
        {
            StonesInHand = Board[cellIndex];
            Board[cellIndex] = 0;
            CurrentCellIndex = cellIndex;
        }

        public bool SelectCell(int cellIndex)
        {
            if (IsPlayerMoving)
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

        public void Step()
        {
            if (!IsPlayerMoving)
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

        private void SetCurrentPlayer(int playerIndex)
        {
            CurrentPlayer = playerIndex;
            StonesInHand = 0;
            CurrentCellIndex = -1;
            SelectedCellIndex = -1;
            IsPlayerMoving = false;
        }

        public void UpdateGameStatus()
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

            if (IsPlayerMoving)
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

        public int GetQuanCellValue(int playerIndex)
        {
            return LargeStones[playerIndex] * LARGE_STONE_VALUE +
                Board[playerIndex * NUMBER_OF_CELL_PER_PLAYER] * SMALL_STONE_VALUE;
        }

#if DEBUG
        public void PrintBoard()
        {
            Console.WriteLine("---------------------------");
            Console.Write("    ");
            for (int i = 1; i < NUMBER_OF_CELL_PER_PLAYER; i++)
            {
                Console.Write(Board[i].ToString("0 ").PadLeft(4, ' '));
            }
            Console.WriteLine();
            Console.Write(LargeStones[0] + "+");
            Console.Write(Board[NUMBER_OF_CELL_PER_PLAYER].ToString("0 ").PadLeft(2, ' '));
            for (int i = 1; i < NUMBER_OF_CELL_PER_PLAYER; i++)
            {
                Console.Write("    ");
            }
            Console.Write(LargeStones[0] + "+");
            Console.WriteLine(Board[NUMBER_OF_CELL_PER_PLAYER * 2 - 1]);
            Console.Write("    ");
            for (int i = 1; i < NUMBER_OF_CELL_PER_PLAYER; i++)
            {
                Console.Write(Board[i + NUMBER_OF_CELL_PER_PLAYER].ToString("0 ").PadLeft(4, ' '));
            }
            Console.WriteLine();
            Console.WriteLine("---------------------------");
            Console.WriteLine("Current Player: " + CurrentPlayer);
            Console.WriteLine("Player 0: " + Players[0].SmallStones + "-" + Players[0].LargeStones + " | " + Players[0].Scores);
            Console.WriteLine("Player 1: " + Players[1].SmallStones + "-" + Players[1].LargeStones + " | " + Players[1].Scores);
        }
#endif
    }
}
