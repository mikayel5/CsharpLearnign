using ChessUniverse.Library.Enums;
using System.Collections;

namespace ChessUniverse.Library.Pieces;

public class Bishop(PieceColor color) : Piece(color, PieceType.Bishop)
{
    public override char GetSymbol() => Color == PieceColor.White ? 'B' : 'b';

    public override bool CanMove(int fromRow, int fromCol, int toRow, int toCol)
    {
        int dx = Math.Abs(fromRow - toRow);
        int dy = Math.Abs(fromCol - toCol);
        return dx == dy && dx != 0;
    }
}
