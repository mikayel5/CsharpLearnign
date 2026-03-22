using ChessUniverse.Library.Enums;

namespace ChessUniverse.Library
{
  public  class ChessGame
    {
        public ChessBoard Board { get; }

        public PieceColor CurrentPlayer { get; private set; }

        
        public bool Move (int fromRow, int fromCol, int toRow, int toCol)
        {
            Piece? piece = Board[fromRow, fromCol]; // take pices 
            
            if (piece == null)
            {
                return false;
            }
           
            if (!piece.CanMove(fromRow, fromCol, toRow, toCol))
            {
                return false; 
            }

            Board[toRow, toCol] = piece;
            Board[fromRow, fromCol] = null; //Removed from its old location
            return true;
        }

        public ChessGame()
        {
            Board = new ChessBoard();
            Board.SetStartPosition();
            CurrentPlayer = PieceColor.White;
        }

       
    }
}
