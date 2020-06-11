using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    public class WinHelper
    {
        Board _board;
        Player _player1;
        Player _player2;
        public WinHelper(Board board, Player player1, Player player2)
        {
            _board = board;
            _player1 = player1;
            _player2 = player2;
        }

        public bool CheckWin()
        {
            if (CheckHorizontalWin())
                return true;
            if (CheckVerticalWin())
                return true;
            if (CheckDiagonalWin())
                return true;
            return false;
        }
        public bool CheckHorizontalWin()
        {
            if ((_board.BoardCanvas[0] == _player1.MyChar && _board.BoardCanvas[1] == _player1.MyChar && _board.BoardCanvas[2] == _player1.MyChar) ||
                (_board.BoardCanvas[3] == _player1.MyChar && _board.BoardCanvas[4] == _player1.MyChar && _board.BoardCanvas[5] == _player1.MyChar) ||
                (_board.BoardCanvas[6] == _player1.MyChar && _board.BoardCanvas[7] == _player1.MyChar && _board.BoardCanvas[8] == _player1.MyChar))
            {
                _player1.IWin = true;
                return true;
            }
            if ((_board.BoardCanvas[0] == _player2.MyChar && _board.BoardCanvas[1] == _player2.MyChar && _board.BoardCanvas[2] == _player2.MyChar) ||
                (_board.BoardCanvas[3] == _player2.MyChar && _board.BoardCanvas[4] == _player2.MyChar && _board.BoardCanvas[5] == _player2.MyChar) ||
                (_board.BoardCanvas[6] == _player2.MyChar && _board.BoardCanvas[7] == _player2.MyChar && _board.BoardCanvas[8] == _player2.MyChar))
            {
                _player2.IWin = true;
                return true;
            }
            return false;
        }
        public bool CheckVerticalWin()
        {
            if ((_board.BoardCanvas[0] == _player1.MyChar && _board.BoardCanvas[3] == _player1.MyChar && _board.BoardCanvas[6] == _player1.MyChar) ||
                (_board.BoardCanvas[1] == _player1.MyChar && _board.BoardCanvas[4] == _player1.MyChar && _board.BoardCanvas[7] == _player1.MyChar) ||
                (_board.BoardCanvas[2] == _player1.MyChar && _board.BoardCanvas[5] == _player1.MyChar && _board.BoardCanvas[8] == _player1.MyChar))
            {
                _player1.IWin = true;
                return true;
            }
            if ((_board.BoardCanvas[0] == _player2.MyChar && _board.BoardCanvas[3] == _player2.MyChar && _board.BoardCanvas[6] == _player2.MyChar) ||
                (_board.BoardCanvas[1] == _player2.MyChar && _board.BoardCanvas[4] == _player2.MyChar && _board.BoardCanvas[7] == _player2.MyChar) ||
                (_board.BoardCanvas[2] == _player2.MyChar && _board.BoardCanvas[5] == _player2.MyChar && _board.BoardCanvas[8] == _player2.MyChar))
            {
                _player2.IWin = true;
                return true;
            }
            return false;
        }
        public bool CheckDiagonalWin()
        {
            if ((_board.BoardCanvas[0] == _player1.MyChar && _board.BoardCanvas[4] == _player1.MyChar && _board.BoardCanvas[8] == _player1.MyChar) ||
                (_board.BoardCanvas[2] == _player1.MyChar && _board.BoardCanvas[4] == _player1.MyChar && _board.BoardCanvas[6] == _player1.MyChar))
            {
                _player1.IWin = true;
                return true;
            }
            if ((_board.BoardCanvas[0] == _player2.MyChar && _board.BoardCanvas[4] == _player2.MyChar && _board.BoardCanvas[8] == _player2.MyChar) ||
                (_board.BoardCanvas[2] == _player2.MyChar && _board.BoardCanvas[4] == _player2.MyChar && _board.BoardCanvas[6] == _player2.MyChar))
            {
                _player2.IWin = true;
                return true;
            }
            return false;
        }
    }
}
