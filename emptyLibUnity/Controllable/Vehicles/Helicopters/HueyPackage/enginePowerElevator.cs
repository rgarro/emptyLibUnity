using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/**
 * Will Test KiteSurf Gear for Money 
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
 *
 * We are going to change the name of this radio station to Kowalsky
 * to whom speed meant freedom of soul ...
 *
 *@author Rolando<rgarro@gmail.com>
 */
public class enginePowerElevator : MonoBehaviour
{
    public float initialAltitude = 1.38f;
    public float maxAltitude = 44.4f;
    public GameObject blades;

    public GameObject tailRotor;//rotates y

    public GameObject helicopter;

    private float pitch;

    private float yaw; 

    private float rudderAngle;

    private AudioSource soundPlayer;
    public AudioClip helicopterThrottleSoundClip;

    private float rotationSteps = 0.00f;
    private float lastRotationSteps = 0.00f;
    private float altitudeSteps = 0.00f;
    public bool turnClocwise = true;
    private float helipadRotationZ;

    public float topRotationSpeed;
    public int enginePowerSliderYpos = 25;
    public int enginePowerSliderXpos = 25;
    public string engineThrottleLabel = "Engine Power";

    public int altitudeSliderYpos = 25;
    public int altitudeSliderXpos = 25;
    public int fwSliderXpos = 25;
    public int fwSliderYpos = 25;
    public string fwLabel = "FW Speed";
    public string altitudeLabel = "Altitude";
    private string enginePowerLabel;
    private float rudderSteps = 25.00F;//keep this in the middle
    public string rudderLabel = "Rudder";
    public int rudderSliderXpos = 25;
    public int rudderSliderYpos = 25;
    public int minAltitudeToRudder = 4;
    public int minRotationStepsToElevate = 15;
    public float pitchAngleFront = 10.00f;
    public float pitchAngleBack = -10.00f;
    public float pitchSteps = 1.00f;
    public float ceroCorrection = 260.00f;
    public float forwardSpeed = 3.0f;
    private bool showForwardSpeedSlider = false;
    public float maxForwardSpeed = 5.0f;
    public string backForwardKeysLegend = "use up down arrow keys ...";
    public float pitchAngleRight = 10.00f;
    public float pitchAngleLeft = -10.00f;
    public float yawAngleRight = 2.0f;
    public float yawAngleLeft = -2.0f;
    public float yawSteps = 0.05f;

    
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
        float rotateTo = this.tailRotor.transform.rotation.eulerAngles.z + this.rotationSteps;
        this.tailRotor.transform.Rotate(0,0,rotateTo);
    }

    
    void changeHelicopterAltitude(){
        if(this.rotationSteps > this.minRotationStepsToElevate){
            float step =  this.altitudeSteps * Time.deltaTime; 
            Vector3 target = new Vector3(this.helicopter.transform.position.x, this.altitudeSteps,this.helicopter.transform.position.z);
            this.helicopter.transform.position = Vector3.MoveTowards(this.helicopter.transform.position, target, step);  
            this.enginePowerLabel = "Engine Power: "+this.rotationSteps + " WATS";  
        } else{
            this.enginePowerLabel = "Increase Engine Power";
            this.descendToTheGround();
        }
    }

    

    void yawLeft(){
        //Debug.Log("yaw left: " + this.helicopter.transform.eulerAngles.z);
        if(this.helicopter.transform.eulerAngles.z > this.yawAngleLeft){
            float angle = this.helicopter.transform.eulerAngles.z - this.yawSteps;
            this.helicopter.transform.Rotate(0,0,angle);      
        }
    }

    void yawRight(){
        //Debug.Log("yaw right .." + this.helicopter.transform.eulerAngles.z);
        if(this.helicopter.transform.eulerAngles.z < this.yawAngleRight){
            float angle = this.helicopter.transform.eulerAngles.z + this.yawSteps;
            this.helicopter.transform.Rotate(0,0,angle);      
        }
    }

    void pitchFront(){
        //Debug.Log("pitch front "+ this.helicopter.transform.eulerAngles.x  +" > " + this.pitchAngleBack);
        if(this.helicopter.transform.eulerAngles.x > this.pitchAngleFront){
            float angle = this.helicopter.transform.eulerAngles.x - this.pitchSteps;
            this.helicopter.transform.Rotate(angle,0,0);
            this.showForwardSpeedSlider = false;      
        }else{
            this.showForwardSpeedSlider = true;
            //this.helicopter.transform.position += Vector3.forward * (Time.deltaTime * this.forwardSpeed);
            this.helicopter.transform.Translate(Vector3.down * (Time.deltaTime * this.forwardSpeed));
        } 
    }

    void pitchBack(){
        //Debug.Log("pitch back "+ this.helicopter.transform.eulerAngles.x  +" < " + this.pitchAngleBack);
        if(this.helicopter.transform.eulerAngles.x < this.pitchAngleBack){
            float angle = this.helicopter.transform.eulerAngles.x + this.pitchSteps;
            this.helicopter.transform.Rotate(angle,0,0);
            this.showForwardSpeedSlider = false;
        }else{
            //Debug.Log("Backward Inclination Reached ..");
            this.showForwardSpeedSlider = true;
            //this.helicopter.transform.position += Vector3.back * (Time.deltaTime*this.forwardSpeed);
            this.helicopter.transform.Translate(Vector3.up * (Time.deltaTime * this.forwardSpeed));
        }
    }

    void moveForward(){
        this.pitchFront();
    }

    void moveBackward(){
        this.pitchBack();
    }

    void rudderLeft(){
        float rotateY = (25 - this.rudderSteps) * -1;
        //Debug.Log("will rudder left: " + rotateY);
        this.helicopter.transform.Rotate(0,0,rotateY);
    }

    void rudderRight(){
        float rotateY = this.rudderSteps - 25;
        //Debug.Log("will rudder right: " + rotateY);
        this.helicopter.transform.Rotate(0,0,rotateY);
    }

    void rudder(){
        if(this.rudderSteps > 25){
            this.rudderRight();
        }
        if(this.rudderSteps < 25){
            this.rudderLeft();
        }
    }

    void joystickControls(){
        if (Input.GetKey("up"))
        {
           // Debug.Log("up arrow: "+ this.helicopter.transform.eulerAngles.x);
            this.moveForward();
        }

        if (Input.GetKey("down"))
        {
            //Debug.Log("down arrow: " + this.helicopter.transform.eulerAngles.x);
            this.moveBackward();
        }
         if (Input.GetKey("left")){
             this.yawLeft();
         }
        if (Input.GetKey("right")){
            this.yawRight();
         }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            this.doRestart();
        }
    }

     public void doRestart(){
        //Debug.Log("will restart");
        //Application.LoadLevel(Application.loadedLevel);
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }

    void OnGUI()
    {
        // Debug.Log("Helicopter X: "+ this.helicopter.transform.eulerAngles.x );
        GUI.Box(new Rect(this.enginePowerSliderXpos - 20,this.enginePowerSliderYpos - 15,275,30), this.engineThrottleLabel);
        this.rotationSteps = GUI.HorizontalSlider(new Rect(this.enginePowerSliderXpos, this.enginePowerSliderYpos, 250, 50), this.rotationSteps, 0.0F, 50.0F);//will joystick this.
         if(this.rotationSteps > this.minRotationStepsToElevate){
             //will elevate at min rotationSteps
            GUI.Box(new Rect(this.altitudeSliderXpos - 20,this.altitudeSliderYpos - 15,275,30), this.altitudeLabel);
            this.altitudeSteps = GUI.HorizontalSlider(new Rect(this.altitudeSliderXpos, this.altitudeSliderYpos, 250, 50), this.altitudeSteps, 0.0F, 50.0F);//will joystick this.
         }
        //Debug.Log("Engine Power: " + this.rotationSteps);
        string subAltitudeLabel = "ALTITUDE: " + Mathf.Ceil(this.helicopter.transform.position.y);
        GUI.Label(new Rect(this.altitudeSliderXpos, this.altitudeSliderYpos+20, 100, 20), subAltitudeLabel);
        if(this.helicopter.transform.position.y > this.minAltitudeToRudder){
            //can only be moved after min altitude reached
            GUI.Label(new Rect(this.altitudeSliderXpos+90, this.altitudeSliderYpos+20, 150, 20), this.backForwardKeysLegend);
        }
        

        GUI.Label(new Rect(this.altitudeSliderXpos, this.altitudeSliderYpos+40, 150, 20), this.enginePowerLabel);
        if(this.helicopter.transform.position.y > this.minAltitudeToRudder){ //will rudder at min altitude
            GUI.Box(new Rect(this.rudderSliderXpos - 20,this.rudderSliderYpos - 15,275,30), this.rudderLabel);
            this.rudderSteps = GUI.HorizontalSlider(new Rect(this.rudderSliderXpos, this.rudderSliderYpos, 250, 50), this.rudderSteps, 0.0F, 50.0F);
            //forward speed control here ..
            if(this.showForwardSpeedSlider){
                GUI.Box(new Rect(this.fwSliderXpos-20,this.fwSliderYpos-15,275,30), this.fwLabel);
                this.forwardSpeed = GUI.HorizontalSlider(new Rect(this.fwSliderXpos, this.fwSliderYpos, 250, 50), this.forwardSpeed, 0.0f, this.maxForwardSpeed);
            }
        }
    }

    /**
    * Altitue power control disjunctions on inecuations must have a fallback to a safe state
    */
     void descendToTheGround(){
        if(this.helicopter.transform.position.y > this.getGroundPosition()){
            this.helicopter.transform.position += Vector3.down * Time.deltaTime;
        }
    }
   

    int getGroundPosition(){
        return 1;
    }

    // Update is called once per frame
    void Update()
    {
        this.rotateBlades();
        this.rotateTailRotor();
        this.changeHelicopterAltitude();
        this.rudder();
        if(this.helicopter.transform.position.y > this.minAltitudeToRudder){ 
            this.joystickControls();
        }
    }
}
