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

    private static bool load;

    public static bool Load{ get => load; set => load = value; }

    void Start()
    {

        yes.onClick.AddListener(TaskOnClick);
        if (yes.gameObject.tag == "Menu" && !SavingData.IsSaved)
        {
            yes.GetComponent<Button>().interactable = false;
        }

        void TaskOnClick()
        {
            if (SavingData.IsSaved)
            {
                OnOff.load = true;
                if (yes.gameObject.tag == "Menu")
                {
                   LoadByIndex(3);
                }
                else
                {
                   LoadByIndex(1);
                    yes.GetComponent<Button>().interactable = true;
                }
            }

        }
        void LoadByIndex(int sceneIndex)
        {
            SceneManager.LoadScene(sceneIndex);
        }
    }
}
