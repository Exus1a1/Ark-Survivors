using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    private void Awake()
    {
        CheckGameManager();
    }
    private void CheckGameManager()
    {
        if (CompareTag("GameManager"))
        {
            CheckSingle();
            InitGameManager();
            return;
        }
        else
        {
            Destroy(this);
        }
    }

    private void CheckSingle()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            return;
        }
        else
        {
            Destroy(this);
        }
    }

    private void InitGameManager()
    {
        GetOrAddComponent<InputManager>();
    }

    private void GetOrAddComponent<T>() where T : Component
    {
        if (!TryGetComponent<T>(out _)) {
            gameObject.AddComponent<T>();
        }
    }
}
