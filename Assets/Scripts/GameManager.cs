using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Transform prefabHealthBar;

    
    // Start is called before the first frame update
    void Start()
    {
        HealthSystem healthSystem = new HealthSystem(100);
        Transform healthBarTransform = Instantiate(prefabHealthBar, new Vector3(0,3),Quaternion.identity);
        HealthBar healthBar = healthBarTransform.GetComponent<HealthBar>();

        healthBar.Setup(healthSystem);

        //healthSystem.Damage(10);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
