using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Gun : MonoBehaviour
{
    private int amount;
    private float interval;
    public GameObject bullet;
    public GameObject shell;
    [SerializeField]
    private Transform muzzlePos;
    [SerializeField]
    private Transform chamberPos;

    public abstract void Attack();

    private void Awake()
    {
        muzzlePos = transform.Find("Muzzle");
        chamberPos = transform.Find("Chamber");
    }
}
