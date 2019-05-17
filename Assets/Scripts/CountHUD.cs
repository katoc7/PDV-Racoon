using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountHUD: MonoBehaviour
{
    public SpriteRenderer mapache;
    public Text countText;
    public GameObject gameOverPanel;
    public Image damageImage;
    public GameObject hudPanel;
    public Slider life;
    public float flashSpeed = 5f;
    public Color flashColour = new Color(1f, 0f, 0f, 0.1f);
    public Color normalColour = new Color(0f, 0f, 0f, 0f);

    int count = 0;
    int health = 100;

    private void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.tag == "Exit")
        {
            Debug.Log("Going to LEVEL 2");
            LoadByIndex(4);
        }
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
            int nhealth = health-5; //CAMBIAR CERDO
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

    public void LoadByIndex(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
