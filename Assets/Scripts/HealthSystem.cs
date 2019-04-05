using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class HealthSystem {

public event EventHandler OnHealthChange;
private int health;
private int healthMax;
    public HealthSystem(int healthMax){
        this.healthMax=healthMax;
        health=healthMax;
    }

    public int GetHealth(){
        return health;
    }

    public float GetHealthPercent(){
        return (float)health / healthMax;
    }

    public void Damage(int damageTaken){
        health -= damageTaken;

        if(health < 0) health =0;
        if(OnHealthChange != null ) OnHealthChange(this, EventArgs.Empty);
        
    }
}
