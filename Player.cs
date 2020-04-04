namespace OAnQuan
{
    public class Player
    {
        public int SmallStones;
        public int LargeStones;

        public int Scores => SmallStones + LargeStones * 10;


    }
}