namespace ChessUniverse.Library.Pieces;

public class Rook(PieceColor color) : Piece(color, PieceType.Rook)
{
    public override char GetSymbol() => Color == PieceColor.White ? 'R' : 'r';
}
