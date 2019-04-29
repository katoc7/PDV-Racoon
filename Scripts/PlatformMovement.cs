using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour {

    /*	public float speed = 1.0f;
       public float vertical = 5.0f;
       public float max=10.0f;
       public float min = 0.0f;

       void Start () {

       }

       void Update () {
           var position = gameObject.transform.position;

           if(vertical<min)
               speed*=-1;

           if (vertical>max)
               speed*=-1;

           vertical+=speed;

           position.y = max;

           gameObject.transform.position = position;
       }*/
       

    public float speed = 1.0f;
    public float h = 0.0f;
    public float min = -5.0f;
    public float max = 5.1f;

    public bool vertical = true;


    void Start()
    {

    }

    void Update()
    {
        var position = gameObject.transform.position;

        if (h < min)
            speed *= -1;

        if (h > max)
            speed *= -1;

        h += speed;

        //Escoger la direccion de las plataformas
        if (vertical)
        {
            position.y = h;
        }
        else
        {
            position.x = h;
        }

        
        gameObject.transform.position = position;
    }
}
