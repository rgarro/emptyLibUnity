﻿/**
 *              _.-'|         \,._
 *           .-'    |         |   ~'=-.
 *        .-'       |         |       |
 *        | ___ []  | _______ |  []   |___.-----.
 *        ||___|    ||       ||       |___|__(*=/
 *        |_..._____||_______||.._____|   \##*----=          ---         ---
 *        [__        \__|||__,"     _/
 *           ((-))______--_____((-))                   . ' .' , '
 *           | I |             | I |               ___' . ' '. . .'
 *           |   |             |   |             _/__* , . ,' '  '
 *           || ||             || ||             _|___*|
 *           || ||             || ||              \____|
 *           ((-))             ((-))
 *           |   |             |   |
 *           |   |             |   |
 *           /O.O\             /O.O\
 *          `====='           `====='       Nadie en el Tercio sabía
 *  -       -"^-^"-           -"^-^"-         Quién era aquel legionario ...
 *
 * turns vertically rotationSteps current transform
 * clockwise or counterclockwise from input turn key
 * 
 * @author Rolanddo<rgarro@gmail.com>
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrelElevator : MonoBehaviour {

	public string upTurnKey;
	public string downTurnKey;
	public float rotationSteps;
	private AudioSource servoSoundPlayer;
	public AudioClip servoSoundClip;
	private bool gUP;
	private bool gDown;

	public float minElev;
	public float maxElev;

	void Start () {
		this.servoSoundPlayer = GetComponent<AudioSource>();
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
				this.playServoSoundOn();
				this.rotateUp ();
			}
		}
		if(Input.GetKeyDown(this.upTurnKey)){
			this.gDown = false;
			this.gUP = true;
		}
		if(this.gUP){
			if (elevRad > this.maxElev) {
				this.playServoSoundOn();
				this.rotateDown ();
			}
		}
		if (Input.GetKeyUp (this.downTurnKey) || Input.GetKeyUp(this.upTurnKey)) {
			this.servoSoundPlayer.Stop ();
			this.resetLed ();
		}
	}

	public void rotateUp(){
		transform.Rotate (Vector3.right * Time.deltaTime * rotationSteps);	
	}

	public void rotateDown(){
		transform.Rotate (Vector3.left * Time.deltaTime * rotationSteps);
	}

	
	private void playServoSoundOn(){
        this.servoSoundPlayer.clip = this.servoSoundClip;
        if (!this.servoSoundPlayer.isPlaying) {
            this.servoSoundPlayer.Play ();
        }
    }

	private void resetLed(){
		this.gUP = false;
		this.gDown = false;
	}
}
