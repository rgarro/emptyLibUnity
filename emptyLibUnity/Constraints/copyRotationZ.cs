using System.Xml.Schema;
using System.Runtime.CompilerServices;
using System;
using System.Globalization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 *        .------..
 *      -          -
 *    /              \
 *  /                   \
 * /    .--._    .---.   |
 * |  /      -__-     \   |
 *  | |                 |  |
 *  ||     ._   _.      ||
 *  ||      o   o       ||
 *  ||      _  |_      ||
 *  C|     (o\_/o)     |O     rodrigues was beavis
 *   \      _____      /       euler was butthead
 *     \ ( /#####\ ) /       
 *      \  `====='  /
 *       \  -___-  /
 *        |       |
 *        /-_____-\
 *      /           \
 *    /               \
 *   /__|  DT / DV  |__\
 *   | ||           |\ \
 *
 * initially Both input and output objects must have rotationZ = 0;
 *
 *@author Rolando<rgarro@gmail.com>
 */
public class copyRotationZ : MonoBehaviour
{
    public GameObject fromObject;//must  have  z rotation = 0
    public GameObject toObject;//must  have  z rotation = 0
    public Boolean Invert = false;

    private float fromDegrees;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void getFromRotation(){
        this.fromDegrees = this.fromObject.transform.eulerAngles.z;
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
        Vector3 newRotation = new Vector3(this.toObject.transform.eulerAngles.x, this.toObject.transform.eulerAngles.y,this.fromDegrees);
        this.toObject.transform.eulerAngles = newRotation;
    }
}
