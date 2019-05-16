using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChaserAi : MonoBehaviour
{
    public float speed;

    float restartTimer;
    public Transform target;
    public Transform bDistractor;

    public float chaseRangePlayer;
    public float chaseRangeDistractor;

    
    // Start is called before the first frame update
    void Start()
    {
        
       
    }

    // Update is called once per frame
    void Update()
    {
        float distanceToTarget = Vector3.Distance(transform.position,target.position);
        float distanceToDistractor = Vector3.Distance(transform.position,bDistractor.position);
        if(distanceToTarget < chaseRangePlayer || chaseRangePlayer < distanceToDistractor){
            Vector3 targetDirection = target.position - transform.position;
            float angle = Mathf.Atan2(targetDirection.y,targetDirection.x)*Mathf.Rad2Deg -45f;
            Quaternion q = Quaternion.AngleAxis(angle,Vector3.forward);
            transform.rotation =Quaternion.RotateTowards(transform.rotation,q,180);
            transform.Translate(Vector3.up * Time.deltaTime * speed);
        } 
        
        if(distanceToDistractor < chaseRangeDistractor || chaseRangeDistractor < distanceToTarget){
            Vector3 targetDirection = bDistractor.position - transform.position;
            float angle = Mathf.Atan2(targetDirection.y,targetDirection.x)*Mathf.Rad2Deg -45f;
            Quaternion q = Quaternion.AngleAxis(angle,Vector3.forward);
            transform.rotation =Quaternion.RotateTowards(transform.rotation,q,180);
            transform.Translate(Vector3.up * Time.deltaTime * speed);
        }
    }
    /*
     void OnTriggerEnter2D(Collider2D col) {

         
        if (col.tag == "Player"){

            
            Debug.Log("Hace danio");
            healthSystem.Damage(10);
            Debug.Log(healthSystem.GetHealthPercent());
            Debug.Log(healthSystem.GetHealth());

            if(healthSystem.GetHealth()<=0){
                restartTimer += Time.deltaTime;
                Scene scene = SceneManager.GetActiveScene();
                SceneManager.LoadScene(scene.name);

            }
            
            }

    }
    */
}
