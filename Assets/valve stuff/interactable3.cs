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
    private void Start() {
        
        
    }

    void OnTriggerEnter(Collider collision)
    {  
       if (!activatedkey)
        if(collision.tag=="Player")
        {
        getin= true;
        text.SetActive(true);
        }
       if (getin) 
        if(collision.tag=="Player")
        {
            getin = true;
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
        if (getin) 
            if(collision.tag=="player")
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
            activatedkey= true;
            text.SetActive(false);
            animator.Play("cardooropening");

                }
        Interact();
    }

    void Interact() 
    {
        
        
        


    }

}
