using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
*  ░░░░░░███████ ]▄▄▄▄▄▄▄▄▃
*  ▂▄▅█████████▅▄▃▂
* I███████████████████].
*   ◥⊙▲⊙▲⊙▲⊙▲⊙▲⊙▲⊙◤...
*
* c mayor scale controlled tile with triangulated forward from a qwerty input  
* like if the base were a kitesurf board x'ing an infinite rienman sum 
* the pytagorean 2d stepper
*
*@author Rolando <rgarro@gmail.com>
*/
public class arrowKeyControlledRotableBase : MonoBehaviour
{

    public float rotationSteps = 3.014f;
    public float forwardSteps = 5.014f;
    public GameObject TheBase;
    //private GameObject TheBase;
    private AudioSource servoSoundPlayer;
	public AudioClip servoSoundClip;
    public AudioClip engineSoundClip;
    private float tetha = 0.00f;//the angle
    private float nextX;
    private float nextY;
    public float screenBodyCorrectionNorthDegrees = 90.00f; 

    public GameObject baseTracks;

    // Start is called before the first frame update
    void Start()
    {
        this.servoSoundPlayer = GetComponent<AudioSource>();
        this.tetha = this.TheBase.transform.rotation.z;
    }

    private void keyListeners(){
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            this.upArrowAction();
            this.drawTracks();
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            this.downArrowAction();
            this.drawTracks();
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            this.rightArrowAction();
            this.drawTracks();
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            this.leftArrowAction();
            this.drawTracks();
        }
    }


     private void leftArrowAction(){
        this.playServoSoundOn();
        this.tetha = this.TheBase.transform.rotation.z + this.rotationSteps;
         this.TheBase.transform.Rotate(0,0,this.tetha);
    }
    
    private void rightArrowAction(){
        this.playServoSoundOn();
        this.tetha = this.TheBase.transform.rotation.z - this.rotationSteps;
        this.TheBase.transform.Rotate(0,0,this.tetha);
        
    }

    private void upArrowAction(){
        this.calculateNexts(true);
        this.playEngineSoundOn();
        this.TheBase.transform.Translate(Vector3.right * Time.deltaTime);
    }

    private void downArrowAction(){
        //Debug.Log("downArrowAction here...");
        this.calculateNexts(false);
        //this.TheBase.transform.Translate(this.nextX,this.nextY,0);
        this.playEngineSoundOn();
        this.TheBase.transform.Translate(Vector3.left * Time.deltaTime);
    }

    private void drawTracks(){
        Vector3 spawnPosition = new Vector3 (this.TheBase.transform.position.x,this.TheBase.transform.position.y ,this.TheBase.transform.position.z);
		Quaternion spawnRotation = this.TheBase.transform.rotation;
        Instantiate (this.baseTracks, spawnPosition, spawnRotation);
    }

    private void calculateNexts(bool goForward=true){
        /**
        * fractally speaking c blues smoke in the water pytagorean 2d stepper
        If you have the hypotenuse, multiply it by sin(θ) to get the length of the side opposite to the angle.
         Alternatively, multiply the hypotenuse by cos(θ) to get the side adjacent to the angle.
          If you have the non-hypotenuse side adjacent to the angle, divide it by cos(θ) to get the length of the hypotenuse.
        */
        float hypotenuse = this.forwardSteps;
        float corretedTetha = this.tetha + this.screenBodyCorrectionNorthDegrees;
        //float oppositeSide = hypotenuse * Mathf.Sin(this.tetha);
        //float adjacentSide = hypotenuse *Mathf.Cos(this.tetha);
        float oppositeSide = hypotenuse * Mathf.Sin(corretedTetha);
        float adjacentSide = hypotenuse *Mathf.Cos(corretedTetha);
       
        if(goForward){
            this.nextX = this.TheBase.transform.position.x + adjacentSide;
            this.nextY = this.TheBase.transform.position.y + oppositeSide;
        } else{
            this.nextX = this.TheBase.transform.position.x - adjacentSide;
            this.nextY = this.TheBase.transform.position.y - oppositeSide;
        }
        //Debug.Log("x: "+this.nextX+" y: "+this.nextY);
    }

    private void playServoSoundOn(){
        this.servoSoundPlayer.clip = this.servoSoundClip;
        if (!this.servoSoundPlayer.isPlaying) {
            this.servoSoundPlayer.Play ();
        }
    }

     private void playEngineSoundOn(){
        this.servoSoundPlayer.clip = this.engineSoundClip;
        if (!this.servoSoundPlayer.isPlaying) {
            this.servoSoundPlayer.Play ();
        }
    }

    // Update is called once per frame
    void Update()
    {
        this.keyListeners();
    }

}
