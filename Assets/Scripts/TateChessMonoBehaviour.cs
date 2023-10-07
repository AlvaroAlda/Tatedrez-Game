using UnityEngine;

public class TateChessMonoBehaviour : MonoBehaviour
{
    protected GameConfig GameConfig;
    private const string ConfigName = "GameConfig";

    protected virtual void Awake()
    {
        GameConfig = Resources.Load<GameConfig>(ConfigName);
    }
}
