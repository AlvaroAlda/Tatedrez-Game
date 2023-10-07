using UnityEngine;

[CreateAssetMenu(fileName = "PieceData", menuName = "Data/PieceData", order = 0)]
public class PieceData : ScriptableObject
{
    public PieceId PieceId;
    public Sprite PieceSprite;
    public PieceController PieceController;
}
