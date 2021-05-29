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
            this.heliPad.transform.rotation.z += this.rotationSteps;
        } else {
            this.heliPad.transform.rotation.z += this.rotationSteps * -1;
        }
        /*
        Vector3 lookPos = target. position - transform. position;
Quaternion lookRot = Quaternion. LookRotation(lookPos, Vector3. up);
float eulerY = lookRot. eulerAngles. y;
Quaternion rotation = Quaternion. Euler (0, eulerY, 0);
transform. rotation = rotation;
        */
    }
}