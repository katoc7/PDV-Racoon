using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ForRealCamera : MonoBehaviour
{
    BoxCollider2D cameraCol;
    private Transform target;
    float restartTimer; 

    public Light l;
    // Start is called before the first frame update
    void Start()
    {
        cameraCol = gameObject.GetComponent<BoxCollider2D>();
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
        if(other.tag!="Deactivator"){
            gameObject.GetComponent<BoxCollider2D>().enabled = true;
        } else if(other.tag == "Deactivator"){
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
            l.GetComponent<Light>().enabled = false;
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
