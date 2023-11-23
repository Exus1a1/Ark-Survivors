using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InputManager: Singleton<InputManager>
{
    public string shoot;
    public string up;
    public string right;
    public string left;
    public string down;

    private void Awake()
    {
        CheckSingle();
    }
    private void CheckSingle()
    {
        if (instance == null)
        {
            instance = this;
            return;
        }
        else
        {
            Destroy(this);
        }
    }
}
