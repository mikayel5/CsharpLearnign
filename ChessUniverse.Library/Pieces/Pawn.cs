using ChessUniverse.Library.Enums;

namespace ChessUniverse.Library.Pieces;

public class Pawn(PieceColor color) : Piece(color, PieceType.Pawn)
{
    public override char GetSymbol() => Color == PieceColor.White ? 'P' : 'p';
    public override bool CanMove(int fromRow, int fromCol, int toRow, int toCol)
    {
        if (Color == PieceColor.White)
        {
            return toRow == fromRow - 1 && fromCol == toCol;
        }
        else
        {
            return toRow == fromRow + 1 && fromCol == toCol;
        }
    }
}
