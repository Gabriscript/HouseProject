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
    public Text text;
    public GameObject rotable;
    public float currentrotation=0;
    public float rotationspeed = 10;
    public bool activated=false;
    
    void OnTriggerEnter(Collider collision)
    {
       if (!activated)
        if(collision.tag=="Player")
        {
        inrange= true;
        text.enabled= true;
        }
        
    }
    void OnTriggerExit(Collider collision)
    {
       if(!activated)
        if (collision.tag == "Player") 
        {
            inrange = false;
            text.enabled = false;
        }
        
    }
    void Update()
    {
        if(!activated)
        if (Input.GetKeyDown(KeyCode.F))
        {
            activated= true;
            text.enabled = false;
        }
        Interact();
    }

    void Interact() 
    {
        if (activated)
        {

            if(currentrotation<=1.5f)
            {
                rotable.transform.rotation = quaternion.Euler(currentrotation, 0, 0);


                currentrotation += rotationspeed*Time.deltaTime;


            }
            

            

            
            

        }
        


    }

}
