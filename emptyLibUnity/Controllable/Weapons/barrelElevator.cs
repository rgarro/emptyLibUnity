/**
 *              _.-'| ------- \,._
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

	public string upTurnKey = "r";
	public string downTurnKey = "t";
	public float elevationSteps = 0.25f;
	private AudioSource servoSoundPlayer;
	public AudioClip servoSoundClip;
	private bool gUP;
	private bool gDown;

	public float minElev;
	public float maxElev;
	private float barrelsElevationY;

	void Start () {
		this.servoSoundPlayer = GetComponent<AudioSource>();
		this.gUP = false;
		this.gDown = false;
	}
	private float radianToDegree(float angle){
		return angle * (180.0f / Mathf.PI);
	}

	void Update () {
		//float elevRad = this.transform.localEulerAngles.x;
//Debug.Log("downTurn: " + this.downTurnKey);		
		float elevRad = this.transform.localEulerAngles.y;
		if(Input.GetKeyDown(this.downTurnKey)){
			this.gDown = true;
			this.gUP = false;
			this.barrelsElevationY = (Mathf.Abs(this.barrelsElevationY) + this.elevationSteps)*-1;
		}
		if(Input.GetKeyDown(this.upTurnKey)){
			this.gDown = false;
			this.gUP = true;
			this.barrelsElevationY = Mathf.Abs(this.barrelsElevationY) + this.elevationSteps;
		}
		if(this.gDown || this.gUP){
			//if (elevRad < this.minElev) { 						
				this.playServoSoundOn();
				this.elevateBarrels();
			//}
		}
		if (Input.GetKeyUp (this.downTurnKey) || Input.GetKeyUp(this.upTurnKey)) {
			this.servoSoundPlayer.Stop ();
			this.resetLed ();
		}
	}

	private void elevateBarrels(){
		this.playServoSoundOn();
		this.transform.Rotate(0,this.barrelsElevationY,0);
	}
	/*public void rotateUp(){
		transform.Rotate (Vector3.right * Time.deltaTime * rotationSteps);	
	}

	public void rotateDown(){
		transform.Rotate (Vector3.left * Time.deltaTime * rotationSteps);
	}*/

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
