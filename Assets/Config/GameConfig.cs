using UnityEngine;

[CreateAssetMenu(fileName = "GameConfig", menuName = "Config/GameConfig")]
public class GameConfig : ScriptableObject
{
    [Header("Grid Settings")] 
    public int Size;

    public GridCell[,] GridCells;
}

