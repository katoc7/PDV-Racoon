using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Load : MonoBehaviour
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
        if (SavingData.IsSaved && SavingData.isNull!= true)
        {
           // SavingData.LoadData();
            rakon = SavingData.Raccon;
           // countPaint.text = rakon.Paints.ToString(); // Actualizar paints

            Debug.Log(countPaint.text);
        }
    }
    
}
