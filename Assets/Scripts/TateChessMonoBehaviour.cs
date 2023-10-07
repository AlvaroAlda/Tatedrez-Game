using UnityEngine;

public class TateChessMonoBehaviour : MonoBehaviour
{
    protected GameManager Manager;
    protected GameConfig GameConfig;

    protected virtual void Awake()
    {
        Manager = GameManager.SharedInstance;
        GameConfig = Manager.GameConfig;
    }
}
