using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

public class interactable1 : MonoBehaviour
{
    public bool inrange=false;
    public GameObject text;
    public GameObject   lightContainer;
    
    
    public bool activated=false;
    public GameObject steam;

    private void Start() {
        steam.SetActive(false);
        lightContainer.SetActive(false);
    }

    void OnTriggerEnter(Collider collision)
    {  
       if (!activated)
        if(collision.tag=="Player")
        {
        inrange= true;
        text.SetActive(true);
        }
        
    }
    void OnTriggerExit(Collider collision)
    {
       if(!activated)
        if (collision.tag == "Player") 
        {
            inrange = false;
            text.SetActive(false);
        }
        
    }
    void Update()
    {
        if(!activated)
        if (Input.GetKeyDown(KeyCode.F))
        {
            activated= true;
            
            steam.SetActive(true);
                lightContainer.SetActive(true);
        }
        Interact();
    }

    void Interact() 
    {
        
        
        


    }

}
