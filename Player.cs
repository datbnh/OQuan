using System;

namespace OAnQuan
{
    public class Player
    {
        public int SmallStones;
        public int LargeStones;

        public int Scores => SmallStones * Game.SMALL_STONE_VALUE + LargeStones * Game.LARGE_STONE_VALUE;

        internal Player Clone()
        {
            return new Player() { SmallStones = this.SmallStones, LargeStones = this.LargeStones };
        }
    }
}