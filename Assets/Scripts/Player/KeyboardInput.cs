using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardInput : IPlayerInput
{
    private void Update()
    {
        if (inputEnabled)
        {
            left = Input.GetKey(InputManager.Instance.left);
            right = Input.GetKey(InputManager.Instance.right);
            up = Input.GetKey(InputManager.Instance.up);
            down = Input.GetKey(InputManager.Instance.down);
            attack = Input.GetMouseButton(InputManager.Instance.attack);
        }
    }
}
