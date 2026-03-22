using ChessUniverse.Library.Enums;

namespace ChessUniverse.Library.Pieces;

public class Knight(PieceColor color) : Piece(color, PieceType.Knight)
{
    public override char GetSymbol() => Color == PieceColor.White ? 'N' : 'n';
    public override bool CanMove(int fromRow, int fromCol, int toRow, int toCol)
    {
        int dx = Math.Abs(fromRow - toRow);
        int dy = Math.Abs(fromCol - toCol);

        return (dx == 2 && dy == 1) ||
                   (dx == 1 && dy == 2);
    }
}
