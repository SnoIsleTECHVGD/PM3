
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
        if (Input.GetKey(left))
        {
            
            rb2D.AddForce(Vector2.left * buildup);
            GetComponent<Animator>().SetInteger("WalkDirection", 1);
        }
        if (Input.GetKey(right))
        {

            rb2D.AddForce(Vector2.right * buildup);
            GetComponent<Animator>().SetInteger("WalkDirection", 3);
        }
        if (Input.GetKey(up))
        {
            rb2D.AddForce(Vector2.up * buildup);
            GetComponent<Animator>().SetInteger("WalkDirection", 2);
        }
        if (Input.GetKey(down))
        {

            rb2D.AddForce(Vector2.down * buildup);
            GetComponent<Animator>().SetInteger("WalkDirection", 0);
        }
        if (Input.GetKeyUp(down))
        {
            GetComponent<Animator>().SetInteger("WalkDirection", 4);
        }
        if (Input.GetKeyUp(up))
        {
            GetComponent<Animator>().SetInteger("WalkDirection", 4);
        }
        if (Input.GetKeyUp(left))
        {
            GetComponent<Animator>().SetInteger("WalkDirection", 4);
        }
        if (Input.GetKeyUp(right))
        {
            GetComponent<Animator>().SetInteger("WalkDirection", 4);
        }
        rb2D.velocity = new Vector2(Mathf.Clamp(rb2D.velocity.x, -maxSpeed, maxSpeed), Mathf.Clamp(rb2D.velocity.y, -maxSpeed, maxSpeed));
    }
}
