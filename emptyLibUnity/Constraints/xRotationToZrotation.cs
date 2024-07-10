using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 * Tranlates rotation x to rotation z
 * Simple Blender3d constraints not getting exported
 * but the pivot points are respected so I figured out 
 * how easy is to port them
 *
 *
 *@author Rolando<rgarro@gmail.com>
 */
public class xRotationToZrotation : MonoBehaviour
{
    public GameObject fromObject;//must  have  x rotation = 0
    public GameObject toObject;//must  have  z rotation = 0
    public bool Invert = false;
    public float offSet = 0;

    private float fromDegrees;
    // Start is called before the first frame update
    void Start()
    {
        
    }

     void getFromRotation(){
        this.fromDegrees = this.fromObject.transform.eulerAngles.x;
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
        Vector3 newRotation = new Vector3(this.toObject.transform.eulerAngles.x,this.toObject.transform.eulerAngles.y,this.fromDegrees);
        this.toObject.transform.eulerAngles = newRotation;
    }
}
