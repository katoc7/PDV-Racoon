using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenMenu : MonoBehaviour
{
    public Button quitButton;
    public GameObject panel;

    void Start()
    {
        quitButton.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        Debug.Log("Quit");
        panel.gameObject.SetActive(true);
    }

}
