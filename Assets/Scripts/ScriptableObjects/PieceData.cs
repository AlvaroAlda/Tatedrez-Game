using UnityEngine;

[CreateAssetMenu(fileName = "PieceData", menuName = "Data/PieceData", order = 0)]
public class PieceData : ScriptableObject
{
    public bool Player1;
    public PieceId PieceId;
    public Sprite PieceSprite;
}
