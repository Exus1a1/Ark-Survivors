using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;
using UnityEngine.U2D;

public class BulletShell : MonoBehaviour
{
    public float speed;
    public float stopTime = .5f;
    public float fadeSpeed = .1f;
    private Rigidbody2D rb;
    private SpriteRenderer sp;

    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        sp = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Start()
    {
        float angle = Random.Range(-30f, 30f);
        rb.velocity = Quaternion.AngleAxis(angle, Vector3.forward) * Vector3.up * speed;
        sp.color = new Color(sp.color.r, sp.color.g, sp.color.b, 1);
        rb.gravityScale = 3;

        StartCoroutine(Stop());
    }

    IEnumerator Stop()
    {
        yield return new WaitForSeconds(stopTime);
        rb.velocity = Vector2.zero;
        rb.gravityScale = 0;

        while (sp.color.a > 0)
        {
            sp.color = new Color(sp.color.r, sp.color.g, sp.color.g, sp.color.a - fadeSpeed);
            yield return new WaitForFixedUpdate();
        }
        Destroy(gameObject);
    }
}
