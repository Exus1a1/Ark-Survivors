using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using UnityEditor;
using UnityEngine;

public enum PlayerStateType
{
    Idle, Hit, Death
}

public class IdleState : IState
{
    private PlayerManager pm;
    private StateManager sm;
    private PlayerController pc;

    public IdleState(PlayerManager manager)
    {
        pm = manager;
        sm = manager.sm;
        pc = manager.pc;
    }
    public void OnEnter()
    {
        pc.anim.Play("idle");
    }

    public void OnUpdate()
    {
        
    }

    public void OnExit()
    {

    }
}