﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
*  ░░░░░░███████ ]▄▄▄▄▄▄▄▄▃
*  ▂▄▅█████████▅▄▃▂
* I███████████████████].
* ◥⊙▲⊙▲⊙▲⊙▲⊙▲⊙▲⊙◤...
*
* c mayor scale controlling a sprite with triangulated forward from a qwerty input  
*
*@author Rolando <rgarro@gmail.com>
*/
public class arrowKeyControlledRotableBase : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void keyListeners(){
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            this.upArrowAction();
        }
    }

    private void upArrowAction(){
        Debug.Log("upArrowAction here...");
    }

    // Update is called once per frame
    void Update()
    {
        this.keyListeners();
    }

}
