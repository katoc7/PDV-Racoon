using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ForRealCamera : MonoBehaviour
{
    PolygonCollider2D cameraCol;
    private Transform target;
    float restartTimer; 
    // Start is called before the first frame update
    void Start()
    {
        cameraCol = gameObject.GetComponent<PolygonCollider2D>();
        cameraCol.enabled=true;
        target=null;
    }

    // Update is called once per frame
    void Update()
    {
        
                
                //gameObject.GetComponent<Collider2D>().enabled = false;
                /* gameObject.GetComponent<PolygonCollider2D>.enabled = false;
                yield return new WaitForSeconds (2);
                collider.enabled = true;*/
    }


/* public void inciarCameraOnOff(){
    StartCoroutine(CamaraTurnOnOff());
}
    public IEnumerator CamaraTurnOnOff(){
        
        
         while(gameObject.GetComponent<PolygonCollider2D>().enabled == true){
            gameObject.GetComponent<PolygonCollider2D>().enabled = false;
            yield return new WaitForSeconds(2);
            gameObject.GetComponent<PolygonCollider2D>().enabled = true;

        }
        
         if(gameObject.GetComponent<PolygonCollider2D>().enabled == true){
            
            Debug.Log("Enters");
            gameObject.GetComponent<PolygonCollider2D>().enabled = false;
            yield return new WaitForSeconds(2);
            
            Debug.Log("Exits");
             


        }else if(gameObject.GetComponent<PolygonCollider2D>().enabled == false){
           
            gameObject.GetComponent<PolygonCollider2D>().enabled = true;
            yield return new WaitForSeconds(2);
        } 
        
    }*/

    void OnTriggerEnter2D(Collider2D other){
        Debug.Log("summat");
        //inciarCameraOnOff();
        if(other.tag!="Enemy" || other.tag!="Player"){
            gameObject.GetComponent<PolygonCollider2D>().enabled = false;
        }

        if (other.tag == "Player"){// 
            target = other.transform;
            transform.LookAt(target);
            Debug.Log("Entro");
            restartTimer += Time.deltaTime;
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.name);
            Debug.Log("Salio");
            }
    }

    /*void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("summat");
        inciarCameraOnOff();

        if (other.tag == "Ground")
        {// 
            gameObject.transform.position =other.gameObject.transform.position;
        }
    }*/
}
