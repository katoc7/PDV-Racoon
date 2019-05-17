using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class OnOff : MonoBehaviour
{
    public Button yes;

    public static bool load{ get => load; set => load = value; }



    void Start() {
       
        yes.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        if (SavingData.IsSaved)
        {
            Debug.Log(SavingData.IsSaved);
            OnOff.load = true;
        }
        
    }

    
}
