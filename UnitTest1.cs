using System;
using Xunit;
using TicTacToe;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void NineTurnsReturnsMaxReachedResult()
        {
            Board board = new Board();
            Player player = new Player(true, "X");
            board.Turn("1", player);
            board.Turn("2", player);
            board.Turn("3", player);
            board.Turn("4", player);
            board.Turn("5", player);
            board.Turn("6", player);
            board.Turn("7", player);
            board.Turn("8", player);
            var res = board.Turn("9", player);
            Assert.True(res == TurnResult.MaxReached);
        }
        [Fact]
        public void BadDigitReturnsBadDigitResult()
        {
            Board board = new Board();
            Player player = new Player(true, "X");
            var res = board.Turn("s", player);
            Assert.True(res == TurnResult.BadDigit);
        }
        [Fact]
        public void PositionInArraySetCorrectly()
        {
            Board board = new Board();
            Player player = new Player(true, "X");
            var res = board.Turn("1", player);
            Assert.True(board.BoardCanvas[0] == "X");
        }
        [Fact]
        public void PlayerHelperSetsMyTurnOnOtherPlayer()
        {
            Board board = new Board();
            Player player1 = new Player(true, "X");
            Player player2 = new Player(false, "0");
            PlayerHelper playerHelper = new PlayerHelper(player1, player2, board);
            playerHelper.NextTurn("1");
            Assert.True(player2.MyTurn);
        }
        [Fact]
        public void WinHelperReturnsWinForHorizontalForPlayer1()
        {
            Board board = new Board();
            Player player1 = new Player(true, "X");
            Player player2 = new Player(false, "0");
            PlayerHelper playerHelper = new PlayerHelper(player1, player2, board);
            WinHelper winHelper = new WinHelper(board, player1, player2);
            playerHelper.NextTurn("1");
            playerHelper.NextTurn("4");
            playerHelper.NextTurn("2");
            playerHelper.NextTurn("5");
            playerHelper.NextTurn("3");
            Assert.True(winHelper.CheckWin());
            Assert.True(player1.IWin);
        }

    }
}
