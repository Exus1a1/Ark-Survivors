using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InputManager: Singleton<InputManager>
{
    public int attack = 0;
    public KeyCode up = KeyCode.W;
    public KeyCode right = KeyCode.D;
    public KeyCode left = KeyCode.A;
    public KeyCode down = KeyCode.S;

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
