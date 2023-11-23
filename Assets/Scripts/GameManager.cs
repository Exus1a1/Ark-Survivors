using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    private void Awake()
    {
        CheckGameManager();
    }
    private void CheckGameManager()
    {
        if (tag == "GameManager")
        {
            CheckSingle();
            InitGamanger();
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

    private void InitGamanger()
    {
        GetOrAddComponent<InputManager>();
    }

    private void GetOrAddComponent<T>() where T : Component
    {
        T temp = GetComponent<T>();
        if (temp == null) {
            gameObject.AddComponent<T>();
        }
    }
}
