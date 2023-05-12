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
    
    
    public bool activatedGen=false;
    public GameObject steam;
    public GameObject shackdoor;

    private void Start() {
        steam.SetActive(false);
        lightContainer.SetActive(false);
    }

    void OnTriggerEnter(Collider collision)
    {  
       if (!activatedGen)
        if(collision.tag=="Player")
        {
        inrange= true;
        text.SetActive(true);
        }
        
    }
    void OnTriggerExit(Collider collision)
    {
       if(!activatedGen)
        if (collision.tag == "Player") 
        {
            inrange = false;
            text.SetActive(false);
        }
        
    }
    void Update()
    {
        if(inrange) 
        if(!activatedGen)
        if (Input.GetKeyDown(KeyCode.F))
        {
            activatedGen = true;
            text.SetActive(false);
            steam.SetActive(true);
                lightContainer.SetActive(true);
                    shackdoor.SetActive(false);
                }
        Interact();
    }

    void Interact() 
    {
        
        
        


    }

}
