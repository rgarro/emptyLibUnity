using System.Xml.Schema;
using System.Runtime.CompilerServices;
using System;
using System.Globalization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 * ================================================.
 *      .-.   .-.     .--.                         |
 *     | OO| | OO|   / _.-' .-.   .-.  .-.   .''.  |
 *     |   | |   |   \  '-. '-'   '-'  '-'   '..'  |
 *     '^^^' '^^^'    '--'                         |
 * ===============.  .-.  .================.  .-.  |
 *                | |   | |                |  '-'  |
 *                | |   | |                |       |
 *                | ':-:' |                |  .-.  |
 * l42            |  '-'  |                |  '-'  |
 * ==============='       '================'       |
 *
 * Simple Blender3d constraints not getting exported
 * but the pivot points are respected so I figured out 
 * how easy is to port them
 *
 *@author Rolando<rgarro@gmail.com>
 */
public class copyRotationZtoY : MonoBehaviour
{
    public GameObject fromObject;//must  have  z rotation = 0
    public GameObject toObject;//must  have  y rotation = 0
    public bool Invert = false;
    public float offSet = 0;

    private float fromDegrees;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void getFromRotation(){
        this.fromDegrees = this.fromObject.transform.eulerAngles.z;
        if(this.offSet > 0 || this.offSet < 0 ){
            this.fromDegrees = this.fromDegrees + this.offSet;
        }
    }

    // Update is called once per frame
    void Update()
    {
        this.getFromRotation();
        if(this.Invert){
            //if(Mathf.Sign(this.fromDegrees)){
                this.fromDegrees = this.fromDegrees *  -1;
            //}
        }
        Vector3 newRotation = new Vector3(this.toObject.transform.eulerAngles.x,this.fromDegrees,this.toObject.transform.eulerAngles.z);
        this.toObject.transform.eulerAngles = newRotation;
    }
}
