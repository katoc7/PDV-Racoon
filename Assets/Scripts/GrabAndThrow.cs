using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabAndThrow : MonoBehaviour
{
    public bool isGrabbed; 
    RaycastHit2D hit;
    public float distance=5f;
    public Transform puntoAnclaje;

    //float movementspeed = 0.5f;

    public float forceThrow;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {  
        //Time.timeScale=movementspeed;

       /*Vector3 posCharacter = new Vector3(Input.GetAxis("Horizontal"),0,0);
            gameObject.transform.position+=posCharacter*movementspeed;*/

        if(Input.GetButtonDown("Fire2")){ //Left Control

            

            if(!isGrabbed){

                hit= Physics2D.Raycast(transform.position,Vector2.right*transform.localScale.x,distance);

               if(hit.collider!=null){
                   isGrabbed=true;
               }
            }
            else{
                isGrabbed=false;
                if(hit.collider.gameObject.GetComponent<Rigidbody2D>()!=null){
                    //hit.collider.gameObject.GetComponent<Rigidbody2D>().gravityScale=1;
                    hit.collider.gameObject.GetComponent<Rigidbody2D>().velocity= 
                    new Vector2(transform.localScale.x,1)*forceThrow;

                }
            }
        }
        if(isGrabbed){
            hit.collider.gameObject.transform.position=puntoAnclaje.position;
        }
        
    }

    void OnDrawGizmos(){
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, transform.position+Vector3.right*transform.localScale.x * distance);
    }
}
