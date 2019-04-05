using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    private HealthSystem healthsystem;
  public void Setup(HealthSystem healthsystem){ 
      this.healthsystem= healthsystem;
      healthsystem.OnHealthChange += HealthSystem_OnHealthChange;

  }

    private void HealthSystem_OnHealthChange(object sender, EventArgs e)
    {
        transform.Find("Bar").localScale = new Vector3(healthsystem.GetHealthPercent(),1);
    }

    private void Update(){
      //transform.Find("Bar").localScale = new Vector3(healthsystem.GetHealthPercent(),1);
  }

}
