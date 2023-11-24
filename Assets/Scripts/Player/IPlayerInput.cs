using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class IPlayerInput : MonoBehaviour
{
    public bool left;
    public bool right;
    public bool up;
    public bool down;
    public bool attack;
    public Vector2 direction
    {
        get
        {
            return GetDirection();
        }
    }

    public bool inputEnabled = true;

    private Vector2 GetDirection()
    {
        int Dup = Convert.ToInt32(up) - Convert.ToInt32(down);
        int Dright = Convert.ToInt32(right) - Convert.ToInt32(left);
        return Dright * Vector2.right + Dup * Vector2.up;
    }
}
