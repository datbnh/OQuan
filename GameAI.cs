using System;
using System.Collections.Generic;
using System.Text;

namespace OAnQuan
{
    public static class GameAI
    {
        //public static int GetDelta(Game game, int cellIndex)
        //{
        //    return GetDelta10(game, game.Clone().PerformCompleteMove(cellIndex));
        //}

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
            //var deltas = new int[(Game.NUMBER_OF_CELL_PER_PLAYER - 1)*game.PlayerNumber];
            return predictBestMove(ref game, ref clonedGame, ref currentDoT);
        }

        private static int predictBestMove(ref Game baseline, ref Game currentTrial, ref int currentDoT)
        {
            Console.WriteLine();
            Console.WriteLine("Current Depth of Though: " + currentDoT);
            if (currentDoT <= 0)
            {
                Console.WriteLine("Best Move: ");
                return predictBestMove(ref baseline, ref currentTrial);
            }

            else
            {
                currentTrial.PerformCompleteMove(
                    predictBestMove(ref baseline, ref currentTrial));
                currentDoT--;
                Console.WriteLine("Initial Game:");
                baseline.PrintBoard();
                Console.WriteLine("This Trial:");
                currentTrial.PrintBoard();
                return predictBestMove(ref baseline, ref currentTrial, ref currentDoT);
            }

        }

        private static int predictBestMove(ref Game baseline, ref Game currentTrial)
        {
            Console.WriteLine("Getting best move of currentTrial...");
            Console.WriteLine("baseline:");
            baseline.PrintBoard();
            Console.WriteLine("currentTrial:");
            currentTrial.PrintBoard();
            Console.WriteLine();
            var delta10s = new int[Game.NUMBER_OF_CELL_PER_PLAYER - 1];
            for (int i = 1; i < Game.NUMBER_OF_CELL_PER_PLAYER; i++)
            {
                Console.WriteLine("i = " + i);
                var clonedGame = currentTrial.Clone();
                clonedGame.PerformCompleteMove(i + Game.NUMBER_OF_CELL_PER_PLAYER * clonedGame.CurrentPlayer);
                clonedGame.PrintBoard();
                delta10s[i - 1] = GetDelta10(baseline, clonedGame);
            }


            var sign = 1;
            if (currentTrial.CurrentPlayer == 0)
                sign = -1;

            var max = int.MinValue;
            var maxIndex = -1;
            Console.WriteLine();
            Console.WriteLine("Scoring:");
            for (int i = 1; i < delta10s.Length + 1; i++)
            {
                Console.WriteLine((i + Game.NUMBER_OF_CELL_PER_PLAYER * currentTrial.CurrentPlayer) + ": " + delta10s[i - 1] * sign);
                if ((sign * delta10s[i - 1]) > max)
                {
                    max = sign * delta10s[i - 1];
                    maxIndex = i;
                }
            }
            Console.WriteLine("Best move: " + (maxIndex + Game.NUMBER_OF_CELL_PER_PLAYER * currentTrial.CurrentPlayer));

            return maxIndex + Game.NUMBER_OF_CELL_PER_PLAYER * currentTrial.CurrentPlayer;
        }

        //private static int predictBestMove(Game clonedGame, ref int[] cummulativeDeltas, ref int currentDepthOfThough, bool invertSign)
        //{
        //    currentDepthOfThough--;
        //    if (currentDepthOfThough <= 0)
        //    {
        //        return predictBestMove(clonedGame, ref cummulativeDeltas);
        //    }
        //    else
        //    {
        //        clonedGame.CompleteMove(predictBestMove(clonedGame, ref cummulativeDeltas));
        //        return predictBestMove(clonedGame, ref cummulativeDeltas, ref currentDepthOfThough, true);
        //    }
        //}

        //private static int predictBestMove(Game clonedGame, ref int[] cummulativeDeltas, bool isOpponent = false)
        //{
        //    for (int i = 0; i < cummulativeDeltas.Length; i++)
        //    {
        //        var cellIndex = i + 1 + Game.NUMBER_OF_CELL_PER_PLAYER * clonedGame.CurrentPlayer;
        //        if (!clonedGame.SelectCell(cellIndex))
        //            cummulativeDeltas[i] = int.MinValue; // negative score for invalid move
        //        else
        //        {
        //            var currentDelta = GetDelta(clonedGame, cellIndex);
        //            for (int j = 0; j < currentDelta.Length; j++)
        //            {
        //                if (j == clonedGame.CurrentPlayer)
        //                        cummulativeDeltas[i] += currentDelta[j];
        //                else
        //                        cummulativeDeltas[i] -= currentDelta[j];
        //            }
        //        }
        //    }

        //    if (!isOpponent)
        //    {
        //        var max = int.MinValue;
        //        var maxIndex = -1;
        //        for (int i = 0; i < cummulativeDeltas.Length; i++)
        //        {
        //            if (cummulativeDeltas[i] > max)
        //            {
        //                max = cummulativeDeltas[i];
        //                maxIndex = i;
        //            }
        //        }
        //    } else
        //    {

        //    }

        //    var bestMoveCellIndex = maxIndex + 1 + Game.NUMBER_OF_CELL_PER_PLAYER * clonedGame.CurrentPlayer;
        //    return bestMoveCellIndex;
        //}

        public static Game PerformCompleteMove(this Game game, int cellIndex)
        {
            Console.WriteLine("  Performing move: " + cellIndex);
            Console.WriteLine("  CurrentPlayer  : " + game.CurrentPlayer);
            Console.Write("  ");
            //game.PrintBoard();
            if (game.State == Game.Status.WAITING_FOR_REFILLING)
                game.Refill(game.CurrentPlayer);
            if (game.SelectCell(cellIndex)) // valid move
            {
                game.BeginMove();
                do
                {
                    game.Step();
                    Console.Write(".");
                }
                while (game.State == Game.Status.PLAYER_MOVING);
                
                if (game.State == Game.Status.WAITING_FOR_FINAL_COLLECTION)
                    game.FinalCollect();
            }
            Console.WriteLine();
            Console.WriteLine("  CurrentPlayer  : " + game.CurrentPlayer);
            return game;
        }
    }
}
