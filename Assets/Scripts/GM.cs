using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine.UI;


public class GM : MonoBehaviour
{

    public int paints;
    public float healt;
    public Vector3 position;
    public int level;

    public Text countPaint;
    public Text lv;
    public Slider life; //listo
    public Rigidbody2D rb2d;
    private Player raccon;
    public GameObject reikon;
    
    public Text countText;
    public GameObject gameOverPanel;
    public Image damageImage;
    public GameObject hudPanel;
    public float flashSpeed = 5f;
    public Color flashColour = new Color(1f, 0f, 0f, 0.1f);
    public Color normalColour = new Color(0f, 0f, 0f, 0f);

    int count = 0;
    int health = 100;

    public static GM instance = null;


    void Start()
    {/*
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }

        if (SavingData.IsSaved)
        {
            Debug.Log("MATAME YA");
            SavingData.LoadData();
        }
       */
    }

 
 
    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.tag == "Paint")
        {
            count++;
            countText.text = "" + count;
        }

        if (col.gameObject.tag == "Pigg")
        {
            int nhealth = health - 5; //CAMBIAR CERDO
            life.value = nhealth;
            health = nhealth;
            damageImage.color = flashColour;
            Debug.Log("MAPACHE MUERTO");
            gameOverPanel.gameObject.SetActive(true);
            hudPanel.gameObject.SetActive(false);
        }

        if (col.gameObject.tag == "Bat")
        {
            int nhealth = health - 10;
            life.value = nhealth;
            health = nhealth;
            damageImage.color = flashColour;
            StartCoroutine(ChangeWhite());

            if (nhealth <= 0)
            {
                Debug.Log("MAPACHE MUERTO");
                gameOverPanel.gameObject.SetActive(true);
                hudPanel.gameObject.SetActive(false);

            }

        }

        if (col.gameObject.tag == "Heart")
        {
            int nhealth = health + 20;
            life.value = nhealth;
            health = nhealth;
        }
    }

    IEnumerator ChangeWhite()
    {
        yield return new WaitForSeconds(1);
        damageImage.color = normalColour;
    }

   
}
