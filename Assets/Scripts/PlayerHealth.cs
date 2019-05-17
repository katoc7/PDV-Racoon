﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerHealth : MonoBehaviour
{
    public int iHealth = 100;                            
    public int currentHealth;                                  
    public Slider healthSlider;                                
    public Image damageImage;                                  
    public float flashSpeed = 5f;                               
    public Color flashColour = new Color(1f, 0f, 0f, 0.1f);
    private PlayerMovement playerMovement;                          
    bool isDead;                                               
    bool damaged;                                               


    void Awake()
    {
        playerMovement = GetComponent<PlayerMovement>();
        currentHealth = iHealth;
    }


    void Update()
    {
        if (damaged)
        {
            damageImage.color = flashColour;
        }
        else
        {
            damageImage.color = Color.Lerp(damageImage.color, Color.clear, flashSpeed * Time.deltaTime);
        }
        
        damaged = false;
    }


    public void TakeDamage(int amount)
    {
        damaged = true;
        currentHealth -= amount;
        healthSlider.value = currentHealth;

        if (currentHealth <= 0 && !isDead)
        {
            Death();
        }
    }


    void Death()
    {
       isDead = true;
       playerMovement.enabled = false;
    }
}
