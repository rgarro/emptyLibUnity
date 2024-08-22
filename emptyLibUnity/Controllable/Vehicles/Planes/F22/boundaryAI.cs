using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boundaryAI : MonoBehaviour
{

    public float maxZpoint = 3000.0f;
    public GameObject AirPlane;
    public float returnPoint = -180.0f; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(this.AirPlane.transform.position.z > this.maxZpoint){
           //this.AirPlane.transform.position.z = this.returnPoint;
           this.AirPlane.transform.position = new Vector3(this.AirPlane.transform.position.x , this.AirPlane.transform.position.y, this.returnPoint);
       }
    }
}
