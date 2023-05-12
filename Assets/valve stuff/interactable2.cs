using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

public class interactable2 : MonoBehaviour
{
    public bool inrange=false;
    public GameObject text;


    bool activatedkey;
    public GameObject key;

    private void Start() {
        
        
    }

    void OnTriggerEnter(Collider collision)
    {  
       if (!activatedkey)
        if(collision.tag=="Player")
        {
        inrange= true;
        text.SetActive(true);
        }
        
    }
    void OnTriggerExit(Collider collision)
    {
       if(!activatedkey)
        if (collision.tag == "Player") 
        {
            inrange = false;
            text.SetActive(false);
        }
        
    }
    void Update()
    {
        if(inrange) 
        if(!activatedkey)
        if (Input.GetKeyDown(KeyCode.F))
        {
            
            text.SetActive(false);
            
                }
        Interact();
    }

    void Interact() 
    {
        
        
        


    }

}
