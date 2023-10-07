using UnityEngine;

[CreateAssetMenu(fileName = "GameConfig", menuName = "Config/GameConfig")]
public class GameConfig : ScriptableObject
{
    public GridCell[,] GridCells;
    
    [Header("CheckBoard Settings")]
    public int Size;

    public Color ColorEven;
    public Color ColorOdd;
}

