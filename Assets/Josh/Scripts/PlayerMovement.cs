
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public KeyCode left;
    public KeyCode right;
    public KeyCode up;
    public KeyCode down;
    public float buildup;
    public float maxSpeed;


    private Rigidbody2D rb2D;


    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        if (Input.GetKeyDown(left))
        {
            
            rb2D.velocity = (Vector2.left * buildup);
        }
        if (Input.GetKeyUp(left))
        {
            rb2D.velocity = Vector2.left * 0;
        }
        if (Input.GetKeyDown(right))
        {
            
            rb2D.velocity = (Vector2.right * buildup);
        }
        if (Input.GetKeyUp(right))
        {
            rb2D.velocity = Vector2.right * 0;
        }
        if (Input.GetKeyDown(up))
        {
            rb2D.velocity = (Vector2.up * buildup);
        }
        if (Input.GetKeyUp(up))
        {
            rb2D.velocity = Vector2.up * 0;
        }
        if (Input.GetKeyDown(down))
        {
            
            rb2D.velocity = (Vector2.down * buildup);
        }
        if (Input.GetKeyUp(down))
        {
            rb2D.velocity = Vector2.down * 0;
        }
    }
}
