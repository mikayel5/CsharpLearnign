using ChessUniverse.Library.Enums;
using System.Collections;

namespace ChessUniverse.Library.Pieces;

public class King(PieceColor color) : Piece(color, PieceType.King)
{
    public override char GetSymbol() => Color == PieceColor.White ? 'K' : 'k';
    public override bool CanMove(int fromRow, int fromCol, int toRow, int toCol)
    {
        int dx = Math.Abs(fromRow - toRow);
        int dy = Math.Abs(fromCol - toCol);

        return (dx <= 1 && dy <= 1) && (dx != 0 || dy != 0);
    }

}
