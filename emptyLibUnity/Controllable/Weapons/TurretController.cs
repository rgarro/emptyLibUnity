/**
 * Blondie Versus Tuco, jesus on the sea sailing to alaska
 *
 * turns horizontally rotationSteps current transform
 * clockwise or counterclockwise from input turn key
 * 
 * @author Rolando <rgarro@gmail.com>
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretController : MonoBehaviour {

	public GameObject turretObj;
	public GameObject barrelsObj;
	public float maxElevationAngle = 75;
	public float minElevationAngle = 0;
	 public string leftTurnKey = "f";
    public string rightTurnKey = "g";
    public float rotationSteps = 0.38f;
	private AudioSource servoSoundPlayer;
    public AudioClip servoSoundClip;
	private float turretRotationY;
	private float turretRotationZ;
	public float farLeftTurretRotationAngle = -130;
	public float farRightTurretRotationAngle = 118;
	 private bool gRight = false;
    private bool gLeft = false;
	//public float turretYpivot = 0;
	//public float turretXpivot = 0;

	void Start () {
		this.turretRotationZ = this.turretObj.transform.rotation.z;
		this.turretRotationY = this.turretObj.transform.rotation.y;
		this.servoSoundPlayer = GetComponent<AudioSource> ();
	}

	void Update () {
        if(Input.GetKeyDown(this.leftTurnKey)){
           this.gLeft = true;
		   this.gRight = false;
			this.turretRotationZ = (Mathf.Abs(this.turretRotationZ) + rotationSteps)*-1;
			//this.turretRotationY = this.turretRotationY - rotationSteps;
        }
		if(Input.GetKeyDown(this.rightTurnKey)){
            this.gRight = true;
			this.gLeft = false;
			this.turretRotationZ = Mathf.Abs(this.turretRotationZ) + rotationSteps;
			//this.turretRotationY = this.turretRotationY + rotationSteps;
        }  
		if(this.gLeft || this.gRight){
			this.rotateTurret();
        }
        
        if (Input.GetKeyUp (this.rightTurnKey) || Input.GetKeyUp(this.leftTurnKey)) {
            gRight = false;
            gLeft = false;
            this.servoSoundPlayer.Stop ();
        }
	}

	private void rotateTurret(){
		this.playServoSoundOn();
Debug.Log ("here IM is only rocknroll ...." + this.turretRotationZ);
		this.turretObj.transform.Rotate(0,0,this.turretRotationZ);
		//Quaternion target = Quaternion.Euler(0,this.turretRotationY,this.turretObj.transform.rotation.z);
        //this.turretObj.transform.SetPositionAndRotation(this.turretObj.transform.position,target);
	}

	private void playServoSoundOn(){
        this.servoSoundPlayer.clip = this.servoSoundClip;
        if (!this.servoSoundPlayer.isPlaying) {
            this.servoSoundPlayer.Play ();
        }
    }

}
