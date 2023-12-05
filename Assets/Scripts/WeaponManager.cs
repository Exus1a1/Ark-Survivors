using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class WeaponManager : IPlayerManager
{
    public List<Gun> guns = new List<Gun>();

    private void Awake()
    {
        guns = GetComponentsInChildren<Gun>().ToList();
    }
}
