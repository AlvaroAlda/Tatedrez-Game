using UnityEngine;

[CreateAssetMenu(fileName = "GameConfig", menuName = "Config/GameConfig")]
public class GameConfig : ScriptableObject
{
    [Header("CheckBoard Settings")]
    public int Size;

    public PlayerData[] Players;

    public Color ColorEven;
    public Color ColorOdd;
}

