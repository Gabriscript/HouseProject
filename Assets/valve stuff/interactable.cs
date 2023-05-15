using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

public class interactable : MonoBehaviour
{
    public bool inrange=false;
    public GameObject text;
    public GameObject rotable;
    public float currentrotation=0;
    public float rotationspeed = 10;
    public bool activated=false;
    public GameObject steam;
    public GameObject gaswall;
    
    
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
        if(inrange) 
        if(!activated)
        if (Input.GetKeyDown(KeyCode.F))
        {
            activated= true;
            text.SetActive( false);
            steam.SetActive(false);
            gaswall.SetActive(false);
            
        }
        Interact();
    }

    void Interact() 
    {
        if (activated)
        {

            if(currentrotation<=3f)
            {
                rotable.transform.rotation = quaternion.Euler(0, -90, currentrotation);


                currentrotation += rotationspeed*Time.deltaTime;


            }
            

            

            
            

        }
        


    }

}
