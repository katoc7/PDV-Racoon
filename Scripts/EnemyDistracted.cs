using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyDistracted : MonoBehaviour
{
     private Transform target;
     public float restartDelay = 5f;
     float restartTimer; 
     //float movementspeed = 3.5f;
     //private Vector3 iPos; 
     //private Vector3 fPos; 
    // Start is called before the first frame update
    void Start()
    {
        target = null;
        
    }

    // Update is called once per frame
    void Update()
    {
        //Time.timeScale = movementspeed;


        Vector3 pattern= new Vector3(Mathf.PingPong(Time.time, 3*2),gameObject.transform.position.y,gameObject.transform.position.z);

        gameObject.transform.position= pattern;
    

        
    }

     void OnTriggerEnter2D(Collider2D col) {
        if (col.tag == "Player"){// 
            target = col.transform;
            transform.LookAt(target);
            Debug.Log("Entro");
            restartTimer += Time.deltaTime;
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.name);
            Debug.Log("Salio");
            }

    }
 
}
