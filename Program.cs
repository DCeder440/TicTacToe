using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();
            Player player1 = new Player(true, "X");
            Player player2 = new Player(false, "0");
            PlayerHelper playerHelper = new PlayerHelper(player1, player2, board);
            WinHelper winHelper = new WinHelper(board, player1, player2);
            TurnResult res = TurnResult.Success;

            while (true)
            {
                PrintHelper.DrawBoardCanvas(board);
                if (res != TurnResult.Success)
                {
                    if (player1.MyTurn)
                        Console.WriteLine("Player1 re-enter number for your 'X'");
                    if (player2.MyTurn)
                        Console.WriteLine("Player2 re-enter number for your '0'");
                }
                else
                {
                    if (winHelper.CheckWin())
                    {
                        if (player1.IWin)
                            Console.WriteLine("Player1 has won!!!");
                        if (player2.IWin)
                            Console.WriteLine("Player2 has won!!!");
                    }
                    else
                    {
                        if (player1.MyTurn)
                            Console.WriteLine("Player1 enter number for your 'X'");
                        if (player2.MyTurn)
                            Console.WriteLine("Player2 enter number for your '0'");
                    }
                }
                var chr = Console.ReadKey();
                res = playerHelper.NextTurn(chr.KeyChar.ToString());
            }
        }
}
}
