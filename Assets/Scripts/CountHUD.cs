using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountHUD: MonoBehaviour
{
    public Text countText;

    public GameObject gameOverPanel;
    public GameObject hudPanel;
    public Slider life;

    int count = 0;
    int health = 100;

    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.tag == "Paint")
        {
            count++;
            countText.text = "" + count;
        }

        if (col.gameObject.tag == "Enemy")
        {
            int nhealth = health-20;
            life.value = nhealth;
            health = nhealth;

            if(nhealth<=0){
                Debug.Log("MAPACHE MUERTO");
                gameOverPanel.gameObject.SetActive(true);
                hudPanel.gameObject.SetActive(false);

            }
        }

    }
}
