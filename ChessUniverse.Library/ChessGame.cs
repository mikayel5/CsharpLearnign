using ChessUniverse.Library.Enums;

namespace ChessUniverse.Library
{
  public  class ChessGame
    {
        public ChessBoard Board { get; }

        public PieceColor CurrentPlayer { get; private set; }

        public ChessGame()
        {
            Board = new ChessBoard();
            Board.SetStartPosition();
            CurrentPlayer = PieceColor.White;
        }
    }
}
