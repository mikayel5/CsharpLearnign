using ChessUniverse.Library.Enums;

namespace ChessUniverse.Library;

public abstract class Piece(PieceColor color, PieceType type)
{
    public PieceColor Color { get; } = color;
    public PieceType Type { get; } = type;

    public virtual char GetSymbol()
    {
        return '?';
    }

    public abstract bool CanMove(int fromRow, int fromCol, int toRow, int toCol);
  
}
