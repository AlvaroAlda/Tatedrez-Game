using UnityEngine;

public class GridCell
{
    public Vector3 Position;
    public BasePieceController GuestPiece;

    public GridCell(Vector3 position, BasePieceController guestPiece = null)
    {
        GuestPiece = guestPiece;
        Position = position;
    }
}
