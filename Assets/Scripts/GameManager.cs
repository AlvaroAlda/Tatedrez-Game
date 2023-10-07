using UnityEngine;

public class GameManager: MonoBehaviour
{
    private static GameManager _instance;
    private const string ConfigName = "GameConfig";
    
    private GameConfig _gameConfig;
    public GameConfig GameConfig => _gameConfig != null ? _gameConfig : Resources.Load<GameConfig>(ConfigName);

    public bool IsDynamicGameModeEnabled;
    
    public static GameManager SharedInstance
    {
        get
        {
            if (!_instance)
            {
                _instance = new GameObject().AddComponent<GameManager>();
                _instance.name = _instance.GetType().ToString();
                DontDestroyOnLoad(_instance.gameObject);
            }
            return _instance;
        }
    }
    
    private void Awake()
    {
        _gameConfig = Resources.Load<GameConfig>(ConfigName);
        IsDynamicGameModeEnabled = false;
    }
    
    public GridCell[,] GridCells;

    public void SwitchPlayer()
    {
        
    }

    public void SwitchGameMode()
    {
        IsDynamicGameModeEnabled = !IsDynamicGameModeEnabled;
    }

    public void EndGame()
    {
        
    }
    
}
