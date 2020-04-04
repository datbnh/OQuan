using System;
using System.Collections.Generic;
using System.Text;

namespace OAnQuan
{
    public class Game
    {
        public Player[] Players;
        /// <summary>
        /// Stores the number of small stones on each cell of the board. 
        /// Large stones are stored separately in LargeStones array.
        /// </summary>
        public int[] Board;

        public int[] LargeStones;
        public int PlayerNumber;

        public int CurrentPlayer;
        public int StonesInHand;
        public int CurrentCellIndex;
        public int SelectedCellIndex;

        public const int NUMBER_OF_CELL_PER_PLAYER = 6;

        public bool IsPlayerMoving = false;

        public bool IsCollectingImatureMandarinAllowed = false;

        public Game()
        {
            PlayerNumber = 2;
            LargeStones = new int[2] { 1, 1 };
            Board = new int[12] { 0, 5, 5, 5, 5, 5, 0, 5, 5, 5, 5, 5 };
            Players = new Player[2] { new Player(), new Player() };
            SetCurrentPlayer(0);
        }

        private void SetCurrentPlayer(int playerIndex)
        {
            CurrentPlayer = playerIndex;
            StonesInHand = 0;
            CurrentCellIndex = -1;
            SelectedCellIndex = -1;
            IsPlayerMoving = false;
        }

        public int GetNextCellIndex(int currentCellIndex)
        {
            if (currentCellIndex >= PlayerNumber * NUMBER_OF_CELL_PER_PLAYER - 1)
                return 0;
            else return currentCellIndex + 1;
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
                SelectedCellIndex = cellIndex;
                return true;
            }
            else
            {
                SelectedCellIndex = -1;
                return false;
            }
        }

        public void BeginMove()
        {
            if (IsPlayerMoving)
                return;

            if (SelectedCellIndex < 0)
                return; // player need to pickup a cell first

            CurrentCellIndex = SelectedCellIndex;
            PickUp(CurrentCellIndex);
            IsPlayerMoving = true;
        }

        public void PickUp(int cellIndex)
        {
            StonesInHand = Board[cellIndex];
            Board[cellIndex] = 0;
            CurrentCellIndex = cellIndex;
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
            }
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
                       (LargeStones[CellIndexToLargeStoneIndex(secondNextCellIndex)] > 0 || Board[secondNextCellIndex] > 5))
                    {
                        Players[CurrentPlayer].LargeStones +=
                            LargeStones[CellIndexToLargeStoneIndex(secondNextCellIndex)];
                        LargeStones[CellIndexToLargeStoneIndex(secondNextCellIndex)] = 0;

                        Players[CurrentPlayer].SmallStones += Board[secondNextCellIndex];
                        Board[secondNextCellIndex] = 0;
                    }
                } 
                else // the 2nd-next cell is "dân" cell
                {
                    Players[CurrentPlayer].SmallStones += Board[secondNextCellIndex];
                    Board[secondNextCellIndex] = 0;
                }

                
                CurrentCellIndex = secondNextCellIndex;
                Collect(); // keep collecting until condition is not met
                return;
            }
            return;
        }

        public int CellIndexToLargeStoneIndex(int cellIndex)
        {
            return cellIndex / NUMBER_OF_CELL_PER_PLAYER;
        }

        //public Status GetGameState ()
        //{
        //    for (int i = 0; i < PlayerNumber; i++)
        //    {
        //        if (Board[i * NUMBER_OF_CELL_PER_PLAYER] > 0)
        //            if (Board[i*NUMBER_OF_CELL_PER_PLAYER] < 5)
        //    }
        //}


        
        public enum Status
        {
            NEW = 0,
            YOUNG_MANDARIN = 1,
            OVER = 2,
        }
    }
}
