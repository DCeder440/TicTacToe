using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    public static class PrintHelper
    {
        public static void DrawBoardCanvas(Board board)
        {
            Console.Clear();
            Console.WriteLine("{0}  {1}  {2}", board.BoardCanvas[0], board.BoardCanvas[1], board.BoardCanvas[2]);
            Console.WriteLine("{0}  {1}  {2}", board.BoardCanvas[3], board.BoardCanvas[4], board.BoardCanvas[5]);
            Console.WriteLine("{0}  {1}  {2}", board.BoardCanvas[6], board.BoardCanvas[7], board.BoardCanvas[8]);
        } 
    }
}
