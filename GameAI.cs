using System;
using System.Collections.Generic;
using System.Text;

namespace OAnQuan
{
    public static class GameAI
    {
        /// <summary>
        /// Retunrs (total change in score of player1) - (total change in score of player0).
        /// </summary>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <returns></returns>
        public static int GetDelta10(Game before, Game after)
        {
            var delta1 = after.Players[1].Scores - before.Players[1].Scores;
            var delta0 = after.Players[0].Scores - before.Players[0].Scores;
            return delta1 - delta0;
        }

        public static int PredictBestMove(Game game, int depthOfThough)
        {
            var currentDoT = depthOfThough * 2 - 2;
            var clonedGame = game.Clone();
            return predictBestMove(ref game, ref clonedGame, ref currentDoT);
        }

        private static int predictBestMove(ref Game baseline, ref Game currentTrial, ref int currentDoT)
        {
#if DEBUG
            System.Diagnostics.Debug.WriteLine("");
            System.Diagnostics.Debug.WriteLine("Current Depth of Though: " + currentDoT);
#endif
            if (currentDoT <= 0)
            {
#if DEBUG
                System.Diagnostics.Debug.WriteLine("Best Move: ");
#endif
                return predictBestMove(ref baseline, ref currentTrial);
            }

            else
            {
                currentTrial.PerformCompleteMove(
                    predictBestMove(ref baseline, ref currentTrial));
                currentDoT--;
#if DEBUG
                System.Diagnostics.Debug.WriteLine("Initial Game:");
                baseline.PrintBoard();
                System.Diagnostics.Debug.WriteLine("This Trial:");
                currentTrial.PrintBoard();
#endif
                return predictBestMove(ref baseline, ref currentTrial, ref currentDoT);
            }

        }

        private static int predictBestMove(ref Game baseline, ref Game currentTrial)
        {
#if DEBUG
            System.Diagnostics.Debug.WriteLine("Getting best move of currentTrial...");
            System.Diagnostics.Debug.WriteLine("baseline:");
            baseline.PrintBoard();
            System.Diagnostics.Debug.WriteLine("currentTrial:");
            currentTrial.PrintBoard();
            System.Diagnostics.Debug.WriteLine("");
#endif
            var delta10s = new int[Game.NUMBER_OF_CELL_PER_PLAYER - 1];
            for (int i = 1; i < Game.NUMBER_OF_CELL_PER_PLAYER; i++)
            {
                var clonedGame = currentTrial.Clone();
                clonedGame.PerformCompleteMove(i + Game.NUMBER_OF_CELL_PER_PLAYER * clonedGame.CurrentPlayer);
                delta10s[i - 1] = GetDelta10(baseline, clonedGame);
#if DEBUG
                System.Diagnostics.Debug.WriteLine("i = " + i);
                clonedGame.PrintBoard();
#endif
            }


            var sign = 1;
            if (currentTrial.CurrentPlayer == 0)
                sign = -1;

            var max = int.MinValue;
            var maxIndex = -1;
#if DEBUG
            System.Diagnostics.Debug.WriteLine("");
            System.Diagnostics.Debug.WriteLine("Scoring:");
#endif
            for (int i = 1; i < delta10s.Length + 1; i++)
            {
#if DEBUG
                System.Diagnostics.Debug.WriteLine((i + Game.NUMBER_OF_CELL_PER_PLAYER * currentTrial.CurrentPlayer) + ": " + delta10s[i - 1] * sign);
#endif
                if ((sign * delta10s[i - 1]) > max)
                {
                    max = sign * delta10s[i - 1];
                    maxIndex = i;
                }
            }
#if DEBUG
            System.Diagnostics.Debug.WriteLine("Best move: " + (maxIndex + Game.NUMBER_OF_CELL_PER_PLAYER * currentTrial.CurrentPlayer));
#endif
            return maxIndex + Game.NUMBER_OF_CELL_PER_PLAYER * currentTrial.CurrentPlayer;
        }

        public static Game PerformCompleteMove(this Game game, int cellIndex)
        {
#if DEBUG
            System.Diagnostics.Debug.WriteLine("  Performing move: " + cellIndex);
            System.Diagnostics.Debug.WriteLine("  CurrentPlayer  : " + game.CurrentPlayer);
            System.Diagnostics.Debug.Write("  ");
            game.PrintBoard();
#endif
            if (game.State == Game.Status.WAITING_FOR_REFILLING)
                game.Refill(game.CurrentPlayer);
            if (game.SelectCell(cellIndex)) // valid move
            {
                game.BeginMove();
                do
                {
                    game.Step();
#if DEBUG
                    System.Diagnostics.Debug.Write(".");
#endif
                }
                while (game.State == Game.Status.PLAYER_MOVING);
                
                if (game.State == Game.Status.WAITING_FOR_FINAL_COLLECTION)
                    game.FinalCollect();
            }
#if DEBUG
            System.Diagnostics.Debug.WriteLine("");
            System.Diagnostics.Debug.WriteLine("  CurrentPlayer  : " + game.CurrentPlayer);
#endif
            return game;
        }
    }
}
