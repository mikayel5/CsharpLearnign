using ChessUniverse.Library.Enums;

namespace ChessUniverse.Library.Pieces;

public class Queen(PieceColor color) : Piece(color, PieceType.Queen) 
{
    public override char GetSymbol() => Color == PieceColor.White ? 'Q' : 'q';

    public override bool CanMove(int fromRow, int fromCol, int toRow, int toCol)
    {
        int dx = Math.Abs(fromRow - toRow);
        int dy = Math.Abs(fromCol - toCol);

        return (dx == dy && dx != 0) || ((dy == 0) || (dx == 0)) && (dx != 0 || dy != 0);
    }

}
