using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public PlayerController pc;
    public StateManager sm;

    void Awake()
    {
        pc = Bind<PlayerController>(transform.Find("Model").gameObject);
        sm = Bind<StateManager>(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private T Bind<T>(GameObject target) where T : IPlayerManager
    {
        T manager = target.GetComponent<T>();
        if (manager == null)
        {
            manager = target.AddComponent<T>();
        }
        if (manager.pm == null)
        {
            manager.pm = this;
        }
        return manager;
    }
}
