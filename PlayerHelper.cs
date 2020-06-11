using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    public class PlayerHelper
    {
        Player _player1;
        Player _player2;
        Board _board;
 
        public PlayerHelper(Player player1, Player Player2, Board board)
        {
            _player1 = player1;
            _player2 = Player2;
            _board = board;
        }

        public TurnResult NextTurn(string pos)
        {
            if (_player1.MyTurn)
            {
                TurnResult res = _board.Turn(pos, _player1);
                if (res != TurnResult.Success)
                    return res;
                _player1.MyTurn = false;
                _player2.MyTurn = true;
            }
            else
            {
                TurnResult res = _board.Turn(pos, _player2);
                if (res != TurnResult.Success)
                    return res;
                _player2.MyTurn = false;
                _player1.MyTurn = true;
            }
            return TurnResult.Success;
        }
    }
}
