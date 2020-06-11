using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    public enum TurnResult
    {
        Success = 1,
        MaxReached = 2,
        BadDigit = 3,
        BadValue = 4
    }

    public class Board
    {
        public const int MAX_GOES = 9;
        public int NoGoes=1;
        public string[] BoardCanvas = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        public TurnResult Turn(string pos, Player player)
        {
            if (!Int32.TryParse(pos, out int j))
                return TurnResult.BadDigit;
            if (NoGoes == MAX_GOES)
                return TurnResult.MaxReached;
            if (BoardCanvas[Int32.Parse(pos)-1] != pos)
                return TurnResult.BadValue;
            NoGoes=NoGoes+1;
            BoardCanvas[Int32.Parse(pos)-1] = player.MyChar;
            return TurnResult.Success;
        }

    }
}
