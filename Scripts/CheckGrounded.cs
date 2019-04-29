using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGrounded : MonoBehaviour
{
    private PlayerMovement player;

    void Start()
    {
        player = GetComponentInParent<PlayerMovement>();
        
    }

    void OnCollisionStay2D(Collision2D col)
    {

        if (col.gameObject.tag == "Ground")
        {
            player.grounded = true;
        }

    }
    void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ground")
        {
            player.grounded = false;
        }
    }
}
