using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
*  ░░░░░░███████ ]▄▄▄▄▄▄▄▄▃
*  ▂▄▅█████████▅▄▃▂
* I███████████████████].
* ◥⊙▲⊙▲⊙▲⊙▲⊙▲⊙▲⊙◤...
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
    public float screenBodyCorrectionNorthDegrees = 90.00f;//si uno esta frente a la tetha de mongongui de donde vienen los space invaders? 

    // Start is called before the first frame update
    void Start()
    {
        this.servoSoundPlayer = GetComponent<AudioSource>();
        //this.TheBase = GetComponent<GameObject>();//meter el objeto dentro del calculador de la tetha provoca el problema
        this.tetha = this.TheBase.transform.rotation.z;
    }

    private void keyListeners(){
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            this.upArrowAction();
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            this.downArrowAction();
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            this.rightArrowAction();
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            this.leftArrowAction();
        }
    }


     private void leftArrowAction(){
        //Debug.Log("left arrow action ...");
        this.playServoSoundOn();
        this.tetha = this.TheBase.transform.rotation.z + this.rotationSteps;
         this.TheBase.transform.Rotate(0,0,this.tetha);
    }
    private void rightArrowAction(){
        //Debug.Log("right arrow action ...");
        this.playServoSoundOn();
        this.tetha = this.TheBase.transform.rotation.z - this.rotationSteps;
        this.TheBase.transform.Rotate(0,0,this.tetha);
        
    }

    private void upArrowAction(){
        //Debug.Log("upArrowAction here...");
        this.calculateNexts(true);
        //this.TheBase.transform.Translate(this.nextX,this.nextY,0);
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
        //Debug.Log("la tetha de tomar cafe de modongui: " + this.tetha);
      // Debug.Log("la tetha corregida: "+corretedTetha);//solo mondongui sabe donde esta el quacker de calle blancos
       
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
