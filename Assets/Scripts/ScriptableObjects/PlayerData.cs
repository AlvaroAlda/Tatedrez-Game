using System;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData", menuName = "Data/PlayerData", order = 0)]
public class PlayerData : ScriptableObject
{
    public string PlayerName;
    public int PlayerId;
    public PieceData[] Pieces;
}

    
