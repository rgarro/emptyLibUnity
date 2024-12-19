using System;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Debug = UnityEngine.Debug;
/**
 *                            ______
 *         |\_______________ (_____\\______________
 * HH======#H###############H#######################
 *         ' ~""""""""""""""`##(_))#H\"""""Y########
 *                           ))    \#H\       `"Y###
 *                           "      }#H)
 * state machine controlling self propelled objects instantiation
 * once per spacebar on key down event ...
 *
 * visual studio code theme and the slingshot code kite colors 
 *
 *@author Rolando<rolando@emptyart.xyz>                       
 */
public class rocketShooter : MonoBehaviour
{

    public GameObject AirPlane;
    public GameObject roundObject;
    private bool is_shooting = false;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    void shootRocket(){
        if(!this.is_shooting){
            Quaternion rotation = Quaternion.Euler(this.AirPlane.transform.localEulerAngles.x,this.AirPlane.transform.localEulerAngles.y,this.AirPlane.transform.localEulerAngles.z);
		    Vector3 position = new Vector3(this.AirPlane.transform.position.x,this.AirPlane.transform.position.y,this.AirPlane.transform.position.z);
            GameObject rocket = (GameObject)Instantiate (this.roundObject,position,rotation);
            this.is_shooting = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        this.joystickControls();
    }

    void joystickControls(){
        if(Input.GetKey("space"))
        {
            this.shootRocket();
        }
        if (Input.GetKeyUp("space"))
        {
            Debug.Log("Space key released");
            this.is_shooting = false;
        }
    }
}
