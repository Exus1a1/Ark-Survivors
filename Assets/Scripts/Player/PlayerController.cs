using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : IPlayerManager
{
    public Animator anim;
    public IPlayerInput pi;
    public float maxSpeed = 5f;
    public Rigidbody2D rd;
    public float speedRate = .5f;
    void Awake()
    {
        anim = GetComponent<Animator>();
        pi = GetComponent<IPlayerInput>();
        if(pi == null)
        {
            pi = gameObject.AddComponent<KeyboardInput>();
        }
        rd = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rd.velocity = Vector2.Lerp(rd.velocity,pi.direction * maxSpeed,speedRate);
        anim.SetBool("isMoving", rd.velocity.sqrMagnitude > 5f);
    }
}
