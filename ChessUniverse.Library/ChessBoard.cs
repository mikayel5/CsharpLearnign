using ChessUniverse.Library.Pieces;
namespace ChessUniverse.Library;

public class ChessBoard
{
    private Piece?[,] _squares = new Piece?[8,8];
    public Piece? this[int row, int col]   // ինդեքսատոր
    {
        get => _squares[row, col];
        set => _squares[row, col] = value;
    }

    public Piece? this[string coordinate]              // 8 | 0  7 - (rank - '1')
    {                                                  // 7 | 1 
        get                                            // 6 | 2     
        {                                              // 5 | 3     
            if(coordinate.Length !=2) return null;     // 4 | 4     
            char file = coordinate[0]; // a - h        // 3 | 5     
            char rank = coordinate[1]; // 1 - 8        // 2 | 6
                                                       // 1 | 7
            int col = file - 'a';                           
            int row = 7 - (rank - '1');        
            
            if(row < 0 || row > 7 || col < 0 || col > 7) 
                return null;
            return _squares[row, col];
        }
        set
        {

        }
    }
    public void SetStartPosition()
    {                    
        Array.Clear(_squares, 0, _squares.Length);              // մաքրելու համար                                                

        _squares[0,0] = new Rook(PieceColor.Black);             //         A B C D E F G H
        _squares[0,1] = new Knight(PieceColor.Black);           // A8    8                 8
        _squares[0,2] = new Bishop(PieceColor.Black);           //       7                 7
        _squares[0,3] = new Queen(PieceColor.Black);            //       6                 6
        _squares[0,4] = new King(PieceColor.Black);             //       5                 5
        _squares[0,5] = new Bishop(PieceColor.Black);           //       4                 4
        _squares[0,6] = new Knight(PieceColor.Black);           //       3                 3
        _squares[0,7] = new Rook(PieceColor.Black);             //       2                 2
        for (int i = 0; i < 8; i++)                             //       1                 1
        {                                                       //         A B C D E F G H
            _squares[1, i] = new Pawn(PieceColor.Black);
            _squares[6, i] = new Pawn(PieceColor.White);
        }
        _squares[7, 0] = new Rook(PieceColor.White);     // A1
        _squares[7, 1] = new Knight(PieceColor.White);
        _squares[7, 2] = new Bishop(PieceColor.White);
        _squares[7, 3] = new Queen(PieceColor.White);
        _squares[7, 4] = new King(PieceColor.White);
        _squares[7, 5] = new Bishop(PieceColor.White);
        _squares[7, 6] = new Knight(PieceColor.White);
        _squares[7, 7] = new Rook(PieceColor.White);
    }
}
