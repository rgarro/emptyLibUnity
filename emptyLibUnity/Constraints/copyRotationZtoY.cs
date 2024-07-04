using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class copyRotationZtoY : MonoBehaviour
{
    public GameObject fromObject;//must  have  z rotation = 0
    public GameObject toObject;//must  have  y rotation = 0
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
        Vector3 newRotation = new Vector3(this.toObject.transform.eulerAngles.x,this.fromDegrees,this.toObject.transform.eulerAngles.z);
        this.toObject.transform.eulerAngles = newRotation;
    }
}
