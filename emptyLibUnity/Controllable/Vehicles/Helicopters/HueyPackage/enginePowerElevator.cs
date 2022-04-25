using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 *
 *                ,,,,,,,,,,---''''---,,,,,,,,,,
 *      --''''''''          ````][''''          ''''''''--
 *                           _3'''':.
 * _                  .,---------------.
 * \\    / _________./  |[__]| o   |J@"\\__
 *  \\==o=========:;    |____|[IL__|''''/_/')
 *     /            `'-,._____===\=_____.,-'
 *                          \         \     ,
 *                    """"""""""""""""""""""
 * Increases engine power rotation speed and helicopter elevation
 * Handles Rotation and Elevation
 * We are going to change the name of this radio station to Kowalsky
 * to whom speed meant freedom of soul ...
 *
 *@author Rolando<rgarro@gmail.com>
 */
public class enginePowerElevator : MonoBehaviour
{
    public float initialAltitude = 0.0f;
    public float maxAltitude = 300.0f;
    public GameObject blades;

    public GameObject tailRotor;//rotates y

    public GameObject helicopter;

    private float pitch;

    private float yaw; 

    private float rudderAngle;

    private AudioSource soundPlayer;
    public AudioClip helicopterThrottleSoundClip;

    private float rotationSteps = 0.01f;
    public bool turnClocwise = true;
    private float helipadRotationZ;

    public float topRotationSpeed;
    public int enginePowerSliderYpos = 25;

    //private int rotationSteps = 5;
    
    // Start is called before the first frame update
    void Start()
    {
        this.helipadRotationZ = this.blades.transform.rotation.z;
        
        //Engine Sound
        this.soundPlayer = GetComponent<AudioSource> ();
        this.soundPlayer.volume = 0.2F;
        this.playEngineSound();
    }

    private void playEngineSound(){
        this.soundPlayer.clip = this.helicopterThrottleSoundClip;
        if (!this.soundPlayer.isPlaying) {
            this.soundPlayer.Play ();
        }
    }

    void rotateBlades(){
        /*if(this.turnClocwise){
            this.helipadRotationZ += this.rotationSteps;
        } else {
            this.helipadRotationZ -= this.rotationSteps;
        }
		this.blades.transform.Rotate(0,0,this.helipadRotationZ+this.rotationSteps);*/

        float rotateTo = this.blades.transform.rotation.eulerAngles.z + this.rotationSteps;
        this.blades.transform.Rotate(0,0,rotateTo);
    }

    void rotateTailRotor(){
        //this.tailRotor.transform.Rotate(0,0,this.helipadRotationZ+this.rotationSteps);
        float rotateTo = this.tailRotor.transform.rotation.eulerAngles.z + this.rotationSteps;
        this.tailRotor.transform.Rotate(0,0,rotateTo);
    }

    void increseRotationSpeed(){

    }

    void increaseHelicopterAltitude(){

    }

    void yawLeft(){

    }

    void yawRight(){

    }

    void pitchFront(){

    }

    void pitchBack(){

    }

    void moveForward(){
        //there goes the challenger being followed by the blue meanies on wheels ..
    }

    void moveBackward(){

    }

    void rudderLeft(){

    }

    void rudderRight(){

    }

    void joystickControls(){
        //find a cheap joystick ina walmart next to an airbase where real pilots have stepped
    }

    void OnGUI()
    {
        //thaiRed bull VS starBucks brunette will fight the smokeShopBlonde ...
        this.rotationSteps = GUI.HorizontalSlider(new Rect(25, this.enginePowerSliderYpos, 100, 30), this.rotationSteps, 0.0F, 10.0F);//will joystick this.
    }

    // Update is called once per frame
    void Update()
    {
        this.rotateBlades();
        this.rotateTailRotor();
    }
}
