using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 *   __---~~~~--__                      __--~~~~---__
 *  `\---~~~~~~~~\\                    //~~~~~~~~---/'
 *    \/~~~~~~~~~\||                  ||/~~~~~~~~~\/
 *                `\\                //'
 *                  `\\            //'
 *                    ||          ||
 *          ______--~~~~~~~~~~~~~~~~~~--______
 *     ___ // _-~                        ~-_ \\ ___
 *    `\__)\/~                              ~\/(__/'
 *     _--`-___                            ___-'--_
 *   /~     `\ ~~~~~~~~------------~~~~~~~~ /'     ~\
 *  /|        `\         ________         /'        |\
 * | `\   ______`\_      \------/      _/'______   /' |
 * |   `\_~-_____\ ~-________________-~ /_____-~_/'   |
 * `.     ~-__________________________________-~     .'
 *  `.      [_______/------|~~|------\_______]      .'
 *   `\--___((____)(________\/________)(____))___--/'
 *    |>>>>>>||                            ||<<<<<<|
 *    `\<<<<</'                            `\>>>>>/'
 *
 * Displays ON /OFF button for rearView mirror
 * more than one camera should be avoided on webGl
 *
 *@author Rolando<rgarro@gmail.com> 
 */
public class rearViewMirrorResetButton : MonoBehaviour
{
    public Texture2D rearViewMirrorIcon;
    public GameObject rearViewMirrorObj;
    public float IconX = 234;
    public float IconY = 10;
    public float IconWidth = 45;
    public float IconHeight = 45;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnGUI(){
        if(GUI.Button(new Rect (this.IconX,this.IconY,this.IconWidth,this.IconHeight),this.rearViewMirrorIcon)) 
        {
            this.doReset();
        }
    }

    protected void doReset(){
        if(this.rearViewMirrorObj.activeSelf){
            this.rearViewMirrorObj.SetActive(false);
        }else{
            this.rearViewMirrorObj.SetActive(true);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
