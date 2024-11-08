using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class FilterManager : MonoBehaviour
{
    public Image panel;
    [SerializeField] public Button publishButton;
    Boolean publish = false;
    public void Filter1()
    {
        panel.color = Color.red;
        publish = true;
    }

    public void Filter2()
    {
        panel.color = Color.yellow;
        publish = true;
    }

    public void Filter3()
    {
        panel.color = Color.green;
        publish = true;
    }

    void Update()
    {
        if(publish == true)
        {
            publishButton.interactable = true;
        }
        else
        {
            Debug.Log("You have to select a filter first");
        }
    }

}
