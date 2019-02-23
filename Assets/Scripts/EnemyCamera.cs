using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCamera : MonoBehaviour
{
    RaycastHit2D cameraRay;
    public float distance = 10f;
    Vector2 m_MyFirstVector;
    Vector2 m_MySecondVector;

    float m_Angle;

    public GameObject m_MyObject;
    public GameObject m_MyOtherObject;
   
    // Start is called before the first frame update
    void Start()
    {
         m_MyFirstVector = Vector2.zero;
        m_Angle = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        //Vector2.Angle(-transform.right,m_MyFirstVector -m_MySecondVector)
        m_MyFirstVector=m_MyObject.transform.position;
        m_MySecondVector=m_MyOtherObject.transform.position;

        m_Angle=Vector2.Angle(m_MyFirstVector,m_MySecondVector);
        Quaternion rotation = Quaternion.Euler(0, m_Angle, 0);

        

        Physics2D.Raycast(transform.position,-Vector2.right*transform.localScale,distance);
         Debug.Log("I'm seeing the player");
     
        //if (target == null) return;
     

    /* float distance = Vector3.Distance(transform.position, target.position);
     bool tooClose = distance < minRange;
     Vector3 direction = tooClose ? Vector3.back : Vector3.forward;
     transform.Translate(direction * Time.deltaTime);*/

     


    }

    void OnDrawGizmos(){
        Gizmos.color = Color.cyan;
        Gizmos.DrawLine(transform.position, transform.position+(-Vector3.right*transform.localScale.x) * distance);
    }

    

 /* void OnTriggerExit(Collider other) {
     if (other.tag == "Player"); //target = null;
     Debug.Log("Salio");
 }*/
 
}
