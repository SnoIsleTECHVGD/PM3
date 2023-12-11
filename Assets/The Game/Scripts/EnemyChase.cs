using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChase : MonoBehaviour
{
    public Transform target;
    public float followDistance;

    private Rigidbody2D rb2D;

    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    
    {
        if (Vector.Distance(taget.positon, transform.positon) < followDistance) ;
        rb2D.velocity = target.position - transform.position;
        rb2D.velocity = (target.position - transform.position).normakized * speed;
    }
}
