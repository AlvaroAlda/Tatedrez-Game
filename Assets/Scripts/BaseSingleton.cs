using UnityEngine;

public class BaseSingleton<T> : MonoBehaviour where T : Component
{
    private static T _instance;
    public static T SharedInstance
    {
        get
        {
            if (!_instance)
            {
                _instance = new GameObject().AddComponent<T>();
                _instance.name = _instance.GetType().ToString();
                DontDestroyOnLoad(_instance.gameObject);
            }
            return _instance;
        }
    }
}
