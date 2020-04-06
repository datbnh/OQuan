using System;

namespace OAnQuan
{
    public class Player
    {
        public int SmallStones;
        public int LargeStones;

        public int Scores => SmallStones + LargeStones * 10;

        internal Player Clone()
        {
            return new Player() { SmallStones = this.SmallStones, LargeStones = this.LargeStones };
        }
    }
}