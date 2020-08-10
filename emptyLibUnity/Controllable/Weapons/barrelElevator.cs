/**
 * turns vertically rotationSteps current transform
 * clockwise or counterclockwise from input turn key
 * 
 * @rolando <rolando@emptyart.xyz>
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrelElevator : MonoBehaviour {

	public string upTurnKey;
	public string downTurnKey;
	public float rotationSteps;
	private AudioSource servoSound;
	public AudioClip servoSounding;
	private bool gUP;
	private bool gDown;

	public float minElev;
	public float maxElev;

	void Start () {
		this.servoSound = GetComponent<AudioSource> ();
		//servoSound.Play();
		//servoSound.clip = Resources.Load<AudioClip>("CerroGordo/Assets/Audio/Tek_Open-Marco-7541_hifi");

		this.gUP = false;
		this.gDown = false;
	}

	private float radianToDegree(float angle){
		return angle * (180.0f / Mathf.PI);
	}

	void Update () {
		float elevRad = this.transform.localEulerAngles.x;
		if(Input.GetKeyDown(this.downTurnKey)){
			this.gDown = true;
			this.gUP = false;
		}
		if(this.gDown){
			if (elevRad < this.minElev) { 
				Debug.Log ("here");		
				this.soundOn ();
				this.rotateUp ();
			}
			
		}
		if(Input.GetKeyDown(this.upTurnKey)){
			this.gDown = false;
			this.gUP = true;
		}
		if(this.gUP){
			if (elevRad > this.maxElev) {
				this.soundOn ();
				this.rotateDown ();
			}
		}
		if (Input.GetKeyUp (this.downTurnKey) || Input.GetKeyUp(this.upTurnKey)) {
			this.servoSound.Stop ();
			this.resetLed ();
		}
	}

	public void rotateUp(){
		transform.Rotate (Vector3.right * Time.deltaTime * rotationSteps);	
	}

	public void rotateDown(){
		transform.Rotate (Vector3.left * Time.deltaTime * rotationSteps);
	}

	private void soundOn(){
		this.servoSound.clip = this.servoSounding;
		if (!this.servoSound.isPlaying) {
			this.servoSound.Play ();
		}
	}

	private void resetLed(){
		this.gUP = false;
		this.gDown = false;
	}
}
