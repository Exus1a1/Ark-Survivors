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
    public Transform weaponPos;
    void Awake()
    {
        anim = GetComponent<Animator>();
        pi = GetComponent<IPlayerInput>();
        if(pi == null)
        {
            pi = gameObject.AddComponent<KeyboardInput>();
        }
        rd = gameObject.GetComponent<Rigidbody2D>();
        weaponPos = transform.Find("Weapon");
    }

    // Update is called once per frame
    void Update()
    {
        rd.velocity = Vector2.Lerp(rd.velocity,pi.direction * maxSpeed,speedRate);
        anim.SetBool("isMoving", rd.velocity.sqrMagnitude > 5f);
        ChangeForward();
    }

    private void ChangeForward()
    {
        Vector2 mPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (mPos.x >= transform.position.x)
        {
            transform.rotation = new Quaternion(0, 0, 0, 0);
            weaponPos.localScale = new Vector3(1, 1, 1);
        }
        else
        {
            transform.rotation = new Quaternion(0, 180, 0, 0);
            weaponPos.localScale = new Vector3(1, -1, 1);
        }
        weaponPos.right = (mPos - new Vector2(transform.position.x, transform.position.y)).normalized;
    }
}
