using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Pool;
using UnityEngine.UI;

public class interactable3 : MonoBehaviour
{
    public bool inrange=false;
    public GameObject text;
    public GameObject Getin;

    bool activatedkey;
    public Animator animator;
    bool getin=false;
    public Image fade;
    bool getin2;
    private void Start() {
        
        
    }

    void OnTriggerEnter(Collider collision)
    {  
       if (!activatedkey)
        if(!getin)
            if(collision.tag=="Player")
        {
        inrange= true;
        text.SetActive(true);
        }
       if (getin) 
        if(collision.tag=="Player")
        {
            inrange = true;
            Getin.SetActive(true);
        }
        
    }
    void OnTriggerExit(Collider collision)
    {
       if(!activatedkey)
        if(!getin) 
            if (collision.tag == "Player") 
        {
            inrange = false;
            text.SetActive(false);
        }
        if (getin) 
            if(collision.tag=="player")
        {
            inrange = false;
            Getin.SetActive(false);
        }
    }
    void Update()
    {
        if(inrange) 
        if(!activatedkey)
        if (Input.GetKeyDown(KeyCode.F))
        {
                    if (!activatedkey)
                    {
                        getin = true;
                        text.SetActive(false);
                        Getin.SetActive(true);
                        animator.Play("cardooropening");
                    }
                    if(getin)
                    {

                        getin2= true;
                        Getin.SetActive(false);

                    }
                       
                }
        Interact();
        if (getin2)
        {
            Color alpha = fade.color;
            alpha.a += 0.2f * Time.deltaTime;
            fade.color = alpha;

        }
    }

    void Interact() 
    {
        
        
        


    }

}
