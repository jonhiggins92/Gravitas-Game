using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Vector2 gravity;
    private Rigidbody2D rb;
    [SerializeField] private float speed;
    public Animator animator;
    public int gravSwitch = 1;
    public float jumpForce = 27;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        gravity = Physics2D.gravity;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * speed, rb.velocity.y);
        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce * gravSwitch);
        }
        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("Fire");
            reverseGravity();
        }

        animator.SetFloat("Speed", Mathf.Abs(rb.velocity.x));
            
    }

    void reverseGravity()
    {
        if (rb.gravityScale == 10)
        {
            rb.gravityScale = -10;
            animator.SetBool("Switch", true);
            gravSwitch = -1;
        }
        else if (rb.gravityScale == -10)
        {
            rb.gravityScale = 10;
            animator.SetBool("Switch", false);
            gravSwitch = 1;
        }
    }


}
