using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarChaser : MonoBehaviour
{
    public float speed;
    public Transform target;

    public float chaseRangePlayer;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distanceToTarget = Vector3.Distance(transform.position,target.position);
       
        if(distanceToTarget < chaseRangePlayer ){
            Vector3 targetDirection = target.position - transform.position;
            
            transform.Translate(targetDirection * Time.deltaTime * speed);
        } 
        
        
    }

     
}
