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
	 public string leftTurnKey = "f";
    public string rightTurnKey = "g";
    public float rotationSteps = 0.38f;
	private AudioSource servoSoundPlayer;
    public AudioClip servoSoundClip;
	private float turretRotationZ;
	public float farLeftTurretRotationAngle = -130;
	public float farRightTurretRotationAngle = 118;
	 private bool gRight = false;
    private bool gLeft = false;
	//public float turretYpivot = 0;
	//public float turretXpivot = 0;
	public GameObject barrelsObj;
	private float barrelsElevationY;
	public float maxElevationAngle = 75;
	public float minElevationAngle = 0;
	public string upKey = "r";
    public string downKey = "t";
    public float elevationSteps = 0.37f;
	private bool gUP = false;
    private bool gDown = false;

	void Start () {
		this.turretRotationZ = this.turretObj.transform.rotation.z;
		this.barrelsElevationY = this.barrelsObj.transform.rotation.y;
		this.servoSoundPlayer = GetComponent<AudioSource> ();
	}

	void Update () {
        this.rotationKeys();
		this.elevationKeys();
	}

	private void elevationKeys(){
		//float elevRad = this.barrelsObj.transform.localEulerAngles.y;
		if(Input.GetKeyDown(this.downKey)){
            this.gDown = true;
            this.gUP = false;
			//if (elevRad < this.minElev) 
			this.barrelsElevationY = (Mathf.Abs(this.barrelsElevationY) + this.elevationSteps)*-1; 
        }
		if(Input.GetKeyDown(this.upKey)){
            this.gDown = false;
            this.gUP = true;
			//if (elevRad > this.maxElev)
			this.barrelsElevationY = Mathf.Abs(this.barrelsElevationY) + this.elevationSteps; 
        }
		if(this.gDown || this.gUP){
			this.elevateBarrels();
		}
		if (Input.GetKeyUp (this.downKey) || Input.GetKeyUp(this.upKey)) {
            this.gDown = false;
            this.gUP = false;
            this.servoSoundPlayer.Stop ();
        }
	}

	private void elevateBarrels(){
		this.playServoSoundOn();
		this.barrelsObj.transform.Rotate(0,this.barrelsElevationY,0);
	}

	private void rotationKeys(){
		float rotationDeg = this.turretObj.transform.localEulerAngles.z;

		if(Input.GetKeyDown(this.leftTurnKey)){
	//Debug.Log("left rotation radians "+(rotationDeg-360));		
		   this.gRight = false;
		   //if((rotationDeg-360) < this.farLeftTurretRotationAngle){
			   this.turretRotationZ = (Mathf.Abs(this.turretRotationZ) + rotationSteps)*-1;
			   this.gLeft = true;
		   //}
        }
		if(Input.GetKeyDown(this.rightTurnKey)){
	//Debug.Log("right rotation radians "+rotationDeg);			
			this.gLeft = false;
			//if(rotationDeg < this.farRightTurretRotationAngle){
				this.turretRotationZ = Mathf.Abs(this.turretRotationZ) + rotationSteps;
				this.gRight = true;
			//}
        }  
		if(this.gLeft || this.gRight){
			this.rotateTurret();
        }
        
        if (Input.GetKeyUp (this.rightTurnKey) || Input.GetKeyUp(this.leftTurnKey)) {
            this.gRight = false;
            this.gLeft = false;
            this.servoSoundPlayer.Stop ();
        }
	}

	private float radianToDegree(float angle){
        return angle * (180.0f / Mathf.PI);
    }

	private void rotateTurret(){
		this.playServoSoundOn();
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
