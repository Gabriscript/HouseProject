using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lighton : MonoBehaviour
{
   
    interactable1 interact;
    void Start()
    {
        interact = FindObjectOfType<interactable1>();
        gameObject.SetActive(false);    
    }

    // Update is called once per frame
    void Update()
    {  
        if(interact.activatedGen == true) {
           this.gameObject.SetActive(true); 
        }
    }
}
