using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 * Will Test KiteSurf Gear for Money 
 *
 *                ,,,,,,,,,,---''''---,,,,,,,,,,
 *      --''''''''          ````][''''          ''''''''--
 *                           _3'''':.
 * _                  .,---------------.
 * \\    / _________./  |[__]| o   |J@"\\__
 *  \\==o=========:;    |____|[IL__|''''/_/')
 *     /            `'-,._____===\=_____.,-'
 *                          \         \     ,
 *                    """"""""""""""""""""""
 * Displays Compass String From given object
 *
 *
 *@author Rolando<rgarro@gmail.com>
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
    }

    void setFrontDegreesQty(){
        this.frontDegreesQty = "- "+Mathf.Round(this.helicopter.transform.eulerAngles.y)+" -";
        float tmp = Mathf.Round(this.helicopter.transform.eulerAngles.y);
         if(tmp==0){
            this.centerLetter = "N";
        }
        if(tmp>0 || tmp <90){
            this.centerLetter = "NE";
        }
    }

    void setLeftDegreesQty(){
        this.leftDegreesQty = "<- "+Mathf.Round(this.helicopter.transform.eulerAngles.y - 45)+" -";
        float tmp = Mathf.Round(this.helicopter.transform.eulerAngles.y);
         if(tmp==0){
            this.leftLetter = "W";
        }
        if(tmp>0 || tmp <90){
            this.centerLetter = "N";
        }
    }

    void setRightDegreesQty(){
        this.rightDegreesQty = "- "+Mathf.Round(this.helicopter.transform.eulerAngles.y + 45)+" ->";
        float tmp = Mathf.Round(this.helicopter.transform.eulerAngles.y);
         if(tmp==0){
            this.leftLetter = "E";
        }
        if(tmp>0 || tmp <90){
            this.centerLetter = "E";
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
    }
}
