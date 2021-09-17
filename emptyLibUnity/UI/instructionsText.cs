using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
*───────────▄▄▄▄▄▄▄▄▄───────────
*────────▄█████████████▄────────
*█████──█████████████████──█████
*▐████▌─▀███▄───────▄███▀─▐████▌
*─█████▄──▀███▄───▄███▀──▄█████─
*─▐██▀███▄──▀███▄███▀──▄███▀██▌─
*──███▄▀███▄──▀███▀──▄███▀▄███──
*──▐█▄▀█▄▀███─▄─▀─▄─███▀▄█▀▄█▌──
*───███▄▀█▄██─██▄██─██▄█▀▄███───
*────▀███▄▀██─█████─██▀▄███▀────
*───█▄─▀█████─█████─█████▀─▄█───
*───███────────███────────███───
*───███▄────▄█─███─█▄────▄███───
*───█████─▄███─███─███▄─█████───
*───█████─████─███─████─█████───
*───█████─████─███─████─█████───
*───█████─████─███─████─█████───
*───█████─████▄▄▄▄▄████─█████───
*────▀███─█████████████─███▀────
*──────▀█─███─▄▄▄▄▄─███─█▀──────
*─────────▀█▌▐█████▌▐█▀─────────
*────────────███████────────────
* Displays a textbox with Instruction Text
* I cant save cybertron
*
*@author Rolando <rgarro@gmail.com>
*/
public class instructionsText : MonoBehaviour
{
    public float windowX = 10;
    public float windowY = 65;
    public float windowHeight = 170;
    public float windowWidth = 150;
    public string instructionsString = "Drive: Arrow Keys \n\nTurn Turret: F, G\n\nElevation: up R down T\n\nShoot: spacebar";
    public string labelString = "Instructions";
    public float marginVal = 25;
    private Rect windowRect;

    void OnGUI(){
        this.windowRect = new Rect(this.windowX,this.windowY,this.windowHeight,this.windowWidth);
        this.windowRect = GUI.Window(0,windowRect,WindowFunction,this.labelString);
    }

    void WindowFunction(int windowID){
      //place instructions here ...
      GUI.Label(new Rect(this.marginVal,this.marginVal,this.windowHeight,this.windowWidth),this.instructionsString);
    }

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

    }
}
