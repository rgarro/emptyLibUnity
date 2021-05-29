using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heliRotator : MonoBehaviour
{
    
    public GameObject heliPad;
    public float rotationSteps = 0.87f;
    public bool turnClocwise = true;
    private float helipadRotationZ;

    // Start is called before the first frame update
    void Start()
    {
        this.helipadRotationZ = this.heliPad.transform.rotation.z;
    }

    // Update is called once per frame
    void Update()
    {
       this.rotateHelipad();
    }

    private void rotateHelipad(){
		//this.playHeliEngineSoundOn();
        if(this.turnClocwise){
            //this.heliPad.transform.rotation.z += this.rotationSteps;//threejs way
            this.helipadRotationZ += this.rotationSteps;
        } else {
            this.helipadRotationZ -= this.rotationSteps;
        }
		this.heliPad.transform.Rotate(0,0,this.helipadRotationZ+this.rotationSteps);
	}

}