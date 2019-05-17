using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OpenNewGame : MonoBehaviour
{

    public int paints;
    public float health;
    public Vector3 position;
    public int level;

    public Text countPaint;
    public Text lv;
    public Slider life; //listo
    public Rigidbody2D rb2d;
    private Player rakon;

    void Start()
    {
        if (OnOff.Load)
        {
            //LoadGame();
        }
    }

    public void LoadByIndex(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }

   

  
}
