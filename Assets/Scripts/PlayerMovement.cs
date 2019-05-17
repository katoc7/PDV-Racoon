        using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float jumpHeight = 6.5f;
    public float pSpeed = 10.0f;
    public float maxSpeed = 15.0f;
    public bool grounded=true;
    public bool docked = false;
    public bool pose = false;

    private Rigidbody2D rb2d;
    private Animator anim;
    private bool jump;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        /*float horizontal = Input.GetAxis("Horizontal");
        var position = gameObject.transform.position;
        position.x += (horizontal*pSpeed);
        
        if (Input.GetKeyDown("space"))
        {
            position.y += jumpHeight;
        }

        gameObject.transform.position = position;*/

        anim.SetFloat("Speed", Mathf.Abs(rb2d.velocity.x));
        anim.SetBool("Grounded", grounded);
        anim.SetBool("Docked", docked);
        anim.SetBool("Pose", pose);

        //Saltar
        if ((Input.GetKeyDown("space") || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W)) && grounded)
        {
            jump = true;
            docked = false;
            pose = false;
        }
        
        //Agacharse
        if ((Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.S)) && grounded)
        {
            docked = true;
        }
        else
        {
            docked = false;
        }

        //Posar
        if (Input.GetKey(KeyCode.LeftShift) && grounded && (Mathf.Abs(rb2d.velocity.x)<0.1))
        {
            pose = true;
        }
        else
        {
            pose = false;   
        }

        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.S))
        {
            rb2d.gravityScale = 1.0f;
           // Debug.Log(rb2d.gravityScale);
        }

    }

    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        rb2d.AddForce(Vector2.right * pSpeed * horizontal);

        float limitSpeed = Mathf.Clamp(rb2d.velocity.x, -maxSpeed, maxSpeed);
        rb2d.velocity = new Vector2(limitSpeed, rb2d.velocity.y);

        if (horizontal > 0.1f)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
        if (horizontal < -0.1f)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
        
        if(jump)
        {
            rb2d.AddForce(Vector2.up * jumpHeight, ForceMode2D.Impulse);
            jump = false;
        }

        if (docked)
        {

        }

        if (pose)
        {

        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag=="Pole")
        {
            rb2d.gravityScale = 0.0f;
            if(Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.S))
            {
                rb2d.gravityScale = 1.0f;
                Debug.Log(rb2d.gravityScale);
            }
        }
    }

    void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.tag == "Pole")
        {
            rb2d.gravityScale = 1.0f;
            Debug.Log("Exit");
        }
    }
}
