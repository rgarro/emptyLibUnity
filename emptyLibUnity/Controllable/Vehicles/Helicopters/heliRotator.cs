using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heliRotator : MonoBehaviour
{
    
    public GameObject heliPad;
    public float rotationSteps = 0.37f;
    public bool turnClocwise = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(this.turnClocwise){
            //this.heliPad.transform.rotation.z += Mathf.Abs(this.rotationSteps);
        } else {
            //this.heliPad.transform.rotation.z += Mathf.Abs(this.rotationSteps) * -1;
        }
    }
}