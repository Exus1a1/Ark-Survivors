using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public PlayerController pc;
    public StateManager sm;
    public WeaponManager wm;

    void Awake()
    {
        pc = Bind<PlayerController>(gameObject);
        sm = Bind<StateManager>(gameObject);
        wm = Bind<WeaponManager>(transform.Find("Weapon").gameObject);
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
