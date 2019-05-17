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



   // public Animator animatorDog;
    
    // Start is called before the first frame update
    void Start()
    {
        
       
    }

    // Update is called once per frame
    void Update()
    {
        float distanceToTarget = Vector3.Distance(transform.position,target.position);
        float distanceToDistractor = Vector3.Distance(transform.position,bDistractor.position);

        if(distanceToTarget <= chaseRangePlayer ){
            
           // animatorDog.SetBool("Intruso",true);
            Vector3 targetDirection = target.position - transform.position;
            //animatorDog.SetFloat("Spotted",1);
            float angle = Mathf.Atan2(targetDirection.y,targetDirection.x)*Mathf.Rad2Deg -45f;
            Quaternion q = Quaternion.AngleAxis(angle,Vector3.forward);
            transform.rotation =Quaternion.RotateTowards(transform.rotation,q,180);
            transform.Translate(Vector3.up * Time.deltaTime * speed);
            //animatorDog.SetBool("Intruso",false);
        } 

        
        if(distanceToDistractor <= chaseRangeDistractor){
            Vector3 targetDirection = bDistractor.position - transform.position;
            //animatorDog.SetBool("Intruso",false);
           // animatorDog.SetFloat("Spotted",0);
            float angle = Mathf.Atan2(targetDirection.y,targetDirection.x)*Mathf.Rad2Deg -45f;
            Quaternion q = Quaternion.AngleAxis(angle,Vector3.forward);
            transform.rotation =Quaternion.RotateTowards(transform.rotation,q,180);
            transform.Translate(Vector3.up * Time.deltaTime * speed);
        }

         if(distanceToTarget < distanceToDistractor && distanceToTarget <= chaseRangePlayer)
        {
            Vector3 targetDirection = target.position - transform.position;
            //animatorDog.SetBool("Intruso",false);
            //animatorDog.SetFloat("Spotted",1);
            float angle = Mathf.Atan2(targetDirection.y,targetDirection.x)*Mathf.Rad2Deg -45f;
            Quaternion q = Quaternion.AngleAxis(angle,Vector3.forward);
            transform.rotation =Quaternion.RotateTowards(transform.rotation,q,180);
            transform.Translate(Vector3.up * Time.deltaTime * speed);
        }

          if(distanceToDistractor < distanceToTarget && distanceToDistractor <= chaseRangeDistractor)
        {
             Vector3 targetDirection = bDistractor.position - transform.position;
            //animatorDog.SetBool("Intruso",true);
            //animatorDog.SetFloat("Spotted",0);
            float angle = Mathf.Atan2(targetDirection.y,targetDirection.x)*Mathf.Rad2Deg -45f;
            Quaternion q = Quaternion.AngleAxis(angle,Vector3.forward);
            transform.rotation =Quaternion.RotateTowards(transform.rotation,q,180);
            transform.Translate(Vector3.up * Time.deltaTime * speed);
        }

            Debug.Log("distancia al player"+distanceToTarget);
            Debug.Log("distancia al distractor"+distanceToDistractor);

    }
    
}
