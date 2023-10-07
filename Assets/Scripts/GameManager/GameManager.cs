using UnityEngine;

public class GameManager: BaseSingleton<GameManager>
{
    private const string ConfigName = "GameConfig";
    private GameConfig _gameConfig;
    public GameConfig GameConfig => _gameConfig != null ? _gameConfig : Resources.Load<GameConfig>(ConfigName);
    
    public GridCell[,] GridCells;

    void Awake()
    {
        _gameConfig = Resources.Load<GameConfig>(ConfigName);
    }

    public void SwitchPlayer()
    {
        
    }

    public void SwitchGameMode()
    {
   
    }

    public void EndGame()
    {
        
    }
    
}
