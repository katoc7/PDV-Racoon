﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
   
    SavingData sd = new SavingData();
   

    public int paints;
    public float health;
    public Vector3 position;
    public int level;

    public Text countPaint;
    public Text countlv;
    public Slider life; //listo
    public Rigidbody2D rb2d;

    void Start()
    {
        GameManager gm = new GameManager();
        health = life.value;
        paints = Int32.Parse(countPaint.text);
        position = rb2d.position;
        level = Int32.Parse(countlv.text);
    }
    

    public void saveGame()
    {
        Player raccon = new Player(paints,health,position,level);
       // sd.SaveData(raccon);
        //Debug.Log("SAVED");
    }


}
