using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    public class Player
    {
        public bool MyTurn;
        public string MyChar;
        public bool IWin;
       
        public Player(bool myTurn, string myChar)
        {
            MyTurn = myTurn;
            MyChar = myChar;
        }
    }
}
