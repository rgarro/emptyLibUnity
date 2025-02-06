using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 * Will Test KiteSurf Gear for Money 
 *
 *                ,,,,,,,,,,---''''---,,,,,,,,,,
 *      --''''''''          ````][''''          ''''''''--
 *                           _>'''':.
 * _                  .,---------------.
 * \\    / _________./  |[__]| o   |J@"\\__
 *  \\==o=========:;    |____|[IL__|''''/_/')
 *     /            `'-,._____===\=_____.,-'
 *                          \         \     ,
 *                    """"""""""""""""""""""
 * Displays Compass String From given object
 * mission amperson should be included
 *
 *
 *@author Rolando<rolando@emptyart.xyz>
 */
public class compassWaypoint : MonoBehaviour
{

    public GameObject helicopter;
    private string frontDegreesQty;
    public int frontLabelXpos = 25;
    public int frontLabelYpos = 25;
    private string centerLetter = "N";

    private string leftDegreesQty;
    public int leftLabelXpos = 800;
    public int leftLabelYpos = 25;
    private string leftLetter = "W";

     private string rightDegreesQty;
    public int rightLabelXpos = 400;
    public int rightLabelYpos = 25;
    private string rightLetter = "E";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     this.setFrontDegreesQty();  
     this.setLeftDegreesQty();
     this.setRightDegreesQty();
    }

    void setFrontDegreesQty(){
        this.frontDegreesQty = "- "+Mathf.Round(this.helicopter.transform.eulerAngles.y)+" -";
        float tmp = Mathf.Round(this.helicopter.transform.eulerAngles.y);
         this.centerLetter = "N";
        if(tmp<5 && tmp > -5){
            this.centerLetter = "N";
        }
        if(tmp>5 && tmp <90){
            this.centerLetter = "NE";
        }
        if(tmp<92 && tmp > 88){
            this.centerLetter = "E";
        }
        if(tmp>92 && tmp <178){
            this.centerLetter = "SE";
        }
         if(tmp>178 && tmp <185){
            this.centerLetter = "S";
        }
        if(tmp>185 && tmp <268){
            this.centerLetter = "SW";
        }
        if(tmp>268 && tmp <273){
            this.centerLetter = "W";
        }
        if(tmp>273 && tmp <358){
            this.centerLetter = "NW";
        }
    }

    void setLeftDegreesQty(){
        this.leftDegreesQty = "<- "+Mathf.Round(this.helicopter.transform.eulerAngles.y - 45)+" -";
        float tmp = Mathf.Round(this.helicopter.transform.eulerAngles.y - 45);
        this.leftLetter = "W";
        if(tmp<5 && tmp > -5){
            this.leftLetter = "N";
        }
        if(tmp>5 && tmp <90){
            this.leftLetter = "NE";
        }
        if(tmp<92 && tmp > 88){
            this.leftLetter = "E";
        }
        if(tmp>92 && tmp <178){
            this.leftLetter = "SE";
        }
         if(tmp>178 && tmp <185){
            this.leftLetter = "S";
        }
        if(tmp>185 && tmp <268){
            this.leftLetter = "SW";
        }
        if(tmp>268 && tmp <273){
            this.leftLetter = "W";
        }
        if(tmp>273 && tmp <358){
            this.leftLetter = "NW";
        }
    }

    void setRightDegreesQty(){
        this.rightDegreesQty = "- "+Mathf.Round(this.helicopter.transform.eulerAngles.y + 45)+" ->";
        float tmp = Mathf.Round(this.helicopter.transform.eulerAngles.y + 45);
         this.rightLetter = "E";
        if(tmp<5 && tmp > -5){
            this.rightLetter = "N";
        }
        if(tmp>5 && tmp <90){
            this.rightLetter = "NE";
        }
        if(tmp<92 && tmp > 88){
            this.rightLetter = "E";
        }
        if(tmp>92 && tmp <178){
            this.rightLetter = "SE";
        }
         if(tmp>178 && tmp <185){
            this.rightLetter = "S";
        }
        if(tmp>185 && tmp <268){
            this.rightLetter = "SW";
        }
        if(tmp>268 && tmp <273){
            this.rightLetter = "W";
        }
        if(tmp>273 && tmp <358){
            this.rightLetter = "NW";
        }
    }

     void OnGUI()
    {
        //North
        GUI.Label(new Rect(this.frontLabelXpos, this.frontLabelYpos-20, 100, 20), this.centerLetter);
        GUI.Label(new Rect(this.frontLabelXpos, this.frontLabelYpos, 100, 20), this.frontDegreesQty);
        //West
        GUI.Label(new Rect(this.leftLabelXpos, this.leftLabelYpos-20, 100, 20), this.leftLetter);
        GUI.Label(new Rect(this.leftLabelXpos, this.leftLabelYpos, 100, 20), this.leftDegreesQty);
        //East
        GUI.Label(new Rect(this.rightLabelXpos, this.rightLabelYpos-20, 100, 20), this.rightLetter);
        GUI.Label(new Rect(this.rightLabelXpos, this.rightLabelYpos, 100, 20), this.rightDegreesQty);
    }
}
